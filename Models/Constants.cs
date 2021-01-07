using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_Asgn4.Models
{
    public static class Constants
    {
        // Since we are not dealing with login functionality
        // so I prefer creating a global Student instance
        // that can be accessed from anywhere in the program
        public static Student Student = new Student();
        public static int SemesterCount = 0;
    }
}
