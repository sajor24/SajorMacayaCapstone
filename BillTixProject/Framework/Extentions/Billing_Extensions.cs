using System.Data;
using Dapper;
using Domain.Models;

namespace Framework.Extensions
{
    public static class BillingExtension
    {
        public static DynamicParameters ToCreateBillingParameters(this Billing model)
        {
            var param = new DynamicParameters();
            param.Add("@UserId",        model.UserId,        DbType.String,  ParameterDirection.Input);
            param.Add("@Amount",        model.Amount,        DbType.Decimal, ParameterDirection.Input);
            param.Add("@PaymentMethod", model.PaymentMethod, DbType.String,  ParameterDirection.Input);
            param.Add("@Status",        model.Status,        DbType.String,  ParameterDirection.Input);
            param.Add("@DueDate",       model.DueDate,       DbType.DateTime,ParameterDirection.Input);
            param.Add("@Description",   model.Description,   DbType.String,  ParameterDirection.Input);
            return param;
        }

        public static DynamicParameters ToUpdateBillingParameters(this Billing model)
        {
            var param = new DynamicParameters();
            param.Add("@BillingId",     model.BillingId,     DbType.String,  ParameterDirection.Input);
            param.Add("@Amount",        model.Amount,        DbType.Decimal, ParameterDirection.Input);
            param.Add("@PaymentMethod", model.PaymentMethod, DbType.String,  ParameterDirection.Input);
            param.Add("@Status",        model.Status,        DbType.String,  ParameterDirection.Input);
            param.Add("@DueDate",       model.DueDate,       DbType.DateTime,ParameterDirection.Input);
            param.Add("@PaidAt",        model.PaidAt,        DbType.DateTime,ParameterDirection.Input);
            param.Add("@Description",   model.Description,   DbType.String,  ParameterDirection.Input);
            return param;
        }

        public static DynamicParameters ToDeleteBillingParameters(this Billing model)
        {
            var param = new DynamicParameters();
            param.Add("@BillingId", model.BillingId, DbType.String, ParameterDirection.Input);
            return param;
        }

        public static DynamicParameters ToGetByUserBillingParameters(string userId)
        {
            var param = new DynamicParameters();
            param.Add("@UserId", userId, DbType.String, ParameterDirection.Input);
            return param;
        }

        public static DynamicParameters ToGetRecentBillingParameters(int top)
        {
            var param = new DynamicParameters();
            param.Add("@Top", top, DbType.Int32, ParameterDirection.Input);
            return param;
        }
    }
}
