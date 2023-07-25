using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangNhap
{
    public partial class Frmmain : Form
    {
        public Frmmain()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void đăngNhậpLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDangNhap f = new FormDangNhap();
            this.Hide();
            f.Show();
        }

        private void quảnLýCâuHỏiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQLCH f = new FrmQLCH();
            f.Show();

        }

        private void quảnLýNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQLND f = new FrmQLND();
            f.Show();
        }

        private void Frmmain_Load(object sender, EventArgs e)
        {

        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xemKếtQuảThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKQuaThi f = new FrmKQuaThi();
            f.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
