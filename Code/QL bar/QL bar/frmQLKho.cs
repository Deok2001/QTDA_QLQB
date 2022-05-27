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
    public partial class frmQLKho : Form
    {
        public frmQLKho()
        {
            InitializeComponent();
        }

        private void frmQLKho_Load(object sender, EventArgs e)
        {
            getData();
            clearText();
        }
        public void clearText()
        {
            txtmanl.Enabled = true;
            btnthem.Enabled = true;
            btnsua.Enabled = false;
            btntk.Enabled = true;
            txtmanl.Text = "";
            txttennl.Text = "";
            txtDonGia.Text = "";
            txtngaysd.Text = "";
            txtmanv.Text = "";

            
        }
        public void getData()
        {
            List<Model.Kho> lst = new List<Model.Kho>();
            try
            {
                String con_str = "Data Source=DESKTOP-K54RFCM\\SQLEXPRESS; Initial Catalog=QL_Bar;User ID=sa; Password=123456";
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();
                String query = "select * from QLKho";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    Model.Kho obj = new Model.Kho(rd);
                    lst.Add(obj);
                }
                conn.Close();
                dgvkho.DataSource = lst;
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
                string manl = txtmanl.Text;
                string tennl = txttennl.Text;
                string ngaysd = txtngaysd.Text;
                DateTime dt = Convert.ToDateTime(ngaysd);
                string dongia = txtDonGia.Text;
                string manv = txtmanv.Text;
                string query = "insert into QLKho (MaNL, TenNL, NgaySuDung ,DonGia, MaNV) VALUES(@MaNL, @TenNL,@NgaySuDung ,@DonGia,@MaNV)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@MaNL", manl));
                cmd.Parameters.Add(new SqlParameter("@TenNL", tennl));
                cmd.Parameters.Add(new SqlParameter("@NgaySuDung", ngaysd));
                cmd.Parameters.Add(new SqlParameter("@DonGia", dongia));
                cmd.Parameters.Add(new SqlParameter("@MaNV", manv));
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

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                string con_str = "Data Source=DESKTOP-K54RFCM\\SQLEXPRESS; Initial Catalog=QL_Bar; User ID=sa; Password=123456;";
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();
                string manl = txtmanl.Text;
                string tennl = txttennl.Text;
                string ngaysd = txtngaysd.Text;
                DateTime dt = Convert.ToDateTime(ngaysd);
               
                string dongia = txtDonGia.Text;
                string manv = txtmanv.Text;
                string query = "update  QLKho set TenNL= @TenNL,NgaySuDung= @NgaySuDung ,DonGia= @DonGia,MaNV= @MaNV where MaNL=@MaNL";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@MaNL", manl));
                cmd.Parameters.Add(new SqlParameter("@TenNL", tennl));
                cmd.Parameters.Add(new SqlParameter("@NgaySuDung", ngaysd));
                cmd.Parameters.Add(new SqlParameter("@DonGia", dongia));
                cmd.Parameters.Add(new SqlParameter("@MaNV", manv));
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

        private void btntk_Click(object sender, EventArgs e)
        {
            

            List<Model.Kho> lst = new List<Model.Kho>();
            try
            {
                String con_str = "Data Source=DESKTOP-K54RFCM\\SQLEXPRESS ; Initial Catalog=QL_Bar; User ID=sa; Password=123456";
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();
                string tk = txtmanl.Text;

                string query1 = "Select count(*) from QLKho where MaNL=@MaNL";
                SqlCommand cmd1 = new SqlCommand(query1, conn);
                cmd1.Parameters.Add(new SqlParameter("@MaNL", tk));
                int sol = (int)cmd1.ExecuteScalar();
                if (sol == 1)
                {
                    string query = "select * from QLKho where MaNL Like '%'+@tk+'%'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.Add(new SqlParameter("@tk", tk));
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        Model.Kho obj = new Model.Kho(rd);
                        lst.Add(obj);
                    }
                    dgvkho.DataSource = lst;
                    clearText();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy");
                    clearText();
                }
                    conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " +ex.Message);
            }
        }

        private void dgvkho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx >= 0)
            {
                txtmanl.Enabled = false;
                btnthem.Enabled = false;
                btnsua.Enabled = true;
                btntk.Enabled = true;
                txtmanl.Text = dgvkho.Rows[idx].Cells["MaNL"].Value.ToString();
                txttennl.Text = dgvkho.Rows[idx].Cells["TenNL"].Value.ToString();
                txtngaysd.Text = dgvkho.Rows[idx].Cells["NgaySuDung"].Value.ToString();
                txtDonGia.Text = dgvkho.Rows[idx].Cells["DonGia"].Value.ToString();
                txtmanv.Text = dgvkho.Rows[idx].Cells["MaNV"].Value.ToString();
            }
        }

       
    }
}
