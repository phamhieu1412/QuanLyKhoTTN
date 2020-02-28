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
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.comboBoxTenSP = new System.Windows.Forms.ComboBox();
            this.comboBoxTenNCC = new System.Windows.Forms.ComboBox();
            this.textBoxLoai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDonGia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSoLuong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.gbTTSP = new System.Windows.Forms.GroupBox();
            this.btXoa = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxMaNCC = new System.Windows.Forms.TextBox();
            this.textBoxDVT = new System.Windows.Forms.TextBox();
            this.textBoxNSX = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbTenNV = new System.Windows.Forms.TextBox();
            this.tbMaPN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanPham)).BeginInit();
            this.gbDSSP.SuspendLayout();
            this.gbTTSP.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(388, 797);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(112, 35);
            this.btnLuu.TabIndex = 29;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // tbTongTien
            // 
            this.tbTongTien.Location = new System.Drawing.Point(807, 722);
            this.tbTongTien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTongTien.Name = "tbTongTien";
            this.tbTongTien.ReadOnly = true;
            this.tbTongTien.Size = new System.Drawing.Size(166, 26);
            this.tbTongTien.TabIndex = 28;
            this.tbTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(718, 726);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Tổng tiền";
            // 
            // dataGridViewSanPham
            // 
            this.dataGridViewSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSanPham.Location = new System.Drawing.Point(21, 29);
            this.dataGridViewSanPham.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewSanPham.Name = "dataGridViewSanPham";
            this.dataGridViewSanPham.RowHeadersWidth = 62;
            this.dataGridViewSanPham.Size = new System.Drawing.Size(856, 231);
            this.dataGridViewSanPham.TabIndex = 0;
            this.dataGridViewSanPham.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSanPham_RowHeaderMouseClick);
            // 
            // gbDSSP
            // 
            this.gbDSSP.Controls.Add(this.dataGridViewSanPham);
            this.gbDSSP.Location = new System.Drawing.Point(70, 412);
            this.gbDSSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbDSSP.Name = "gbDSSP";
            this.gbDSSP.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbDSSP.Size = new System.Drawing.Size(903, 275);
            this.gbDSSP.TabIndex = 26;
            this.gbDSSP.TabStop = false;
            this.gbDSSP.Text = "danh sách sản phẩm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(440, 85);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Tên loại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Tên NCC";
            // 
            // btnSua
            // 
            this.btnSua.Enabled = false;
            this.btnSua.Location = new System.Drawing.Point(381, 238);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 35);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(237, 238);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 35);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // comboBoxTenSP
            // 
            this.comboBoxTenSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTenSP.FormattingEnabled = true;
            this.comboBoxTenSP.Location = new System.Drawing.Point(578, 34);
            this.comboBoxTenSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxTenSP.Name = "comboBoxTenSP";
            this.comboBoxTenSP.Size = new System.Drawing.Size(296, 28);
            this.comboBoxTenSP.TabIndex = 2;
            this.comboBoxTenSP.SelectedIndexChanged += new System.EventHandler(this.comboBoxTenSP_SelectedIndexChanged);
            // 
            // comboBoxTenNCC
            // 
            this.comboBoxTenNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTenNCC.FormattingEnabled = true;
            this.comboBoxTenNCC.Location = new System.Drawing.Point(148, 34);
            this.comboBoxTenNCC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxTenNCC.Name = "comboBoxTenNCC";
            this.comboBoxTenNCC.Size = new System.Drawing.Size(199, 28);
            this.comboBoxTenNCC.TabIndex = 1;
            this.comboBoxTenNCC.SelectedIndexChanged += new System.EventHandler(this.comboBoxNCC_SelectedIndexChanged);
            // 
            // textBoxLoai
            // 
            this.textBoxLoai.Enabled = false;
            this.textBoxLoai.Location = new System.Drawing.Point(578, 80);
            this.textBoxLoai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLoai.Name = "textBoxLoai";
            this.textBoxLoai.ReadOnly = true;
            this.textBoxLoai.Size = new System.Drawing.Size(296, 26);
            this.textBoxLoai.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(440, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tên Sản Phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 177);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Đơn vị tính";
            // 
            // textBoxDonGia
            // 
            this.textBoxDonGia.Location = new System.Drawing.Point(148, 172);
            this.textBoxDonGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDonGia.Name = "textBoxDonGia";
            this.textBoxDonGia.Size = new System.Drawing.Size(199, 26);
            this.textBoxDonGia.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Đơn giá nhập";
            // 
            // textBoxSoLuong
            // 
            this.textBoxSoLuong.Location = new System.Drawing.Point(148, 126);
            this.textBoxSoLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSoLuong.Name = "textBoxSoLuong";
            this.textBoxSoLuong.Size = new System.Drawing.Size(199, 26);
            this.textBoxSoLuong.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "SL Nhập";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(532, 797);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 35);
            this.btnThoat.TabIndex = 30;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // gbTTSP
            // 
            this.gbTTSP.Controls.Add(this.btXoa);
            this.gbTTSP.Controls.Add(this.label11);
            this.gbTTSP.Controls.Add(this.textBoxMaNCC);
            this.gbTTSP.Controls.Add(this.textBoxDVT);
            this.gbTTSP.Controls.Add(this.textBoxNSX);
            this.gbTTSP.Controls.Add(this.label9);
            this.gbTTSP.Controls.Add(this.label10);
            this.gbTTSP.Controls.Add(this.label8);
            this.gbTTSP.Controls.Add(this.btnSua);
            this.gbTTSP.Controls.Add(this.btnThem);
            this.gbTTSP.Controls.Add(this.comboBoxTenSP);
            this.gbTTSP.Controls.Add(this.comboBoxTenNCC);
            this.gbTTSP.Controls.Add(this.textBoxLoai);
            this.gbTTSP.Controls.Add(this.label6);
            this.gbTTSP.Controls.Add(this.label5);
            this.gbTTSP.Controls.Add(this.textBoxDonGia);
            this.gbTTSP.Controls.Add(this.label4);
            this.gbTTSP.Controls.Add(this.textBoxSoLuong);
            this.gbTTSP.Controls.Add(this.label3);
            this.gbTTSP.Location = new System.Drawing.Point(70, 114);
            this.gbTTSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTTSP.Name = "gbTTSP";
            this.gbTTSP.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTTSP.Size = new System.Drawing.Size(903, 289);
            this.gbTTSP.TabIndex = 25;
            this.gbTTSP.TabStop = false;
            this.gbTTSP.Text = "Thông tin sản phẩm";
            // 
            // btXoa
            // 
            this.btXoa.Enabled = false;
            this.btXoa.Location = new System.Drawing.Point(525, 238);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(112, 35);
            this.btXoa.TabIndex = 29;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 85);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "Mã NCC";
            // 
            // textBoxMaNCC
            // 
            this.textBoxMaNCC.Enabled = false;
            this.textBoxMaNCC.Location = new System.Drawing.Point(148, 80);
            this.textBoxMaNCC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxMaNCC.Name = "textBoxMaNCC";
            this.textBoxMaNCC.ReadOnly = true;
            this.textBoxMaNCC.Size = new System.Drawing.Size(199, 26);
            this.textBoxMaNCC.TabIndex = 27;
            // 
            // textBoxDVT
            // 
            this.textBoxDVT.Enabled = false;
            this.textBoxDVT.Location = new System.Drawing.Point(578, 172);
            this.textBoxDVT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDVT.Name = "textBoxDVT";
            this.textBoxDVT.ReadOnly = true;
            this.textBoxDVT.Size = new System.Drawing.Size(296, 26);
            this.textBoxDVT.TabIndex = 26;
            // 
            // textBoxNSX
            // 
            this.textBoxNSX.Enabled = false;
            this.textBoxNSX.Location = new System.Drawing.Point(578, 126);
            this.textBoxNSX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNSX.Name = "textBoxNSX";
            this.textBoxNSX.ReadOnly = true;
            this.textBoxNSX.Size = new System.Drawing.Size(296, 26);
            this.textBoxNSX.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(440, 131);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Nước Sản Xuất";
            // 
            // tbTenNV
            // 
            this.tbTenNV.Enabled = false;
            this.tbTenNV.Location = new System.Drawing.Point(807, 18);
            this.tbTenNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTenNV.Name = "tbTenNV";
            this.tbTenNV.ReadOnly = true;
            this.tbTenNV.Size = new System.Drawing.Size(202, 26);
            this.tbTenNV.TabIndex = 24;
            // 
            // tbMaPN
            // 
            this.tbMaPN.Enabled = false;
            this.tbMaPN.Location = new System.Drawing.Point(92, 18);
            this.tbMaPN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMaPN.Name = "tbMaPN";
            this.tbMaPN.ReadOnly = true;
            this.tbMaPN.Size = new System.Drawing.Size(148, 26);
            this.tbMaPN.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Mã PN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(393, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 50);
            this.label1.TabIndex = 21;
            this.label1.Text = "Phiếu Nhập Kho";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(70, 697);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(624, 74);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ghi chú";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 25);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(592, 26);
            this.textBox1.TabIndex = 0;
            // 
            // NhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 851);
            this.Controls.Add(this.groupBox1);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NhapKho";
            this.Text = "NhapKho";
            this.Load += new System.EventHandler(this.NhapKho_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NhapKho_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanPham)).EndInit();
            this.gbDSSP.ResumeLayout(false);
            this.gbTTSP.ResumeLayout(false);
            this.gbTTSP.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox tbTongTien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewSanPham;
        private System.Windows.Forms.GroupBox gbDSSP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox comboBoxTenSP;
        private System.Windows.Forms.ComboBox comboBoxTenNCC;
        private System.Windows.Forms.TextBox textBoxLoai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDonGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSoLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox gbTTSP;
        private System.Windows.Forms.TextBox tbTenNV;
        private System.Windows.Forms.TextBox tbMaPN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNSX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxDVT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxMaNCC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btXoa;
    }
}