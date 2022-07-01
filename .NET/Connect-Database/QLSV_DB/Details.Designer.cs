namespace QLSV_DB
{
    partial class Details
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
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.checkCMND = new System.Windows.Forms.CheckBox();
            this.checkHocba = new System.Windows.Forms.CheckBox();
            this.checkPhoto = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.txtDTB = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.lbAvgScore = new System.Windows.Forms.Label();
            this.txtDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lbDateOfBirth = new System.Windows.Forms.Label();
            this.lbClass = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbMSSV = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbClass
            // 
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(165, 185);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(149, 24);
            this.cbClass.TabIndex = 28;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(194, 410);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 26;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // checkCMND
            // 
            this.checkCMND.AutoSize = true;
            this.checkCMND.Location = new System.Drawing.Point(25, 95);
            this.checkCMND.Name = "checkCMND";
            this.checkCMND.Size = new System.Drawing.Size(69, 20);
            this.checkCMND.TabIndex = 12;
            this.checkCMND.Text = "CMND";
            this.checkCMND.UseVisualStyleBackColor = true;
            // 
            // checkHocba
            // 
            this.checkHocba.AutoSize = true;
            this.checkHocba.Location = new System.Drawing.Point(25, 58);
            this.checkHocba.Name = "checkHocba";
            this.checkHocba.Size = new System.Drawing.Size(73, 20);
            this.checkHocba.TabIndex = 1;
            this.checkHocba.Text = "Học bạ";
            this.checkHocba.UseVisualStyleBackColor = true;
            // 
            // checkPhoto
            // 
            this.checkPhoto.AutoSize = true;
            this.checkPhoto.Location = new System.Drawing.Point(25, 22);
            this.checkPhoto.Name = "checkPhoto";
            this.checkPhoto.Size = new System.Drawing.Size(52, 20);
            this.checkPhoto.TabIndex = 0;
            this.checkPhoto.Text = "Ảnh";
            this.checkPhoto.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkCMND);
            this.groupBox1.Controls.Add(this.checkHocba);
            this.groupBox1.Controls.Add(this.checkPhoto);
            this.groupBox1.Location = new System.Drawing.Point(433, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 131);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hồ sơ nộp";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(116, 31);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(74, 20);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(19, 31);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(58, 20);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(458, 407);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rbFemale);
            this.gbGender.Controls.Add(this.rbMale);
            this.gbGender.Location = new System.Drawing.Point(78, 261);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(200, 70);
            this.gbGender.TabIndex = 24;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender";
            // 
            // txtDTB
            // 
            this.txtDTB.Location = new System.Drawing.Point(526, 144);
            this.txtDTB.Name = "txtDTB";
            this.txtDTB.Size = new System.Drawing.Size(149, 22);
            this.txtDTB.TabIndex = 23;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(165, 132);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(149, 22);
            this.txtName.TabIndex = 22;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(165, 86);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(149, 22);
            this.txtMSSV.TabIndex = 21;
            // 
            // lbAvgScore
            // 
            this.lbAvgScore.AutoSize = true;
            this.lbAvgScore.Location = new System.Drawing.Point(430, 150);
            this.lbAvgScore.Name = "lbAvgScore";
            this.lbAvgScore.Size = new System.Drawing.Size(70, 16);
            this.lbAvgScore.TabIndex = 20;
            this.lbAvgScore.Text = "Avg Score";
            // 
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.Location = new System.Drawing.Point(526, 92);
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.Size = new System.Drawing.Size(200, 22);
            this.txtDateOfBirth.TabIndex = 19;
            // 
            // lbDateOfBirth
            // 
            this.lbDateOfBirth.AutoSize = true;
            this.lbDateOfBirth.Location = new System.Drawing.Point(430, 92);
            this.lbDateOfBirth.Name = "lbDateOfBirth";
            this.lbDateOfBirth.Size = new System.Drawing.Size(78, 16);
            this.lbDateOfBirth.TabIndex = 18;
            this.lbDateOfBirth.Text = "Date of birth";
            // 
            // lbClass
            // 
            this.lbClass.AutoSize = true;
            this.lbClass.Location = new System.Drawing.Point(75, 185);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(41, 16);
            this.lbClass.TabIndex = 17;
            this.lbClass.Text = "Class";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(75, 135);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(44, 16);
            this.lbName.TabIndex = 16;
            this.lbName.Text = "Name";
            // 
            // lbMSSV
            // 
            this.lbMSSV.AutoSize = true;
            this.lbMSSV.Location = new System.Drawing.Point(74, 92);
            this.lbMSSV.Name = "lbMSSV";
            this.lbMSSV.Size = new System.Drawing.Size(45, 16);
            this.lbMSSV.TabIndex = 15;
            this.lbMSSV.Text = "MSSV";
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.txtDTB);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.lbAvgScore);
            this.Controls.Add(this.txtDateOfBirth);
            this.Controls.Add(this.lbDateOfBirth);
            this.Controls.Add(this.lbClass);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbMSSV);
            this.Name = "Details";
            this.Text = "DetailForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox checkCMND;
        private System.Windows.Forms.CheckBox checkHocba;
        private System.Windows.Forms.CheckBox checkPhoto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.TextBox txtDTB;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Label lbAvgScore;
        private System.Windows.Forms.DateTimePicker txtDateOfBirth;
        private System.Windows.Forms.Label lbDateOfBirth;
        private System.Windows.Forms.Label lbClass;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbMSSV;
    }
}