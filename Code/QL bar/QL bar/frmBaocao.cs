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
    public partial class frmBaocao : Form
    {
        public frmBaocao()
        {
            InitializeComponent();
        }

        private void frmBaocao_Load(object sender, EventArgs e)
        {
            getData();
            getcmb();
            timer1.Enabled = true;
           
            
        }
        public void getcmb()
        {
            List<Model.Baocao> lst = new List<Model.Baocao>();
            try
            {
                String con_str = "Data Source=DESKTOP-K54RFCM\\SQLEXPRESS; Initial Catalog=QL_Bar;User ID=sa; Password=123456";
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();
                String query = "Select * from Baocao";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    Model.Baocao obj = new Model.Baocao(rd);
                    lst.Add(obj);
                }
                conn.Close();
                cmbloaibc.DataSource = lst;
                //displaymember xác định kiểu duex liệu nà được hiển thị lên
                cmbloaibc.DisplayMember = "LoaiBC";
                // values member : giá trị ánh xạ 
                cmbloaibc.ValueMember = "LoaiBC";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
            }
        }
        public void getData()
        {
            List<Model.Baocao> lst = new List<Model.Baocao>();
            try
            {
                String con_str = "Data Source=DESKTOP-K54RFCM\\SQLEXPRESS; Initial Catalog=QL_Bar;User ID=sa; Password=123456";
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();
                String query = "Select * from Baocao";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    Model.Baocao obj = new Model.Baocao(rd);
                    lst.Add(obj);
                }
                conn.Close();
                dgvbc.DataSource = lst;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
            }
        }        

        private void cmbloaibc_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Model.Baocao> lst = new List<Model.Baocao>();
            try
            {
                String con_str = "Data Source=DESKTOP-K54RFCM\\SQLEXPRESS ; Initial Catalog=QL_Bar; User ID=sa; Password=123456";
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();
                string tk = cmbloaibc.Text;
                string query = "select * from Baocao where LoaiBC = @LoaiBC";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@LoaiBC", tk));
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    Model.Baocao obj = new Model.Baocao(rd);
                    lst.Add(obj);
                }
                conn.Close();
                dgvbc.DataSource = lst;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
            }
        }

        private void btnxuatfile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ToExcel(dgvbc, saveFileDialog1.FileName);
            }
        }
        private void ToExcel(DataGridView dataGridView1, string fileName)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;

            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;

                workbook = excel.Workbooks.Add(Type.Missing);

                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                worksheet.Name = "Báo cáo thống kê";

                // export header
                for (int i = 0; i < dgvbc.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dgvbc.Columns[i].HeaderText;
                }

                // export content
                for (int i = 0; i < dgvbc.RowCount; i++)
                {
                    for (int j = 0; j < dgvbc.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgvbc.Rows[i].Cells[j].Value.ToString();
                    }
                }

                // save workbook
                workbook.SaveAs(fileName);
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất file thành công!" +
                    "\n❤❤Chúc bạn có một ngày vui vẻ❤❤", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbtime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
