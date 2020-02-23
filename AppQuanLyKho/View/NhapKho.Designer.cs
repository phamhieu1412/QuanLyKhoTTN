namespace AppQuanLyKho.View
{
    partial class NhapKho
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
            this.btnLuu = new System.Windows.Forms.Button();
            this.tbTongTien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewSanPham = new System.Windows.Forms.DataGridView();
            this.gbDSSP = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.tbTenNV = new System.Windows.Forms.TextBox();
            this.tbMaPN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDonGia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSoLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMaNCC = new System.Windows.Forms.TextBox();
            this.comboBoxTenNCC = new System.Windows.Forms.ComboBox();
            this.comboBoxNCC = new System.Windows.Forms.ComboBox();
            this.comboBoxTenSP = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gbTTSP = new System.Windows.Forms.GroupBox();
            this.textBoxDVT = new System.Windows.Forms.TextBox();
            this.textBoxLoai = new System.Windows.Forms.TextBox();
            this.textBoxNSX = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanPham)).BeginInit();
            this.gbDSSP.SuspendLayout();
            this.gbTTSP.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(259, 485);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 29;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.BtnLuu_Click);
            // 
            // tbTongTien
            // 
            this.tbTongTien.Location = new System.Drawing.Point(549, 465);
            this.tbTongTien.Name = "tbTongTien";
            this.tbTongTien.ReadOnly = true;
            this.tbTongTien.Size = new System.Drawing.Size(100, 20);
            this.tbTongTien.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(491, 468);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Tổng tiền";
            // 
            // dataGridViewSanPham
            // 
            this.dataGridViewSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSanPham.Location = new System.Drawing.Point(19, 29);
            this.dataGridViewSanPham.Name = "dataGridViewSanPham";
            this.dataGridViewSanPham.Size = new System.Drawing.Size(566, 150);
            this.dataGridViewSanPham.TabIndex = 0;
            this.dataGridViewSanPham.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewSanPham_RowHeaderMouseClick);
            // 
            // gbDSSP
            // 
            this.gbDSSP.Controls.Add(this.dataGridViewSanPham);
            this.gbDSSP.Location = new System.Drawing.Point(47, 277);
            this.gbDSSP.Name = "gbDSSP";
            this.gbDSSP.Size = new System.Drawing.Size(602, 179);
            this.gbDSSP.TabIndex = 26;
            this.gbDSSP.TabStop = false;
            this.gbDSSP.Text = "danh sách sản phẩm";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(355, 485);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 30;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // tbTenNV
            // 
            this.tbTenNV.Location = new System.Drawing.Point(574, 12);
            this.tbTenNV.Name = "tbTenNV";
            this.tbTenNV.ReadOnly = true;
            this.tbTenNV.Size = new System.Drawing.Size(100, 20);
            this.tbTenNV.TabIndex = 24;
            // 
            // tbMaPN
            // 
            this.tbMaPN.Location = new System.Drawing.Point(61, 12);
            this.tbMaPN.Name = "tbMaPN";
            this.tbMaPN.ReadOnly = true;
            this.tbMaPN.Size = new System.Drawing.Size(100, 20);
            this.tbMaPN.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Mã PN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(262, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 33);
            this.label1.TabIndex = 21;
            this.label1.Text = "Phiếu Nhập Kho";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "SL Nhập";
            // 
            // textBoxDonGia
            // 
            this.textBoxDonGia.Location = new System.Drawing.Point(99, 52);
            this.textBoxDonGia.Name = "textBoxDonGia";
            this.textBoxDonGia.Size = new System.Drawing.Size(134, 20);
            this.textBoxDonGia.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Đơn giá nhập";
            // 
            // textBoxSoLuong
            // 
            this.textBoxSoLuong.Location = new System.Drawing.Point(99, 82);
            this.textBoxSoLuong.Name = "textBoxSoLuong";
            this.textBoxSoLuong.Size = new System.Drawing.Size(134, 20);
            this.textBoxSoLuong.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mã ĐVT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nước Sản Xuất";
            // 
            // textBoxMaNCC
            // 
            this.textBoxMaNCC.Location = new System.Drawing.Point(385, 52);
            this.textBoxMaNCC.Name = "textBoxMaNCC";
            this.textBoxMaNCC.Size = new System.Drawing.Size(199, 20);
            this.textBoxMaNCC.TabIndex = 10;
            // 
            // comboBoxTenNCC
            // 
            this.comboBoxTenNCC.FormattingEnabled = true;
            this.comboBoxTenNCC.Location = new System.Drawing.Point(99, 112);
            this.comboBoxTenNCC.Name = "comboBoxTenNCC";
            this.comboBoxTenNCC.Size = new System.Drawing.Size(134, 21);
            this.comboBoxTenNCC.TabIndex = 12;
            // 
            // comboBoxNCC
            // 
            this.comboBoxNCC.FormattingEnabled = true;
            this.comboBoxNCC.Location = new System.Drawing.Point(99, 22);
            this.comboBoxNCC.Name = "comboBoxNCC";
            this.comboBoxNCC.Size = new System.Drawing.Size(134, 21);
            this.comboBoxNCC.TabIndex = 13;
            this.comboBoxNCC.SelectedIndexChanged += new System.EventHandler(this.ComboBoxNCC_SelectedIndexChanged);
            // 
            // comboBoxTenSP
            // 
            this.comboBoxTenSP.FormattingEnabled = true;
            this.comboBoxTenSP.Location = new System.Drawing.Point(385, 22);
            this.comboBoxTenSP.Name = "comboBoxTenSP";
            this.comboBoxTenSP.Size = new System.Drawing.Size(199, 21);
            this.comboBoxTenSP.TabIndex = 14;
            this.comboBoxTenSP.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTenSP_SelectedIndexChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(212, 155);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(308, 155);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Mã NCC";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(293, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Mã Sản Phẩm";
            // 
            // gbTTSP
            // 
            this.gbTTSP.Controls.Add(this.textBoxNSX);
            this.gbTTSP.Controls.Add(this.textBoxDVT);
            this.gbTTSP.Controls.Add(this.textBoxLoai);
            this.gbTTSP.Controls.Add(this.label10);
            this.gbTTSP.Controls.Add(this.label8);
            this.gbTTSP.Controls.Add(this.btnSua);
            this.gbTTSP.Controls.Add(this.btnThem);
            this.gbTTSP.Controls.Add(this.comboBoxTenSP);
            this.gbTTSP.Controls.Add(this.comboBoxNCC);
            this.gbTTSP.Controls.Add(this.comboBoxTenNCC);
            this.gbTTSP.Controls.Add(this.textBoxMaNCC);
            this.gbTTSP.Controls.Add(this.label6);
            this.gbTTSP.Controls.Add(this.label5);
            this.gbTTSP.Controls.Add(this.textBoxSoLuong);
            this.gbTTSP.Controls.Add(this.label4);
            this.gbTTSP.Controls.Add(this.textBoxDonGia);
            this.gbTTSP.Controls.Add(this.label3);
            this.gbTTSP.Location = new System.Drawing.Point(47, 83);
            this.gbTTSP.Name = "gbTTSP";
            this.gbTTSP.Size = new System.Drawing.Size(602, 188);
            this.gbTTSP.TabIndex = 25;
            this.gbTTSP.TabStop = false;
            this.gbTTSP.Text = "Thông tin sản phẩm";
            // 
            // textBoxDVT
            // 
            this.textBoxDVT.Location = new System.Drawing.Point(395, 115);
            this.textBoxDVT.Name = "textBoxDVT";
            this.textBoxDVT.Size = new System.Drawing.Size(134, 20);
            this.textBoxDVT.TabIndex = 24;
            // 
            // textBoxLoai
            // 
            this.textBoxLoai.Location = new System.Drawing.Point(395, 85);
            this.textBoxLoai.Name = "textBoxLoai";
            this.textBoxLoai.Size = new System.Drawing.Size(134, 20);
            this.textBoxLoai.TabIndex = 23;
            // 
            // textBoxNSX
            // 
            this.textBoxNSX.Location = new System.Drawing.Point(234, 84);
            this.textBoxNSX.Name = "textBoxNSX";
            this.textBoxNSX.Size = new System.Drawing.Size(134, 20);
            this.textBoxNSX.TabIndex = 25;
            // 
            // NhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 525);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.tbTongTien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gbDSSP);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.gbTTSP);
            this.Controls.Add(this.tbTenNV);
            this.Controls.Add(this.tbMaPN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NhapKho";
            this.Text = "NhapKho";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanPham)).EndInit();
            this.gbDSSP.ResumeLayout(false);
            this.gbTTSP.ResumeLayout(false);
            this.gbTTSP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox tbTongTien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewSanPham;
        private System.Windows.Forms.GroupBox gbDSSP;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox tbTenNV;
        private System.Windows.Forms.TextBox tbMaPN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDonGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxMaNCC;
        private System.Windows.Forms.ComboBox comboBoxTenNCC;
        private System.Windows.Forms.ComboBox comboBoxNCC;
        private System.Windows.Forms.ComboBox comboBoxTenSP;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbTTSP;
        private System.Windows.Forms.TextBox textBoxDVT;
        private System.Windows.Forms.TextBox textBoxLoai;
        private System.Windows.Forms.TextBox textBoxNSX;
    }
}