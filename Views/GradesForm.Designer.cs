namespace VP_Asgn4
{
    partial class GradesForm
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
            this.Subj1Tbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Grade1Cbx = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SemTbx = new System.Windows.Forms.TextBox();
            this.CrdHrs1Tbx = new System.Windows.Forms.TextBox();
            this.CrdHrs2Tbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Grade2Cbx = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Subj2Tbx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CrdHrs3Tbx = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Grade3Cbx = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Subj3Tbx = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CrdHrs4Tbx = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Grade4Cbx = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Subj4Tbx = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CrdHrs5Tbx = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Grade5Cbx = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Subj5Tbx = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.CrdHrs6Tbx = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.Grade6Cbx = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.Subj6Tbx = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Subj1Tbx
            // 
            this.Subj1Tbx.Location = new System.Drawing.Point(187, 104);
            this.Subj1Tbx.Name = "Subj1Tbx";
            this.Subj1Tbx.Size = new System.Drawing.Size(284, 22);
            this.Subj1Tbx.TabIndex = 24;
            this.Subj1Tbx.TextChanged += new System.EventHandler(this.Subj1Tbx_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(51, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Subject Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(50, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Enter your grades";
            // 
            // Grade1Cbx
            // 
            this.Grade1Cbx.FormattingEnabled = true;
            this.Grade1Cbx.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "F"});
            this.Grade1Cbx.Location = new System.Drawing.Point(388, 141);
            this.Grade1Cbx.Name = "Grade1Cbx";
            this.Grade1Cbx.Size = new System.Drawing.Size(83, 24);
            this.Grade1Cbx.TabIndex = 26;
            this.Grade1Cbx.SelectedIndexChanged += new System.EventHandler(this.Grade1Cbx_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(309, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Grade:";
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SubmitBtn.ForeColor = System.Drawing.Color.Green;
            this.SubmitBtn.Location = new System.Drawing.Point(271, 616);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(200, 33);
            this.SubmitBtn.TabIndex = 47;
            this.SubmitBtn.Text = "Generate Transcript";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.Location = new System.Drawing.Point(309, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 20);
            this.label14.TabIndex = 48;
            this.label14.Text = "Semester:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(51, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Credit Hours:";
            // 
            // SemTbx
            // 
            this.SemTbx.Enabled = false;
            this.SemTbx.Location = new System.Drawing.Point(414, 40);
            this.SemTbx.Name = "SemTbx";
            this.SemTbx.Size = new System.Drawing.Size(54, 22);
            this.SemTbx.TabIndex = 52;
            // 
            // CrdHrs1Tbx
            // 
            this.CrdHrs1Tbx.Location = new System.Drawing.Point(187, 141);
            this.CrdHrs1Tbx.Name = "CrdHrs1Tbx";
            this.CrdHrs1Tbx.Size = new System.Drawing.Size(80, 22);
            this.CrdHrs1Tbx.TabIndex = 53;
            this.CrdHrs1Tbx.TextChanged += new System.EventHandler(this.CrdHrs1Tbx_TextChanged);
            // 
            // CrdHrs2Tbx
            // 
            this.CrdHrs2Tbx.Location = new System.Drawing.Point(187, 224);
            this.CrdHrs2Tbx.Name = "CrdHrs2Tbx";
            this.CrdHrs2Tbx.Size = new System.Drawing.Size(80, 22);
            this.CrdHrs2Tbx.TabIndex = 59;
            this.CrdHrs2Tbx.TextChanged += new System.EventHandler(this.CrdHrs2Tbx_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(51, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 58;
            this.label4.Text = "Credit Hours:";
            // 
            // Grade2Cbx
            // 
            this.Grade2Cbx.FormattingEnabled = true;
            this.Grade2Cbx.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "F"});
            this.Grade2Cbx.Location = new System.Drawing.Point(388, 224);
            this.Grade2Cbx.Name = "Grade2Cbx";
            this.Grade2Cbx.Size = new System.Drawing.Size(83, 24);
            this.Grade2Cbx.TabIndex = 57;
            this.Grade2Cbx.SelectedIndexChanged += new System.EventHandler(this.Grade2Cbx_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(309, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 56;
            this.label5.Text = "Grade:";
            // 
            // Subj2Tbx
            // 
            this.Subj2Tbx.Location = new System.Drawing.Point(187, 187);
            this.Subj2Tbx.Name = "Subj2Tbx";
            this.Subj2Tbx.Size = new System.Drawing.Size(284, 22);
            this.Subj2Tbx.TabIndex = 55;
            this.Subj2Tbx.TextChanged += new System.EventHandler(this.Subj2Tbx_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(51, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 54;
            this.label6.Text = "Subject Name:";
            // 
            // CrdHrs3Tbx
            // 
            this.CrdHrs3Tbx.Location = new System.Drawing.Point(187, 307);
            this.CrdHrs3Tbx.Name = "CrdHrs3Tbx";
            this.CrdHrs3Tbx.Size = new System.Drawing.Size(80, 22);
            this.CrdHrs3Tbx.TabIndex = 65;
            this.CrdHrs3Tbx.TextChanged += new System.EventHandler(this.CrdHrs3Tbx_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(51, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 64;
            this.label8.Text = "Credit Hours:";
            // 
            // Grade3Cbx
            // 
            this.Grade3Cbx.FormattingEnabled = true;
            this.Grade3Cbx.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "F"});
            this.Grade3Cbx.Location = new System.Drawing.Point(388, 307);
            this.Grade3Cbx.Name = "Grade3Cbx";
            this.Grade3Cbx.Size = new System.Drawing.Size(83, 24);
            this.Grade3Cbx.TabIndex = 63;
            this.Grade3Cbx.SelectedIndexChanged += new System.EventHandler(this.Grade3Cbx_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(309, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 62;
            this.label9.Text = "Grade:";
            // 
            // Subj3Tbx
            // 
            this.Subj3Tbx.Location = new System.Drawing.Point(187, 270);
            this.Subj3Tbx.Name = "Subj3Tbx";
            this.Subj3Tbx.Size = new System.Drawing.Size(284, 22);
            this.Subj3Tbx.TabIndex = 61;
            this.Subj3Tbx.TextChanged += new System.EventHandler(this.Subj3Tbx_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(51, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 20);
            this.label10.TabIndex = 60;
            this.label10.Text = "Subject Name:";
            // 
            // CrdHrs4Tbx
            // 
            this.CrdHrs4Tbx.Location = new System.Drawing.Point(187, 393);
            this.CrdHrs4Tbx.Name = "CrdHrs4Tbx";
            this.CrdHrs4Tbx.Size = new System.Drawing.Size(80, 22);
            this.CrdHrs4Tbx.TabIndex = 71;
            this.CrdHrs4Tbx.TextChanged += new System.EventHandler(this.CrdHrs4Tbx_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(51, 393);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 20);
            this.label11.TabIndex = 70;
            this.label11.Text = "Credit Hours:";
            // 
            // Grade4Cbx
            // 
            this.Grade4Cbx.FormattingEnabled = true;
            this.Grade4Cbx.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "F"});
            this.Grade4Cbx.Location = new System.Drawing.Point(388, 393);
            this.Grade4Cbx.Name = "Grade4Cbx";
            this.Grade4Cbx.Size = new System.Drawing.Size(83, 24);
            this.Grade4Cbx.TabIndex = 69;
            this.Grade4Cbx.SelectedIndexChanged += new System.EventHandler(this.Grade4Cbx_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(309, 393);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 20);
            this.label12.TabIndex = 68;
            this.label12.Text = "Grade:";
            // 
            // Subj4Tbx
            // 
            this.Subj4Tbx.Location = new System.Drawing.Point(187, 356);
            this.Subj4Tbx.Name = "Subj4Tbx";
            this.Subj4Tbx.Size = new System.Drawing.Size(284, 22);
            this.Subj4Tbx.TabIndex = 67;
            this.Subj4Tbx.TextChanged += new System.EventHandler(this.Subj4Tbx_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(51, 356);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 20);
            this.label13.TabIndex = 66;
            this.label13.Text = "Subject Name:";
            // 
            // CrdHrs5Tbx
            // 
            this.CrdHrs5Tbx.Location = new System.Drawing.Point(187, 476);
            this.CrdHrs5Tbx.Name = "CrdHrs5Tbx";
            this.CrdHrs5Tbx.Size = new System.Drawing.Size(80, 22);
            this.CrdHrs5Tbx.TabIndex = 77;
            this.CrdHrs5Tbx.TextChanged += new System.EventHandler(this.CrdHrs5Tbx_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label15.Location = new System.Drawing.Point(51, 476);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 20);
            this.label15.TabIndex = 76;
            this.label15.Text = "Credit Hours:";
            // 
            // Grade5Cbx
            // 
            this.Grade5Cbx.FormattingEnabled = true;
            this.Grade5Cbx.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "F"});
            this.Grade5Cbx.Location = new System.Drawing.Point(388, 476);
            this.Grade5Cbx.Name = "Grade5Cbx";
            this.Grade5Cbx.Size = new System.Drawing.Size(83, 24);
            this.Grade5Cbx.TabIndex = 75;
            this.Grade5Cbx.SelectedIndexChanged += new System.EventHandler(this.Grade5Cbx_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label16.Location = new System.Drawing.Point(309, 476);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 20);
            this.label16.TabIndex = 74;
            this.label16.Text = "Grade:";
            // 
            // Subj5Tbx
            // 
            this.Subj5Tbx.Location = new System.Drawing.Point(187, 439);
            this.Subj5Tbx.Name = "Subj5Tbx";
            this.Subj5Tbx.Size = new System.Drawing.Size(284, 22);
            this.Subj5Tbx.TabIndex = 73;
            this.Subj5Tbx.TextChanged += new System.EventHandler(this.Subj5Tbx_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label17.Location = new System.Drawing.Point(51, 439);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(119, 20);
            this.label17.TabIndex = 72;
            this.label17.Text = "Subject Name:";
            // 
            // CrdHrs6Tbx
            // 
            this.CrdHrs6Tbx.Location = new System.Drawing.Point(187, 560);
            this.CrdHrs6Tbx.Name = "CrdHrs6Tbx";
            this.CrdHrs6Tbx.Size = new System.Drawing.Size(80, 22);
            this.CrdHrs6Tbx.TabIndex = 83;
            this.CrdHrs6Tbx.TextChanged += new System.EventHandler(this.CrdHrs6Tbx_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label18.Location = new System.Drawing.Point(51, 560);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(110, 20);
            this.label18.TabIndex = 82;
            this.label18.Text = "Credit Hours:";
            // 
            // Grade6Cbx
            // 
            this.Grade6Cbx.FormattingEnabled = true;
            this.Grade6Cbx.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "F"});
            this.Grade6Cbx.Location = new System.Drawing.Point(388, 560);
            this.Grade6Cbx.Name = "Grade6Cbx";
            this.Grade6Cbx.Size = new System.Drawing.Size(83, 24);
            this.Grade6Cbx.TabIndex = 81;
            this.Grade6Cbx.SelectedIndexChanged += new System.EventHandler(this.Grade6Cbx_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label19.Location = new System.Drawing.Point(309, 560);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 20);
            this.label19.TabIndex = 80;
            this.label19.Text = "Grade:";
            // 
            // Subj6Tbx
            // 
            this.Subj6Tbx.Location = new System.Drawing.Point(187, 523);
            this.Subj6Tbx.Name = "Subj6Tbx";
            this.Subj6Tbx.Size = new System.Drawing.Size(284, 22);
            this.Subj6Tbx.TabIndex = 79;
            this.Subj6Tbx.TextChanged += new System.EventHandler(this.Subj6Tbx_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label20.Location = new System.Drawing.Point(51, 523);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(119, 20);
            this.label20.TabIndex = 78;
            this.label20.Text = "Subject Name:";
            // 
            // GradesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 685);
            this.Controls.Add(this.CrdHrs6Tbx);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.Grade6Cbx);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.Subj6Tbx);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.CrdHrs5Tbx);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Grade5Cbx);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.Subj5Tbx);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.CrdHrs4Tbx);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Grade4Cbx);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Subj4Tbx);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.CrdHrs3Tbx);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Grade3Cbx);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Subj3Tbx);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CrdHrs2Tbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Grade2Cbx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Subj2Tbx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CrdHrs1Tbx);
            this.Controls.Add(this.SemTbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.Grade1Cbx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Subj1Tbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GradesForm";
            this.Text = "Grades";
            this.Load += new System.EventHandler(this.GradesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Subj1Tbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Grade1Cbx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SemTbx;
        private System.Windows.Forms.TextBox CrdHrs1Tbx;
        private System.Windows.Forms.TextBox CrdHrs2Tbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Grade2Cbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Subj2Tbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CrdHrs3Tbx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Grade3Cbx;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Subj3Tbx;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CrdHrs4Tbx;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox Grade4Cbx;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Subj4Tbx;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox CrdHrs5Tbx;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox Grade5Cbx;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Subj5Tbx;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox CrdHrs6Tbx;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox Grade6Cbx;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox Subj6Tbx;
        private System.Windows.Forms.Label label20;
    }
}