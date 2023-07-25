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
    public partial class FrmShowDiem : Form
    {   SqlConnection conn = new SqlConnection(@"Data Source = CUYEN\CUYEN; Initial Catalog = Exam; Integrated Security = True");
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlDataAdapter da1 = new SqlDataAdapter();
        DataTable dt1 = new DataTable();
        string MND;
        string mk;
        SqlCommand cmd;

        public FrmShowDiem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "update NguoiDung set Password = null where MaND = '"+MND+"' ";
            cmd.ExecuteNonQuery();
            Application.Exit();
        }
        public FrmShowDiem(string Message1,string Message2) : this()
        {
            MND = Message1;
            mk = Message2;
            conn.Open();
            string mamon = "select MaMon from Mon where Password ='"+mk+"'";
            da = new SqlDataAdapter(mamon, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            grdData1.DataSource= dt;

            //"+grdData1.Rows[0].Cells["MaMon"].Value.ToString()+"
            string diem = "select count(TraLoi) as 'SoDiem' from BaiLam,CauHoi  where BaiLam.MaCH= CauHoi.MaCH and BaiLam.TraLoi=CauHoi.DapAn and MaND='"+MND+"' and BaiLam.MaMon='"+grdData1.Rows[0].Cells["MaMon"].Value.ToString()+"' and TraLoi is not null";
            da1 = new SqlDataAdapter(diem, conn);
            dt1 = new DataTable();
            dt1.Clear();
            da1.Fill(dt1);
            grdData3.DataSource= dt1;
            label2.Text= grdData3.Rows[0].Cells["SoDiem"].Value.ToString();           
        }
        private void FrmShowDiem_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void grdData1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
