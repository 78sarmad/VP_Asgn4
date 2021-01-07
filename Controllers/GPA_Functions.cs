using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_Asgn4
{
    class GPA_Functions
    {
        public double gradeToPoints(String grade)
        {
            if (grade == "A")
                return 4;
            else if (grade == "B")
                return 3;
            else if (grade == "C")
                return 2;
            else if (grade == "D")
                return 1.5;
            else if (grade == "F")
                return 0;
            else
                return 0;
        }

        public double calculateSGPA(List<Subject> SubjectList)
        {
            double total_points = 0, total_crd_hrs = 0;
            double sgpa = 0;

            foreach(Subject Subj in SubjectList)
            {
                double points = gradeToPoints(Subj.Grade);
                double crd_hrs = Convert.ToDouble(Subj.Credit_Hours);
                double subj_points = (points * crd_hrs);

                total_points += subj_points;
                total_crd_hrs += crd_hrs;
            }

            try
            {
                sgpa = (total_points / total_crd_hrs);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return sgpa;
        }

        public double calculateCGPA(List<Semester> SemesterList)
        {
            double total_points = 0;
            int sem_count = 0;
            double cgpa = 0;

            foreach (Semester Sem in SemesterList)
            {
                total_points += Convert.ToDouble(Sem.SGPA);
                sem_count++;
            }
            
            try
            {
                 cgpa = (total_points / (double) sem_count);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return cgpa;
        }
    }
}
