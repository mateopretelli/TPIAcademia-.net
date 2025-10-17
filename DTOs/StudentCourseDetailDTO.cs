using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class StudentCourseDetailDTO
    {
        public int ID { get; set; }
        public int IDStudent { get; set; }
        public int IDCourse { get; set; }
        public string StudentName { get; set; }
        public string StudentLastName { get; set; }
        public string StudentEmail { get; set; }
        public int? Grade { get; set; }
        public string Condition { get; set; }
        public string State { get; set; }
    }
}
