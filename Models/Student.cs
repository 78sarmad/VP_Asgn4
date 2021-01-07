using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_Asgn4
{
    public class Student
    {
        public String Name { get; set; }
        public String Enroll { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public String Degree { get; set; }
        public String Phone { get; set; }
        public String BloodGroup { get; set; }
        public String DOB { get; set; }
        public String CGPA { get; set; }

        private List<Semester> semesterList = new List<Semester>();

        public List<Semester> SemesterList
        {
            get
            {
                return semesterList;
            }
            set
            {
                semesterList = value;
            }
        }
    }
}
