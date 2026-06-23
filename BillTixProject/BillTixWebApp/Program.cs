using BillTixWebApp.Components;
using Framework;
using Framework.Commands;
using Domain.ICommands;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<Repository>();

builder.Services.AddScoped<ICreate_User, Create_User>();
builder.Services.AddScoped<ILoginUser, LoginUser>();
builder.Services.AddScoped<IUpdate_User, Update_User>();
builder.Services.AddScoped<IDelete_User, Delete_User>();
builder.Services.AddScoped<IGetAll_User, GetAll_User>();

// Billing
builder.Services.AddScoped<ICreate_Billing, Create_Billing>();
builder.Services.AddScoped<IUpdate_Billing, Update_Billing>();
builder.Services.AddScoped<IDelete_Billing, Delete_Billing>();
builder.Services.AddScoped<IGetAll_Billing, GetAll_Billing>();
builder.Services.AddScoped<IGetByUser_Billing, GetByUser_Billing>();
builder.Services.AddScoped<IGetRecent_Billing, GetRecent_Billing>();

// Subscription
builder.Services.AddScoped<ICreate_Subscription, Create_Subscription>();
builder.Services.AddScoped<IUpdate_Subscription, Update_Subscription>();
builder.Services.AddScoped<IDelete_Subscription, Delete_Subscription>();
builder.Services.AddScoped<IGetAll_Subscription, GetAll_Subscription>();
builder.Services.AddScoped<IGetByUser_Subscription, GetByUser_Subscription>();

// InternetPlans
builder.Services.AddScoped<ICreate_InternetPlan, Create_InternetPlan>();
builder.Services.AddScoped<IUpdate_InternetPlan, Update_InternetPlan>();
builder.Services.AddScoped<IDelete_InternetPlan, Delete_InternetPlan>();
builder.Services.AddScoped<IGetAll_InternetPlan, GetAll_InternetPlan>();

// Razor Components
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();


// ======================
// AUTHENTICATION
// ======================

builder.Services.AddHttpContextAccessor();

builder.Services
    .AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/login";
        options.AccessDeniedPath = "/access-denied";
        options.ExpireTimeSpan = TimeSpan.FromHours(1);
    });

builder.Services.AddAuthorization();

builder.Services.AddCascadingAuthenticationState();

var app = builder.Build();


// ======================
// PIPELINE
// ======================

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAntiforgery();


// IMPORTANT
app.UseAuthentication();
app.UseAuthorization();

app.MapStaticAssets();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// Minimal API — handles SignInAsync (HttpContext not available in Blazor Server components)
app.MapPost("/account/login", async (
    HttpContext context,
    ILoginUser loginUser,
    [Microsoft.AspNetCore.Mvc.FromForm] string username,
    [Microsoft.AspNetCore.Mvc.FromForm] string password,
    [Microsoft.AspNetCore.Mvc.FromForm] string? returnRole) =>
{
    var user = await loginUser.ExecuteAsync(username, password);

    if (user == null)
        return Results.Redirect("/login?error=1");

    // Role check if portal-specific login
    if (!string.IsNullOrEmpty(returnRole) &&
        !string.Equals(user.Role, returnRole, StringComparison.OrdinalIgnoreCase))
        return Results.Redirect($"/login?role={returnRole}&error=2");

    var claims = new List<Claim>
    {
        new(ClaimTypes.Name, user.Username ?? ""),
        new(ClaimTypes.Role, user.Role ?? "")
    };

    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
    var principal = new ClaimsPrincipal(identity);

    await context.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

    var redirect = user.Role switch
    {
        "Admin" => "/admin-dashboard",
        "Subscriber" => "/sub-dashboard",
        "Staff" => "/staff-dashboard",
        "Technician" => "/tech-dashboard",
        _ => "/"
    };

    return Results.Redirect(redirect);
}).DisableAntiforgery();
app.MapGet("/account/logout", async (HttpContext context) =>
{
    await context.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
    return Results.Redirect("/");
});

app.Run();