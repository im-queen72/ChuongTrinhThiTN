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
    public partial class FrmKQuaThi : Form
    {   SqlConnection conn = new SqlConnection(@"Data Source = CUYEN\CUYEN; Initial Catalog = Exam; Integrated Security = True");
        SqlDataAdapter da2 = new SqlDataAdapter();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataAdapter da3 = new SqlDataAdapter();
        SqlDataAdapter da4 = new SqlDataAdapter();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        DataTable dt4 = new DataTable();
        DataTable dt = new DataTable();
        DataTable dtBC = new DataTable();


        int i;
        public FrmKQuaThi()
        {
            InitializeComponent();
        }

        private void FrmKQuaThi_Load(object sender, EventArgs e)
        {
            conn.Open();
            string h = "select * from KetQua ";
            da3 = new SqlDataAdapter(h, conn);
            dt3 = new DataTable();
            dt3.Clear();
            da3.Fill(dt3);
            grdData5.DataSource= dt3;
            button4.Visible=false;
            
        }
            
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            string t = "select NguoiDung.Ten,NguoiDung.MaND,KetQua.TenMon, SoDiem from NguoiDung,KetQua where NguoiDung.MaQND='1' and KetQua.MaND= NguoiDung.MaND and KetQua.MaMon='"+comGT.Text+"'";            
            da2 = new SqlDataAdapter(t, conn);
            dt2 = new DataTable();
            dt2.Clear();
            da2.Fill(dt2);

            KQKT baocao = new KQKT();
            baocao.SetDataSource(dt2);
            

            XuatKQ frm = new XuatKQ();
            frm.Show();
            //string sql = "Select NguoiDung.Ten,NguoiDung.MaND,KetQua.TenMon,SoDiem from KetQua,NguoiDung " +
            //    "where " + comTenTruong.Text + "='" + comGT.Text + "'";
            //da2= new SqlDataAdapter(sql, conn);
            //dtBC = new DataTable();
            //dtBC.Clear();
            //da2.Fill(dtBC);
            //KQKT bc = new KQKT();
            //bc.SetDataSource(dtBC);
            ////bc.DataDefinition.FormulaFields["Tentruong"].Text = "'" + comTenTruong.Text + "'";
            ////bc.DataDefinition.FormulaFields["Giatri"].Text = "'" + comGT.Text + "'";
            //XuatKQ f = new XuatKQ();
            //f.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            i=grdData5.CurrentRow.Index;
            conn.Close();
            conn.Open();
           
            string h = "select MaBL, MaND, ExamID, BaiLam.MaCH, TraLoi, DapAn from BaiLam,CauHoi where BaiLam.MaCH=CauHoi.MaCH and MaND= '"+ grdData5.Rows[i].Cells["MaND"].Value.ToString() +"' and BaiLam.MaMon='"+grdData5.Rows[i].Cells["MaMon"].Value.ToString()+"' and TraLoi is not null ";
            da4 = new SqlDataAdapter(h, conn);
            dt4 = new DataTable();
            dt4.Clear();
            da4.Fill(dt4);
            grdData6.DataSource= dt4;
            button4.Visible=true;
            btnXuatBang.Visible=false;
            button3.Visible=false;
            grdData5.Hide();
            

        }

        private void button4_Click(object sender, EventArgs e)
        {

            grdData5.Show();
            button4.Visible=false;
            btnXuatBang.Visible=true;
            button3.Visible=true;
        }

        private void grdData6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string sql = "Select Distinct " + comTenTruong.Text + " From KetQua ";
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            comGT.DataSource = dt;
            comGT.DisplayMember = comTenTruong.Text;
            comGT.ValueMember = comTenTruong.Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dt.Clear();
            string sql = "Select * From KetQua where " + comTenTruong.Text + "='" + comGT.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdData5.DataSource = dt;
            grdData5.Refresh();
            //MaND,KetQua.MaMon,ExamID,SoDiem

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sql = "Select * From KetQua";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdData5.DataSource = dt;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            string o = "select TenMon, MaMon, DiemTB from Mon ";
            da2 = new SqlDataAdapter(o, conn);
            dt2 = new DataTable();
            dt2.Clear();
            da2.Fill(dt2);

            BaocaoMon baocao = new BaocaoMon();
            baocao.SetDataSource(dt2);

            FrmDiemTBcacMon1 frm = new FrmDiemTBcacMon1();
            frm.Show();
        }
    }
}
