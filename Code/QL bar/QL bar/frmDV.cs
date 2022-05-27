using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_bar
{
    public partial class frmDV : Form
    {
        public frmDV()
        {
            InitializeComponent();
        }

        private void frmDV_Load(object sender, EventArgs e)
        {
            getData();
            getcmb();
        }
       
        public void getData()
        {
            List<Model.DV> lst = new List<Model.DV>();
            try
            {
                String con_str = "Data Source=DESKTOP-K54RFCM\\SQLEXPRESS; Initial Catalog=QL_Bar;User ID=sa; Password=123456";
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();
                String query = "Select * from DV";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    Model.DV obj = new Model.DV(rd);
                    lst.Add(obj);
                }
                conn.Close();
                dgvdv.DataSource = lst;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
            }
        }
        public void getcmb()
        {
            List<Model.DV> lst = new List<Model.DV>();
            try
            {
                String con_str = "Data Source=DESKTOP-K54RFCM\\SQLEXPRESS; Initial Catalog=QL_Bar;User ID=sa; Password=123456";
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();
                String query = "Select * from DV";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    Model.DV obj = new Model.DV(rd);
                    lst.Add(obj);
                }
                conn.Close();
                cmbkh.DataSource = lst;
                //displaymember xác định kiểu duex liệu nà được hiển thị lên
                cmbkh.DisplayMember = "MaKH";
                // values member : giá trị ánh xạ 
                cmbkh.ValueMember = "MaKH";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
            }
        }

        public void clearText()
        {

            btnthem.Enabled = true;
            cmbkh.Text = "";
            txttendv.Text = "";
            txtdongia.Text = "";
            txtsoluong.Text = "";

        }
        private void dgvdv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx >= 0)
            {
               // txtkh.Text = dgvdv.Rows[idx].Cells["MaKH"].Value.ToString();
  
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                string con_str = "Data Source=DESKTOP-K54RFCM\\SQLEXPRESS; Initial Catalog=QL_Bar; User ID=sa; Password=123456;";
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();
                string makh = cmbkh.Text;
                string tendv = txttendv.Text;
                string soluong = txtsoluong.Text;
                string dongia = txtdongia.Text;
               
                string query = "insert into DV (MaKH, TenDV, SoLuong ,DonGia) VALUES(@MaKH, @TenDV,@SoLuong ,@DonGia) ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@MaKH", makh));
                cmd.Parameters.Add(new SqlParameter("@TenDV", tendv));
                cmd.Parameters.Add(new SqlParameter("@SoLuong", soluong));
                cmd.Parameters.Add(new SqlParameter("@DonGia", dongia));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công");
                conn.Close();
                getData();
                clearText();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: Mã khách hàng không hợp lệ! \nVui lòng nhập lại😊");
            }
        }

        private void cmbkh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
