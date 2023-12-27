using CourseProject.Info;
using CourseProject.Models;
using CourseProject.UserInfo;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Services
{
    internal class GetSceduleInfo
    {
        private readonly string ConnectionString = DepartmantConnectionString.connectionString;
        public SceduleModel GetScedule()
        {
            SceduleModel model = new SceduleModel();
            using (SqlConnection connection = new(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new("select * from Scedule where departament_id = @DepartmentId", connection))
                {
                    command.Parameters.AddWithValue("@DepartmentId", DepartmentInfo.DepartmentId);
                    using SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        model.DepartmentId = Convert.ToInt32(reader["departament_id"]);
                        model.Id = Convert.ToInt32(reader["scedule_id"]);
                        model.Name = reader["scedule_notes"].ToString();
                        model.Years = reader["scedule_year"].ToString();
                        DepartmentInfo.SceduleId = Convert.ToInt32(reader["scedule_id"]);
                    }
                }
                connection.Close();

                return model;
            }
        }

    }
}
