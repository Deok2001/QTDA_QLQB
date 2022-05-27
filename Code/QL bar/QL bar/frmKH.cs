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
    public partial class frmKH : Form
    {
        public frmKH()
        {
            InitializeComponent();
        }


        private void frmKH_Load(object sender, EventArgs e)
        {
            getData();
            clearText();
        }
        public void clearText()
        { 
            btndv.Enabled = true;
            txtmakh.Enabled = true;
            btnthem.Enabled = true;
            txtmakh.Text="";
            txtmanv.Text = "";
            txttenkh.Text = "";
            txtdc.Text = "";
            txtsdt.Text = "";


        }
        public void getData()
        {
            List<Model.KhachHang> lst = new List<Model.KhachHang>();
            try
            {
                String con_str = "Data Source=DESKTOP-K54RFCM\\SQLEXPRESS; Initial Catalog=QL_Bar;User ID=sa; Password=123456";
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();
                String query = "select * from QLKH";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    Model.KhachHang obj = new Model.KhachHang(rd);
                    lst.Add(obj);
                }
                conn.Close();
                dgvkh.DataSource = lst;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
            }
        }

        public void dgvkh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;

            if (idx >= 0)
            {
                txtmakh.Enabled = true;
                btndv.Enabled = true;
                btnthem.Enabled = false;
                txtmakh.Text = dgvkh.Rows[idx].Cells["MaKH"].Value.ToString();
                txttenkh.Text = dgvkh.Rows[idx].Cells["TenKH"].Value.ToString();
                txtdc.Text = dgvkh.Rows[idx].Cells["DiaChi"].Value.ToString();
                txtsdt.Text = dgvkh.Rows[idx].Cells["SoDT"].Value.ToString();
                txtmanv.Text = dgvkh.Rows[idx].Cells["MaNV"].Value.ToString();

            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                string con_str = "Data Source=DESKTOP-K54RFCM\\SQLEXPRESS; Initial Catalog=QL_Bar; User ID=sa; Password=123456;";
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();
                string makh = txtmakh.Text;
                string tenkh = txttenkh.Text;
                string sodt = txtsdt.Text;
                string diachi = txtdc.Text;
                string manv = txtmanv.Text;
                string query = "insert into QLKH (MaKH, TenKH, SoDT, DiaChi, MaNV) VALUES(@MaKH, @TenKH,@SoDT,@DiaChi,@MaNV)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@MaKH", makh));
                cmd.Parameters.Add(new SqlParameter("@TenKH", tenkh));
                cmd.Parameters.Add(new SqlParameter("@SoDT", sodt));
                cmd.Parameters.Add(new SqlParameter("@DiaChi", diachi));
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

        private void btndv_Click(object sender, EventArgs e)
        {
            frmDV dv = new frmDV();
            dv.Show();
           //string dv = txtmakh.Text;
            //txtmakh.Text = "";
            /*switch (dv)
            {
                case "01":
                    MessageBox.Show("Tên:Beer Tiger Crystal " +
                       "\nSố lượng:3  " +
                       "\nThẻ thành viên: Có"
                       , "Dịch vụ khách hàng đã sử dụng",
                       MessageBoxButtons.OK);
                    break;
                case "02":
                    MessageBox.Show("Tên:Beer Tiger Crystal,Trà Mạn( Ấm),Camel Caster " +
                       "\nSố lượng:5  " +
                       "\nThẻ thành viên: Không"
                       , "Dịch vụ khách hàng đã sử dụng",
                       MessageBoxButtons.OK);
                    break;
                case "03":
                    MessageBox.Show("Tên:Whisky Sour,BK53,Sparta Lamborghini ( Set 3 Glass) " +
                       "\nSố lượng:6" +
                       "\nThẻ thành viên: Có"
                       , "Dịch vụ khách hàng đã sử dụng",
                       MessageBoxButtons.OK);
                    break;
                case "04":
                    MessageBox.Show("Tên:Reserver Bordeaux ( Vang Pháp),Beer Tiger Crystal,Falo Negroamaro( Vang Ý) " +
                       "\nSố lượng:10  " +
                       "\nThẻ thành viên: Có"
                       , "Dịch vụ khách hàng đã sử dụng",
                       MessageBoxButtons.OK);
                    break;
                case "05":
                    MessageBox.Show("Tên:Beer Heineken,IL Pumo Malvasia SVN Blanc ( Vang Ý),Trà Mạn( Ấm) " +
                       "\nSố lượng:8  " +
                       "\nThẻ thành viên: Có"
                       , "Dịch vụ khách hàng đã sử dụng",
                       MessageBoxButtons.OK);
                    break;
                case "06":
                    MessageBox.Show("Tên:35' Sounth Cabernet Sauvignon( Vang Chile),Trà Mạn( Ấm),Camel Caster " +
                       "\nSố lượng:8  " +
                       "\nThẻ thành viên: Không"
                       , "Dịch vụ khách hàng đã sử dụng",
                       MessageBoxButtons.OK);
                    break;
                case "07":
                    MessageBox.Show("Tên:Whisky Sour,BK53,Sparta Lamborghini ( Set 3 Glass) " +
                       "\nSố lượng:6" +
                       "\nThẻ thành viên: Có"
                       , "Dịch vụ khách hàng đã sử dụng",
                       MessageBoxButtons.OK);
                    break;
                case "08":
                    MessageBox.Show("Tên:Beer Bubweise Mỹ,Reserver Bordeaux ( Vang Pháp),Beer Tiger Crystal,Falo Negroamaro( Vang Ý) " +
                       "\nSố lượng:12  " +
                       "\nThẻ thành viên: Có"
                       , "Dịch vụ khách hàng đã sử dụng",
                       MessageBoxButtons.OK);
                    break;
                case "09":
                    MessageBox.Show("Tên:Beer Bubweise Mỹ,Camel Caster,Red Bull, Pespsi,Falo Negroamaro( Vang Ý) " +
                       "\nSố lượng:4  " +
                       "\nThẻ thành viên: Có"
                       , "Dịch vụ khách hàng đã sử dụng",
                       MessageBoxButtons.OK);
                    break;
                case "10":
                    MessageBox.Show("Tên:BK52,Trà Mạn( Ấm),Camel Caster " +
                       "\nSố lượng:5  " +
                       "\nThẻ thành viên: Không"
                       , "Dịch vụ khách hàng đã sử dụng",
                       MessageBoxButtons.OK);
                    break;
                case "11":
                    MessageBox.Show("Tên:Whisky Sour,BK53,Sparta Lamborghini ( Set 3 Glass),Reserver Bordeaux ( Vang Pháp) " +
                       "\nSố lượng:6" +
                       "\nThẻ thành viên: Có"
                       , "Dịch vụ khách hàng đã sử dụng",
                       MessageBoxButtons.OK);
                    break;
                case "12":
                    MessageBox.Show("Tên:Reserver Bordeaux ( Vang Pháp),Beer Tiger Crystal,Falo Negroamaro( Vang Ý),J.P Chenet Fashion (Strawberry of Apple) " +
                       "\nSố lượng:10  " +
                       "\nThẻ thành viên: Có"
                       , "Dịch vụ khách hàng đã sử dụng",
                       MessageBoxButtons.OK);
                    break;
                case "13":
                    MessageBox.Show("Tên:Beer Tiger Crystal " +
                       "\nSố lượng:4  " +
                       "\nThẻ thành viên: Không"
                       , "Dịch vụ khách hàng đã sử dụng",
                       MessageBoxButtons.OK);
                    break;
                case "14":
                    MessageBox.Show("Tên:Trà Mạn( Ấm),Camel Caster " +
                       "\nSố lượng:3  " +
                       "\nThẻ thành viên: Có"
                       , "Dịch vụ khách hàng đã sử dụng",
                       MessageBoxButtons.OK);
                    break;
                case "15":
                    MessageBox.Show("Tên:Whisky Sour,BK52,Sparta Lamborghini ( Set 3 Glass) " +
                       "\nSố lượng:6" +
                       "\nThẻ thành viên: Không"
                       , "Dịch vụ khách hàng đã sử dụng",
                       MessageBoxButtons.OK);
                    break;
                case "16":
                    MessageBox.Show("Tên:Reserver Bordeaux ( Vang Pháp),Beer Tiger Crystal,Falo Negroamaro( Vang Ý),Whisky Sour " +
                       "\nSố lượng:7  " +
                       "\nThẻ thành viên: Có"
                       , "Dịch vụ khách hàng đã sử dụng",
                       MessageBoxButtons.OK);
                    break;
                case "17":
                    MessageBox.Show("Tên:Beer Heineken,IL Pumo Malvasia SVN Blanc ( Vang Ý),Trà Mạn( Ấm),Beer Sapparo Premium " +
                       "\nSố lượng:8  " +
                       "\nThẻ thành viên: Không"
                       , "Dịch vụ khách hàng đã sử dụng",
                       MessageBoxButtons.OK);
                    break;
                case "18":
                    MessageBox.Show("Tên:35' Sounth Cabernet Sauvignon( Vang Chile),Trà Mạn( Ấm),Camel Caster,IL Pumo Malvasia SVN Blanc ( Vang Ý) " +
                       "\nSố lượng:9  " +
                       "\nThẻ thành viên: Có"
                       , "Dịch vụ khách hàng đã sử dụng",
                       MessageBoxButtons.OK);
                    break;
                case "19":
                    MessageBox.Show("Tên:Whisky Sour,BK53,Sparta Lamborghini ( Set 3 Glass),Camel Caster " +
                       "\nSố lượng:10" +
                       "\nThẻ thành viên: Không"
                       , "Dịch vụ khách hàng đã sử dụng",
                       MessageBoxButtons.OK);
                    break;
                case "20":
                    MessageBox.Show("Tên:Beer Bubweise Mỹ,Reserver Bordeaux ( Vang Pháp),Beer Tiger Crystal,Falo Negroamaro( Vang Ý),Beer Trúc Bạch" +
                       "\nSố lượng:12  " +
                       "\nThẻ thành viên: Có"
                       , "Dịch vụ khách hàng đã sử dụng",
                       MessageBoxButtons.OK);
                    break;
                case "21":
                    MessageBox.Show("Tên:Beer Bubweise Mỹ,Camel Caster,Red Bull, Pespsi,Falo Negroamaro( Vang Ý),Camel Caster " +
                       "\nSố lượng:11  " +
                       "\nThẻ thành viên: Có"
                       , "Dịch vụ khách hàng đã sử dụng",
                       MessageBoxButtons.OK);
                    break;
                case "22":
                    MessageBox.Show("Tên:BK52,Trà Mạn( Ấm),Camel Caster " +
                       "\nSố lượng:5  " +
                       "\nThẻ thành viên: Không"
                       , "Dịch vụ khách hàng đã sử dụng",
                       MessageBoxButtons.OK);
                    break;
                case "23":
                    MessageBox.Show("Tên:Whisky Sour,BK53,Sparta Lamborghini ( Set 3 Glass),Reserver Bordeaux ( Vang Pháp) " +
                       "\nSố lượng:8" +
                       "\nThẻ thành viên: Có"
                       , "Dịch vụ khách hàng đã sử dụng",
                       MessageBoxButtons.OK);
                    break;
                case "24":
                    MessageBox.Show("Tên:Reserver Bordeaux ( Vang Pháp),Beer Tiger Crystal,Falo Negroamaro( Vang Ý),J.P Chenet Fashion (Strawberry of Apple) " +
                       "\nSố lượng:10  " +
                       "\nThẻ thành viên: Không"
                       , "Dịch vụ khách hàng đã sử dụng",
                       MessageBoxButtons.OK);
                    break;

            }*/
             
      
        }
    }
}