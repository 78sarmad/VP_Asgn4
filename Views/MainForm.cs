using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VP_Asgn4.Controllers;
using VP_Asgn4.Models;

namespace VP_Asgn4
{
    public partial class MainForm : Form
    {
        private Student Stud;
        private Validations V;

        public MainForm()
        {
            InitializeComponent();
            Stud = Constants.Student;
            V = new Validations();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ProceedBtn.Enabled = false;
        }

        private void NameTbx_TextChanged(object sender, EventArgs e)
        {
            Stud.Name = NameTbx.Text;
        }

        private void EnrollTbx_TextChanged(object sender, EventArgs e)
        {
            Stud.Enroll = EnrollTbx.Text;
        }

        private void EmailTbx_TextChanged(object sender, EventArgs e)
        {
            Stud.Email = EmailTbx.Text;
        }

        private void PwdTbx_TextChanged(object sender, EventArgs e)
        {
            Stud.Password = PwdTbx.Text;
        }

        private void PhoneTbx_TextChanged(object sender, EventArgs e)
        {
            Stud.Phone = PhoneTbx.Text;
        }

        private void BldGrpCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Stud.BloodGroup = BldGrpCbx.Text;
        }

        private void DegreeTbx_TextChanged(object sender, EventArgs e)
        {
            Stud.Degree = DegreeTbx.Text;
        }


        private void DobPicker_ValueChanged(object sender, EventArgs e)
        {
            Stud.DOB = DobPicker.Value.ToShortDateString();
        }

        private void VerifyBtn_Click(object sender, EventArgs e)
        {
            V.thisFieldIsRequired(NameTbx, ProceedBtn);
            V.thisFieldIsRequired(EnrollTbx, ProceedBtn);
            V.thisFieldIsRequired(DegreeTbx, ProceedBtn);
        }

        private void ProceedBtn_Click(object sender, EventArgs e)
        {
            FileOperations FO = new FileOperations(Stud);
            bool isSuccessful = FO.writeProfileToFile();

            if (isSuccessful)
            {
                MessageBox.Show("Details added.\nClick \'Proceed\' button to add your grades.", "Success");
                GradesForm GSF = new GradesForm();
                GSF.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("We could not save your grades. Please try again.", "Error");
            }
        }
    }
}
