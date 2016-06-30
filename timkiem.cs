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

namespace tuantpps03715_assignment
{
    public partial class timkiem : Form
    {
        DataTable dt;
        DataView dv;
        SqlDataAdapter sa;
        public timkiem()
        {
            InitializeComponent();
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-T5BHHIS;Initial Catalog=phantuan5289;Integrated Security=True");
            SqlDataAdapter sa = new SqlDataAdapter("select makh,tenkh, diachi, sdt, email from khachhang where tenkh like '" + txttimkiem.Text + "%'", kn);
            DataTable dt = new DataTable();
            sa.Fill(dt);
           dgvtimkiem.DataSource = dt;
        }

        private void bttimkiem_Click(object sender, EventArgs e)
        {
            string timkiem = txttimkiem.Text;
            dv.RowFilter = "tenkh like'" + timkiem + "%'";
            dgvtimkiem.DataSource = dv;
        }


        private void timkiem_Load(object sender, EventArgs e)
        {
            SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-T5BHHIS;Initial Catalog=phantuan5289;Integrated Security=True");
            sa = new SqlDataAdapter("select * from khachhang", kn);
            dt = new DataTable("tenkh");

            sa.Fill(dt);
            dv = new DataView(dt);
            dgvtimkiem.DataSource = dv;

        }




        private void btthoattk_Click(object sender, EventArgs e)
        {
            DialogResult hoitk;
            hoitk = MessageBox.Show(" ARE YOU SURE? ", "WARNING!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoitk == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}


