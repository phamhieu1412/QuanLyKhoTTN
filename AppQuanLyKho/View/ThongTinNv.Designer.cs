namespace AppQuanLyKho.View
{
    partial class ThongTinNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinNV));
            this.lable1 = new System.Windows.Forms.Label();
            this.NV_TenDN = new System.Windows.Forms.Label();
            this.NV_Email = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NV_SDT = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NV_HoTen = new System.Windows.Forms.Label();
            this.lable2 = new System.Windows.Forms.Label();
            this.NV_DiaChi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NV_Admin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(24, 26);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(81, 13);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "Tên đăng nhập";
            // 
            // NV_TenDN
            // 
            this.NV_TenDN.AutoSize = true;
            this.NV_TenDN.Location = new System.Drawing.Point(124, 26);
            this.NV_TenDN.Name = "NV_TenDN";
            this.NV_TenDN.Size = new System.Drawing.Size(16, 13);
            this.NV_TenDN.TabIndex = 1;
            this.NV_TenDN.Text = "...";
            // 
            // NV_Email
            // 
            this.NV_Email.AutoSize = true;
            this.NV_Email.Location = new System.Drawing.Point(124, 101);
            this.NV_Email.Name = "NV_Email";
            this.NV_Email.Size = new System.Drawing.Size(16, 13);
            this.NV_Email.TabIndex = 3;
            this.NV_Email.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email";
            // 
            // NV_SDT
            // 
            this.NV_SDT.AutoSize = true;
            this.NV_SDT.Location = new System.Drawing.Point(124, 76);
            this.NV_SDT.Name = "NV_SDT";
            this.NV_SDT.Size = new System.Drawing.Size(16, 13);
            this.NV_SDT.TabIndex = 5;
            this.NV_SDT.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số điện thoại";
            // 
            // NV_HoTen
            // 
            this.NV_HoTen.AutoSize = true;
            this.NV_HoTen.Location = new System.Drawing.Point(124, 51);
            this.NV_HoTen.Name = "NV_HoTen";
            this.NV_HoTen.Size = new System.Drawing.Size(16, 13);
            this.NV_HoTen.TabIndex = 7;
            this.NV_HoTen.Text = "...";
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Location = new System.Drawing.Point(24, 51);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(39, 13);
            this.lable2.TabIndex = 6;
            this.lable2.Text = "Họ tên";
            // 
            // NV_DiaChi
            // 
            this.NV_DiaChi.AutoSize = true;
            this.NV_DiaChi.Location = new System.Drawing.Point(124, 126);
            this.NV_DiaChi.Name = "NV_DiaChi";
            this.NV_DiaChi.Size = new System.Drawing.Size(16, 13);
            this.NV_DiaChi.TabIndex = 9;
            this.NV_DiaChi.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Địa chỉ";
            // 
            // NV_Admin
            // 
            this.NV_Admin.Location = new System.Drawing.Point(186, 4);
            this.NV_Admin.Name = "NV_Admin";
            this.NV_Admin.ReadOnly = true;
            this.NV_Admin.Size = new System.Drawing.Size(100, 20);
            this.NV_Admin.TabIndex = 11;
            // 
            // ThongTinNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 159);
            this.Controls.Add(this.NV_Admin);
            this.Controls.Add(this.NV_DiaChi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NV_HoTen);
            this.Controls.Add(this.lable2);
            this.Controls.Add(this.NV_SDT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NV_Email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NV_TenDN);
            this.Controls.Add(this.lable1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThongTinNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin cá nhân";
            this.Load += new System.EventHandler(this.ThongTinNV_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ThongTinNV_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ThongTinNV_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label NV_TenDN;
        private System.Windows.Forms.Label NV_Email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label NV_SDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label NV_HoTen;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.Label NV_DiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NV_Admin;
    }
}