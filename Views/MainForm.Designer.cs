namespace VP_Asgn4
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NameTbx = new System.Windows.Forms.TextBox();
            this.EnrollTbx = new System.Windows.Forms.TextBox();
            this.EmailTbx = new System.Windows.Forms.TextBox();
            this.PwdTbx = new System.Windows.Forms.TextBox();
            this.PhoneTbx = new System.Windows.Forms.TextBox();
            this.ProceedBtn = new System.Windows.Forms.Button();
            this.DegreeTbx = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BldGrpCbx = new System.Windows.Forms.ComboBox();
            this.DobPicker = new System.Windows.Forms.DateTimePicker();
            this.VerifyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(43, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(43, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name: *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(44, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enrollment: *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(43, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(43, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(43, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(461, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Blood Group:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(461, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Date of Birth:";
            // 
            // NameTbx
            // 
            this.NameTbx.Location = new System.Drawing.Point(163, 97);
            this.NameTbx.Name = "NameTbx";
            this.NameTbx.Size = new System.Drawing.Size(203, 22);
            this.NameTbx.TabIndex = 8;
            this.NameTbx.TextChanged += new System.EventHandler(this.NameTbx_TextChanged);
            // 
            // EnrollTbx
            // 
            this.EnrollTbx.Location = new System.Drawing.Point(163, 145);
            this.EnrollTbx.Name = "EnrollTbx";
            this.EnrollTbx.Size = new System.Drawing.Size(203, 22);
            this.EnrollTbx.TabIndex = 9;
            this.EnrollTbx.TextChanged += new System.EventHandler(this.EnrollTbx_TextChanged);
            // 
            // EmailTbx
            // 
            this.EmailTbx.Location = new System.Drawing.Point(163, 189);
            this.EmailTbx.Name = "EmailTbx";
            this.EmailTbx.Size = new System.Drawing.Size(203, 22);
            this.EmailTbx.TabIndex = 10;
            this.EmailTbx.TextChanged += new System.EventHandler(this.EmailTbx_TextChanged);
            // 
            // PwdTbx
            // 
            this.PwdTbx.Location = new System.Drawing.Point(163, 233);
            this.PwdTbx.Name = "PwdTbx";
            this.PwdTbx.Size = new System.Drawing.Size(203, 22);
            this.PwdTbx.TabIndex = 11;
            this.PwdTbx.TextChanged += new System.EventHandler(this.PwdTbx_TextChanged);
            // 
            // PhoneTbx
            // 
            this.PhoneTbx.Location = new System.Drawing.Point(163, 282);
            this.PhoneTbx.Name = "PhoneTbx";
            this.PhoneTbx.Size = new System.Drawing.Size(203, 22);
            this.PhoneTbx.TabIndex = 12;
            this.PhoneTbx.TextChanged += new System.EventHandler(this.PhoneTbx_TextChanged);
            // 
            // ProceedBtn
            // 
            this.ProceedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ProceedBtn.ForeColor = System.Drawing.Color.Green;
            this.ProceedBtn.Location = new System.Drawing.Point(565, 306);
            this.ProceedBtn.Name = "ProceedBtn";
            this.ProceedBtn.Size = new System.Drawing.Size(141, 46);
            this.ProceedBtn.TabIndex = 15;
            this.ProceedBtn.Text = "Proceed";
            this.ProceedBtn.UseVisualStyleBackColor = true;
            this.ProceedBtn.Click += new System.EventHandler(this.ProceedBtn_Click);
            // 
            // DegreeTbx
            // 
            this.DegreeTbx.Location = new System.Drawing.Point(163, 330);
            this.DegreeTbx.Name = "DegreeTbx";
            this.DegreeTbx.Size = new System.Drawing.Size(342, 22);
            this.DegreeTbx.TabIndex = 17;
            this.DegreeTbx.TextChanged += new System.EventHandler(this.DegreeTbx_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(44, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Degree: *";
            // 
            // BldGrpCbx
            // 
            this.BldGrpCbx.FormattingEnabled = true;
            this.BldGrpCbx.Items.AddRange(new object[] {
            "O+",
            "A+",
            "B+",
            "AB+",
            "O-",
            "A-",
            "B-",
            "AB-"});
            this.BldGrpCbx.Location = new System.Drawing.Point(608, 97);
            this.BldGrpCbx.Name = "BldGrpCbx";
            this.BldGrpCbx.Size = new System.Drawing.Size(98, 24);
            this.BldGrpCbx.TabIndex = 18;
            this.BldGrpCbx.SelectedIndexChanged += new System.EventHandler(this.BldGrpCbx_SelectedIndexChanged);
            // 
            // DobPicker
            // 
            this.DobPicker.Location = new System.Drawing.Point(465, 187);
            this.DobPicker.Name = "DobPicker";
            this.DobPicker.Size = new System.Drawing.Size(241, 22);
            this.DobPicker.TabIndex = 19;
            this.DobPicker.ValueChanged += new System.EventHandler(this.DobPicker_ValueChanged);
            // 
            // VerifyBtn
            // 
            this.VerifyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.VerifyBtn.Location = new System.Drawing.Point(591, 233);
            this.VerifyBtn.Name = "VerifyBtn";
            this.VerifyBtn.Size = new System.Drawing.Size(115, 35);
            this.VerifyBtn.TabIndex = 20;
            this.VerifyBtn.Text = "Verify Info";
            this.VerifyBtn.UseVisualStyleBackColor = true;
            this.VerifyBtn.Click += new System.EventHandler(this.VerifyBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 393);
            this.Controls.Add(this.VerifyBtn);
            this.Controls.Add(this.DobPicker);
            this.Controls.Add(this.BldGrpCbx);
            this.Controls.Add(this.DegreeTbx);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ProceedBtn);
            this.Controls.Add(this.PhoneTbx);
            this.Controls.Add(this.PwdTbx);
            this.Controls.Add(this.EmailTbx);
            this.Controls.Add(this.EnrollTbx);
            this.Controls.Add(this.NameTbx);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "GPA Calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NameTbx;
        private System.Windows.Forms.TextBox EnrollTbx;
        private System.Windows.Forms.TextBox EmailTbx;
        private System.Windows.Forms.TextBox PwdTbx;
        private System.Windows.Forms.TextBox PhoneTbx;
        private System.Windows.Forms.Button ProceedBtn;
        private System.Windows.Forms.TextBox DegreeTbx;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox BldGrpCbx;
        private System.Windows.Forms.DateTimePicker DobPicker;
        private System.Windows.Forms.Button VerifyBtn;
    }
}

