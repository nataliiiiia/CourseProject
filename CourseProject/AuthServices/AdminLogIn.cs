using CourseProject.Info;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CourseProject.AuthServices
{
    internal class AdminLogIn(string login, string password, string connectionString)
    {
        private readonly string Login = login;
        private readonly string Password = password;
        private readonly string ConnectionString = connectionString;

        public bool TryLogIn()
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();
            using SqlCommand command = new("CheckUserCredentials", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Username", Login);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Role", "admin");
            SqlParameter outputParameter = new()
            {
                ParameterName = "@IsAuthenticated",
                SqlDbType = SqlDbType.Bit,
                Direction = ParameterDirection.Output
            };
            command.Parameters.Add(outputParameter);

            SqlParameter userIdParameter = new()
            {
                ParameterName= "UserId",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Output
            };
            command.Parameters.Add(userIdParameter);
            command.ExecuteNonQuery();
            bool isAuthenticated = (bool)outputParameter.Value;
            if (isAuthenticated) { User.UId = int.Parse(userIdParameter.Value.ToString()); }
            connection.Close();
            return isAuthenticated;

        }
    }
}
