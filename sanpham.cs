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
    public partial class sanpham : Form
    {
        public sanpham()
        {
            InitializeComponent();
        }
        public void ketnoi()
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-T5BHHIS;Initial Catalog=phantuan5289;Integrated Security=True");
                kn.Open();//mo ket noi 
                string sql = "select * from sanpham";
                SqlCommand cmd = new SqlCommand(sql, kn);// thuc thi cac lenh query
                SqlDataAdapter sa = new SqlDataAdapter(cmd);//van chuyen du lieu 
                DataTable dt = new DataTable();//tạo 1 bảng trong he thong
                sa.Fill(dt);//do du lieu vao bang ao
                dgvsanpham.DataSource = dt; //bang ao du lieu do vao datagridview
            }
            catch
            {
                MessageBox.Show("FAILED");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-T5BHHIS;Initial Catalog=phantuan5289;Integrated Security=True");
                kn.Close();
            }
        }

        private void sanpham_Load(object sender, EventArgs e)
        {
            ketnoi();
        }
        int index;

        private void dgvsanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dgvsanpham.CurrentRow.Index;
            txtmasp.Text = dgvsanpham.Rows[index].Cells[0].Value.ToString();
            txttensp.Text = dgvsanpham.Rows[index].Cells[1].Value.ToString();
            txtgia.Text = dgvsanpham.Rows[index].Cells[2].Value.ToString();
            txtloaisp.Text = dgvsanpham.Rows[index].Cells[3].Value.ToString();
        }
        string themsp;

        private void btthemsp_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-T5BHHIS;Initial Catalog=phantuan5289;Integrated Security=True");
                kn.Open();
                themsp = "insert into sanpham values('" + txtmasp.Text + "','" + txttensp.Text + "','" + txtgia.Text + "','" + txtloaisp.Text + "')";
                SqlCommand cmdthemsp = new SqlCommand(themsp, kn);
                cmdthemsp.ExecuteNonQuery();
                ketnoi();
            }
            catch
            {
                MessageBox.Show("FAILED");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-T5BHHIS;Initial Catalog=phantuan5289;Integrated Security=True");
                kn.Close();
            }
        }
        string xoamahd;
        string xoamasp;

        private void btxoasp_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-T5BHHIS;Initial Catalog=phantuan5289;Integrated Security=True");
                kn.Open();
                xoamahd = "delete chitiet_hd where masp = '" + txtmasp.Text + "'";
                xoamasp = "delete sanpham where masp = '" + txtmasp.Text + "'";
                SqlCommand cmdxoamahd = new SqlCommand(xoamahd, kn);
                SqlCommand cmdxoamasp = new SqlCommand(xoamasp, kn);
                cmdxoamahd.ExecuteNonQuery();
                cmdxoamasp.ExecuteNonQuery();
                ketnoi();
            }
            catch
            {
                MessageBox.Show("FAILED");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-T5BHHIS;Initial Catalog=phantuan5289;Integrated Security=True");
                kn.Close();
            }
        }
        string suasp;

        private void btsuasp_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-T5BHHIS;Initial Catalog=phantuan5289;Integrated Security=True");
                kn.Open();
                suasp = "update sanpham set  tensp ='" + txttensp.Text + "', gia = '" + txtgia.Text + "', loaisp ='" + txtloaisp.Text + "' where masp='" + txtmasp.Text + "'";
                SqlCommand cmdsuasp = new SqlCommand(suasp, kn);
                cmdsuasp.ExecuteNonQuery();
                ketnoi();
            }
            catch
            {
                MessageBox.Show("FAILED");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-T5BHHIS;Initial Catalog=phantuan5289;Integrated Security=True");
                kn.Close();
            }
        }

        private void btthoatsp_Click(object sender, EventArgs e)
        {
            DialogResult hoisp;
            hoisp = MessageBox.Show(" ARE YOU SURE? ", "WARNING!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoisp == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}