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
    public partial class FormDangNhap : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=CUYEN\CUYEN;Initial Catalog=Exam;Integrated Security=True");
        SqlCommand cmd;
        string tk;
        string mk;
        public FormDangNhap()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btDangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                tk = txtTentk.Text;
                mk = txtMatkhau.Text;
                Frmmain f = new Frmmain();
                FrmKTraThongTinSV d = new FrmKTraThongTinSV(txtTentk.Text, txtMatkhau.Text);
                string sql = "Select MaQND, MaND, Mon.Password from NguoiDung, Mon where MaND= '"+tk+"'and Mon.Password= '"+mk+"';";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta= cmd.ExecuteReader();
                if (dta.Read()==true) 
                {
                    string l = dta["MaQND"].ToString();
                    if (l == "1")
                    {
                        CapNhatMK();
                        d.Show();
                    }
                   
                }
                else if(dta.Read()==false)
                {
                    f.Show();
                }
                else 
                {
                    MessageBox.Show("Đăng nhập thất bại!");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi kết nối");
            }
            this.Hide();
        }
        private void CapNhatMK()
        {
            conn.Close();
            conn.Open();
            string updatediem = "update NguoiDung set Password = '"+mk+"' where MaND = '"+tk+"'";
            cmd = conn.CreateCommand();
            cmd.CommandText= updatediem;
            cmd.ExecuteNonQuery();
        }
        private void txtTentk_TextChanged(object sender, EventArgs e)
        {

        }

        private void picHide_Click(object sender, EventArgs e)
        {
            if(txtMatkhau.PasswordChar=='*')
            {
                picOpen.BringToFront();
                txtMatkhau.PasswordChar = '\0';
            }
        }

        private void picOpen_Click(object sender, EventArgs e)
        {

            if (txtMatkhau.PasswordChar == '\0')
            {
                picHide.BringToFront();
                txtMatkhau.PasswordChar = '*';
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("\t");
            }
        }
    }   
}
