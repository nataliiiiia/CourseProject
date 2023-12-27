using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using CourseProject.Models;
using CourseProject.UserInfo;
using CourseProject.Info;
using System.Data;

namespace CourseProject.Services
{
    internal class QueryDepartmentInfo()
    {
        private readonly string ConnectionString = DepartmantConnectionString.connectionString;

        public Dictionary<int, string> GetDepartaments()
        {
            Dictionary<int, string> departments = [];
            using (SqlConnection connection = new (ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new ("select departament_id, departament_name from Departament", 
                    connection))
                {
                    using SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int departmentID = int.Parse(reader["departament_id"].ToString());
                        string? departmentName = reader["departament_name"].ToString();
                        departments.Add(departmentID, departmentName);
                    }
                }
                connection.Close();
            }
            return departments;
        }
        public DepartmentModel GetDepartmentById(int departmentID)
        {
            DepartmentModel departmentInfo = new();
            using (SqlConnection connection = new(ConnectionString))
            {
                connection.Open();
                
                using (SqlCommand command = new("select * from Departament where departament_id = @DepartmentId", connection))
                {
                    command.Parameters.AddWithValue("@DepartmentId", departmentID);
                    using SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string? departmentName = reader["departament_name"].ToString();
                        string? departmentDescription = reader["departament_description"].ToString();
                        string? academicVolume = reader["academic_volume"].ToString();
                        string? chief = reader["chief"].ToString();
                        string? contact = reader["dapertament_contact"].ToString();
                        departmentInfo.Name = departmentName;
                        departmentInfo.Description = departmentDescription;
                        departmentInfo.AcademicVolume = academicVolume;
                        departmentInfo.Id = departmentID;
                        departmentInfo.Chief = chief;
                        departmentInfo.Contact = contact;
                    }
                }
                connection.Close();
            }
            return departmentInfo;
        }

        public Dictionary<int, ProfessorModel> GetProffesors(int departmentID)
        {
            Dictionary<int, ProfessorModel> professors = [];
            using (SqlConnection connection = new(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new("select * from Professor where departament_id = @DepartmentId", connection))
                {
                    command.Parameters.AddWithValue("@DepartmentId", departmentID);
                    using SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ProfessorModel model = new();
                        int Id = int.Parse(reader["professor_id"].ToString());
                        model.Surname = reader["professor_surname"].ToString();
                        model.Name = reader["professor_name"].ToString();
                        model.Patronymic = reader["professor_middle_name"].ToString();
                        model.Position = reader["professor_position"].ToString();
                        model.Contact = reader["professor_contact"].ToString();
                        model.Handlership = bool.Parse(reader["handlership"].ToString());
                        model.DepartmentId = departmentID;
                        professors.Add(Id, model);
                    }
                }
                connection.Close();
            }
            return professors;
        }
        public void AlterDepartmentInfo(DepartmentModel department) 
        {
            using (SqlConnection connection = new(ConnectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    SqlCommand command = new SqlCommand
                    {
                        Transaction = transaction,
                        Connection = connection,
                        CommandText = "UpdateDepartmentInfo",
                    };
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@DepartmentID", DepartmentInfo.DepartmentId);
                    command.Parameters.AddWithValue("@Chief", department.Chief);
                    command.Parameters.AddWithValue("@DepartmentContact", department.Contact);
                    command.Parameters.AddWithValue("@DepartmentDescription", department.Description);
                    command.ExecuteNonQuery();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Помилка даних", MessageBoxButtons.OK);
                    transaction.Rollback();
                }
                finally { connection.Close(); }
            }
        }
    }
}

