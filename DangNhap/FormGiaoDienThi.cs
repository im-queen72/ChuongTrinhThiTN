using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DangNhap
{
    public partial class FormGiaoDienThi : Form
    {
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlCommand cmd;

        SqlDataAdapter da1 = new SqlDataAdapter();
        DataTable dt1 = new DataTable();
        //SqlCommand cmd1;


        //link database của Huy
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9GAKJV7\SQLEXPRESS01;Initial Catalog=Exam;Integrated Security=True");

        //link database của Hoàng
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-KJNF2QE\SQLEXPRESS;Initial Catalog=Exam;Integrated Security=True");

        //Link Database Cuyên
        //SqlConnection conn = new SqlConnection(@"Data Source = CUYEN\CUYEN; Initial Catalog = ExamData; Integrated Security = True");

        public string msv;
        public string mk;

        int i;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label lbA;
        private Label lbB;
        private Label lbC;
        private Label lbD;
        private Label lbAnsA;
        private Label lbAnsB;
        private Label lbAnsC;
        private Label lbAnsD;
        private Timer timer1;
        private IContainer components;
        private TextBox textBox1;
        private DataGridView grdData1;
        private Button btPre;
        private Button btNext;
        private Button button1;
        private Panel panel3;
        private Label label20;
        private RadioButton radioButton9;
        private RadioButton radioButton10;
        private RadioButton radioButton11;
        private RadioButton radioButton12;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Panel panel4;
        private Label label25;
        private RadioButton radioButton13;
        private RadioButton radioButton14;
        private RadioButton radioButton15;
        private RadioButton radioButton16;
        private Label label26;
        private Label label27;
        private Label label28;
        private Label label29;
        private Panel panel1;
        private Label label15;
        private RadioButton radioButton8;
        private RadioButton radioButton5;
        private RadioButton radioButton7;
        private RadioButton radioButton6;
        private Label label16;
        private Label label19;
        private Label label18;
        private Label label17;
        private Panel panel5;
        private Label label30;
        private RadioButton radioButton17;
        private RadioButton radioButton18;
        private RadioButton radioButton19;
        private RadioButton radioButton20;
        private Label label31;
        private Label label32;
        private Label label33;
        private Label label34;
        private Panel panel2;
        private Panel panel11;
        private Label label55;
        private RadioButton radioButton37;
        private RadioButton radioButton38;
        private RadioButton radioButton39;
        private RadioButton radioButton40;
        private Label label56;
        private Label label57;
        private Label label58;
        private Label label59;
        private Panel panel10;
        private Label label50;
        private RadioButton radioButton33;
        private RadioButton radioButton34;
        private RadioButton radioButton35;
        private RadioButton radioButton36;
        private Label label51;
        private Label label52;
        private Label label53;
        private Label label54;
        private Panel panel9;
        private Label label45;
        private RadioButton radioButton29;
        private RadioButton radioButton30;
        private RadioButton radioButton31;
        private RadioButton radioButton32;
        private Label label46;
        private Label label47;
        private Label label48;
        private Label label49;
        private Panel panel7;
        private Label label35;
        private RadioButton radioButton21;
        private RadioButton radioButton22;
        private RadioButton radioButton23;
        private RadioButton radioButton24;
        private Label label36;
        private Label label37;
        private Label label38;
        private Label label39;
        private Panel panel8;
        private Label label40;
        private RadioButton radioButton25;
        private RadioButton radioButton26;
        private RadioButton radioButton27;
        private RadioButton radioButton28;
        private Label label41;
        private Label label42;
        private Label label43;
        private Label label44;
        private Panel panel6;
        private Label label9;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Label label10;
        private Label label11;
        private Label label13;
        private Label label14;
        private Label NoiDungCauHoi;
        private Label label60;
        private DataGridView grdData5;
        private BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label6;
        private Label lbMin;
        private Label label12;
        private Label lbSec;
        private GroupBox grbTimes;
        private Label label8;
        private Label label1;
        private Label label61;

        public FormGiaoDienThi()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiaoDienThi));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbA = new System.Windows.Forms.Label();
            this.lbB = new System.Windows.Forms.Label();
            this.lbC = new System.Windows.Forms.Label();
            this.lbD = new System.Windows.Forms.Label();
            this.lbAnsA = new System.Windows.Forms.Label();
            this.lbAnsB = new System.Windows.Forms.Label();
            this.lbAnsC = new System.Windows.Forms.Label();
            this.lbAnsD = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grdData1 = new System.Windows.Forms.DataGridView();
            this.btPre = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.radioButton15 = new System.Windows.Forms.RadioButton();
            this.radioButton16 = new System.Windows.Forms.RadioButton();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label30 = new System.Windows.Forms.Label();
            this.radioButton17 = new System.Windows.Forms.RadioButton();
            this.radioButton18 = new System.Windows.Forms.RadioButton();
            this.radioButton19 = new System.Windows.Forms.RadioButton();
            this.radioButton20 = new System.Windows.Forms.RadioButton();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label55 = new System.Windows.Forms.Label();
            this.radioButton37 = new System.Windows.Forms.RadioButton();
            this.radioButton38 = new System.Windows.Forms.RadioButton();
            this.radioButton39 = new System.Windows.Forms.RadioButton();
            this.radioButton40 = new System.Windows.Forms.RadioButton();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label50 = new System.Windows.Forms.Label();
            this.radioButton33 = new System.Windows.Forms.RadioButton();
            this.radioButton34 = new System.Windows.Forms.RadioButton();
            this.radioButton35 = new System.Windows.Forms.RadioButton();
            this.radioButton36 = new System.Windows.Forms.RadioButton();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label45 = new System.Windows.Forms.Label();
            this.radioButton29 = new System.Windows.Forms.RadioButton();
            this.radioButton30 = new System.Windows.Forms.RadioButton();
            this.radioButton31 = new System.Windows.Forms.RadioButton();
            this.radioButton32 = new System.Windows.Forms.RadioButton();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label35 = new System.Windows.Forms.Label();
            this.radioButton21 = new System.Windows.Forms.RadioButton();
            this.radioButton22 = new System.Windows.Forms.RadioButton();
            this.radioButton23 = new System.Windows.Forms.RadioButton();
            this.radioButton24 = new System.Windows.Forms.RadioButton();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label40 = new System.Windows.Forms.Label();
            this.radioButton25 = new System.Windows.Forms.RadioButton();
            this.radioButton26 = new System.Windows.Forms.RadioButton();
            this.radioButton27 = new System.Windows.Forms.RadioButton();
            this.radioButton28 = new System.Windows.Forms.RadioButton();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.NoiDungCauHoi = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.grdData5 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbMin = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbSec = new System.Windows.Forms.Label();
            this.grbTimes = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdData1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.grbTimes.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "ht";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(215, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 46);
            this.label4.TabIndex = 3;
            this.label4.Text = "msv";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(531, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 46);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày sinh:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(672, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 46);
            this.label7.TabIndex = 6;
            this.label7.Text = "ns";
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbA.Location = new System.Drawing.Point(78, 319);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(48, 37);
            this.lbA.TabIndex = 13;
            this.lbA.Text = "A,";
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbB.Location = new System.Drawing.Point(79, 374);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(47, 37);
            this.lbB.TabIndex = 14;
            this.lbB.Text = "B,";
            // 
            // lbC
            // 
            this.lbC.AutoSize = true;
            this.lbC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbC.Location = new System.Drawing.Point(78, 429);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(49, 37);
            this.lbC.TabIndex = 15;
            this.lbC.Text = "C,";
            // 
            // lbD
            // 
            this.lbD.AutoSize = true;
            this.lbD.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbD.Location = new System.Drawing.Point(79, 484);
            this.lbD.Name = "lbD";
            this.lbD.Size = new System.Drawing.Size(49, 37);
            this.lbD.TabIndex = 16;
            this.lbD.Text = "D,";
            // 
            // lbAnsA
            // 
            this.lbAnsA.AutoSize = true;
            this.lbAnsA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnsA.Location = new System.Drawing.Point(132, 319);
            this.lbAnsA.Name = "lbAnsA";
            this.lbAnsA.Size = new System.Drawing.Size(142, 37);
            this.lbAnsA.TabIndex = 17;
            this.lbAnsA.Text = "answerA";
            // 
            // lbAnsB
            // 
            this.lbAnsB.AutoSize = true;
            this.lbAnsB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnsB.Location = new System.Drawing.Point(132, 374);
            this.lbAnsB.Name = "lbAnsB";
            this.lbAnsB.Size = new System.Drawing.Size(141, 37);
            this.lbAnsB.TabIndex = 18;
            this.lbAnsB.Text = "answerB";
            // 
            // lbAnsC
            // 
            this.lbAnsC.AutoSize = true;
            this.lbAnsC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnsC.Location = new System.Drawing.Point(132, 429);
            this.lbAnsC.Name = "lbAnsC";
            this.lbAnsC.Size = new System.Drawing.Size(143, 37);
            this.lbAnsC.TabIndex = 19;
            this.lbAnsC.Text = "answerC";
            // 
            // lbAnsD
            // 
            this.lbAnsD.AutoSize = true;
            this.lbAnsD.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnsD.Location = new System.Drawing.Point(132, 484);
            this.lbAnsD.Name = "lbAnsD";
            this.lbAnsD.Size = new System.Drawing.Size(143, 37);
            this.lbAnsD.TabIndex = 20;
            this.lbAnsD.Text = "answerD";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox1.Location = new System.Drawing.Point(1, 110);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(970, 120);
            this.textBox1.TabIndex = 21;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // grdData1
            // 
            this.grdData1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData1.Location = new System.Drawing.Point(257, 113);
            this.grdData1.Name = "grdData1";
            this.grdData1.ReadOnly = true;
            this.grdData1.RowHeadersWidth = 62;
            this.grdData1.RowTemplate.Height = 28;
            this.grdData1.Size = new System.Drawing.Size(430, 109);
            this.grdData1.TabIndex = 22;
            this.grdData1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdData1_CellContentClick);
            // 
            // btPre
            // 
            this.btPre.BackColor = System.Drawing.Color.Orange;
            this.btPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPre.Location = new System.Drawing.Point(463, 574);
            this.btPre.Name = "btPre";
            this.btPre.Size = new System.Drawing.Size(149, 44);
            this.btPre.TabIndex = 23;
            this.btPre.Text = "Câu trước";
            this.btPre.UseVisualStyleBackColor = false;
            this.btPre.Click += new System.EventHandler(this.btPre_Click);
            // 
            // btNext
            // 
            this.btNext.BackColor = System.Drawing.Color.Orange;
            this.btNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNext.Location = new System.Drawing.Point(699, 574);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(149, 44);
            this.btNext.TabIndex = 24;
            this.btNext.Text = "Câu sau";
            this.btNext.UseVisualStyleBackColor = false;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1036, 607);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 44);
            this.button1.TabIndex = 25;
            this.button1.Text = "Nộp Bài";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.radioButton9);
            this.panel3.Controls.Add(this.radioButton10);
            this.panel3.Controls.Add(this.radioButton11);
            this.panel3.Controls.Add(this.radioButton12);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.label23);
            this.panel3.Controls.Add(this.label24);
            this.panel3.Location = new System.Drawing.Point(20, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 71);
            this.panel3.TabIndex = 40;
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(8, 15);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(36, 37);
            this.label20.TabIndex = 34;
            this.label20.Text = "2";
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(166, 48);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(21, 20);
            this.radioButton9.TabIndex = 32;
            this.radioButton9.TabStop = true;
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(218, 48);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(21, 20);
            this.radioButton10.TabIndex = 29;
            this.radioButton10.TabStop = true;
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.radioButton10_CheckedChanged);
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(114, 48);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(21, 20);
            this.radioButton11.TabIndex = 31;
            this.radioButton11.TabStop = true;
            this.radioButton11.UseVisualStyleBackColor = true;
            this.radioButton11.CheckedChanged += new System.EventHandler(this.radioButton11_CheckedChanged);
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(62, 48);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(21, 20);
            this.radioButton12.TabIndex = 30;
            this.radioButton12.TabStop = true;
            this.radioButton12.UseVisualStyleBackColor = true;
            this.radioButton12.CheckedChanged += new System.EventHandler(this.radioButton12_CheckedChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(56, 13);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(34, 32);
            this.label21.TabIndex = 35;
            this.label21.Text = "A";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(108, 13);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(34, 32);
            this.label22.TabIndex = 37;
            this.label22.Text = "B";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(160, 13);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(35, 32);
            this.label23.TabIndex = 36;
            this.label23.Text = "C";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(213, 13);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(35, 32);
            this.label24.TabIndex = 35;
            this.label24.Text = "D";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label25);
            this.panel4.Controls.Add(this.radioButton13);
            this.panel4.Controls.Add(this.radioButton14);
            this.panel4.Controls.Add(this.radioButton15);
            this.panel4.Controls.Add(this.radioButton16);
            this.panel4.Controls.Add(this.label26);
            this.panel4.Controls.Add(this.label27);
            this.panel4.Controls.Add(this.label28);
            this.panel4.Controls.Add(this.label29);
            this.panel4.Location = new System.Drawing.Point(20, 152);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(244, 71);
            this.panel4.TabIndex = 41;
            this.panel4.Click += new System.EventHandler(this.panel4_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(8, 15);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(36, 37);
            this.label25.TabIndex = 34;
            this.label25.Text = "3";
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.Location = new System.Drawing.Point(166, 48);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(21, 20);
            this.radioButton13.TabIndex = 32;
            this.radioButton13.TabStop = true;
            this.radioButton13.UseVisualStyleBackColor = true;
            this.radioButton13.CheckedChanged += new System.EventHandler(this.radioButton13_CheckedChanged);
            // 
            // radioButton14
            // 
            this.radioButton14.AutoSize = true;
            this.radioButton14.Location = new System.Drawing.Point(218, 48);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(21, 20);
            this.radioButton14.TabIndex = 29;
            this.radioButton14.TabStop = true;
            this.radioButton14.UseVisualStyleBackColor = true;
            this.radioButton14.CheckedChanged += new System.EventHandler(this.radioButton14_CheckedChanged);
            // 
            // radioButton15
            // 
            this.radioButton15.AutoSize = true;
            this.radioButton15.Location = new System.Drawing.Point(114, 48);
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.Size = new System.Drawing.Size(21, 20);
            this.radioButton15.TabIndex = 31;
            this.radioButton15.TabStop = true;
            this.radioButton15.UseVisualStyleBackColor = true;
            this.radioButton15.CheckedChanged += new System.EventHandler(this.radioButton15_CheckedChanged);
            // 
            // radioButton16
            // 
            this.radioButton16.AutoSize = true;
            this.radioButton16.Location = new System.Drawing.Point(62, 48);
            this.radioButton16.Name = "radioButton16";
            this.radioButton16.Size = new System.Drawing.Size(21, 20);
            this.radioButton16.TabIndex = 30;
            this.radioButton16.TabStop = true;
            this.radioButton16.UseVisualStyleBackColor = true;
            this.radioButton16.CheckedChanged += new System.EventHandler(this.radioButton16_CheckedChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(56, 13);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(34, 32);
            this.label26.TabIndex = 35;
            this.label26.Text = "A";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(108, 13);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(34, 32);
            this.label27.TabIndex = 37;
            this.label27.Text = "B";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(160, 13);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(35, 32);
            this.label28.TabIndex = 36;
            this.label28.Text = "C";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(213, 13);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(35, 32);
            this.label29.TabIndex = 35;
            this.label29.Text = "D";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.radioButton8);
            this.panel1.Controls.Add(this.radioButton5);
            this.panel1.Controls.Add(this.radioButton7);
            this.panel1.Controls.Add(this.radioButton6);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Location = new System.Drawing.Point(20, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 71);
            this.panel1.TabIndex = 39;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(8, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 37);
            this.label15.TabIndex = 34;
            this.label15.Text = "1";
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(166, 48);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(21, 20);
            this.radioButton8.TabIndex = 32;
            this.radioButton8.TabStop = true;
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(218, 48);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(21, 20);
            this.radioButton5.TabIndex = 29;
            this.radioButton5.TabStop = true;
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(114, 48);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(21, 20);
            this.radioButton7.TabIndex = 31;
            this.radioButton7.TabStop = true;
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(62, 48);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(21, 20);
            this.radioButton6.TabIndex = 30;
            this.radioButton6.TabStop = true;
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(56, 13);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 32);
            this.label16.TabIndex = 35;
            this.label16.Text = "A";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(108, 13);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 32);
            this.label19.TabIndex = 37;
            this.label19.Text = "B";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(160, 13);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 32);
            this.label18.TabIndex = 36;
            this.label18.Text = "C";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(213, 13);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 32);
            this.label17.TabIndex = 35;
            this.label17.Text = "D";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label30);
            this.panel5.Controls.Add(this.radioButton17);
            this.panel5.Controls.Add(this.radioButton18);
            this.panel5.Controls.Add(this.radioButton19);
            this.panel5.Controls.Add(this.radioButton20);
            this.panel5.Controls.Add(this.label31);
            this.panel5.Controls.Add(this.label32);
            this.panel5.Controls.Add(this.label33);
            this.panel5.Controls.Add(this.label34);
            this.panel5.Location = new System.Drawing.Point(20, 229);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(244, 71);
            this.panel5.TabIndex = 42;
            this.panel5.Click += new System.EventHandler(this.panel5_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(8, 15);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(36, 37);
            this.label30.TabIndex = 34;
            this.label30.Text = "4";
            // 
            // radioButton17
            // 
            this.radioButton17.AutoSize = true;
            this.radioButton17.Location = new System.Drawing.Point(166, 48);
            this.radioButton17.Name = "radioButton17";
            this.radioButton17.Size = new System.Drawing.Size(21, 20);
            this.radioButton17.TabIndex = 32;
            this.radioButton17.TabStop = true;
            this.radioButton17.UseVisualStyleBackColor = true;
            this.radioButton17.CheckedChanged += new System.EventHandler(this.radioButton17_CheckedChanged);
            // 
            // radioButton18
            // 
            this.radioButton18.AutoSize = true;
            this.radioButton18.Location = new System.Drawing.Point(218, 48);
            this.radioButton18.Name = "radioButton18";
            this.radioButton18.Size = new System.Drawing.Size(21, 20);
            this.radioButton18.TabIndex = 29;
            this.radioButton18.TabStop = true;
            this.radioButton18.UseVisualStyleBackColor = true;
            this.radioButton18.CheckedChanged += new System.EventHandler(this.radioButton18_CheckedChanged);
            // 
            // radioButton19
            // 
            this.radioButton19.AutoSize = true;
            this.radioButton19.Location = new System.Drawing.Point(114, 48);
            this.radioButton19.Name = "radioButton19";
            this.radioButton19.Size = new System.Drawing.Size(21, 20);
            this.radioButton19.TabIndex = 31;
            this.radioButton19.TabStop = true;
            this.radioButton19.UseVisualStyleBackColor = true;
            this.radioButton19.CheckedChanged += new System.EventHandler(this.radioButton19_CheckedChanged);
            // 
            // radioButton20
            // 
            this.radioButton20.AutoSize = true;
            this.radioButton20.Location = new System.Drawing.Point(62, 48);
            this.radioButton20.Name = "radioButton20";
            this.radioButton20.Size = new System.Drawing.Size(21, 20);
            this.radioButton20.TabIndex = 30;
            this.radioButton20.TabStop = true;
            this.radioButton20.UseVisualStyleBackColor = true;
            this.radioButton20.CheckedChanged += new System.EventHandler(this.radioButton20_CheckedChanged);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(56, 13);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(34, 32);
            this.label31.TabIndex = 35;
            this.label31.Text = "A";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(108, 13);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(34, 32);
            this.label32.TabIndex = 37;
            this.label32.Text = "B";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(160, 13);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(35, 32);
            this.label33.TabIndex = 36;
            this.label33.Text = "C";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(213, 13);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(35, 32);
            this.label34.TabIndex = 35;
            this.label34.Text = "D";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.panel11);
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(970, 264);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 337);
            this.panel2.TabIndex = 43;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Gainsboro;
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.label55);
            this.panel11.Controls.Add(this.radioButton37);
            this.panel11.Controls.Add(this.radioButton38);
            this.panel11.Controls.Add(this.radioButton39);
            this.panel11.Controls.Add(this.radioButton40);
            this.panel11.Controls.Add(this.label56);
            this.panel11.Controls.Add(this.label57);
            this.panel11.Controls.Add(this.label58);
            this.panel11.Controls.Add(this.label59);
            this.panel11.Location = new System.Drawing.Point(19, 691);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(244, 71);
            this.panel11.TabIndex = 44;
            this.panel11.Click += new System.EventHandler(this.panel11_Click);
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.Location = new System.Drawing.Point(8, 15);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(53, 37);
            this.label55.TabIndex = 34;
            this.label55.Text = "10";
            // 
            // radioButton37
            // 
            this.radioButton37.AutoSize = true;
            this.radioButton37.Location = new System.Drawing.Point(166, 48);
            this.radioButton37.Name = "radioButton37";
            this.radioButton37.Size = new System.Drawing.Size(21, 20);
            this.radioButton37.TabIndex = 32;
            this.radioButton37.TabStop = true;
            this.radioButton37.UseVisualStyleBackColor = true;
            this.radioButton37.CheckedChanged += new System.EventHandler(this.radioButton37_CheckedChanged);
            // 
            // radioButton38
            // 
            this.radioButton38.AutoSize = true;
            this.radioButton38.Location = new System.Drawing.Point(218, 48);
            this.radioButton38.Name = "radioButton38";
            this.radioButton38.Size = new System.Drawing.Size(21, 20);
            this.radioButton38.TabIndex = 29;
            this.radioButton38.TabStop = true;
            this.radioButton38.UseVisualStyleBackColor = true;
            this.radioButton38.CheckedChanged += new System.EventHandler(this.radioButton38_CheckedChanged);
            // 
            // radioButton39
            // 
            this.radioButton39.AutoSize = true;
            this.radioButton39.Location = new System.Drawing.Point(114, 48);
            this.radioButton39.Name = "radioButton39";
            this.radioButton39.Size = new System.Drawing.Size(21, 20);
            this.radioButton39.TabIndex = 31;
            this.radioButton39.TabStop = true;
            this.radioButton39.UseVisualStyleBackColor = true;
            this.radioButton39.CheckedChanged += new System.EventHandler(this.radioButton39_CheckedChanged);
            // 
            // radioButton40
            // 
            this.radioButton40.AutoSize = true;
            this.radioButton40.Location = new System.Drawing.Point(62, 48);
            this.radioButton40.Name = "radioButton40";
            this.radioButton40.Size = new System.Drawing.Size(21, 20);
            this.radioButton40.TabIndex = 30;
            this.radioButton40.TabStop = true;
            this.radioButton40.UseVisualStyleBackColor = true;
            this.radioButton40.CheckedChanged += new System.EventHandler(this.radioButton40_CheckedChanged);
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.Location = new System.Drawing.Point(56, 13);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(34, 32);
            this.label56.TabIndex = 35;
            this.label56.Text = "A";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.Location = new System.Drawing.Point(108, 13);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(34, 32);
            this.label57.TabIndex = 37;
            this.label57.Text = "B";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.Location = new System.Drawing.Point(160, 13);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(35, 32);
            this.label58.TabIndex = 36;
            this.label58.Text = "C";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.Location = new System.Drawing.Point(213, 13);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(35, 32);
            this.label59.TabIndex = 35;
            this.label59.Text = "D";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Gainsboro;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.label50);
            this.panel10.Controls.Add(this.radioButton33);
            this.panel10.Controls.Add(this.radioButton34);
            this.panel10.Controls.Add(this.radioButton35);
            this.panel10.Controls.Add(this.radioButton36);
            this.panel10.Controls.Add(this.label51);
            this.panel10.Controls.Add(this.label52);
            this.panel10.Controls.Add(this.label53);
            this.panel10.Controls.Add(this.label54);
            this.panel10.Location = new System.Drawing.Point(19, 614);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(244, 71);
            this.panel10.TabIndex = 44;
            this.panel10.Click += new System.EventHandler(this.panel10_Click);
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(8, 15);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(36, 37);
            this.label50.TabIndex = 34;
            this.label50.Text = "9";
            // 
            // radioButton33
            // 
            this.radioButton33.AutoSize = true;
            this.radioButton33.Location = new System.Drawing.Point(166, 48);
            this.radioButton33.Name = "radioButton33";
            this.radioButton33.Size = new System.Drawing.Size(21, 20);
            this.radioButton33.TabIndex = 32;
            this.radioButton33.TabStop = true;
            this.radioButton33.UseVisualStyleBackColor = true;
            this.radioButton33.CheckedChanged += new System.EventHandler(this.radioButton33_CheckedChanged);
            // 
            // radioButton34
            // 
            this.radioButton34.AutoSize = true;
            this.radioButton34.Location = new System.Drawing.Point(218, 48);
            this.radioButton34.Name = "radioButton34";
            this.radioButton34.Size = new System.Drawing.Size(21, 20);
            this.radioButton34.TabIndex = 29;
            this.radioButton34.TabStop = true;
            this.radioButton34.UseVisualStyleBackColor = true;
            this.radioButton34.CheckedChanged += new System.EventHandler(this.radioButton34_CheckedChanged);
            // 
            // radioButton35
            // 
            this.radioButton35.AutoSize = true;
            this.radioButton35.Location = new System.Drawing.Point(114, 48);
            this.radioButton35.Name = "radioButton35";
            this.radioButton35.Size = new System.Drawing.Size(21, 20);
            this.radioButton35.TabIndex = 31;
            this.radioButton35.TabStop = true;
            this.radioButton35.UseVisualStyleBackColor = true;
            this.radioButton35.CheckedChanged += new System.EventHandler(this.radioButton35_CheckedChanged);
            // 
            // radioButton36
            // 
            this.radioButton36.AutoSize = true;
            this.radioButton36.Location = new System.Drawing.Point(62, 48);
            this.radioButton36.Name = "radioButton36";
            this.radioButton36.Size = new System.Drawing.Size(21, 20);
            this.radioButton36.TabIndex = 30;
            this.radioButton36.TabStop = true;
            this.radioButton36.UseVisualStyleBackColor = true;
            this.radioButton36.CheckedChanged += new System.EventHandler(this.radioButton36_CheckedChanged);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(56, 13);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(34, 32);
            this.label51.TabIndex = 35;
            this.label51.Text = "A";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(108, 13);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(34, 32);
            this.label52.TabIndex = 37;
            this.label52.Text = "B";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.Location = new System.Drawing.Point(160, 13);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(35, 32);
            this.label53.TabIndex = 36;
            this.label53.Text = "C";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.Location = new System.Drawing.Point(213, 13);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(35, 32);
            this.label54.TabIndex = 35;
            this.label54.Text = "D";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Gainsboro;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.label45);
            this.panel9.Controls.Add(this.radioButton29);
            this.panel9.Controls.Add(this.radioButton30);
            this.panel9.Controls.Add(this.radioButton31);
            this.panel9.Controls.Add(this.radioButton32);
            this.panel9.Controls.Add(this.label46);
            this.panel9.Controls.Add(this.label47);
            this.panel9.Controls.Add(this.label48);
            this.panel9.Controls.Add(this.label49);
            this.panel9.Location = new System.Drawing.Point(19, 537);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(244, 71);
            this.panel9.TabIndex = 45;
            this.panel9.Click += new System.EventHandler(this.panel9_Click);
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(8, 15);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(36, 37);
            this.label45.TabIndex = 34;
            this.label45.Text = "8";
            // 
            // radioButton29
            // 
            this.radioButton29.AutoSize = true;
            this.radioButton29.Location = new System.Drawing.Point(166, 48);
            this.radioButton29.Name = "radioButton29";
            this.radioButton29.Size = new System.Drawing.Size(21, 20);
            this.radioButton29.TabIndex = 32;
            this.radioButton29.TabStop = true;
            this.radioButton29.UseVisualStyleBackColor = true;
            this.radioButton29.CheckedChanged += new System.EventHandler(this.radioButton29_CheckedChanged);
            // 
            // radioButton30
            // 
            this.radioButton30.AutoSize = true;
            this.radioButton30.Location = new System.Drawing.Point(218, 48);
            this.radioButton30.Name = "radioButton30";
            this.radioButton30.Size = new System.Drawing.Size(21, 20);
            this.radioButton30.TabIndex = 29;
            this.radioButton30.TabStop = true;
            this.radioButton30.UseVisualStyleBackColor = true;
            this.radioButton30.CheckedChanged += new System.EventHandler(this.radioButton30_CheckedChanged);
            // 
            // radioButton31
            // 
            this.radioButton31.AutoSize = true;
            this.radioButton31.Location = new System.Drawing.Point(114, 48);
            this.radioButton31.Name = "radioButton31";
            this.radioButton31.Size = new System.Drawing.Size(21, 20);
            this.radioButton31.TabIndex = 31;
            this.radioButton31.TabStop = true;
            this.radioButton31.UseVisualStyleBackColor = true;
            this.radioButton31.CheckedChanged += new System.EventHandler(this.radioButton31_CheckedChanged);
            // 
            // radioButton32
            // 
            this.radioButton32.AutoSize = true;
            this.radioButton32.Location = new System.Drawing.Point(62, 48);
            this.radioButton32.Name = "radioButton32";
            this.radioButton32.Size = new System.Drawing.Size(21, 20);
            this.radioButton32.TabIndex = 30;
            this.radioButton32.TabStop = true;
            this.radioButton32.UseVisualStyleBackColor = true;
            this.radioButton32.CheckedChanged += new System.EventHandler(this.radioButton32_CheckedChanged);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(56, 13);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(34, 32);
            this.label46.TabIndex = 35;
            this.label46.Text = "A";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(108, 13);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(34, 32);
            this.label47.TabIndex = 37;
            this.label47.Text = "B";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(160, 13);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(35, 32);
            this.label48.TabIndex = 36;
            this.label48.Text = "C";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(213, 13);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(35, 32);
            this.label49.TabIndex = 35;
            this.label49.Text = "D";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gainsboro;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label35);
            this.panel7.Controls.Add(this.radioButton21);
            this.panel7.Controls.Add(this.radioButton22);
            this.panel7.Controls.Add(this.radioButton23);
            this.panel7.Controls.Add(this.radioButton24);
            this.panel7.Controls.Add(this.label36);
            this.panel7.Controls.Add(this.label37);
            this.panel7.Controls.Add(this.label38);
            this.panel7.Controls.Add(this.label39);
            this.panel7.Location = new System.Drawing.Point(19, 383);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(244, 71);
            this.panel7.TabIndex = 40;
            this.panel7.Click += new System.EventHandler(this.panel7_Click);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(8, 15);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(36, 37);
            this.label35.TabIndex = 34;
            this.label35.Text = "6";
            // 
            // radioButton21
            // 
            this.radioButton21.AutoSize = true;
            this.radioButton21.Location = new System.Drawing.Point(166, 48);
            this.radioButton21.Name = "radioButton21";
            this.radioButton21.Size = new System.Drawing.Size(21, 20);
            this.radioButton21.TabIndex = 32;
            this.radioButton21.TabStop = true;
            this.radioButton21.UseVisualStyleBackColor = true;
            this.radioButton21.CheckedChanged += new System.EventHandler(this.radioButton21_CheckedChanged);
            // 
            // radioButton22
            // 
            this.radioButton22.AutoSize = true;
            this.radioButton22.Location = new System.Drawing.Point(218, 48);
            this.radioButton22.Name = "radioButton22";
            this.radioButton22.Size = new System.Drawing.Size(21, 20);
            this.radioButton22.TabIndex = 29;
            this.radioButton22.TabStop = true;
            this.radioButton22.UseVisualStyleBackColor = true;
            this.radioButton22.CheckedChanged += new System.EventHandler(this.radioButton22_CheckedChanged);
            // 
            // radioButton23
            // 
            this.radioButton23.AutoSize = true;
            this.radioButton23.Location = new System.Drawing.Point(114, 48);
            this.radioButton23.Name = "radioButton23";
            this.radioButton23.Size = new System.Drawing.Size(21, 20);
            this.radioButton23.TabIndex = 31;
            this.radioButton23.TabStop = true;
            this.radioButton23.UseVisualStyleBackColor = true;
            this.radioButton23.CheckedChanged += new System.EventHandler(this.radioButton23_CheckedChanged);
            // 
            // radioButton24
            // 
            this.radioButton24.AutoSize = true;
            this.radioButton24.Location = new System.Drawing.Point(62, 48);
            this.radioButton24.Name = "radioButton24";
            this.radioButton24.Size = new System.Drawing.Size(21, 20);
            this.radioButton24.TabIndex = 30;
            this.radioButton24.TabStop = true;
            this.radioButton24.UseVisualStyleBackColor = true;
            this.radioButton24.CheckedChanged += new System.EventHandler(this.radioButton24_CheckedChanged);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(56, 13);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(34, 32);
            this.label36.TabIndex = 35;
            this.label36.Text = "A";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(108, 13);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(34, 32);
            this.label37.TabIndex = 37;
            this.label37.Text = "B";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(160, 13);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(35, 32);
            this.label38.TabIndex = 36;
            this.label38.Text = "C";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(213, 13);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(35, 32);
            this.label39.TabIndex = 35;
            this.label39.Text = "D";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gainsboro;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.label40);
            this.panel8.Controls.Add(this.radioButton25);
            this.panel8.Controls.Add(this.radioButton26);
            this.panel8.Controls.Add(this.radioButton27);
            this.panel8.Controls.Add(this.radioButton28);
            this.panel8.Controls.Add(this.label41);
            this.panel8.Controls.Add(this.label42);
            this.panel8.Controls.Add(this.label43);
            this.panel8.Controls.Add(this.label44);
            this.panel8.Location = new System.Drawing.Point(19, 460);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(244, 71);
            this.panel8.TabIndex = 44;
            this.panel8.Click += new System.EventHandler(this.panel8_Click);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(8, 15);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(36, 37);
            this.label40.TabIndex = 34;
            this.label40.Text = "7";
            // 
            // radioButton25
            // 
            this.radioButton25.AutoSize = true;
            this.radioButton25.Location = new System.Drawing.Point(166, 48);
            this.radioButton25.Name = "radioButton25";
            this.radioButton25.Size = new System.Drawing.Size(21, 20);
            this.radioButton25.TabIndex = 32;
            this.radioButton25.TabStop = true;
            this.radioButton25.UseVisualStyleBackColor = true;
            this.radioButton25.CheckedChanged += new System.EventHandler(this.radioButton25_CheckedChanged);
            // 
            // radioButton26
            // 
            this.radioButton26.AutoSize = true;
            this.radioButton26.Location = new System.Drawing.Point(218, 48);
            this.radioButton26.Name = "radioButton26";
            this.radioButton26.Size = new System.Drawing.Size(21, 20);
            this.radioButton26.TabIndex = 29;
            this.radioButton26.TabStop = true;
            this.radioButton26.UseVisualStyleBackColor = true;
            this.radioButton26.CheckedChanged += new System.EventHandler(this.radioButton26_CheckedChanged);
            // 
            // radioButton27
            // 
            this.radioButton27.AutoSize = true;
            this.radioButton27.Location = new System.Drawing.Point(114, 48);
            this.radioButton27.Name = "radioButton27";
            this.radioButton27.Size = new System.Drawing.Size(21, 20);
            this.radioButton27.TabIndex = 31;
            this.radioButton27.TabStop = true;
            this.radioButton27.UseVisualStyleBackColor = true;
            this.radioButton27.CheckedChanged += new System.EventHandler(this.radioButton27_CheckedChanged);
            // 
            // radioButton28
            // 
            this.radioButton28.AutoSize = true;
            this.radioButton28.Location = new System.Drawing.Point(62, 48);
            this.radioButton28.Name = "radioButton28";
            this.radioButton28.Size = new System.Drawing.Size(21, 20);
            this.radioButton28.TabIndex = 30;
            this.radioButton28.TabStop = true;
            this.radioButton28.UseVisualStyleBackColor = true;
            this.radioButton28.CheckedChanged += new System.EventHandler(this.radioButton28_CheckedChanged);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(56, 13);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(34, 32);
            this.label41.TabIndex = 35;
            this.label41.Text = "A";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(108, 13);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(34, 32);
            this.label42.TabIndex = 37;
            this.label42.Text = "B";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(160, 13);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(35, 32);
            this.label43.TabIndex = 36;
            this.label43.Text = "C";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(213, 13);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(35, 32);
            this.label44.TabIndex = 35;
            this.label44.Text = "D";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gainsboro;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.radioButton1);
            this.panel6.Controls.Add(this.radioButton2);
            this.panel6.Controls.Add(this.radioButton3);
            this.panel6.Controls.Add(this.radioButton4);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Location = new System.Drawing.Point(19, 306);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(244, 71);
            this.panel6.TabIndex = 44;
            this.panel6.Click += new System.EventHandler(this.panel6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 37);
            this.label9.TabIndex = 34;
            this.label9.Text = "5";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(166, 48);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(21, 20);
            this.radioButton1.TabIndex = 32;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(218, 48);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(21, 20);
            this.radioButton2.TabIndex = 29;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(114, 48);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(21, 20);
            this.radioButton3.TabIndex = 31;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(62, 48);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(21, 20);
            this.radioButton4.TabIndex = 30;
            this.radioButton4.TabStop = true;
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(56, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 32);
            this.label10.TabIndex = 35;
            this.label10.Text = "A";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(108, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 32);
            this.label11.TabIndex = 37;
            this.label11.Text = "B";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(160, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 32);
            this.label13.TabIndex = 36;
            this.label13.Text = "C";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(213, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 32);
            this.label14.TabIndex = 35;
            this.label14.Text = "D";
            // 
            // NoiDungCauHoi
            // 
            this.NoiDungCauHoi.AutoSize = true;
            this.NoiDungCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoiDungCauHoi.Location = new System.Drawing.Point(54, 253);
            this.NoiDungCauHoi.Name = "NoiDungCauHoi";
            this.NoiDungCauHoi.Size = new System.Drawing.Size(139, 46);
            this.NoiDungCauHoi.TabIndex = 44;
            this.NoiDungCauHoi.Text = "cauhoi";
            this.NoiDungCauHoi.Click += new System.EventHandler(this.label60_Click);
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.Location = new System.Drawing.Point(636, 174);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(98, 46);
            this.label60.TabIndex = 46;
            this.label60.Text = "mon";
            this.label60.Click += new System.EventHandler(this.label60_Click_1);
            // 
            // grdData5
            // 
            this.grdData5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData5.Location = new System.Drawing.Point(770, 149);
            this.grdData5.Name = "grdData5";
            this.grdData5.RowHeadersWidth = 62;
            this.grdData5.RowTemplate.Height = 28;
            this.grdData5.Size = new System.Drawing.Size(112, 81);
            this.grdData5.TabIndex = 47;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(156, 542);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, -32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1213, 202);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(531, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 46);
            this.label6.TabIndex = 51;
            this.label6.Text = "Môn thi:";
            // 
            // lbMin
            // 
            this.lbMin.AutoSize = true;
            this.lbMin.BackColor = System.Drawing.Color.Orange;
            this.lbMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMin.Location = new System.Drawing.Point(76, 64);
            this.lbMin.Name = "lbMin";
            this.lbMin.Size = new System.Drawing.Size(84, 46);
            this.lbMin.TabIndex = 9;
            this.lbMin.Text = "min";
            this.lbMin.Click += new System.EventHandler(this.lbMin_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Orange;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(102, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 40);
            this.label12.TabIndex = 11;
            this.label12.Text = ":";
            // 
            // lbSec
            // 
            this.lbSec.AutoSize = true;
            this.lbSec.BackColor = System.Drawing.Color.Orange;
            this.lbSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSec.Location = new System.Drawing.Point(117, 64);
            this.lbSec.Name = "lbSec";
            this.lbSec.Size = new System.Drawing.Size(83, 46);
            this.lbSec.TabIndex = 10;
            this.lbSec.Text = "sec";
            // 
            // grbTimes
            // 
            this.grbTimes.BackColor = System.Drawing.Color.Orange;
            this.grbTimes.Controls.Add(this.label1);
            this.grbTimes.Controls.Add(this.lbSec);
            this.grbTimes.Controls.Add(this.label12);
            this.grbTimes.Controls.Add(this.lbMin);
            this.grbTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTimes.Location = new System.Drawing.Point(979, 110);
            this.grbTimes.Name = "grbTimes";
            this.grbTimes.Size = new System.Drawing.Size(259, 120);
            this.grbTimes.TabIndex = 48;
            this.grbTimes.TabStop = false;
            this.grbTimes.Enter += new System.EventHandler(this.grbTimes_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 40);
            this.label1.TabIndex = 12;
            this.label1.Text = "Thời Gian:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(264, 46);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã sinh viên: ";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.Location = new System.Drawing.Point(37, 127);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(201, 46);
            this.label61.TabIndex = 1;
            this.label61.Text = "Họ và tên:";
            this.label61.Click += new System.EventHandler(this.label61_Click);
            // 
            // FormGiaoDienThi
            // 
            this.ClientSize = new System.Drawing.Size(1275, 827);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label60);
            this.Controls.Add(this.NoiDungCauHoi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btPre);
            this.Controls.Add(this.lbAnsD);
            this.Controls.Add(this.lbAnsC);
            this.Controls.Add(this.lbAnsB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbAnsA);
            this.Controls.Add(this.lbD);
            this.Controls.Add(this.lbC);
            this.Controls.Add(this.lbB);
            this.Controls.Add(this.lbA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label61);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.grdData1);
            this.Controls.Add(this.grdData5);
            this.Controls.Add(this.grbTimes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGiaoDienThi";
            this.Text = "Bài kiểm tra";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormGiaoDienThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdData1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.grbTimes.ResumeLayout(false);
            this.grbTimes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        public FormGiaoDienThi(string Message1,string Message2) : this()
        {
            conn.Open();

            msv = Message1;
            mk = Message2;
           

            string sql = "select Ten,MaND,NgaySinh, Mon.TenMon, Mon.MaMon from Mon, NguoiDung where  NguoiDung.MaND ='"+msv+"' and Mon.Password ='"+mk+"';";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dta = cmd.ExecuteReader();
            if (dta.Read()==true)
            {
                label3.Text=dta["Ten"].ToString();
                label4.Text=dta["MaND"].ToString();
                label7.Text=dta["NgaySinh"].ToString();
                label60.Text=dta["TenMon"].ToString();
                timer1.Start();
            }
            conn.Close();
        }
        public void FormGiaoDienThi_Load(object sender, EventArgs e)
        {
            conn.Open();
            string h = "select top 10 * from CauHoi,NguoiDung, Mon where NguoiDung.Password=Mon.Password and Mon.MaMon=CauHoi.MaMon order by NEWID() ";
            da = new SqlDataAdapter(h, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            grdData1.DataSource= dt;
            ShowCauHoi();
            conn.Close();
            conn.Open();

            string mamon = "select MaMon from Mon where Password ='"+mk+"'";
            //SqlCommand cmd1 = new SqlCommand(mamon, conn);
            //SqlDataReader dta1 = cmd1.ExecuteReader();          
            da1 = new SqlDataAdapter(mamon, conn);
            dt1 = new DataTable();
            dt1.Clear();
            da1.Fill(dt1);
            grdData5.DataSource= dt1;

        }
        private void ShowCauHoi()
        {
            i = grdData1.CurrentRow.Index;
            NoiDungCauHoi.Text="  Câu " +(i+1).ToString() + ": " +grdData1.Rows[i].Cells["CauHoi"].Value.ToString();
            lbAnsA.Text=grdData1.Rows[i].Cells["OptionA"].Value.ToString();
            lbAnsB.Text=grdData1.Rows[i].Cells["OptionB"].Value.ToString();
            if (grdData1.Rows[i].Cells["OptionC"].Value.ToString()=="")
            {
                lbAnsC.Visible=false;
                lbC.Visible=false;
            }
            else
            {
                lbAnsC.Visible=true;
                lbC.Visible=true;
                lbAnsC.Text=grdData1.Rows[i].Cells["OptionC"].Value.ToString();
            }

            if (grdData1.Rows[i].Cells["OptionD"].Value.ToString()=="")
            {
                lbAnsD.Visible=false;
                lbD.Visible=false;
            }
            else
            {
                lbAnsD.Visible=true;
                lbD.Visible=true;
                lbAnsD.Text=grdData1.Rows[i].Cells["OptionD"].Value.ToString();
            }

        }

        int sec1 = 60;
        int min1 = 4;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sec1--;
            if (sec1 == 0)
            {
                min1--;
                sec1=60;
                sec1--;
            }

            if (min1 < 0)
            {
                timer1.Stop();
                MessageBox.Show("Hết giờ làm bài thi");
            }
            lbSec.Text= sec1.ToString();
            lbMin.Text= min1.ToString();
        }

        public void btPre_Click(object sender, EventArgs e)
        {
            i = grdData1.CurrentRow.Index;
            if (i==0)
            {
                grdData1.CurrentCell = grdData1[0, grdData1.RowCount-2];
            }
            else
            {
                grdData1.CurrentCell = grdData1[0, i-1];
            }

            ShowCauHoi();
        }

        public void btNext_Click(object sender, EventArgs e)
        {
            i = grdData1.CurrentRow.Index;
            if (i==grdData1.RowCount-2)
            {
                grdData1.CurrentCell = grdData1[0, 0];
            }
            else
            {
                grdData1.CurrentCell = grdData1[0, i+1];
            }
            ShowCauHoi();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            FrmShowDiem dd = new FrmShowDiem(msv,mk);

            if (MessageBox.Show("Bạn có muốn nộp bài thi hay không?", "Thông báo", MessageBoxButtons.YesNo) ==DialogResult.Yes)
            {
                timer1.Stop();
                CapNhatDiem();
                CapNhatDiemTB();
            }
            dd.ShowDialog();
        }
       
        public void CapNhatDiem()
        {
            //string updatediem = "update KetQua set SoDiem= (select count(TraLoi) as 'SoDiem' from BaiLam, CauHoi, Mon where BaiLam.MaCH= CauHoi.MaCH and Mon.MaMon=CauHoi.MaMon and BaiLam.TraLoi=CauHoi.DapAn and MaND = '"+msv+"' and TraLoi is not null) where MaND = '"+msv+"' ";
            string updatediem1 = "update KetQua set SoDiem = (select count(TraLoi) as 'SoDiem' from BaiLam, CauHoi  where BaiLam.MaCH= CauHoi.MaCH and BaiLam.TraLoi=CauHoi.DapAn and MaND = '"+msv+"' and BaiLam.MaMon='"+grdData1.Rows[0].Cells["MaMon"].Value.ToString()+"' and TraLoi is not null) where MaND = '"+msv+"' and MaMon = '"+grdData1.Rows[0].Cells["MaMon"].Value.ToString()+"'";
                cmd = conn.CreateCommand();
                cmd.CommandText= updatediem1;
                cmd.ExecuteNonQuery();          
        }
        public void CapNhatDiemTB()
        {
            string updateDiemtb = "update Mon set DiemTB = (select avg(SoDiem) as 'Diem tb' from KetQua, Mon where KetQua.MaMon=Mon.MaMon and Password = '"+mk+"' ) where Password = '"+mk+"'";
            cmd = conn.CreateCommand();
            cmd.CommandText= updateDiemtb;
            cmd.ExecuteNonQuery();
        }
    
       
        private void label60_Click(object sender, EventArgs e)
        {
            NoiDungCauHoi.Height=143;
            NoiDungCauHoi.Width=982;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            i = 0;
            NoiDungCauHoi.Text="  Câu " +(i+1).ToString() + ": " +grdData1.Rows[i].Cells["CauHoi"].Value.ToString();
            lbAnsA.Text=grdData1.Rows[i].Cells["OptionA"].Value.ToString();
            lbAnsB.Text=grdData1.Rows[i].Cells["OptionB"].Value.ToString();           
            if (grdData1.Rows[i].Cells["OptionC"].Value.ToString()=="")
            {
                lbAnsC.Visible=false;
                lbC.Visible=false;
            }
            else
            {
                lbAnsC.Visible=true;
                lbC.Visible=true;
                lbAnsC.Text=grdData1.Rows[i].Cells["OptionC"].Value.ToString();
            }

            if (grdData1.Rows[i].Cells["OptionD"].Value.ToString()=="")
            {
                lbAnsD.Visible=false;
                lbD.Visible=false;
            }
            else
            {
                lbAnsD.Visible=true;
                lbD.Visible=true;
                lbAnsD.Text=grdData1.Rows[i].Cells["OptionD"].Value.ToString();
            }

        }

        private void panel3_Click(object sender, EventArgs e)
        {
            i = 1;
            NoiDungCauHoi.Text="  Câu " +(i+1).ToString() + ": " +grdData1.Rows[i].Cells["CauHoi"].Value.ToString();
            lbAnsA.Text=grdData1.Rows[i].Cells["OptionA"].Value.ToString();
            lbAnsB.Text=grdData1.Rows[i].Cells["OptionB"].Value.ToString();           
            if (grdData1.Rows[i].Cells["OptionC"].Value.ToString()=="")
            {
                lbAnsC.Visible=false;
                lbC.Visible=false;
            }
            else
            {
                lbAnsC.Visible=true;
                lbC.Visible=true;
                lbAnsC.Text=grdData1.Rows[i].Cells["OptionC"].Value.ToString();
            }

            if (grdData1.Rows[i].Cells["OptionD"].Value.ToString()=="")
            {
                lbAnsD.Visible=false;
                lbD.Visible=false;
            }
            else
            {
                lbAnsD.Visible=true;
                lbD.Visible=true;
                lbAnsD.Text=grdData1.Rows[i].Cells["OptionD"].Value.ToString();
            }
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            i = 2;
            NoiDungCauHoi.Text="  Câu " +(i+1).ToString() + ": " +grdData1.Rows[i].Cells["CauHoi"].Value.ToString();
            lbAnsA.Text=grdData1.Rows[i].Cells["OptionA"].Value.ToString();
            lbAnsB.Text=grdData1.Rows[i].Cells["OptionB"].Value.ToString();            
            if (grdData1.Rows[i].Cells["OptionC"].Value.ToString()=="")
            {
                lbAnsC.Visible=false;
                lbC.Visible=false;
            }
            else
            {
                lbAnsC.Visible=true;
                lbC.Visible=true;
                lbAnsC.Text=grdData1.Rows[i].Cells["OptionC"].Value.ToString();
            }

            if (grdData1.Rows[i].Cells["OptionD"].Value.ToString()=="")
            {
                lbAnsD.Visible=false;
                lbD.Visible=false;
            }
            else
            {
                lbAnsD.Visible=true;
                lbD.Visible=true;
                lbAnsD.Text=grdData1.Rows[i].Cells["OptionD"].Value.ToString();
            }
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            i = 3;
            NoiDungCauHoi.Text="  Câu " +(i+1).ToString() + ": " +grdData1.Rows[i].Cells["CauHoi"].Value.ToString();
            lbAnsA.Text=grdData1.Rows[i].Cells["OptionA"].Value.ToString();
            lbAnsB.Text=grdData1.Rows[i].Cells["OptionB"].Value.ToString();            
            if (grdData1.Rows[i].Cells["OptionC"].Value.ToString()=="")
            {
                lbAnsC.Visible=false;
                lbC.Visible=false;
            }
            else
            {
                lbAnsC.Visible=true;
                lbC.Visible=true;
                lbAnsC.Text=grdData1.Rows[i].Cells["OptionC"].Value.ToString();
            }

            if (grdData1.Rows[i].Cells["OptionD"].Value.ToString()=="")
            {
                lbAnsD.Visible=false;
                lbD.Visible=false;
            }
            else
            {
                lbAnsD.Visible=true;
                lbD.Visible=true;
                lbAnsD.Text=grdData1.Rows[i].Cells["OptionD"].Value.ToString();
            }
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            i = 4;
            NoiDungCauHoi.Text="  Câu " +(i+1).ToString() + ": " +grdData1.Rows[i].Cells["CauHoi"].Value.ToString();
            lbAnsA.Text=grdData1.Rows[i].Cells["OptionA"].Value.ToString();
            lbAnsB.Text=grdData1.Rows[i].Cells["OptionB"].Value.ToString();          
            if (grdData1.Rows[i].Cells["OptionC"].Value.ToString()=="")
            {
                lbAnsC.Visible=false;
                lbC.Visible=false;
            }
            else
            {
                lbAnsC.Visible=true;
                lbC.Visible=true;
                lbAnsC.Text=grdData1.Rows[i].Cells["OptionC"].Value.ToString();
            }

            if (grdData1.Rows[i].Cells["OptionD"].Value.ToString()=="")
            {
                lbAnsD.Visible=false;
                lbD.Visible=false;
            }
            else
            {
                lbAnsD.Visible=true;
                lbD.Visible=true;
                lbAnsD.Text=grdData1.Rows[i].Cells["OptionD"].Value.ToString();
            }
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            i = 5;
            NoiDungCauHoi.Text="  Câu " +(i+1).ToString() + ": " +grdData1.Rows[i].Cells["CauHoi"].Value.ToString();
            lbAnsA.Text=grdData1.Rows[i].Cells["OptionA"].Value.ToString();
            lbAnsB.Text=grdData1.Rows[i].Cells["OptionB"].Value.ToString();
            if (grdData1.Rows[i].Cells["OptionC"].Value.ToString()=="")
            {
                lbAnsC.Visible=false;
                lbC.Visible=false;
            }
            else
            {
                lbAnsC.Visible=true;
                lbC.Visible=true;
                lbAnsC.Text=grdData1.Rows[i].Cells["OptionC"].Value.ToString();
            }

            if (grdData1.Rows[i].Cells["OptionD"].Value.ToString()=="")
            {
                lbAnsD.Visible=false;
                lbD.Visible=false;
            }
            else
            {
                lbAnsD.Visible=true;
                lbD.Visible=true;
                lbAnsD.Text=grdData1.Rows[i].Cells["OptionD"].Value.ToString();
            }
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            i = 6;
            NoiDungCauHoi.Text="  Câu " +(i+1).ToString() + ": " +grdData1.Rows[i].Cells["CauHoi"].Value.ToString();
            lbAnsA.Text=grdData1.Rows[i].Cells["OptionA"].Value.ToString();
            lbAnsB.Text=grdData1.Rows[i].Cells["OptionB"].Value.ToString();
            if (grdData1.Rows[i].Cells["OptionC"].Value.ToString()=="")
            {
                lbAnsC.Visible=false;
                lbC.Visible=false;
            }
            else
            {
                lbAnsC.Visible=true;
                lbC.Visible=true;
                lbAnsC.Text=grdData1.Rows[i].Cells["OptionC"].Value.ToString();
            }

            if (grdData1.Rows[i].Cells["OptionD"].Value.ToString()=="")
            {
                lbAnsD.Visible=false;
                lbD.Visible=false;
            }
            else
            {
                lbAnsD.Visible=true;
                lbD.Visible=true;
                lbAnsD.Text=grdData1.Rows[i].Cells["OptionD"].Value.ToString();
            }
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            i = 7;
            NoiDungCauHoi.Text="  Câu " +(i+1).ToString() + ": " +grdData1.Rows[i].Cells["CauHoi"].Value.ToString();
            lbAnsA.Text=grdData1.Rows[i].Cells["OptionA"].Value.ToString();
            lbAnsB.Text=grdData1.Rows[i].Cells["OptionB"].Value.ToString();
            if (grdData1.Rows[i].Cells["OptionC"].Value.ToString()=="")
            {
                lbAnsC.Visible=false;
                lbC.Visible=false;
            }
            else
            {
                lbAnsC.Visible=true;
                lbC.Visible=true;
                lbAnsC.Text=grdData1.Rows[i].Cells["OptionC"].Value.ToString();
            }

            if (grdData1.Rows[i].Cells["OptionD"].Value.ToString()=="")
            {
                lbAnsD.Visible=false;
                lbD.Visible=false;
            }
            else
            {
                lbAnsD.Visible=true;
                lbD.Visible=true;
                lbAnsD.Text=grdData1.Rows[i].Cells["OptionD"].Value.ToString();
            }
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            i = 8;
            NoiDungCauHoi.Text="  Câu " +(i+1).ToString() + ": " +grdData1.Rows[i].Cells["CauHoi"].Value.ToString();
            lbAnsA.Text=grdData1.Rows[i].Cells["OptionA"].Value.ToString();
            lbAnsB.Text=grdData1.Rows[i].Cells["OptionB"].Value.ToString();
            if (grdData1.Rows[i].Cells["OptionC"].Value.ToString()=="")
            {
                lbAnsC.Visible=false;
                lbC.Visible=false;
            }
            else
            {
                lbAnsC.Visible=true;
                lbC.Visible=true;
                lbAnsC.Text=grdData1.Rows[i].Cells["OptionC"].Value.ToString();
            }

            if (grdData1.Rows[i].Cells["OptionD"].Value.ToString()=="")
            {
                lbAnsD.Visible=false;
                lbD.Visible=false;
            }
            else
            {
                lbAnsD.Visible=true;
                lbD.Visible=true;
                lbAnsD.Text=grdData1.Rows[i].Cells["OptionD"].Value.ToString();
            }
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            i = 9;
            NoiDungCauHoi.Text="  Câu " +(i+1).ToString() + ": " +grdData1.Rows[i].Cells["CauHoi"].Value.ToString();
            lbAnsA.Text=grdData1.Rows[i].Cells["OptionA"].Value.ToString();
            lbAnsB.Text=grdData1.Rows[i].Cells["OptionB"].Value.ToString();
            if (grdData1.Rows[i].Cells["OptionC"].Value.ToString()=="")
            {
                lbAnsC.Visible=false;
                lbC.Visible=false;
            }
            else
            {
                lbAnsC.Visible=true;
                lbC.Visible=true;
                lbAnsC.Text=grdData1.Rows[i].Cells["OptionC"].Value.ToString();
            }

            if (grdData1.Rows[i].Cells["OptionD"].Value.ToString()=="")
            {
                lbAnsD.Visible=false;
                lbD.Visible=false;
            }
            else
            {
                lbAnsD.Visible=true;
                lbD.Visible=true;
                lbAnsD.Text=grdData1.Rows[i].Cells["OptionD"].Value.ToString();
            }
        }

        //câu 1:
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked==true)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = " update BaiLam set TraLoi= 'A' where MaCH = '" + grdData1.Rows[0].Cells["MaCH"].Value.ToString() + "' and MaND ='"+msv+"' and MaMon = '" + grdData1.Rows[0].Cells["MaMon"].Value.ToString() + "'; ";
                cmd.ExecuteNonQuery();
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked==true)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = " update BaiLam set TraLoi= 'B' where MaCH = '" + grdData1.Rows[0].Cells["MaCH"].Value.ToString() + "'and MaND ='"+msv+"' and MaMon = '"+grdData1.Rows[0].Cells["MaMon"].Value.ToString()+"'; ";
                cmd.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked==true)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = " update BaiLam set TraLoi= 'C' where MaCH = '" + grdData1.Rows[0].Cells["MaCH"].Value.ToString() + "'and MaND ='"+msv+"' and MaMon = '"+grdData1.Rows[0].Cells["MaMon"].Value.ToString()+"'; ";
                cmd.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked==true)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = " update BaiLam set TraLoi= 'D' where MaCH = '" + grdData1.Rows[0].Cells["MaCH"].Value.ToString() + "'and MaND ='"+msv+"' and MaMon = '"+grdData1.Rows[0].Cells["MaMon"].Value.ToString()+"'; ";
                cmd.ExecuteNonQuery();
            }
        }



        //câu 2:
        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton12.Checked==true)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = " update BaiLam set TraLoi= 'A' where MaCH = '" + grdData1.Rows[1].Cells["MaCH"].Value.ToString() + "'and MaND ='"+msv+"' and MaMon = '"+grdData1.Rows[0].Cells["MaMon"].Value.ToString()+"'; ";
                cmd.ExecuteNonQuery();
            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked==true)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = " update BaiLam set TraLoi= 'B' where MaCH = '" + grdData1.Rows[1].Cells["MaCH"].Value.ToString() + "'and MaND ='"+msv+"' and MaMon = '"+grdData1.Rows[0].Cells["MaMon"].Value.ToString()+"'; ";
                cmd.ExecuteNonQuery();
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked==true)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = " update BaiLam set TraLoi= 'C' where MaCH = '" + grdData1.Rows[1].Cells["MaCH"].Value.ToString() + "'and MaND ='"+msv+"' and MaMon = '"+grdData1.Rows[0].Cells["MaMon"].Value.ToString()+"'; ";
                cmd.ExecuteNonQuery();
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked==true)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = " update BaiLam set TraLoi= 'D' where MaCH = '" + grdData1.Rows[1].Cells["MaCH"].Value.ToString() + "'and MaND ='"+msv+"' and MaMon = '"+grdData1.Rows[0].Cells["MaMon"].Value.ToString()+"'; ";
                cmd.ExecuteNonQuery();
            }
        }


        //câu 3: 
        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton16.Checked==true)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = " update BaiLam set TraLoi= 'A' where MaCH = '" + grdData1.Rows[2].Cells["MaCH"].Value.ToString() + "'and MaND ='"+msv+"' and MaMon = '"+grdData1.Rows[0].Cells["MaMon"].Value.ToString()+"'; ";
                cmd.ExecuteNonQuery();
            }
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton15.Checked==true)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = " update BaiLam set TraLoi= 'B' where MaCH = '" + grdData1.Rows[2].Cells["MaCH"].Value.ToString() + "'and MaND ='"+msv+"' and MaMon = '"+grdData1.Rows[0].Cells["MaMon"].Value.ToString()+"'; ";
                cmd.ExecuteNonQuery();
            }
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton13.Checked==true)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = " update BaiLam set TraLoi= 'C' where MaCH = '" + grdData1.Rows[2].Cells["MaCH"].Value.ToString() + "'and MaND ='"+msv+"' and MaMon = '"+grdData1.Rows[0].Cells["MaMon"].Value.ToString()+"'; ";
                cmd.ExecuteNonQuery();
            }
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton14.Checked==true)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = " update BaiLam set TraLoi= 'D' where MaCH = '" + grdData1.Rows[2].Cells["MaCH"].Value.ToString() + "'and MaND ='"+msv+"' and MaMon = '"+grdData1.Rows[0].Cells["MaMon"].Value.ToString()+"'; ";
                cmd.ExecuteNonQuery();
            }
        }


        //câu 4
        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton20.Checked==true)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = " update BaiLam set TraLoi= 'A' where MaCH = '" + grdData1.Rows[3].Cells["MaCH"].Value.ToString() + "'and MaND ='"+msv+"' and MaMon = '"+grdData1.Rows[0].Cells["MaMon"].Value.ToString()+"'; ";
                cmd.ExecuteNonQuery();
            }
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton19.Checked==true)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = " update BaiLam set TraLoi= 'B' where MaCH = '" + grdData1.Rows[3].Cells["MaCH"].Value.ToString() + "'and MaND ='"+msv+"' and MaMon = '"+grdData1.Rows[0].Cells["MaMon"].Value.ToString()+"'; ";
                cmd.ExecuteNonQuery();
            }
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton17.Checked==true)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = " update BaiLam set TraLoi= 'C' where MaCH = '" + grdData1.Rows[3].Cells["MaCH"].Value.ToString() + "'and MaND ='"+msv+"' and MaMon = '"+grdData1.Rows[0].Cells["MaMon"].Value.ToString()+"'; ";
                cmd.ExecuteNonQuery();
            }
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton18.Checked==true)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = " update BaiLam set TraLoi= 'D' where MaCH = '" + grdData1.Rows[3].Cells["MaCH"].Value.ToString() + "'and MaND ='"+msv+"' and MaMon = '"+grdData1.Rows[0].Cells["MaMon"].Value.ToString()+"'; ";
                cmd.ExecuteNonQuery();
            }
        }


        //câu 5:
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked==true)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = " update BaiLam set TraLoi= 'A' where MaCH = '" + grdData1.Rows[4].Cells["MaCH"].Value.ToString() + "'and MaND ='"+msv+"' and MaMon = '"+grdData1.Rows[0].Cells["MaMon"].Value.ToString()+"'; ";
                cmd.ExecuteNonQuery();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton19.Checked==true)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = " update BaiLam set TraLoi= 'B' where MaCH = '" + grdData1.Rows[4].Cells["MaCH"].Value.ToString() + "'and MaND ='"+msv+"' and MaMon = '"+grdData1.Rows[0].Cells["MaMon"].Value.ToString()+"'; ";
                cmd.ExecuteNonQuery();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = " update BaiLam set TraLoi= 'C' where MaCH = '" + grdData1.Rows[4].Cells["MaCH"].Value.ToString() + "'and MaND ='"+msv+"' and MaMon = '"+grdData1.Rows[0].Cells["MaMon"].Value.ToString()+"'; ";
                cmd.ExecuteNonQuery();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked==true)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = " update BaiLam set TraLoi= 'D' where MaCH = '" + grdData1.Rows[4].Cells["MaCH"].Value.ToString() + "'and MaND ='"+msv+"' and MaMon = '"+grdData1.Rows[0].Cells["MaMon"].Value.ToString()+"'; ";
                cmd.ExecuteNonQuery();
            }
        }


        //câu 6:
        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton24.Checked==true)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = " update BaiLam set TraLoi= 'A' where MaCH = '" + grdData1.Rows[5].Cells["MaCH"].Value.ToString() + "'and MaND ='"+msv+"' and MaMon = '"+grdData1.Rows[0].Cells["MaMon"].Value.ToString()+"'; ";
                cmd.ExecuteNonQuery();
            }
        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton23.Checked==true)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = " update BaiLam set TraLoi= 'B' where MaCH = '" + grdData1.Rows[5].Cells["MaCH"].Value.ToString() + "'and MaND ='"+msv+"' and MaMon = '"+grdData1.Rows[0].Cells["MaMon"].Value.ToString()+"'; ";
                cmd.ExecuteNonQuery();
            }
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton21.Checked==true)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = " update BaiLam set TraLoi= 'C' where MaCH = '" + grdData1.Rows[5].Cells["MaCH"].Value.ToString() + "'and MaND ='"+msv+"' and MaMon = '"+grdData1.Rows[0].Cells["MaMon"].Value.ToString()+"'; ";
                cmd.ExecuteNonQuery();
            }
        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton22.Checked==true)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = " update BaiLam set TraLoi= 'D' where MaCH = '" + grdData1.Rows[5].Cells["MaCH"].Value.ToString() + "'and MaND ='"+msv+"' and MaMon = '"+grdData1.Rows[0].Cells["MaMon"].Value.ToString()+"'; ";
                cmd.ExecuteNonQuery();
            }
        }


        //câu 7:
        private void radioButton28_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton28.Checked==true)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = " update BaiLam set TraLoi= 'A' where MaCH = '" + grdData1.Rows[6].Cells["MaCH"].Value.ToString() + "'and MaND ='"+msv+"' and MaMon = '"+grdData1.Rows[0].Cells["MaMon"].Value.ToString()+"'; ";
                cmd.ExecuteNonQuery();
            }
        }

        private void radioButton27_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton27.Checked==true)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = " update BaiLam set TraLoi= 'B' where MaCH = '" + grdData1.Rows[6].Cells["MaCH"].Value.ToString() + "'and MaND ='"+msv+"' and MaMon = '"+grdData1.Rows[0].Cells["MaMon"].Value.ToString()+"'; ";
                cmd.ExecuteNonQuery();
            }
        }

        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton25.Checked==true)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = " update BaiLam set TraLoi= 'C' where MaCH = '" + grdData1.Rows[6].Cells["MaCH"].Value.ToString() + "'and MaND ='"+msv+"' and MaMon = '"+grdData1.Rows[0].Cells["MaMon"].Value.ToString()+"'; ";
                cmd.ExecuteNonQuery();
            }
        }

        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton26.Checked==true)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = " update BaiLam set TraLoi= 'D' where MaCH = '" + grdData1.Rows[6].Cells["MaCH"].Value.ToString() + "'and MaND ='"+msv+"' and MaMon = '"+grdData1.Rows[0].Cells["MaMon"].Value.ToString()+"'; ";
                cmd.ExecuteNonQuery();
            }
        }


        //câu 8:
        private void radioButton32_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton32.Checked==true)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = " update BaiLam set TraLoi= 'A' where MaCH = '" + grdData1.Rows[7].Cells["MaCH"].Value.ToString() + "'and MaND ='"+msv+"' and MaMon = '"+grdData1.Rows[0].Cells["MaMon"].Value.ToString()+"'; ";
                cmd.ExecuteNonQuery();
            }
        }

        private void radioButton31_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton31.Checked==true)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = " update BaiLam set TraLoi= 'B' where MaCH = '" + grdData1.Rows[7].Cells["MaCH"].Value.ToString() + "'and MaND ='"+msv+"' and MaMon = '"+grdData1.Rows[0].Cells["MaMon"].Value.ToString()+"'; ";
                cmd.ExecuteNonQuery();
            }
        }

        private void radioButton29_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton29.Checked==true)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = " update BaiLam set TraLoi= 'C' where MaCH = '" + grdData1.Rows[7].Cells["MaCH"].Value.ToString() + "'and MaND ='"+msv+"' and MaMon = '"+grdData1.Rows[0].Cells["MaMon"].Value.ToString()+"'; ";
                cmd.ExecuteNonQuery();
            }
        }

        private void radioButton30_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton30.Checked==true)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = " update BaiLam set TraLoi= 'D' where MaCH = '" + grdData1.Rows[7].Cells["MaCH"].Value.ToString() + "'and MaND ='"+msv+"' and MaMon = '"+grdData1.Rows[0].Cells["MaMon"].Value.ToString()+"'; ";
                cmd.ExecuteNonQuery();
            }
        }

        //Câu 9:
        private void radioButton36_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton36.Checked==true)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = " update BaiLam set TraLoi= 'A' where MaCH = '" + grdData1.Rows[8].Cells["MaCH"].Value.ToString() + "'and MaND ='"+msv+"' and MaMon = '"+grdData1.Rows[0].Cells["MaMon"].Value.ToString()+"'; ";
                cmd.ExecuteNonQuery();
            }
        }

        private void radioButton35_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton35.Checked==true)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = " update BaiLam set TraLoi= 'B' where MaCH = '" + grdData1.Rows[8].Cells["MaCH"].Value.ToString() + "'and MaND ='"+msv+"' and MaMon = '"+grdData1.Rows[0].Cells["MaMon"].Value.ToString()+"'; ";
                cmd.ExecuteNonQuery();
            }
        }

        private void radioButton33_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton33.Checked==true)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = " update BaiLam set TraLoi= 'C' where MaCH = '" + grdData1.Rows[8].Cells["MaCH"].Value.ToString() + "'and MaND ='"+msv+"' and MaMon = '"+grdData1.Rows[0].Cells["MaMon"].Value.ToString()+"'; ";
                cmd.ExecuteNonQuery();
            }
        }

        private void radioButton34_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton34.Checked==true)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = " update BaiLam set TraLoi= 'D' where MaCH = '" + grdData1.Rows[8].Cells["MaCH"].Value.ToString() + "'and MaND ='"+msv+"' and MaMon = '"+grdData1.Rows[0].Cells["MaMon"].Value.ToString()+"'; ";
                cmd.ExecuteNonQuery();
            }
        }


        //câu 10:
        private void radioButton40_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton40.Checked==true)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = " update BaiLam set TraLoi= 'A' where MaCH = '" + grdData1.Rows[9].Cells["MaCH"].Value.ToString() + "'and MaND ='"+msv+"' and MaMon = '"+grdData1.Rows[0].Cells["MaMon"].Value.ToString()+"'; ";
                cmd.ExecuteNonQuery();
            }
        }

        private void radioButton39_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton39.Checked==true)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = " update BaiLam set TraLoi= 'B' where MaCH = '" + grdData1.Rows[9].Cells["MaCH"].Value.ToString() + "'and MaND ='"+msv+"' and MaMon = '"+grdData1.Rows[0].Cells["MaMon"].Value.ToString()+"'; ";
                cmd.ExecuteNonQuery();
            }
        }

        private void radioButton37_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton37.Checked==true)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = " update BaiLam set TraLoi= 'C' where MaCH = '" + grdData1.Rows[9].Cells["MaCH"].Value.ToString() + "'and MaND ='"+msv+"' and MaMon = '"+grdData1.Rows[0].Cells["MaMon"].Value.ToString()+"'; ";
                cmd.ExecuteNonQuery();
            }
        }

        private void radioButton38_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton38.Checked==true)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = " update BaiLam set TraLoi= 'D' where MaCH = '" + grdData1.Rows[9].Cells["MaCH"].Value.ToString() + "'and MaND ='"+msv+"' and MaMon = '"+grdData1.Rows[0].Cells["MaMon"].Value.ToString()+"'; ";
                cmd.ExecuteNonQuery();
            }
        }

        private void grdData1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void lbMin_Click(object sender, EventArgs e)
        {

        }

        private void label60_Click_1(object sender, EventArgs e)
        {

        }

        private void grbTimes_Enter(object sender, EventArgs e)
        {

        }

        private void label61_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
