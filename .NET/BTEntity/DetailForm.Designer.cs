namespace BTEntity
{
    partial class DetailForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.cbPic = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.grHS = new System.Windows.Forms.GroupBox();
            this.cbNN = new System.Windows.Forms.CheckBox();
            this.cbHB = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rBtnFemale = new System.Windows.Forms.RadioButton();
            this.rBtnMale = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbLSH = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDTB = new System.Windows.Forms.TextBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grHS.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(285, 275);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 34);
            this.btnCancel.TabIndex = 51;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // birthDate
            // 
            this.birthDate.Location = new System.Drawing.Point(356, 62);
            this.birthDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(198, 20);
            this.birthDate.TabIndex = 49;
            // 
            // cbPic
            // 
            this.cbPic.AutoSize = true;
            this.cbPic.Location = new System.Drawing.Point(18, 24);
            this.cbPic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbPic.Name = "cbPic";
            this.cbPic.Size = new System.Drawing.Size(45, 17);
            this.cbPic.TabIndex = 0;
            this.cbPic.Text = "Ảnh";
            this.cbPic.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(136, 275);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(82, 34);
            this.btnOK.TabIndex = 52;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // grHS
            // 
            this.grHS.Controls.Add(this.cbNN);
            this.grHS.Controls.Add(this.cbHB);
            this.grHS.Controls.Add(this.cbPic);
            this.grHS.Location = new System.Drawing.Point(285, 128);
            this.grHS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grHS.Name = "grHS";
            this.grHS.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grHS.Size = new System.Drawing.Size(268, 109);
            this.grHS.TabIndex = 50;
            this.grHS.TabStop = false;
            this.grHS.Text = "Hồ sơ nộp";
            // 
            // cbNN
            // 
            this.cbNN.AutoSize = true;
            this.cbNN.Location = new System.Drawing.Point(18, 71);
            this.cbNN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbNN.Name = "cbNN";
            this.cbNN.Size = new System.Drawing.Size(90, 17);
            this.cbNN.TabIndex = 0;
            this.cbNN.Text = "CC ngoại ngữ";
            this.cbNN.UseVisualStyleBackColor = true;
            // 
            // cbHB
            // 
            this.cbHB.AutoSize = true;
            this.cbHB.Location = new System.Drawing.Point(18, 46);
            this.cbHB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbHB.Name = "cbHB";
            this.cbHB.Size = new System.Drawing.Size(61, 17);
            this.cbHB.TabIndex = 0;
            this.cbHB.Text = "Học bạ";
            this.cbHB.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "DTB";
            // 
            // rBtnFemale
            // 
            this.rBtnFemale.AutoSize = true;
            this.rBtnFemale.Location = new System.Drawing.Point(89, 28);
            this.rBtnFemale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rBtnFemale.Name = "rBtnFemale";
            this.rBtnFemale.Size = new System.Drawing.Size(59, 17);
            this.rBtnFemale.TabIndex = 1;
            this.rBtnFemale.TabStop = true;
            this.rBtnFemale.Text = "Female";
            this.rBtnFemale.UseVisualStyleBackColor = true;
            // 
            // rBtnMale
            // 
            this.rBtnMale.AutoSize = true;
            this.rBtnMale.Location = new System.Drawing.Point(19, 28);
            this.rBtnMale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rBtnMale.Name = "rBtnMale";
            this.rBtnMale.Size = new System.Drawing.Size(48, 17);
            this.rBtnMale.TabIndex = 0;
            this.rBtnMale.TabStop = true;
            this.rBtnMale.Text = "Male";
            this.rBtnMale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "DTB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBtnFemale);
            this.groupBox1.Controls.Add(this.rBtnMale);
            this.groupBox1.Location = new System.Drawing.Point(50, 171);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(168, 67);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // cbbLSH
            // 
            this.cbbLSH.FormattingEnabled = true;
            this.cbbLSH.Location = new System.Drawing.Point(112, 128);
            this.cbbLSH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbLSH.Name = "cbbLSH";
            this.cbbLSH.Size = new System.Drawing.Size(106, 21);
            this.cbbLSH.TabIndex = 44;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(112, 93);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(106, 20);
            this.txtName.TabIndex = 42;
            // 
            // txtDTB
            // 
            this.txtDTB.Location = new System.Drawing.Point(356, 93);
            this.txtDTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDTB.Name = "txtDTB";
            this.txtDTB.Size = new System.Drawing.Size(198, 20);
            this.txtDTB.TabIndex = 43;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(112, 58);
            this.txtMSSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(106, 20);
            this.txtMSSV.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Lớp SH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "MSSV";
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.birthDate);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grHS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbbLSH);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDTB);
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DetailForm";
            this.Text = "DetailForm";
            this.grHS.ResumeLayout(false);
            this.grHS.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker birthDate;
        private System.Windows.Forms.CheckBox cbPic;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox grHS;
        private System.Windows.Forms.CheckBox cbNN;
        private System.Windows.Forms.CheckBox cbHB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rBtnFemale;
        private System.Windows.Forms.RadioButton rBtnMale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbLSH;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDTB;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}