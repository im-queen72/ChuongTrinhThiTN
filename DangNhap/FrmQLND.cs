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
    public partial class FrmQLND : Form
    {   SqlConnection conn = new SqlConnection(@"Data Source = CUYEN\CUYEN; Initial Catalog = Exam; Integrated Security = True");


        SqlCommand cmd;
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        void loaddata()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select MaND, Ten, NgaySinh, MaQND, Password from NguoiDung";
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            grd1.DataSource = dt;
        }

        public FrmQLND()
        {
            InitializeComponent();
        }

       

        private void FrmQLND_Load(object sender, EventArgs e)
        {
            conn.Open();
            loaddata();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void grd1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = grd1.CurrentRow.Index;
            txtMand.Text = grd1.Rows[i].Cells[0].Value.ToString();
            txtTennd.Text = grd1.Rows[i].Cells[1].Value.ToString();
            txtNgaysinh.Text = grd1.Rows[i].Cells[2].Value.ToString();
            txtMaqnd.Text = grd1.Rows[i].Cells[3].Value.ToString();
            txtMk.Text = grd1.Rows[i].Cells[4].Value.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "insert into NguoiDung values('" + txtMand.Text + "',N'" + txtTennd.Text + "','" + txtNgaysinh.Text + "','" + txtMaqnd.Text + "',N'" + txtMk.Text + "')";
            cmd.ExecuteNonQuery();
            loaddata();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này?(Y/N)", "Xác nhận yêu cầu", MessageBoxButtons.YesNo) == DialogResult.Yes)
            cmd = conn.CreateCommand();
            cmd.CommandText = "delete  from NguoiDung where MaND = '" + txtMand.Text + "'";
            cmd.ExecuteNonQuery();
            loaddata();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "update NguoiDung set MaND = '" + txtMand.Text + "', Ten = N'" + txtTennd.Text + "', NgaySinh ='" + txtNgaysinh.Text + "', MaQND ='" + txtMaqnd.Text + "',Password =N'" + txtMk.Text + "'where MaND ='" + txtMand.Text + "' ";
            cmd.ExecuteNonQuery();
            loaddata();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FrmQLND_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                SendKeys.Send("\t");
            }
        }

        private void grd1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void txtMand_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
