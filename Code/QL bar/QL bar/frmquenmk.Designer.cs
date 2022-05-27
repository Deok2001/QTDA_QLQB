
namespace QL_bar
{
    partial class frmquenmk
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.btnsend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vui lòng nhập số điện thoại khôi phục : \r\n";
            // 
            // txtsdt
            // 
            this.txtsdt.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsdt.Location = new System.Drawing.Point(72, 198);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(275, 34);
            this.txtsdt.TabIndex = 1;
            // 
            // btnsend
            // 
            this.btnsend.BackColor = System.Drawing.Color.Chocolate;
            this.btnsend.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsend.Location = new System.Drawing.Point(364, 187);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(140, 55);
            this.btnsend.TabIndex = 2;
            this.btnsend.Text = "Gửi mã";
            this.btnsend.UseVisualStyleBackColor = false;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // frmquenmk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(572, 450);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.label1);
            this.Name = "frmquenmk";
            this.Text = "QuênMK";
            this.Load += new System.EventHandler(this.frmquenmk_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Button btnsend;
    }
}