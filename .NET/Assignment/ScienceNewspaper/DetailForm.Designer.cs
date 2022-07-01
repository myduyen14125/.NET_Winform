namespace ScienceNewspaper
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
            this.lbID = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbHuongNC = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbHuongNC = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtSV = new System.Windows.Forms.TextBox();
            this.lbSV = new System.Windows.Forms.Label();
            this.cbGVHD = new System.Windows.Forms.ComboBox();
            this.lbGVHD = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.lbYear = new System.Windows.Forms.Label();
            this.lbPublisher = new System.Windows.Forms.Label();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbTrue = new System.Windows.Forms.RadioButton();
            this.rbFalse = new System.Windows.Forms.RadioButton();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(32, 33);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(67, 16);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "Mã DATN";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(32, 74);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(72, 16);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Tên DATN";
            // 
            // lbHuongNC
            // 
            this.lbHuongNC.AutoSize = true;
            this.lbHuongNC.Location = new System.Drawing.Point(32, 151);
            this.lbHuongNC.Name = "lbHuongNC";
            this.lbHuongNC.Size = new System.Drawing.Size(69, 16);
            this.lbHuongNC.TabIndex = 2;
            this.lbHuongNC.Text = "Hướng NC";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(146, 27);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(229, 22);
            this.txtID.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(146, 71);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(229, 22);
            this.txtName.TabIndex = 4;
            // 
            // cbHuongNC
            // 
            this.cbHuongNC.FormattingEnabled = true;
            this.cbHuongNC.Location = new System.Drawing.Point(146, 148);
            this.cbHuongNC.Name = "cbHuongNC";
            this.cbHuongNC.Size = new System.Drawing.Size(229, 24);
            this.cbHuongNC.TabIndex = 5;
            this.cbHuongNC.SelectedIndexChanged += new System.EventHandler(this.cbHuongNC_SelectedIndexChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(78, 369);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(300, 369);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtSV
            // 
            this.txtSV.Location = new System.Drawing.Point(146, 108);
            this.txtSV.Name = "txtSV";
            this.txtSV.Size = new System.Drawing.Size(229, 22);
            this.txtSV.TabIndex = 10;
            // 
            // lbSV
            // 
            this.lbSV.AutoSize = true;
            this.lbSV.Location = new System.Drawing.Point(32, 111);
            this.lbSV.Name = "lbSV";
            this.lbSV.Size = new System.Drawing.Size(80, 16);
            this.lbSV.TabIndex = 9;
            this.lbSV.Text = "SV thực hiện";
            // 
            // cbGVHD
            // 
            this.cbGVHD.FormattingEnabled = true;
            this.cbGVHD.Location = new System.Drawing.Point(146, 193);
            this.cbGVHD.Name = "cbGVHD";
            this.cbGVHD.Size = new System.Drawing.Size(229, 24);
            this.cbGVHD.TabIndex = 12;
            // 
            // lbGVHD
            // 
            this.lbGVHD.AutoSize = true;
            this.lbGVHD.Location = new System.Drawing.Point(32, 196);
            this.lbGVHD.Name = "lbGVHD";
            this.lbGVHD.Size = new System.Drawing.Size(46, 16);
            this.lbGVHD.TabIndex = 11;
            this.lbGVHD.Text = "GVHD";
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(145, 297);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(229, 24);
            this.cbYear.TabIndex = 14;
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(31, 300);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(81, 16);
            this.lbYear.TabIndex = 13;
            this.lbYear.Text = "Năm bảo vệ";
            // 
            // lbPublisher
            // 
            this.lbPublisher.AutoSize = true;
            this.lbPublisher.Location = new System.Drawing.Point(32, 252);
            this.lbPublisher.Name = "lbPublisher";
            this.lbPublisher.Size = new System.Drawing.Size(66, 16);
            this.lbPublisher.TabIndex = 15;
            this.lbPublisher.Text = "Tình trạng";
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbFalse);
            this.gbStatus.Controls.Add(this.rbTrue);
            this.gbStatus.Location = new System.Drawing.Point(145, 241);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(230, 27);
            this.gbStatus.TabIndex = 16;
            this.gbStatus.TabStop = false;
            // 
            // rbTrue
            // 
            this.rbTrue.AutoSize = true;
            this.rbTrue.Location = new System.Drawing.Point(6, 7);
            this.rbTrue.Name = "rbTrue";
            this.rbTrue.Size = new System.Drawing.Size(90, 20);
            this.rbTrue.TabIndex = 0;
            this.rbTrue.TabStop = true;
            this.rbTrue.Text = "Đã bảo vệ";
            this.rbTrue.UseVisualStyleBackColor = true;
            // 
            // rbFalse
            // 
            this.rbFalse.AutoSize = true;
            this.rbFalse.Location = new System.Drawing.Point(123, 7);
            this.rbFalse.Name = "rbFalse";
            this.rbFalse.Size = new System.Drawing.Size(104, 20);
            this.rbFalse.TabIndex = 1;
            this.rbFalse.TabStop = true;
            this.rbFalse.Text = "Chưa bảo vệ";
            this.rbFalse.UseVisualStyleBackColor = true;
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 450);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.lbPublisher);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.lbYear);
            this.Controls.Add(this.cbGVHD);
            this.Controls.Add(this.lbGVHD);
            this.Controls.Add(this.txtSV);
            this.Controls.Add(this.lbSV);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbHuongNC);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbHuongNC);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbID);
            this.Name = "DetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailForm";
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbHuongNC;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbHuongNC;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtSV;
        private System.Windows.Forms.Label lbSV;
        private System.Windows.Forms.ComboBox cbGVHD;
        private System.Windows.Forms.Label lbGVHD;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.Label lbPublisher;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbFalse;
        private System.Windows.Forms.RadioButton rbTrue;
    }
}