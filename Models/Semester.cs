using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_Asgn4
{
    public class Semester
    {
        public String Semester_No { get; set; }
        public String SGPA { get; set; }

        private List<Subject> subjectList = new List<Subject>();

        public List<Subject> SubjectList
        {
            get
            {
                return subjectList;
            }
            set
            {
                subjectList = value;
            }
        }
    }
}
