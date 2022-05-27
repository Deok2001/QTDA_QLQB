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
    public partial class frmquenmk : Form
    {
        public frmquenmk()
        {
            InitializeComponent();
        }
        public void clearText()
        {
            txtsdt.Text = "";
        }
        private void btnsend_Click(object sender, EventArgs e)
        {
            List<Model.quenmk> lst = new List<Model.quenmk>();
            try
            {
                String con_str = "Data Source=DESKTOP-K54RFCM\\SQLEXPRESS ; Initial Catalog=QL_Bar; User ID=sa; Password=123456";
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();
                string tk = txtsdt.Text;

                string query1 = "Select count(*) from QLNV where SoDT=@SoDT";
                SqlCommand cmd1 = new SqlCommand(query1, conn);
                cmd1.Parameters.Add(new SqlParameter("@SoDT", tk));
                int sol = (int)cmd1.ExecuteScalar();
                if (sol == 1)
                {
                    string query = "select * from QLNV where SoDT Like '%'+@tk+'%'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.Add(new SqlParameter("@tk", tk));
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        Model.quenmk obj = new Model.quenmk(rd);
                        lst.Add(obj);
                    }
                    MessageBox.Show("Vui lòng chờ trong giây lát");
                    this.DialogResult = DialogResult.OK;
                    
                    this.Close();
                    ;
                }
                else
                {
                    MessageBox.Show("Số điện thoại không hợp lệ");
                    clearText();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
            }
        }

        private void frmquenmk_Load(object sender, EventArgs e)
        {

        }
    }
}
