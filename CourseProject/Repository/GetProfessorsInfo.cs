using CourseProject.Info;
using CourseProject.Models;
using CourseProject.UserInfo;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Services
{
    internal class GetProfessorsInfo(int professorId)
    {
        private readonly string ConnectionString = DepartmantConnectionString.connectionString;

        public ProfessorModel GetInfo()
        {
            ProfessorModel professorModel = new();
            using SqlConnection connection = new(ConnectionString);
            connection.Open();
            using SqlCommand command = new("GetProfessorResponsibility", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ProfessorId", professorId);
            using SqlDataReader reader = command.ExecuteReader();
            Dictionary<int, string> data = new();
            while (reader.Read())
            { 
                professorModel.Surname = reader["professor_surname"].ToString();
                professorModel.Name = reader["professor_name"].ToString();
                professorModel.Patronymic = reader["professor_middle_name"].ToString();
                professorModel.Position = reader["professor_position"].ToString();
                professorModel.Contact = reader["professor_contact"].ToString();
                professorModel.Handlership = bool.Parse(reader["handlership"].ToString());
                professorModel.DepartmentId = DepartmentInfo.DepartmentId;
                data.Add(int.Parse(reader["event_id"].ToString()),reader["event_name"].ToString());
                professorModel.Events = data;            
            }
            return professorModel;
        }
    }
}
