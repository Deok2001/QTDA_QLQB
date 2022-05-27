
namespace QL_bar
{
    partial class frmBaocao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.cmbloaibc = new System.Windows.Forms.ComboBox();
            this.dgvbc = new System.Windows.Forms.DataGridView();
            this.MaBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnxuatfile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.lbtime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbc)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(193, 109);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(229, 34);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(491, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tổng Quan Về Báo Cáo";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnlammoi);
            this.groupBox1.Controls.Add(this.cmbloaibc);
            this.groupBox1.Controls.Add(this.dgvbc);
            this.groupBox1.Controls.Add(this.btnxuatfile);
            this.groupBox1.Location = new System.Drawing.Point(19, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1278, 497);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doanh thu của quán";
            // 
            // btnlammoi
            // 
            this.btnlammoi.BackColor = System.Drawing.Color.GreenYellow;
            this.btnlammoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlammoi.Location = new System.Drawing.Point(6, 40);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(165, 48);
            this.btnlammoi.TabIndex = 0;
            this.btnlammoi.Text = "Làm Mới";
            this.btnlammoi.UseVisualStyleBackColor = false;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // cmbloaibc
            // 
            this.cmbloaibc.BackColor = System.Drawing.SystemColors.Window;
            this.cmbloaibc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbloaibc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbloaibc.FormattingEnabled = true;
            this.cmbloaibc.Location = new System.Drawing.Point(204, 48);
            this.cmbloaibc.Name = "cmbloaibc";
            this.cmbloaibc.Size = new System.Drawing.Size(121, 34);
            this.cmbloaibc.TabIndex = 1;
            this.cmbloaibc.SelectedIndexChanged += new System.EventHandler(this.cmbloaibc_SelectedIndexChanged);
            // 
            // dgvbc
            // 
            this.dgvbc.AllowUserToAddRows = false;
            this.dgvbc.AllowUserToDeleteRows = false;
            this.dgvbc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvbc.BackgroundColor = System.Drawing.Color.Wheat;
            this.dgvbc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBC,
            this.LoaiBC,
            this.NgayBC,
            this.SoLuongDV,
            this.DoanhThu,
            this.MaNV});
            this.dgvbc.Location = new System.Drawing.Point(7, 105);
            this.dgvbc.Name = "dgvbc";
            this.dgvbc.ReadOnly = true;
            this.dgvbc.RowHeadersWidth = 51;
            this.dgvbc.RowTemplate.Height = 24;
            this.dgvbc.Size = new System.Drawing.Size(1265, 386);
            this.dgvbc.TabIndex = 1;
            // 
            // MaBC
            // 
            this.MaBC.DataPropertyName = "MaBC";
            this.MaBC.HeaderText = "Mã Báo Cáo";
            this.MaBC.MinimumWidth = 6;
            this.MaBC.Name = "MaBC";
            this.MaBC.ReadOnly = true;
            this.MaBC.Width = 180;
            // 
            // LoaiBC
            // 
            this.LoaiBC.DataPropertyName = "LoaiBC";
            this.LoaiBC.HeaderText = "Loại Báo Cáo";
            this.LoaiBC.MinimumWidth = 6;
            this.LoaiBC.Name = "LoaiBC";
            this.LoaiBC.ReadOnly = true;
            this.LoaiBC.Width = 200;
            // 
            // NgayBC
            // 
            this.NgayBC.DataPropertyName = "NgayBC";
            this.NgayBC.HeaderText = "Ngày Báo Cáo";
            this.NgayBC.MinimumWidth = 6;
            this.NgayBC.Name = "NgayBC";
            this.NgayBC.ReadOnly = true;
            this.NgayBC.Width = 200;
            // 
            // SoLuongDV
            // 
            this.SoLuongDV.DataPropertyName = "SoLuongDV";
            this.SoLuongDV.HeaderText = "Số Lượng Dịch Vụ";
            this.SoLuongDV.MinimumWidth = 6;
            this.SoLuongDV.Name = "SoLuongDV";
            this.SoLuongDV.ReadOnly = true;
            this.SoLuongDV.Width = 250;
            // 
            // DoanhThu
            // 
            this.DoanhThu.DataPropertyName = "DoanhThu";
            this.DoanhThu.HeaderText = "Doanh Thu";
            this.DoanhThu.MinimumWidth = 6;
            this.DoanhThu.Name = "DoanhThu";
            this.DoanhThu.ReadOnly = true;
            this.DoanhThu.Width = 180;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            this.MaNV.Width = 200;
            // 
            // btnxuatfile
            // 
            this.btnxuatfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnxuatfile.BackColor = System.Drawing.Color.Coral;
            this.btnxuatfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnxuatfile.Location = new System.Drawing.Point(1010, 24);
            this.btnxuatfile.Name = "btnxuatfile";
            this.btnxuatfile.Size = new System.Drawing.Size(253, 58);
            this.btnxuatfile.TabIndex = 2;
            this.btnxuatfile.Text = "Xuất File Excel";
            this.btnxuatfile.UseVisualStyleBackColor = false;
            this.btnxuatfile.Click += new System.EventHandler(this.btnxuatfile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hôm nay :   ";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Excel Workbook|*.xlsx|Excel 2007|*.xlsx";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Thời gian : ";
            // 
            // lbtime
            // 
            this.lbtime.AutoSize = true;
            this.lbtime.Location = new System.Drawing.Point(188, 160);
            this.lbtime.Name = "lbtime";
            this.lbtime.Size = new System.Drawing.Size(57, 27);
            this.lbtime.TabIndex = 7;
            this.lbtime.Text = "time";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmBaocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1309, 757);
            this.Controls.Add(this.lbtime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmBaocao";
            this.Text = "Báo cáo thống kê";
            this.Load += new System.EventHandler(this.frmBaocao_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnxuatfile;
        private System.Windows.Forms.DataGridView dgvbc;
        private System.Windows.Forms.ComboBox cmbloaibc;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbtime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
    }
}