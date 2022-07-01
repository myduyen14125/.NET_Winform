namespace ScienceNewspaper
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lbHuongNC = new System.Windows.Forms.Label();
            this.cbHuongNC = new System.Windows.Forms.ComboBox();
            this.lbGVHD = new System.Windows.Forms.Label();
            this.cbGVHD = new System.Windows.Forms.ComboBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HuongNC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GVHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.ID,
            this.NameDA,
            this.SV,
            this.HuongNC,
            this.GVHD,
            this.Status,
            this.Year});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1240, 266);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(121, 343);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(257, 343);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(394, 343);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "DEL";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(121, 403);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(257, 403);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(212, 22);
            this.txtSearch.TabIndex = 6;
            // 
            // lbHuongNC
            // 
            this.lbHuongNC.AutoSize = true;
            this.lbHuongNC.Location = new System.Drawing.Point(758, 346);
            this.lbHuongNC.Name = "lbHuongNC";
            this.lbHuongNC.Size = new System.Drawing.Size(69, 16);
            this.lbHuongNC.TabIndex = 7;
            this.lbHuongNC.Text = "Hướng NC";
            // 
            // cbHuongNC
            // 
            this.cbHuongNC.FormattingEnabled = true;
            this.cbHuongNC.Location = new System.Drawing.Point(861, 343);
            this.cbHuongNC.Name = "cbHuongNC";
            this.cbHuongNC.Size = new System.Drawing.Size(153, 24);
            this.cbHuongNC.TabIndex = 8;
            // 
            // lbGVHD
            // 
            this.lbGVHD.AutoSize = true;
            this.lbGVHD.Location = new System.Drawing.Point(758, 449);
            this.lbGVHD.Name = "lbGVHD";
            this.lbGVHD.Size = new System.Drawing.Size(46, 16);
            this.lbGVHD.TabIndex = 9;
            this.lbGVHD.Text = "GVHD";
            // 
            // cbGVHD
            // 
            this.cbGVHD.FormattingEnabled = true;
            this.cbGVHD.Location = new System.Drawing.Point(861, 449);
            this.cbGVHD.Name = "cbGVHD";
            this.cbGVHD.Size = new System.Drawing.Size(153, 24);
            this.cbGVHD.TabIndex = 10;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(758, 401);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(66, 16);
            this.lbStatus.TabIndex = 11;
            this.lbStatus.Text = "Tình trạng";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(861, 401);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(153, 24);
            this.cbStatus.TabIndex = 12;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 125;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Mã đồ án";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // NameDA
            // 
            this.NameDA.DataPropertyName = "NameDA";
            this.NameDA.HeaderText = "Tên đồ án";
            this.NameDA.MinimumWidth = 6;
            this.NameDA.Name = "NameDA";
            this.NameDA.Width = 125;
            // 
            // SV
            // 
            this.SV.DataPropertyName = "SV";
            this.SV.HeaderText = "Tên sinh viên";
            this.SV.MinimumWidth = 6;
            this.SV.Name = "SV";
            this.SV.Width = 125;
            // 
            // HuongNC
            // 
            this.HuongNC.DataPropertyName = "HuongNC";
            this.HuongNC.HeaderText = "Hướng NC";
            this.HuongNC.MinimumWidth = 6;
            this.HuongNC.Name = "HuongNC";
            this.HuongNC.Width = 125;
            // 
            // GVHD
            // 
            this.GVHD.DataPropertyName = "GVHD";
            this.GVHD.HeaderText = "GVHD";
            this.GVHD.MinimumWidth = 6;
            this.GVHD.Name = "GVHD";
            this.GVHD.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GVHD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.GVHD.Width = 125;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Tình trạng";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Status.Width = 125;
            // 
            // Year
            // 
            this.Year.DataPropertyName = "Year";
            this.Year.HeaderText = "Năm bảo vệ";
            this.Year.MinimumWidth = 6;
            this.Year.Name = "Year";
            this.Year.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Year.Width = 125;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 536);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.cbGVHD);
            this.Controls.Add(this.lbGVHD);
            this.Controls.Add(this.cbHuongNC);
            this.Controls.Add(this.lbHuongNC);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lbHuongNC;
        private System.Windows.Forms.ComboBox cbHuongNC;
        private System.Windows.Forms.Label lbGVHD;
        private System.Windows.Forms.ComboBox cbGVHD;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HuongNC;
        private System.Windows.Forms.DataGridViewTextBoxColumn GVHD;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
        private System.Windows.Forms.DataGridViewComboBoxColumn Year;
    }
}

