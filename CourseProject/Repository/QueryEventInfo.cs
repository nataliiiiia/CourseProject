using CourseProject.Forms;
using CourseProject.Info;
using CourseProject.Models;
using CourseProject.UserInfo;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CourseProject.Services
{
    internal class QueryEventInfo
    {
        private readonly string ConnectionString = DepartmantConnectionString.connectionString;
        public EventModel GetEventById(int eventId)
        {
            EventModel model = new EventModel();
            int sceduleId = DepartmentInfo.SceduleId;
            using (SqlConnection connection = new(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new("select * from Event where event_id = @EventId", 
                    connection))
                {
                    command.Parameters.AddWithValue("@EventId", eventId);
                    using SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        model.SceduleId = sceduleId;
                        model.SectionId = int.Parse(reader["section_id"].ToString());
                        model.Name = reader["event_name"].ToString();
                        model.Result = reader["event_result"].ToString();
                        model.Description = reader["event_description"].ToString();
                        model.Status = reader["event_status"].ToString();
                        model.Date = DateTime.Parse(reader["event_due"].ToString());
                        model.Id = int.Parse(reader["event_id"].ToString());
                    }
                }
                connection.Close();
            }
            using (SqlConnection connection = new(ConnectionString)) 
            {
                model.ExecutersId = [];
                connection.Open();
                using (SqlCommand command = new("select professor_id from EventResponsibility where event_id = @EventId", connection))
                {
                    command.Parameters.AddWithValue("@EventId", eventId);
                    using SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        model.ExecutersId.Add(int.Parse(reader["professor_id"].ToString()));
                    }
                }
                connection.Close();
            }
            
            return model;
        }
        public void AddEvent(EventModel model)
        {
            int eventId;
            using (SqlConnection connection = new(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new("AddNewEvent", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EventName", model.Name);
                    command.Parameters.AddWithValue("@EventDescription", model.Description);
                    command.Parameters.AddWithValue("@EventResult", model.Result);
                    command.Parameters.AddWithValue("@EventDue", model.Date);
                    command.Parameters.AddWithValue("@SectionId", model.SectionId);
                    command.Parameters.AddWithValue("@SceduleId", DepartmentInfo.SceduleId);
                    SqlParameter eventIdParameter = new("@EventId", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(eventIdParameter);
                    command.ExecuteNonQuery();
                    eventId = (int)eventIdParameter.Value;
                }

                foreach(var prof in model.ExecutersId)
                {
                    using (SqlCommand command = new("insert into EventResponsibility " +
                        "(professor_id, event_id) values (@ProfessorId, @EventId)", connection))
                    {
                        command.Parameters.AddWithValue("@ProfessorId", prof);
                        command.Parameters.AddWithValue("@EventId", eventId);
                        command.ExecuteNonQuery();
                    }
                }
                connection.Close();
            }
        }
        public int DeleteEvent(int event_id)
        {
            int rowsAffected;
            using (SqlConnection connection = new (ConnectionString))
            {
                
                try {
                    connection.Open();
                    using (SqlCommand command = new("delete from EventResponsibility where event_id = @EventId", connection))
                    {
                        command.Parameters.AddWithValue("@EventId", event_id);
                        rowsAffected = command.ExecuteNonQuery();
                    }

                    using (SqlCommand command = new("delete from Event where event_id = @EventId", connection))
                    {
                        command.Parameters.AddWithValue("@EventId", event_id);
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                catch (Exception) { rowsAffected = 0; }
                  
            }
            return rowsAffected;
        }
        public void AlterEvent(EventModel model)
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
                        CommandText = "UpdateEventInfo",
                    };
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EventId", model.Id);
                    command.Parameters.AddWithValue("@EventName", model.Name);
                    command.Parameters.AddWithValue("@EventDescription", model.Description);
                    command.Parameters.AddWithValue("@EventResult", model.Result);
                    command.Parameters.AddWithValue("@EventDue", model.Date);
                    command.Parameters.AddWithValue("@SectionId", model.SectionId);
                    command.Parameters.AddWithValue("@EventStatus", model.Status);
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
