
namespace QL_bar
{
    partial class frmLogin
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
            this.btnqmk = new System.Windows.Forms.Button();
            this.btndn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.txttk = new System.Windows.Forms.TextBox();
            this.lbmk = new System.Windows.Forms.Label();
            this.lbtk = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnqmk
            // 
            this.btnqmk.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnqmk.Location = new System.Drawing.Point(776, 555);
            this.btnqmk.Name = "btnqmk";
            this.btnqmk.Size = new System.Drawing.Size(195, 54);
            this.btnqmk.TabIndex = 20;
            this.btnqmk.Text = "Quên Mật Khẩu";
            this.btnqmk.UseVisualStyleBackColor = false;
            this.btnqmk.Click += new System.EventHandler(this.btnqmk_Click);
            // 
            // btndn
            // 
            this.btndn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btndn.Location = new System.Drawing.Point(402, 555);
            this.btndn.Name = "btndn";
            this.btndn.Size = new System.Drawing.Size(195, 54);
            this.btndn.TabIndex = 19;
            this.btndn.Text = "Đăng Nhập";
            this.btndn.UseVisualStyleBackColor = false;
            this.btndn.Click += new System.EventHandler(this.btndn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.Window;
            this.checkBox1.Location = new System.Drawing.Point(428, 427);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(188, 31);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Nhớ mật khẩu";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtmk
            // 
            this.txtmk.BackColor = System.Drawing.SystemColors.Window;
            this.txtmk.Location = new System.Drawing.Point(635, 348);
            this.txtmk.Name = "txtmk";
            this.txtmk.PasswordChar = '*';
            this.txtmk.Size = new System.Drawing.Size(275, 34);
            this.txtmk.TabIndex = 15;
            // 
            // txttk
            // 
            this.txttk.BackColor = System.Drawing.SystemColors.Window;
            this.txttk.Location = new System.Drawing.Point(635, 273);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(275, 34);
            this.txttk.TabIndex = 13;
            // 
            // lbmk
            // 
            this.lbmk.AutoSize = true;
            this.lbmk.BackColor = System.Drawing.SystemColors.Window;
            this.lbmk.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbmk.Location = new System.Drawing.Point(423, 348);
            this.lbmk.Name = "lbmk";
            this.lbmk.Size = new System.Drawing.Size(111, 27);
            this.lbmk.TabIndex = 18;
            this.lbmk.Text = "Mật khẩu";
            // 
            // lbtk
            // 
            this.lbtk.AutoSize = true;
            this.lbtk.BackColor = System.Drawing.SystemColors.Window;
            this.lbtk.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbtk.Location = new System.Drawing.Point(423, 278);
            this.lbtk.Name = "lbtk";
            this.lbtk.Size = new System.Drawing.Size(117, 27);
            this.lbtk.TabIndex = 16;
            this.lbtk.Text = "Tài khoản";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(434, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(625, 69);
            this.label1.TabIndex = 14;
            this.label1.Text = "Đăng Nhập Hệ Thống";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btndn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QL_bar.Properties.Resources.quan_bar_o_dubai_white_dubai;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 731);
            this.Controls.Add(this.btnqmk);
            this.Controls.Add(this.btndn);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.txttk);
            this.Controls.Add(this.lbmk);
            this.Controls.Add(this.lbtk);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnqmk;
        private System.Windows.Forms.Button btndn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.Label lbmk;
        private System.Windows.Forms.Label lbtk;
        private System.Windows.Forms.Label label1;
    }
}