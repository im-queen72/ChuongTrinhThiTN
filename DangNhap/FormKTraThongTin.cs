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



namespace APP
{    public partial class FormKTraThongTin : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9GAKJV7\SQLEXPRESS01;Initial Catalog=Exam;Integrated Security=True");

        public string tk;
        public string mk;

        public FormKTraThongTin()
        {
            InitializeComponent();
        }
        public FormKTraThongTin(string Message1, string Message2) : this()
        {
            conn.Open();
            tk = Message1;
            mk = Message2;
            string sql = "select Ten,MaND,NgaySinh from NguoiDung where  MaND ='"+tk+"' and MK= '"+mk+"';";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dta = cmd.ExecuteReader();
            if (dta.Read()==true)
            {
                label4.Text=dta["Ten"].ToString();
                label5.Text=dta["MaND"].ToString();
                label6.Text=dta["NgaySinh"].ToString();              
            }
        }
      
        private void button2_Click(object sender, EventArgs e)
        { 
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-KJNF2QE\SQLEXPRESS;Initial Catalog=Exam;Integrated Security=True");
            conn.Open();
            string msv = label5.Text;
            FormGiaoDienThi Child1 = new FormGiaoDienThi(label5.Text);

            string sql = "select Ten from NguoiDung where MaND ='"+tk+"' and MK= '"+mk+"';";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dta = cmd.ExecuteReader();
           
            while (dta.Read())
            {
                Child1.ShowDialog();
                               
               
            }
           
        }

        private void FormKTraThongTin_Load(object sender, EventArgs e)
        {

        }
    }
}
