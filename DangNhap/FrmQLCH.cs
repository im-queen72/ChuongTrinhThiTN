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
    public partial class FrmQLCH : Form
    {   
        SqlConnection conn = new SqlConnection(@"Data Source = CUYEN\CUYEN; Initial Catalog = Exam; Integrated Security = True");


        SqlCommand cmd;
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlDataAdapter da1 = new SqlDataAdapter();
        DataTable dt1 = new DataTable();


        void loaddata()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from CauHoi";
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            grd1.DataSource = dt;
        }

        public FrmQLCH()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = grd1.CurrentRow.Index;
            txtMach.Text = grd1.Rows[i].Cells[0].Value.ToString();
            txtCauhoi.Text = grd1.Rows[i].Cells[1].Value.ToString();
            txtA.Text = grd1.Rows[i].Cells[2].Value.ToString();
            txtB.Text = grd1.Rows[i].Cells[3].Value.ToString();
            txtC.Text = grd1.Rows[i].Cells[4].Value.ToString();
            txtD.Text = grd1.Rows[i].Cells[5].Value.ToString();
            txtDapan.Text = grd1.Rows[i].Cells[6].Value.ToString();
            txtDiem.Text = grd1.Rows[i].Cells[7].Value.ToString();

        }

       

        private void FrmQLCH_Load(object sender, EventArgs e)
        {
            conn.Open();
            loaddata();
        }

        private void grd1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = grd1.CurrentRow.Index;
            txtMach.Text = grd1.Rows[i].Cells[0].Value.ToString();
            txtCauhoi.Text = grd1.Rows[i].Cells[1].Value.ToString();
            txtA.Text = grd1.Rows[i].Cells[2].Value.ToString();
            txtB.Text = grd1.Rows[i].Cells[3].Value.ToString();
            txtC.Text = grd1.Rows[i].Cells[4].Value.ToString();
            txtD.Text = grd1.Rows[i].Cells[5].Value.ToString();
            txtDapan.Text = grd1.Rows[i].Cells[6].Value.ToString();
            txtDiem.Text = grd1.Rows[i].Cells[7].Value.ToString();
            txtMamon.Text = grd1.Rows[i].Cells[8].Value.ToString();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "insert into CauHoi values('"+txtMach.Text+"',N'"+txtCauhoi.Text+"',N'"+txtA.Text+ "',N'" + txtB.Text + "',N'" + txtC.Text + "',N'" + txtD.Text + "','" + txtDapan.Text + "'," + txtDiem.Text + ",'"+txtMamon.Text+"')";
            cmd.ExecuteNonQuery();
            loaddata();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này?(Y/N)", "Xác nhận yêu cầu", MessageBoxButtons.YesNo) == DialogResult.Yes)
            cmd = conn.CreateCommand();
            cmd.CommandText = "delete  from CauHoi where MaCH = '"+txtMach.Text+"'";
            cmd.ExecuteNonQuery();
            loaddata();
        } 

        private void btSua_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "update CauHoi set MaCH = '"+txtMach.Text+"', CauHoi = N'"+txtCauhoi.Text+"', OptionA=N'"+txtA.Text+ "', OptionB=N'" + txtB.Text + "',OptionC=N'" + txtC.Text + "',OptionD=N'" + txtD.Text + "',DapAn=N'"+txtDapan.Text+"',Diem="+txtDiem.Text+",MaMon='"+txtMamon.Text+ "'where MaCH ='" + txtMach.Text + "' ";
            cmd.ExecuteNonQuery();
            loaddata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmQLCH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("\t");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            conn.Close();
            conn.Open();
            string t = "select MaCH, CauHoi, OptionA, OptionB, OptionC, OptionD, DapAn from CauHoi   ";
            da1 = new SqlDataAdapter(t, conn);
            dt1 = new DataTable();
            dt1.Clear();
            da1.Fill(dt1);

            QLCH baocao = new QLCH();
            baocao.SetDataSource(dt1);
            FrmXuatCauHoi f = new FrmXuatCauHoi();
            
            f.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtMamon_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtD_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtDapan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtDiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtCauhoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMach_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {

        }
    }

}
