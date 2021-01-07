using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VP_Asgn4.Views;
using VP_Asgn4.Models;

namespace VP_Asgn4
{
    public partial class GradesForm : Form
    {
        private Student Stud;
        private Semester Sem;
        private Subject[] Subjects;

        public GradesForm()
        {
            InitializeComponent();
            Constants.SemesterCount++;

            this.Stud = Constants.Student;
            Sem = new Semester();
            Subjects = new Subject[6];
        }

        private void GradesForm_Load(object sender, EventArgs e)
        {
            SemTbx.Text = Constants.SemesterCount.ToString();

            // we get NullReferenceException here if we don't already initialize
            Subjects[0] = new Subject();
            Subjects[1] = new Subject();
            Subjects[2] = new Subject();
            Subjects[3] = new Subject();
            Subjects[4] = new Subject();
            Subjects[5] = new Subject();
        }

        private void Subj1Tbx_TextChanged(object sender, EventArgs e)
        {
            Subjects[0].Name = Subj1Tbx.Text;
        }

        private void CrdHrs1Tbx_TextChanged(object sender, EventArgs e)
        {
            Subjects[0].Credit_Hours = CrdHrs1Tbx.Text;
        }

        private void Grade1Cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Subjects[0].Grade = Grade1Cbx.Text;
        }

        private void Subj2Tbx_TextChanged(object sender, EventArgs e)
        {
            Subjects[1].Name = Subj2Tbx.Text;
        }

        private void CrdHrs2Tbx_TextChanged(object sender, EventArgs e)
        {
            Subjects[1].Credit_Hours = CrdHrs2Tbx.Text;
        }

        private void Grade2Cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Subjects[1].Grade = Grade2Cbx.Text;
        }

        private void Subj3Tbx_TextChanged(object sender, EventArgs e)
        {
            Subjects[2].Name = Subj3Tbx.Text;
        }

        private void CrdHrs3Tbx_TextChanged(object sender, EventArgs e)
        {
            Subjects[2].Credit_Hours = CrdHrs3Tbx.Text;
        }

        private void Grade3Cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Subjects[2].Grade = Grade3Cbx.Text;
        }

        private void Subj4Tbx_TextChanged(object sender, EventArgs e)
        {
            Subjects[3].Name = Subj4Tbx.Text;
        }

        private void CrdHrs4Tbx_TextChanged(object sender, EventArgs e)
        {
            Subjects[3].Credit_Hours = CrdHrs4Tbx.Text;
        }

        private void Grade4Cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Subjects[3].Grade = Grade4Cbx.Text;
        }

        private void Subj5Tbx_TextChanged(object sender, EventArgs e)
        {
            Subjects[4].Name = Subj5Tbx.Text;
        }

        private void CrdHrs5Tbx_TextChanged(object sender, EventArgs e)
        {
            Subjects[4].Credit_Hours = CrdHrs5Tbx.Text;
        }

        private void Grade5Cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Subjects[4].Grade = Grade5Cbx.Text;
        }

        private void Subj6Tbx_TextChanged(object sender, EventArgs e)
        {
            Subjects[5].Name = Subj6Tbx.Text;
        }

        private void CrdHrs6Tbx_TextChanged(object sender, EventArgs e)
        {
            Subjects[5].Credit_Hours = CrdHrs6Tbx.Text;
        }

        private void Grade6Cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Subjects[5].Grade = Grade6Cbx.Text;
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            Sem.Semester_No = Constants.SemesterCount.ToString();

            try
            {
                foreach (Subject Subj in Subjects)
                    Sem.SubjectList.Add(Subj);
                Stud.SemesterList.Add(Sem);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (StackOverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }

            MessageBox.Show("Grades added.", "Success");

            GPA_Functions GPF = new GPA_Functions();
            Sem.SGPA = GPF.calculateSGPA(Sem.SubjectList).ToString();
            Stud.CGPA = GPF.calculateCGPA(Stud.SemesterList).ToString();

            TranscriptForm TSF = new TranscriptForm();
            TSF.Show();
            this.Close();
        }
    }
}
