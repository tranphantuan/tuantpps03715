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
    public partial class quanlykhachhang : Form
    {
        public quanlykhachhang()
        {
            InitializeComponent();
        }
        private void ketnoi()
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-T5BHHIS;Initial Catalog=phantuan5289;Integrated Security=True");
                kn.Open();//mo ket noi 
                string sql = "select * from khachhang";
                SqlCommand cmd = new SqlCommand(sql, kn);// thuc thi cac lenh query
                SqlDataAdapter sa = new SqlDataAdapter(cmd);//van chuyen du lieu 
                DataTable dt = new DataTable();//tạo 1 bảng trong he thong
                sa.Fill(dt);//do du lieu vao bang ao
                dgvdulieukh.DataSource = dt; //bang ao du lieu do vao datagridview
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối bạn vui lòng nhập lại");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-T5BHHIS;Initial Catalog=phantuan5289;Integrated Security=True");
                kn.Close();//dong ket noi
            }

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ketnoi();
        }

        int index;
        private void dgvdulieukh_Click(object sender, EventArgs e)
        {
            index = dgvdulieukh.CurrentRow.Index;
            txtmakh.Text = dgvdulieukh.Rows[index].Cells[0].Value.ToString();
            txttenkh.Text= dgvdulieukh.Rows[index].Cells[1].Value.ToString();
            txtdiachi.Text = dgvdulieukh.Rows[index].Cells[2].Value.ToString();
            txtsodt.Text = dgvdulieukh.Rows[index].Cells[3].Value.ToString();
            txtemail.Text = dgvdulieukh.Rows[index].Cells[4].Value.ToString();
          
            //click vào hiển thị trên o chi tiet
        }
        //button Them
        string them;
        private void btthem_Click(object sender, EventArgs e)
        {
            try{
                 SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-T5BHHIS;Initial Catalog=phantuan5289;Integrated Security=True");
                kn.Open();
                them = "insert into khachhang values('"+txtmakh.Text+"','"+txttenkh.Text+"','"+txtdiachi.Text+"','"+txtsodt.Text+"','"+txtemail.Text+"')";
                SqlCommand cmdthem = new SqlCommand(them, kn);
                cmdthem.ExecuteNonQuery();
                ketnoi();
            }
            catch{
                MessageBox.Show("FAILED");
            }
            finally{
                 SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-T5BHHIS;Initial Catalog=phantuan5289;Integrated Security=True");
                kn.Close();
                    
            }
        }
        // button Xoa
        string xoahd;
        string xoakh;
        private void btxoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-T5BHHIS;Initial Catalog=phantuan5289;Integrated Security=True");
                kn.Open();
                xoahd = "delete hoadon where makh = '" + txtmakh.Text + "'";
                xoakh = "delete khachhang where makh = '" + txtmakh.Text + "'";
                SqlCommand cmdxoahd = new SqlCommand(xoahd, kn);
                SqlCommand cmdxoakh = new SqlCommand(xoakh, kn);
                cmdxoahd.ExecuteNonQuery();
                cmdxoakh.ExecuteNonQuery();
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
// Button Sua
        string sua;
        private void btsua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-T5BHHIS;Initial Catalog=phantuan5289;Integrated Security=True");
                kn.Open();
                sua = "update khachhang set tenkh = '" + txttenkh.Text + "', diachi ='" + txtdiachi.Text + "', sdt = '" + txtsodt.Text + "', email='" + txtemail.Text + "' where makh='" + txtmakh.Text + "'";
                SqlCommand cmdsua = new SqlCommand(sua, kn);
                cmdsua.ExecuteNonQuery();
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
        // Button Thoat
        private void btthoat_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show(" ARE YOU SURE? ", "WARNING!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi==DialogResult.Yes)
            {
                this.Close();
            }
        }



    }
}
