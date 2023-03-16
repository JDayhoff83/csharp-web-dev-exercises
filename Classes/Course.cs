using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Course
    {
        private string topic { get; set; }
        private Teacher instructor { get; set; }
        private List<Student> enrolledStudents;
    }
}
