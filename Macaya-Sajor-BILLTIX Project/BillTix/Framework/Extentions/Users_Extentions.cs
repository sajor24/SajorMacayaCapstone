using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using Domain.Models;
using BCrypt.Net;

namespace Framework.Extentions
{
    public static class EmployeeExtension
    {
        public static DynamicParameters ToCreateEmployeeDynamicParameters(this Users user)
        {
            var param = new DynamicParameters();

            param.Add("@FirstName", user.FirstName);
            param.Add("@LastName", user.LastName);
            param.Add("@Username", user.Username);

            string hashedPassword =
                BCrypt.Net.BCrypt.HashPassword(user.Password);

            param.Add("@Password", hashedPassword);

            param.Add("@Role", user.Role);

            return param;
        }
    }

        public static class UserExtension
        {
            public static DynamicParameters ToLoginParameters(this string username)
            {
                var param = new DynamicParameters();
                param.Add("@Username", username);
                return param;
            }
        }
    }
