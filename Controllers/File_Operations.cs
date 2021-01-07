using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using VP_Asgn4.Models;
using VP_Asgn4.Controllers;

namespace VP_Asgn4
{
    class FileOperations
    {
        Student Stud;
        String DesktopPath, StudFileRoot;
        Validations V;

        public FileOperations(Student Stud)
        {
            this.Stud = Stud;
            DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            StudFileRoot = DesktopPath + "\\Students\\" + Stud.Enroll + "\\";

            V = new Validations();
            V.validateDirectory(StudFileRoot);
        }

        public bool writeProfileToFile()
        {
            bool success = false;
            String ProfilePath = StudFileRoot + "Profile Info.txt";

            if (!Directory.Exists(StudFileRoot))
            {
                Directory.CreateDirectory(StudFileRoot);
            }

            try
            {
                using (StreamWriter SW = File.CreateText(ProfilePath))
                {
                    SW.WriteLine("Name: " + Stud.Name + "\nEnrollment: " + Stud.Enroll + "\nEmail: " + Stud.Email + "\nPassword: " + Stud.Password + "\nPhone: " + Stud.Phone + "\nAddress: " + Stud.Degree + "\nBlood Group: " + Stud.BloodGroup + "\nDate of Birth: " + Stud.DOB);
                    SW.Close();
                    success = true;
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return success;
        }

        public bool writeGradesToFile()
        {
            bool success = false;
            String GradesPath = StudFileRoot + "Grades.txt";

            try
            {
                using (StreamWriter SW = File.CreateText(GradesPath))
                {
                    foreach (Semester Sem in Stud.SemesterList)
                    {
                        foreach (Subject Subj in Sem.SubjectList)
                        {
                            SW.WriteLine(Subj.Name + ":" + Subj.Credit_Hours + ":" + Subj.Grade);
                        }

                        SW.WriteLine("SGPA: " + Sem.SGPA);
                    }
                    SW.WriteLine("CGPA: " + Stud.CGPA);
                    SW.WriteLine("\n\n");

                    SW.Close();
                    success = true;
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return success;
        }
    }
}
