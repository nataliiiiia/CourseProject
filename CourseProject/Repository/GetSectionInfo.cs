using CourseProject.Info;
using CourseProject.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace CourseProject.Repository
{
    internal class GetSectionInfo
    {
        private readonly string ConnectionString = DepartmantConnectionString.connectionString;
        public SectionModel GetSection(int sectionId)
        {
            SectionModel section = new SectionModel();
            using (SqlConnection connection = new(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new("select * from SceduleSection where section_id =  @SectionId", connection))
                {
                    command.Parameters.AddWithValue("@SectionId", sectionId);
                    using SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        section.Id = sectionId;
                        section.Name = reader["section_name"].ToString();
                        section.Description = reader["section_description"].ToString();
                    }
                }
                connection.Close();
            }
            return section;
        }
        public Dictionary<int, SectionModel> GetAllSections()
        {
            Dictionary<int, SectionModel> sections = new Dictionary<int, SectionModel>();

            using (SqlConnection connection = new(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new("select * from SceduleSection", connection))
                {
                    using SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        SectionModel section = new SectionModel();
                        section.Id = int.Parse(reader["section_id"].ToString());
                        section.Name = reader["section_name"].ToString();
                        section.Description = reader["section_description"].ToString();
                        sections.Add(section.Id, section);
                    }
                }
                connection.Close();
            }
            return sections;
        }
    }
}
