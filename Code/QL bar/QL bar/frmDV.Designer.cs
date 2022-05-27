
namespace QL_bar
{
    partial class frmDV
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
            this.lbtt = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvdv = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbtien = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttendv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cmbkh = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdv)).BeginInit();
            this.SuspendLayout();
            // 
            // lbtt
            // 
            this.lbtt.AutoSize = true;
            this.lbtt.Location = new System.Drawing.Point(716, 311);
            this.lbtt.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbtt.Name = "lbtt";
            this.lbtt.Size = new System.Drawing.Size(0, 27);
            this.lbtt.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvdv);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 268);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(1024, 330);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin dịch vụ";
            // 
            // dgvdv
            // 
            this.dgvdv.AllowUserToAddRows = false;
            this.dgvdv.AllowUserToDeleteRows = false;
            this.dgvdv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvdv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenDV,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien});
            this.dgvdv.Location = new System.Drawing.Point(9, 35);
            this.dgvdv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvdv.Name = "dgvdv";
            this.dgvdv.ReadOnly = true;
            this.dgvdv.RowHeadersWidth = 51;
            this.dgvdv.RowTemplate.Height = 24;
            this.dgvdv.Size = new System.Drawing.Size(1006, 287);
            this.dgvdv.TabIndex = 0;
            this.dgvdv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdv_CellClick);
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            this.MaKH.Width = 150;
            // 
            // TenDV
            // 
            this.TenDV.DataPropertyName = "TenDV";
            this.TenDV.HeaderText = "Tên DV";
            this.TenDV.MinimumWidth = 6;
            this.TenDV.Name = "TenDV";
            this.TenDV.ReadOnly = true;
            this.TenDV.Width = 280;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 160;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            this.DonGia.Width = 160;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            this.ThanhTien.Width = 200;
            // 
            // lbtien
            // 
            this.lbtien.AutoSize = true;
            this.lbtien.Location = new System.Drawing.Point(1021, 370);
            this.lbtien.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbtien.Name = "lbtien";
            this.lbtien.Size = new System.Drawing.Size(0, 27);
            this.lbtien.TabIndex = 3;
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.Lime;
            this.btnthem.Location = new System.Drawing.Point(442, 208);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(142, 52);
            this.btnthem.TabIndex = 4;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(773, 144);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(156, 34);
            this.txtdongia.TabIndex = 3;
            this.txtdongia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(606, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 27);
            this.label6.TabIndex = 21;
            this.label6.Text = "Đơn giá";
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(773, 79);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(156, 34);
            this.txtsoluong.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(606, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 27);
            this.label5.TabIndex = 22;
            this.label5.Text = "Số Lượng";
            // 
            // txttendv
            // 
            this.txttendv.Location = new System.Drawing.Point(215, 137);
            this.txttendv.Name = "txttendv";
            this.txttendv.Size = new System.Drawing.Size(156, 34);
            this.txttendv.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 27);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tên DV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 27);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mã KH";
            // 
            // cmbkh
            // 
            this.cmbkh.FormattingEnabled = true;
            this.cmbkh.Location = new System.Drawing.Point(215, 80);
            this.cmbkh.Name = "cmbkh";
            this.cmbkh.Size = new System.Drawing.Size(156, 34);
            this.cmbkh.TabIndex = 0;
            this.cmbkh.SelectedIndexChanged += new System.EventHandler(this.cmbkh_SelectedIndexChanged);
            // 
            // frmDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1066, 602);
            this.Controls.Add(this.cmbkh);
            this.Controls.Add(this.txtdongia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttendv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.lbtien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbtt);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmDV";
            this.Text = "Dịch Vụ";
            this.Load += new System.EventHandler(this.frmDV_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbtt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvdv;
        private System.Windows.Forms.Label lbtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttendv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmbkh;
    }
}