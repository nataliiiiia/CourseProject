using CourseProject.Info;
using CourseProject.Models;
using CourseProject.UserInfo;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Repository
{
    internal class QueryReviews
    {
        private readonly string ConnectionString = DepartmantConnectionString.connectionString;

        public void SendReview(ReviewModel reviewModel)
        {
            using (SqlConnection connection = new(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new("AddReview", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@RevisorId", User.UId);
                    command.Parameters.AddWithValue("@ReviewText", reviewModel.Text);
                    command.Parameters.AddWithValue("@ReviewDatetime", reviewModel.Time);
                    command.Parameters.AddWithValue("@DepartmentId", reviewModel.Department);
                    command.Parameters.AddWithValue("@Title", reviewModel.Title);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        public Dictionary<int, ReviewModel> GetReviews()
        {
            Dictionary<int, ReviewModel> reviews = new Dictionary<int, ReviewModel>();
            using (SqlConnection connection = new(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new("select * from Review where department_id = @DepartmentId", connection))
                {
                    command.Parameters.AddWithValue("@DepartmentId", DepartmentInfo.DepartmentId);
                    using SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ReviewModel reviewModel = new ReviewModel();
                        reviewModel.Id = int.Parse(reader["review_id"].ToString());
                        reviewModel.Title = reader["Title"].ToString();
                        reviewModel.Text = reader["review_text"].ToString();
                        reviewModel.Revisor = int.Parse(reader["revisor_id"].ToString());
                        reviewModel.Department = int.Parse(reader["department_id"].ToString());
                        reviewModel.Time = DateTime.Parse(reader["review_datetime"].ToString());
                        reviews.Add(reviewModel.Id, reviewModel);
                    }
                }
            }
            return reviews;
        }
    }
}
