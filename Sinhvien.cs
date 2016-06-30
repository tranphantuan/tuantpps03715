using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tuantpps03715_assignment
{
    public partial class Sinhvien : Form
    {
        public Sinhvien()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Sinhvien_Load(object sender, EventArgs e)
        {

        }

        private void btquanlykh_Click(object sender, EventArgs e)
        {
            quanlykhachhang qlkh = new quanlykhachhang();
            qlkh.ShowDialog();

        }

        private void bttimkiem_Click(object sender, EventArgs e)
        {
            timkiem tk = new timkiem();
            tk.ShowDialog();
        }

        private void btthoatsv_Click(object sender, EventArgs e)
        {
            DialogResult hoisv;
            hoisv = MessageBox.Show(" ARE YOU SURE? ", "WARNING!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoisv == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btsanpham_Click(object sender, EventArgs e)
        {
            sanpham sp = new sanpham();
            sp.ShowDialog();
        }
    }
}
