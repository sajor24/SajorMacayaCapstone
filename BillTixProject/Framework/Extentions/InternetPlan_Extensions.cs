using System.Data;
using Dapper;
using Domain.Models;

namespace Framework.Extensions
{
    public static class InternetPlanExtension
    {
        public static DynamicParameters ToCreateInternetPlanParameters(this InternetPlan model)
        {
            var param = new DynamicParameters();
            param.Add("@PlanName", model.PlanName, DbType.String, ParameterDirection.Input);
            param.Add("@Speed",    model.Speed,    DbType.String, ParameterDirection.Input);
            param.Add("@Price",    model.Price,    DbType.Decimal, ParameterDirection.Input);
            param.Add("@Features", model.Features, DbType.String, ParameterDirection.Input);
            param.Add("@IsActive", model.IsActive, DbType.Boolean, ParameterDirection.Input);
            return param;
        }

        public static DynamicParameters ToUpdateInternetPlanParameters(this InternetPlan model)
        {
            var param = new DynamicParameters();
            param.Add("@PlanId",   model.PlanId,   DbType.String, ParameterDirection.Input);
            param.Add("@PlanName", model.PlanName, DbType.String, ParameterDirection.Input);
            param.Add("@Speed",    model.Speed,    DbType.String, ParameterDirection.Input);
            param.Add("@Price",    model.Price,    DbType.Decimal, ParameterDirection.Input);
            param.Add("@Features", model.Features, DbType.String, ParameterDirection.Input);
            param.Add("@IsActive", model.IsActive, DbType.Boolean, ParameterDirection.Input);
            return param;
        }

        public static DynamicParameters ToDeleteInternetPlanParameters(this InternetPlan model)
        {
            var param = new DynamicParameters();
            param.Add("@PlanId", model.PlanId, DbType.String, ParameterDirection.Input);
            return param;
        }
    }
}
