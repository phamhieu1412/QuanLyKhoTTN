namespace AppQuanLyKho
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
            this.tbMKHienTai = new System.Windows.Forms.TextBox();
            this.tbMKMoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMKMoi1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu hiện tại";
            // 
            // tbMKHienTai
            // 
            this.tbMKHienTai.Location = new System.Drawing.Point(175, 17);
            this.tbMKHienTai.Name = "tbMKHienTai";
            this.tbMKHienTai.Size = new System.Drawing.Size(128, 20);
            this.tbMKHienTai.TabIndex = 1;
            // 
            // tbMKMoi
            // 
            this.tbMKMoi.Location = new System.Drawing.Point(175, 47);
            this.tbMKMoi.Name = "tbMKMoi";
            this.tbMKMoi.Size = new System.Drawing.Size(128, 20);
            this.tbMKMoi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu mới";
            // 
            // tbMKMoi1
            // 
            this.tbMKMoi1.Location = new System.Drawing.Point(175, 77);
            this.tbMKMoi1.Name = "tbMKMoi1";
            this.tbMKMoi1.Size = new System.Drawing.Size(128, 20);
            this.tbMKMoi1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhập lại mật khẩu mới";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(175, 106);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(75, 23);
            this.btnXacNhan.TabIndex = 6;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 141);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.tbMKMoi1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMKMoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMKHienTai);
            this.Controls.Add(this.label1);
            this.Name = "DoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMKHienTai;
        private System.Windows.Forms.TextBox tbMKMoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMKMoi1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXacNhan;
    }
}