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
    public partial class XuatKQ : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source = CUYEN\CUYEN; Initial Catalog = ExamData; Integrated Security = True");

        SqlDataAdapter da3 = new SqlDataAdapter();
        SqlDataAdapter da2 = new SqlDataAdapter();
        DataTable dt3 = new DataTable();
        DataTable dt2 = new DataTable();
        public XuatKQ()
        {
            InitializeComponent();
        }

        private void XuatKQ_Load(object sender, EventArgs e)
        {
          
        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {

        }
    }
   
}
