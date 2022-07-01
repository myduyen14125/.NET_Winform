namespace Ex1
{
    partial class Form1
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
            this.label_title = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.cb_caovoi = new System.Windows.Forms.CheckBox();
            this.cb_taytrang = new System.Windows.Forms.CheckBox();
            this.cb_chuphinh = new System.Windows.Forms.CheckBox();
            this.price1 = new System.Windows.Forms.Label();
            this.price2 = new System.Windows.Forms.Label();
            this.price3 = new System.Windows.Forms.Label();
            this.label_tramRang = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_total = new System.Windows.Forms.Label();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.cashBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(172, 24);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(244, 29);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Dental Payment Form";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(85, 81);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(103, 16);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Tên khách hàng";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(227, 81);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(217, 22);
            this.nameBox.TabIndex = 2;
            // 
            // cb_caovoi
            // 
            this.cb_caovoi.AutoSize = true;
            this.cb_caovoi.Location = new System.Drawing.Point(88, 136);
            this.cb_caovoi.Name = "cb_caovoi";
            this.cb_caovoi.Size = new System.Drawing.Size(75, 20);
            this.cb_caovoi.TabIndex = 3;
            this.cb_caovoi.Text = "Cạo vôi";
            this.cb_caovoi.UseVisualStyleBackColor = true;
            // 
            // cb_taytrang
            // 
            this.cb_taytrang.AutoSize = true;
            this.cb_taytrang.Location = new System.Drawing.Point(88, 183);
            this.cb_taytrang.Name = "cb_taytrang";
            this.cb_taytrang.Size = new System.Drawing.Size(86, 20);
            this.cb_taytrang.TabIndex = 4;
            this.cb_taytrang.Text = "Tẩy trắng";
            this.cb_taytrang.UseVisualStyleBackColor = true;
            // 
            // cb_chuphinh
            // 
            this.cb_chuphinh.AutoSize = true;
            this.cb_chuphinh.Location = new System.Drawing.Point(88, 232);
            this.cb_chuphinh.Name = "cb_chuphinh";
            this.cb_chuphinh.Size = new System.Drawing.Size(117, 20);
            this.cb_chuphinh.TabIndex = 5;
            this.cb_chuphinh.Text = "Chụp hình răng";
            this.cb_chuphinh.UseVisualStyleBackColor = true;
            // 
            // price1
            // 
            this.price1.AutoSize = true;
            this.price1.Location = new System.Drawing.Point(360, 136);
            this.price1.Name = "price1";
            this.price1.Size = new System.Drawing.Size(59, 16);
            this.price1.TabIndex = 6;
            this.price1.Text = "$100.000";
            // 
            // price2
            // 
            this.price2.AutoSize = true;
            this.price2.Location = new System.Drawing.Point(350, 183);
            this.price2.Name = "price2";
            this.price2.Size = new System.Drawing.Size(69, 16);
            this.price2.TabIndex = 7;
            this.price2.Text = "$1.200.000";
            // 
            // price3
            // 
            this.price3.AutoSize = true;
            this.price3.Location = new System.Drawing.Point(357, 232);
            this.price3.Name = "price3";
            this.price3.Size = new System.Drawing.Size(59, 16);
            this.price3.TabIndex = 8;
            this.price3.Text = "$200.000";
            // 
            // label_tramRang
            // 
            this.label_tramRang.AutoSize = true;
            this.label_tramRang.Location = new System.Drawing.Point(85, 298);
            this.label_tramRang.Name = "label_tramRang";
            this.label_tramRang.Size = new System.Drawing.Size(69, 16);
            this.label_tramRang.TabIndex = 9;
            this.label_tramRang.Text = "Trám răng";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(210, 289);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 10;
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Location = new System.Drawing.Point(353, 341);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(38, 16);
            this.label_total.TabIndex = 11;
            this.label_total.Text = "Total";
            // 
            // totalBox
            // 
            this.totalBox.Enabled = false;
            this.totalBox.Location = new System.Drawing.Point(409, 338);
            this.totalBox.Name = "totalBox";
            this.totalBox.Size = new System.Drawing.Size(100, 22);
            this.totalBox.TabIndex = 12;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(79, 402);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 13;
            this.exitBtn.Text = "Thoát";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // cashBtn
            // 
            this.cashBtn.Location = new System.Drawing.Point(369, 402);
            this.cashBtn.Name = "cashBtn";
            this.cashBtn.Size = new System.Drawing.Size(102, 23);
            this.cashBtn.TabIndex = 14;
            this.cashBtn.Text = "Tính tiền";
            this.cashBtn.UseVisualStyleBackColor = true;
            this.cashBtn.Click += new System.EventHandler(this.cashBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 496);
            this.Controls.Add(this.cashBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_tramRang);
            this.Controls.Add(this.price3);
            this.Controls.Add(this.price2);
            this.Controls.Add(this.price1);
            this.Controls.Add(this.cb_chuphinh);
            this.Controls.Add(this.cb_taytrang);
            this.Controls.Add(this.cb_caovoi);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.CheckBox cb_caovoi;
        private System.Windows.Forms.CheckBox cb_taytrang;
        private System.Windows.Forms.CheckBox cb_chuphinh;
        private System.Windows.Forms.Label price1;
        private System.Windows.Forms.Label price2;
        private System.Windows.Forms.Label price3;
        private System.Windows.Forms.Label label_tramRang;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.TextBox totalBox;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button cashBtn;
    }
}

