namespace DangNhap
{
    partial class FrmKQuaThi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKQuaThi));
            this.grdData5 = new System.Windows.Forms.DataGridView();
            this.MaND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnXuatBang = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.grdData6 = new System.Windows.Forms.DataGridView();
            this.MaBL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comTenTruong = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comGT = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdData5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdData6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // grdData5
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdData5.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdData5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaND,
            this.TenMon,
            this.MaMon,
            this.ExamID,
            this.SoDiem});
            this.grdData5.Location = new System.Drawing.Point(38, 215);
            this.grdData5.Name = "grdData5";
            this.grdData5.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grdData5.RowHeadersWidth = 62;
            this.grdData5.RowTemplate.Height = 28;
            this.grdData5.Size = new System.Drawing.Size(829, 454);
            this.grdData5.TabIndex = 0;
            // 
            // MaND
            // 
            this.MaND.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaND.DataPropertyName = "MaND";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaND.DefaultCellStyle = dataGridViewCellStyle2;
            this.MaND.HeaderText = "Mã Sinh Viên";
            this.MaND.MinimumWidth = 12;
            this.MaND.Name = "MaND";
            this.MaND.ReadOnly = true;
            // 
            // TenMon
            // 
            this.TenMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenMon.DataPropertyName = "TenMon";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenMon.DefaultCellStyle = dataGridViewCellStyle3;
            this.TenMon.HeaderText = "Tên Môn ";
            this.TenMon.MinimumWidth = 8;
            this.TenMon.Name = "TenMon";
            // 
            // MaMon
            // 
            this.MaMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaMon.DataPropertyName = "MaMon";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaMon.DefaultCellStyle = dataGridViewCellStyle4;
            this.MaMon.HeaderText = "Mã Môn";
            this.MaMon.MinimumWidth = 8;
            this.MaMon.Name = "MaMon";
            this.MaMon.ReadOnly = true;
            // 
            // ExamID
            // 
            this.ExamID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ExamID.DataPropertyName = "ExamID";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExamID.DefaultCellStyle = dataGridViewCellStyle5;
            this.ExamID.HeaderText = "ExamID";
            this.ExamID.MinimumWidth = 8;
            this.ExamID.Name = "ExamID";
            this.ExamID.ReadOnly = true;
            // 
            // SoDiem
            // 
            this.SoDiem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoDiem.DataPropertyName = "SoDiem";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoDiem.DefaultCellStyle = dataGridViewCellStyle6;
            this.SoDiem.HeaderText = "Số Điểm";
            this.SoDiem.MinimumWidth = 8;
            this.SoDiem.Name = "SoDiem";
            this.SoDiem.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(963, 740);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 48);
            this.button1.TabIndex = 14;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXuatBang
            // 
            this.btnXuatBang.BackColor = System.Drawing.Color.Orange;
            this.btnXuatBang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatBang.Location = new System.Drawing.Point(430, 688);
            this.btnXuatBang.Name = "btnXuatBang";
            this.btnXuatBang.Size = new System.Drawing.Size(193, 47);
            this.btnXuatBang.TabIndex = 15;
            this.btnXuatBang.Text = "In bảng điểm";
            this.btnXuatBang.UseVisualStyleBackColor = false;
            this.btnXuatBang.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Orange;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(178, 688);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(244, 47);
            this.button3.TabIndex = 16;
            this.button3.Text = "Xem chi tiết bài làm";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // grdData6
            // 
            this.grdData6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBL});
            this.grdData6.Location = new System.Drawing.Point(38, 215);
            this.grdData6.Name = "grdData6";
            this.grdData6.RowHeadersWidth = 62;
            this.grdData6.RowTemplate.Height = 28;
            this.grdData6.Size = new System.Drawing.Size(829, 454);
            this.grdData6.TabIndex = 17;
            this.grdData6.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdData6_CellContentClick);
            // 
            // MaBL
            // 
            this.MaBL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaBL.DataPropertyName = "MaBL";
            this.MaBL.HeaderText = "MaBL";
            this.MaBL.MinimumWidth = 8;
            this.MaBL.Name = "MaBL";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Orange;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(38, 688);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 47);
            this.button4.TabIndex = 18;
            this.button4.Text = "Quay lại";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(444, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 37);
            this.label1.TabIndex = 52;
            this.label1.Text = "KẾT QUẢ THI";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-49, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1320, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(631, 688);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(270, 47);
            this.button2.TabIndex = 55;
            this.button2.Text = "In điểm TB các môn";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(958, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 29);
            this.label2.TabIndex = 56;
            this.label2.Text = "Lọc dữ liệu";
            // 
            // comTenTruong
            // 
            this.comTenTruong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comTenTruong.FormattingEnabled = true;
            this.comTenTruong.Items.AddRange(new object[] {
            "MaND",
            "MaMon",
            "ExamID",
            "SoDiem"});
            this.comTenTruong.Location = new System.Drawing.Point(1002, 264);
            this.comTenTruong.Name = "comTenTruong";
            this.comTenTruong.Size = new System.Drawing.Size(182, 37);
            this.comTenTruong.TabIndex = 57;
            this.comTenTruong.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(873, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 29);
            this.label3.TabIndex = 58;
            this.label3.Text = "Lọc theo:";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Orange;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(888, 378);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 48);
            this.button5.TabIndex = 59;
            this.button5.Text = "Lọc";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(873, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 29);
            this.label4.TabIndex = 60;
            this.label4.Text = "Giá trị lọc: ";
            // 
            // comGT
            // 
            this.comGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comGT.FormattingEnabled = true;
            this.comGT.Location = new System.Drawing.Point(1002, 312);
            this.comGT.Name = "comGT";
            this.comGT.Size = new System.Drawing.Size(182, 37);
            this.comGT.TabIndex = 61;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Orange;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(1039, 378);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(124, 48);
            this.button6.TabIndex = 62;
            this.button6.Text = "Hủy lọc";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // FrmKQuaThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1196, 801);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.comGT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comTenTruong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnXuatBang);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.grdData5);
            this.Controls.Add(this.grdData6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmKQuaThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết quả thi";
            this.Load += new System.EventHandler(this.FrmKQuaThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdData5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdData6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdData5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnXuatBang;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView grdData6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comTenTruong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comGT;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaND;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDiem;
    }
}