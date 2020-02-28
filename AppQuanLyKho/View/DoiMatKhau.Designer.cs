namespace AppQuanLyKho.View
{
    partial class DoiMatKhau
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
            this.txtMKHienTai = new System.Windows.Forms.TextBox();
            this.txtMKMoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMKMoi1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu hiện tại";
            // 
            // txtMKHienTai
            // 
            this.txtMKHienTai.Location = new System.Drawing.Point(228, 54);
            this.txtMKHienTai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMKHienTai.Name = "txtMKHienTai";
            this.txtMKHienTai.ReadOnly = true;
            this.txtMKHienTai.Size = new System.Drawing.Size(211, 26);
            this.txtMKHienTai.TabIndex = 1;
            // 
            // txtMKMoi
            // 
            this.txtMKMoi.Location = new System.Drawing.Point(228, 100);
            this.txtMKMoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMKMoi.Name = "txtMKMoi";
            this.txtMKMoi.Size = new System.Drawing.Size(211, 26);
            this.txtMKMoi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu mới";
            // 
            // txtMKMoi1
            // 
            this.txtMKMoi1.Location = new System.Drawing.Point(228, 146);
            this.txtMKMoi1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMKMoi1.Name = "txtMKMoi1";
            this.txtMKMoi1.Size = new System.Drawing.Size(211, 26);
            this.txtMKMoi1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhập lại mật khẩu mới";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(228, 191);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(102, 35);
            this.btnXacNhan.TabIndex = 3;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.BtnXacNhan_Click);
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(228, 14);
            this.txtTenDN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.ReadOnly = true;
            this.txtTenDN.Size = new System.Drawing.Size(211, 26);
            this.txtTenDN.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tên đăng nhập";
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 240);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenDN);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txtMKMoi1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMKMoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMKHienTai);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.DoiMatKhau_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DoiMatKhau_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMKHienTai;
        private System.Windows.Forms.TextBox txtMKMoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMKMoi1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.Label label4;
    }
}