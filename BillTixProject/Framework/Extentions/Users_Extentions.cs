using System.Data;
using Dapper;
using Domain.Models;

namespace Framework.Extensions
{
    public static class UserExtension
    {
        public static DynamicParameters ToUserDynamicParameters(this Users model)
        {
            var param = new DynamicParameters();
            var hashedPassword = BCrypt.Net.BCrypt.HashPassword(model.Password);

            param.Add("@UserId", model.UserId, DbType.String, ParameterDirection.Input);
            param.Add("@FirstName", model.FirstName, DbType.String, ParameterDirection.Input);
            param.Add("@LastName", model.LastName, DbType.String, ParameterDirection.Input);
            param.Add("@Username", model.Username, DbType.String, ParameterDirection.Input);
            param.Add("@Password", hashedPassword, DbType.String, ParameterDirection.Input);
            param.Add("@Role", model.Role, DbType.String, ParameterDirection.Input);
            param.Add("@Email", model.Email, DbType.String, ParameterDirection.Input);
            param.Add("@ContactNumber", model.ContactNumber, DbType.String, ParameterDirection.Input);
            param.Add("@Address", model.Address, DbType.String, ParameterDirection.Input);

            return param;
        }

        public static DynamicParameters ToCreateUserDynamicParameters(this Users model)
        {
            var param = new DynamicParameters();
            var hashedPassword = BCrypt.Net.BCrypt.HashPassword(model.Password);
            param.Add("@FirstName", model.FirstName, DbType.String, ParameterDirection.Input);
            param.Add("@LastName", model.LastName, DbType.String, ParameterDirection.Input);
            param.Add("@Username", model.Username, DbType.String, ParameterDirection.Input);
            param.Add("@Password", hashedPassword, DbType.String, ParameterDirection.Input);
            param.Add("@Role", model.Role, DbType.String, ParameterDirection.Input);
            param.Add("@Email", model.Email, DbType.String, ParameterDirection.Input);
            param.Add("@ContactNumber", model.ContactNumber, DbType.String, ParameterDirection.Input);
            param.Add("@Address", model.Address, DbType.String, ParameterDirection.Input);

            return param;
        }

        public static DynamicParameters ToDeleteUserDynamicParameters(this Users model)
        {
            var param = new DynamicParameters();

            param.Add("@UserId", model.UserId, DbType.String, ParameterDirection.Input);

            return param;
        }
    }
}