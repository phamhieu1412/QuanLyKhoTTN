namespace AppQuanLyKho.View
{
    partial class NhapSanPham
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxNSX = new System.Windows.Forms.TextBox();
            this.textBoxDonGia = new System.Windows.Forms.TextBox();
            this.textBoxMaSP = new System.Windows.Forms.TextBox();
            this.textBoxTensp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxPhanLoai = new System.Windows.Forms.ComboBox();
            this.textBoxDonViTinh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Thêm sản phẩm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxNSX
            // 
            this.textBoxNSX.Location = new System.Drawing.Point(115, 77);
            this.textBoxNSX.Name = "textBoxNSX";
            this.textBoxNSX.Size = new System.Drawing.Size(130, 20);
            this.textBoxNSX.TabIndex = 3;
            // 
            // textBoxDonGia
            // 
            this.textBoxDonGia.Location = new System.Drawing.Point(372, 77);
            this.textBoxDonGia.Name = "textBoxDonGia";
            this.textBoxDonGia.Size = new System.Drawing.Size(130, 20);
            this.textBoxDonGia.TabIndex = 4;
            // 
            // textBoxMaSP
            // 
            this.textBoxMaSP.Location = new System.Drawing.Point(115, 28);
            this.textBoxMaSP.Name = "textBoxMaSP";
            this.textBoxMaSP.Size = new System.Drawing.Size(130, 20);
            this.textBoxMaSP.TabIndex = 1;
            // 
            // textBoxTensp
            // 
            this.textBoxTensp.Location = new System.Drawing.Point(372, 28);
            this.textBoxTensp.Name = "textBoxTensp";
            this.textBoxTensp.Size = new System.Drawing.Size(130, 20);
            this.textBoxTensp.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã sản phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nước sản xuất:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phân loại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tên sản phẩm:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Đơn giá:";
            // 
            // comboBoxPhanLoai
            // 
            this.comboBoxPhanLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPhanLoai.FormattingEnabled = true;
            this.comboBoxPhanLoai.Location = new System.Drawing.Point(115, 125);
            this.comboBoxPhanLoai.Name = "comboBoxPhanLoai";
            this.comboBoxPhanLoai.Size = new System.Drawing.Size(130, 21);
            this.comboBoxPhanLoai.TabIndex = 5;
            this.comboBoxPhanLoai.SelectedIndexChanged += new System.EventHandler(this.comboBoxPhanLoai_SelectedIndexChanged);
            // 
            // textBoxDonViTinh
            // 
            this.textBoxDonViTinh.Location = new System.Drawing.Point(372, 125);
            this.textBoxDonViTinh.Name = "textBoxDonViTinh";
            this.textBoxDonViTinh.Size = new System.Drawing.Size(130, 20);
            this.textBoxDonViTinh.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Đơn vị tính:";
            // 
            // NhapSanPham
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 226);
            this.Controls.Add(this.comboBoxPhanLoai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTensp);
            this.Controls.Add(this.textBoxMaSP);
            this.Controls.Add(this.textBoxDonViTinh);
            this.Controls.Add(this.textBoxDonGia);
            this.Controls.Add(this.textBoxNSX);
            this.Controls.Add(this.button1);
            this.Name = "NhapSanPham";
            this.Text = "Nhap San Pham";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxNSX;
        private System.Windows.Forms.TextBox textBoxDonGia;
        private System.Windows.Forms.TextBox textBoxMaSP;
        private System.Windows.Forms.TextBox textBoxTensp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxPhanLoai;
        private System.Windows.Forms.TextBox textBoxDonViTinh;
        private System.Windows.Forms.Label label4;
    }
}