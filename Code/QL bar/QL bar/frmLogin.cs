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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btndn_Click(object sender, EventArgs e)
        {
            try
            {
                //tạo kết nối
                String con_str = "Data Source=DESKTOP-K54RFCM\\SQLEXPRESS; Initial Catalog=QL_Bar; User ID=sa; Password=123456";
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();
                // truy vấn
                String tk = txttk.Text;
                String mk = txtmk.Text;
                String query = "  Select COUNT(*) from [Nguoi dung] where Taikhoan= @tk and Matkhau= @mk";
                // thực thi câu lệnh truy vấn
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@tk", tk));
                cmd.Parameters.Add(new SqlParameter("@mk", mk));
                // lựa chonnjphuowng thức thực thi phù hợp
                int SoLuong = (int)cmd.ExecuteScalar();
                conn.Close();

                if (SoLuong == 1)
                {
                    MessageBox.Show("Đăng nhập thành công !");
                    this.Hide();
                  
                    frmHethong ht = new frmHethong();
                    ht.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }

        private void btnqmk_Click(object sender, EventArgs e)
        {
            frmquenmk qmk = new frmquenmk();
            qmk.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(txttk.Text !="" && txtmk.Text != "")
            {
                if (checkBox1.Checked == true)
                {
                    string tk = txttk.Text;
                    string mk = txtmk.Text;
                    Properties.Settings.Default.Taikhoan = tk;
                    Properties.Settings.Default.Matkhau = mk;
                    Properties.Settings.Default.Save();

                }
                else
                {
                    Properties.Settings.Default.Reset();
                }
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txttk.Text = Properties.Settings.Default.Taikhoan;
            txtmk.Text = Properties.Settings.Default.Matkhau;
            if(Properties.Settings.Default.Taikhoan !="")
            {
                checkBox1.Checked = true;
            }
           
        }

      
    }
}
