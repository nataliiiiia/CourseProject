using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    internal class ProfessorModel
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Position { get; set; }
        public string Contact { get; set; }
        public bool Handlership { get; set; }
        public int DepartmentId { get; set; }
        public Dictionary<int, string> Events { get; set;}
    }
}
