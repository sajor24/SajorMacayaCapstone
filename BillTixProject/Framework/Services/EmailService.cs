using Domain.ICommands;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Configuration;
using MimeKit;

namespace Framework.Services
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _config;

        public EmailService(IConfiguration config)
        {
            _config = config;
        }

        public async Task SendAsync(string toEmail, string subject, string body)
        {
            var host     = _config["Email:Host"]     ?? "smtp-relay.brevo.com";
            var port     = int.Parse(_config["Email:Port"] ?? "587");
            var from     = _config["Email:From"]     ?? throw new InvalidOperationException("Email:From not configured.");
            var username = _config["Email:Username"] ?? throw new InvalidOperationException("Email:Username not configured.");
            var password = _config["Email:Password"] ?? throw new InvalidOperationException("Email:Password not configured.");

            var mail = new MimeMessage();
            mail.From.Add(new MailboxAddress("BillTix", from));
            mail.To.Add(MailboxAddress.Parse(toEmail));
            mail.Subject = subject;

            mail.Body = new TextPart("html") { Text = body };

            using var smtp = new SmtpClient();
            await smtp.ConnectAsync(host, port, SecureSocketOptions.StartTls);
            await smtp.AuthenticateAsync(username, password);
            await smtp.SendAsync(mail);
            await smtp.DisconnectAsync(true);
        }

        public async Task SendBillingDueReminderAsync(string toEmail, string firstName, string billingId, decimal amount, DateTime dueDate)
        {
            var subject = "💳 Payment Reminder – Bill Due Soon";
            var body = $@"
                <div style='font-family:Arial,sans-serif;max-width:600px;margin:0 auto;border:1px solid #e5e7eb;border-radius:8px;overflow:hidden;'>
                    <div style='background:#2563eb;padding:24px;text-align:center;'>
                        <h1 style='color:#fff;margin:0;font-size:22px;'>BillTix</h1>
                    </div>
                    <div style='padding:32px;'>
                        <h2 style='color:#111827;'>Hi {firstName},</h2>
                        <p style='color:#374151;'>This is a friendly reminder that your bill is due soon.</p>
                        <div style='background:#f3f4f6;border-radius:8px;padding:16px;margin:24px 0;'>
                            <table style='width:100%;'>
                                <tr><td style='color:#6b7280;'>Billing ID</td><td style='font-weight:600;text-align:right;'>{billingId}</td></tr>
                                <tr><td style='color:#6b7280;'>Amount Due</td><td style='font-weight:600;color:#dc2626;text-align:right;'>₱{amount:N2}</td></tr>
                                <tr><td style='color:#6b7280;'>Due Date</td><td style='font-weight:600;text-align:right;'>{dueDate:MMMM dd, yyyy}</td></tr>
                            </table>
                        </div>
                        <p style='color:#374151;'>Please settle your payment before the due date to avoid service interruption.</p>
                    </div>
                    <div style='background:#f9fafb;padding:16px;text-align:center;'>
                        <p style='color:#9ca3af;font-size:12px;margin:0;'>BillTix – Internet Billing System</p>
                    </div>
                </div>";

            await SendAsync(toEmail, subject, body);
        }

        public async Task SendMaintenanceNoticeAsync(string toEmail, string firstName, string title, string messageText)
        {
            var subject = $"🔧 {title}";
            var body = $@"
                <div style='font-family:Arial,sans-serif;max-width:600px;margin:0 auto;border:1px solid #e5e7eb;border-radius:8px;overflow:hidden;'>
                    <div style='background:#2563eb;padding:24px;text-align:center;'>
                        <h1 style='color:#fff;margin:0;font-size:22px;'>BillTix</h1>
                    </div>
                    <div style='padding:32px;'>
                        <h2 style='color:#111827;'>Hi {firstName},</h2>
                        <h3 style='color:#2563eb;'>{title}</h3>
                        <p style='color:#374151;line-height:1.6;'>{messageText}</p>
                    </div>
                    <div style='background:#f9fafb;padding:16px;text-align:center;'>
                        <p style='color:#9ca3af;font-size:12px;margin:0;'>BillTix – Internet Billing System</p>
                    </div>
                </div>";

            await SendAsync(toEmail, subject, body);
        }
    }
}
