using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    internal class EventModel
    {
        public int Id { get; set; }
        public int SectionId { get; set; }
        public int SceduleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Result { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }
        public List<int> ExecutersId { get; set; }
    }
}
