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

namespace QL_bar
{
    public partial class frmQLNV : Form
    {
        public frmQLNV()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void clearText()
        {
            txtmanv.Enabled = true;
            btnthem.Enabled = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            txtmanv.Text = "";
            txttennv.Text = "";
            txtdc.Text = "";
            txtcv.Text = "";
            txtngaysinh.Text = "";

            txtsdt.Text = "";
        }
        private void frmQLNV_Load(object sender, EventArgs e)
        {
            getData();
            clearText();
        }
        public void getData()
        {
            List<Model.NhanVien> lst = new List<Model.NhanVien>();
            try
            {
                String con_str = "Data Source=DESKTOP-K54RFCM\\SQLEXPRESS; Initial Catalog=QL_Bar;User ID=sa; Password=123456";
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();
                String query = "select * from QLNV";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    Model.NhanVien obj = new Model.NhanVien(rd);
                    lst.Add(obj);
                }
                conn.Close();
                dgvnv.DataSource = lst;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                string con_str = "Data Source=DESKTOP-K54RFCM\\SQLEXPRESS; Initial Catalog=QL_Bar; User ID=sa; Password=123456;";
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();
                string manv = txtmanv.Text;
                string tennv = txttennv.Text;
                string ngaysinh = txtngaysinh.Text;
                
                string sodt = txtsdt.Text;
                string diachi = txtdc.Text;
                string chucvu = txtcv.Text;
                string query = "insert into QLNV (MaNV, TenNV, NgaySinh ,SoDT, DiaChi, ChucVu) VALUES(@MaNV, @TenNV,@NgaySinh ,@SoDT,@DiaChi,@ChucVu)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@MaNV", manv));
                cmd.Parameters.Add(new SqlParameter("@TenNV", tennv));
                cmd.Parameters.Add(new SqlParameter("@NgaySinh", ngaysinh));
                cmd.Parameters.Add(new SqlParameter("@SoDT", sodt));
                cmd.Parameters.Add(new SqlParameter("@DiaChi", diachi));
                cmd.Parameters.Add(new SqlParameter("@ChucVu", chucvu));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công");
                conn.Close();
                getData();
                clearText();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: Mã bị trùng ");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                string con_str = "Data Source=DESKTOP-K54RFCM\\SQLEXPRESS; Initial Catalog=QL_Bar; User ID=sa; Password=123456;";
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();
                string manv = txtmanv.Text;
                string query = "delete from QLNV where MaNV= @MaNV";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@MaNV", manv));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
                conn.Close();
                getData();
                clearText();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                string con_str = "Data Source=DESKTOP-K54RFCM\\SQLEXPRESS; Initial Catalog=QL_Bar; User ID=sa; Password=123456;";
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();
                string manv = txtmanv.Text;
                string tennv = txttennv.Text;  
                string ngaysinh = txtngaysinh.Text;
              
                string sodt = txtsdt.Text;
                string diachi = txtdc.Text;
                string chucvu = txtcv.Text;
                string query = "update  QLNV set TenNV= @TenNV,NgaySinh= @NgaySinh ,SoDT= @SoDT,DiaChi= @DiaChi,ChucVu= @ChucVu where MaNV=@MaNV";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@MaNV", manv));
                cmd.Parameters.Add(new SqlParameter("@TenNV", tennv));
                cmd.Parameters.Add(new SqlParameter("@NgaySinh", ngaysinh));
                cmd.Parameters.Add(new SqlParameter("@SoDT", sodt));
                cmd.Parameters.Add(new SqlParameter("@DiaChi", diachi));
                cmd.Parameters.Add(new SqlParameter("@ChucVu", chucvu));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công");
                conn.Close();
                getData();
                clearText();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dgvnv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx >= 0)
            {
                txtmanv.Enabled = false;
                btnthem.Enabled = false;
                btnsua.Enabled = true;
                btnxoa.Enabled = true;
                txtmanv.Text = dgvnv.Rows[idx].Cells["MaNV"].Value.ToString();
                txttennv.Text = dgvnv.Rows[idx].Cells["TenNV"].Value.ToString();
                txtngaysinh.Text = dgvnv.Rows[idx].Cells["NgaySinh"].Value.ToString();
                txtsdt.Text = dgvnv.Rows[idx].Cells["SoDT"].Value.ToString();
                txtdc.Text = dgvnv.Rows[idx].Cells["DiaChi"].Value.ToString();
                txtcv.Text = dgvnv.Rows[idx].Cells["ChucVu"].Value.ToString();


            }
        }

        private void dgvnv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
