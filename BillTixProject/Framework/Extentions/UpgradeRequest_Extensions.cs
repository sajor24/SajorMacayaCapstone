using System.Data;
using Dapper;
using Domain.Models;

namespace Framework.Extensions
{
    public static class UpgradeRequestExtension
    {
        public static DynamicParameters ToCreateParameters(this UpgradeRequest model)
        {
            var param = new DynamicParameters();
            param.Add("@UserId",      model.UserId,      DbType.String,   ParameterDirection.Input);
            param.Add("@PlanId",      model.PlanId,      DbType.String,   ParameterDirection.Input);
            param.Add("@PlanName",    model.PlanName,    DbType.String,   ParameterDirection.Input);
            param.Add("@ReferenceNo", model.ReferenceNo, DbType.String,   ParameterDirection.Input);
            return param;
        }

        public static DynamicParameters ToUpdateParameters(this UpgradeRequest model)
        {
            var param = new DynamicParameters();
            param.Add("@RequestId",   model.RequestId,   DbType.String,   ParameterDirection.Input);
            param.Add("@Status",      model.Status,      DbType.String,   ParameterDirection.Input);
            param.Add("@ProcessedAt", model.ProcessedAt, DbType.DateTime, ParameterDirection.Input);
            return param;
        }
    }
}
