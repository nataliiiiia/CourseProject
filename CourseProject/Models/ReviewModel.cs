using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    internal class ReviewModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Title { get; set; }
        public int Revisor { get; set; }
        public int Department { get; set;}
        public DateTime Time { get; set; }
    }
}
