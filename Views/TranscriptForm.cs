using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VP_Asgn4.Models;

namespace VP_Asgn4.Views
{
    public partial class TranscriptForm : Form
    {
        private Student Stud;

        public TranscriptForm()
        {
            InitializeComponent();
            this.Stud = Constants.Student;
        }

        private void TranscriptForm_Load(object sender, EventArgs e)
        {
            int SemIndex = (Constants.SemesterCount - 1);

            StudNameTbx.Text = Stud.Name;
            StudEnrollTbx.Text = Stud.Enroll;
            StudDegreeTbx.Text = Stud.Degree;

            SemTitleLbl.Text += Constants.SemesterCount.ToString();
            SGPATbx.Text = Stud.SemesterList.ElementAt(SemIndex).SGPA;
            CGPATbx.Text = Stud.CGPA;

            Subj1Tbx.Text = Stud.SemesterList.ElementAt(SemIndex).SubjectList.ElementAt(0).Name;
            CrdHrs1Tbx.Text = Stud.SemesterList.ElementAt(SemIndex).SubjectList.ElementAt(0).Credit_Hours;
            Grade1Tbx.Text = Stud.SemesterList.ElementAt(SemIndex).SubjectList.ElementAt(0).Grade;

            Subj2Tbx.Text = Stud.SemesterList.ElementAt(SemIndex).SubjectList.ElementAt(1).Name;
            CrdHrs2Tbx.Text = Stud.SemesterList.ElementAt(SemIndex).SubjectList.ElementAt(1).Credit_Hours;
            Grade2Tbx.Text = Stud.SemesterList.ElementAt(SemIndex).SubjectList.ElementAt(1).Grade;

            Subj3Tbx.Text = Stud.SemesterList.ElementAt(SemIndex).SubjectList.ElementAt(2).Name;
            CrdHrs3Tbx.Text = Stud.SemesterList.ElementAt(SemIndex).SubjectList.ElementAt(2).Credit_Hours;
            Grade3Tbx.Text = Stud.SemesterList.ElementAt(SemIndex).SubjectList.ElementAt(2).Grade;

            Subj4Tbx.Text = Stud.SemesterList.ElementAt(SemIndex).SubjectList.ElementAt(3).Name;
            CrdHrs4Tbx.Text = Stud.SemesterList.ElementAt(SemIndex).SubjectList.ElementAt(3).Credit_Hours;
            Grade4Tbx.Text = Stud.SemesterList.ElementAt(SemIndex).SubjectList.ElementAt(3).Grade;

            Subj5Tbx.Text = Stud.SemesterList.ElementAt(SemIndex).SubjectList.ElementAt(4).Name;
            CrdHrs5Tbx.Text = Stud.SemesterList.ElementAt(SemIndex).SubjectList.ElementAt(4).Credit_Hours;
            Grade5Tbx.Text = Stud.SemesterList.ElementAt(SemIndex).SubjectList.ElementAt(4).Grade;

            Subj6Tbx.Text = Stud.SemesterList.ElementAt(SemIndex).SubjectList.ElementAt(5).Name;
            CrdHrs6Tbx.Text = Stud.SemesterList.ElementAt(SemIndex).SubjectList.ElementAt(5).Credit_Hours;
            Grade6Tbx.Text = Stud.SemesterList.ElementAt(SemIndex).SubjectList.ElementAt(5).Grade;
        }

        private void AddMoreBtn_Click(object sender, EventArgs e)
        {
            GradesForm GSF = new GradesForm();
            GSF.Show();
            this.Close();
        }

        private void SaveGradesBtn_Click(object sender, EventArgs e)
        {
            FileOperations FO = new FileOperations(Stud);
            bool isSuccessful = FO.writeGradesToFile();

            if (isSuccessful)
                MessageBox.Show("Grades saved to file.", "Success");
            else
                MessageBox.Show("We could not save your grades. Please try again.", "Error");
        }

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
