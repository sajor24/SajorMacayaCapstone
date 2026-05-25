using System.Data;
using Dapper;
using Domain.Models;

namespace Framework.Extensions
{
    public static class SubscriptionExtension
    {
        public static DynamicParameters ToCreateSubscriptionParameters(this Subscription model)
        {
            var param = new DynamicParameters();
            param.Add("@UserId",    model.UserId,    DbType.String,  ParameterDirection.Input);
            param.Add("@PlanName",  model.PlanName,  DbType.String,  ParameterDirection.Input);
            param.Add("@PlanPrice", model.PlanPrice, DbType.Decimal, ParameterDirection.Input);
            param.Add("@StartDate", model.StartDate, DbType.DateTime,ParameterDirection.Input);
            param.Add("@EndDate",   model.EndDate,   DbType.DateTime,ParameterDirection.Input);
            param.Add("@Status",    model.Status,    DbType.String,  ParameterDirection.Input);
            return param;
        }

        public static DynamicParameters ToUpdateSubscriptionParameters(this Subscription model)
        {
            var param = new DynamicParameters();
            param.Add("@SubscriptionId", model.SubscriptionId, DbType.String,  ParameterDirection.Input);
            param.Add("@PlanName",       model.PlanName,       DbType.String,  ParameterDirection.Input);
            param.Add("@PlanPrice",      model.PlanPrice,      DbType.Decimal, ParameterDirection.Input);
            param.Add("@StartDate",      model.StartDate,      DbType.DateTime,ParameterDirection.Input);
            param.Add("@EndDate",        model.EndDate,        DbType.DateTime,ParameterDirection.Input);
            param.Add("@Status",         model.Status,         DbType.String,  ParameterDirection.Input);
            return param;
        }

        public static DynamicParameters ToDeleteSubscriptionParameters(this Subscription model)
        {
            var param = new DynamicParameters();
            param.Add("@SubscriptionId", model.SubscriptionId, DbType.String, ParameterDirection.Input);
            return param;
        }

        public static DynamicParameters ToGetByUserSubscriptionParameters(string userId)
        {
            var param = new DynamicParameters();
            param.Add("@UserId", userId, DbType.String, ParameterDirection.Input);
            return param;
        }
    }
}
