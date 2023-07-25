
namespace DangNhap
{
    partial class FrmQLCH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQLCH));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grd1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMamon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDapan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCauhoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMach = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.grd1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btThem);
            this.groupBox1.Controls.Add(this.btXoa);
            this.groupBox1.Controls.Add(this.btSua);
            this.groupBox1.Location = new System.Drawing.Point(-3, 122);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(940, 557);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách Câu hỏi";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grd1
            // 
            this.grd1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd1.Location = new System.Drawing.Point(25, 24);
            this.grd1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grd1.Name = "grd1";
            this.grd1.RowHeadersWidth = 51;
            this.grd1.RowTemplate.Height = 24;
            this.grd1.Size = new System.Drawing.Size(907, 211);
            this.grd1.TabIndex = 0;
            this.grd1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd1_CellClick);
            this.grd1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox2.Controls.Add(this.txtMamon);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtD);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtC);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtDapan);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtB);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.txtA);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtDiem);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtCauhoi);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtMach);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(25, 245);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(743, 279);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtMamon
            // 
            this.txtMamon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMamon.Location = new System.Drawing.Point(107, 27);
            this.txtMamon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMamon.Name = "txtMamon";
            this.txtMamon.Size = new System.Drawing.Size(170, 31);
            this.txtMamon.TabIndex = 30;
            this.txtMamon.TextChanged += new System.EventHandler(this.txtMamon_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(427, 171);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "D";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtD
            // 
            this.txtD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD.Location = new System.Drawing.Point(462, 168);
            this.txtD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(259, 31);
            this.txtD.TabIndex = 28;
            this.txtD.TextChanged += new System.EventHandler(this.txtD_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(426, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "C";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtC
            // 
            this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.Location = new System.Drawing.Point(462, 118);
            this.txtC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(259, 31);
            this.txtC.TabIndex = 26;
            this.txtC.TextChanged += new System.EventHandler(this.txtC_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(428, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "B";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtDapan
            // 
            this.txtDapan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDapan.Location = new System.Drawing.Point(462, 218);
            this.txtDapan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDapan.Name = "txtDapan";
            this.txtDapan.Size = new System.Drawing.Size(259, 31);
            this.txtDapan.TabIndex = 20;
            this.txtDapan.TextChanged += new System.EventHandler(this.txtDapan_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(388, 219);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Đáp án";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(462, 68);
            this.txtB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(259, 31);
            this.txtB.TabIndex = 24;
            this.txtB.TextChanged += new System.EventHandler(this.txtB_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(427, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "A";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Điểm";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDiem
            // 
            this.txtDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiem.Location = new System.Drawing.Point(107, 212);
            this.txtDiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(170, 31);
            this.txtDiem.TabIndex = 18;
            this.txtDiem.TextChanged += new System.EventHandler(this.txtDiem_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 153);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(87, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Câu hỏi";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtCauhoi
            // 
            this.txtCauhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCauhoi.Location = new System.Drawing.Point(107, 153);
            this.txtCauhoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCauhoi.Multiline = true;
            this.txtCauhoi.Name = "txtCauhoi";
            this.txtCauhoi.Size = new System.Drawing.Size(170, 29);
            this.txtCauhoi.TabIndex = 16;
            this.txtCauhoi.TextChanged += new System.EventHandler(this.txtCauhoi_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã câu hỏi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMach
            // 
            this.txtMach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMach.Location = new System.Drawing.Point(107, 85);
            this.txtMach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMach.Name = "txtMach";
            this.txtMach.Size = new System.Drawing.Size(170, 31);
            this.txtMach.TabIndex = 0;
            this.txtMach.TextChanged += new System.EventHandler(this.txtMach_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 29);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(95, 25);
            this.label8.TabIndex = 31;
            this.label8.Text = "Mã môn ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(776, 424);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 41);
            this.button2.TabIndex = 6;
            this.button2.Text = "Xuất đề thi";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.Orange;
            this.btThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(776, 245);
            this.btThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(142, 43);
            this.btThem.TabIndex = 2;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.Color.Orange;
            this.btSua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btSua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Location = new System.Drawing.Point(776, 306);
            this.btSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(142, 41);
            this.btSua.TabIndex = 3;
            this.btSua.Text = "Sửa ";
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.Orange;
            this.btXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(776, 365);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(142, 41);
            this.btXoa.TabIndex = 4;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(776, 483);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(1024, 210);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(125, 59);
            this.btnReport.TabIndex = 6;
            this.btnReport.Text = "Xuất báo cáo";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-3, -37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(973, 222);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(462, 18);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 31);
            this.textBox1.TabIndex = 22;
            this.textBox1.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(462, 18);
            this.txtA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(259, 31);
            this.txtA.TabIndex = 22;
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            // 
            // FrmQLCH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(967, 633);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmQLCH";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí câu hỏi";
            this.Load += new System.EventHandler(this.FrmQLCH_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmQLCH_KeyDown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grd1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDapan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCauhoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMach;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.TextBox txtMamon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtA;
    }
}