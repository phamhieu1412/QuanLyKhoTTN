namespace AppQuanLyKho.View
{
    partial class SuaTTSanPham
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
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tenSPTb = new System.Windows.Forms.TextBox();
            this.maSPTb = new System.Windows.Forms.TextBox();
            this.donViTb = new System.Windows.Forms.TextBox();
            this.donGiaTb = new System.Windows.Forms.TextBox();
            this.nuocSXTb = new System.Windows.Forms.TextBox();
            this.btnSuaSP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Đơn vị tính:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(281, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Đơn giá:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nước sản xuất:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tên sản phẩm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã sản phẩm:";
            // 
            // tenSPTb
            // 
            this.tenSPTb.Location = new System.Drawing.Point(366, 18);
            this.tenSPTb.Name = "tenSPTb";
            this.tenSPTb.Size = new System.Drawing.Size(130, 20);
            this.tenSPTb.TabIndex = 4;
            // 
            // maSPTb
            // 
            this.maSPTb.Location = new System.Drawing.Point(109, 18);
            this.maSPTb.Name = "maSPTb";
            this.maSPTb.Size = new System.Drawing.Size(130, 20);
            this.maSPTb.TabIndex = 5;
            // 
            // donViTb
            // 
            this.donViTb.Location = new System.Drawing.Point(366, 115);
            this.donViTb.Name = "donViTb";
            this.donViTb.Size = new System.Drawing.Size(130, 20);
            this.donViTb.TabIndex = 6;
            // 
            // donGiaTb
            // 
            this.donGiaTb.Location = new System.Drawing.Point(366, 67);
            this.donGiaTb.Name = "donGiaTb";
            this.donGiaTb.Size = new System.Drawing.Size(130, 20);
            this.donGiaTb.TabIndex = 7;
            // 
            // nuocSXTb
            // 
            this.nuocSXTb.Location = new System.Drawing.Point(109, 67);
            this.nuocSXTb.Name = "nuocSXTb";
            this.nuocSXTb.Size = new System.Drawing.Size(130, 20);
            this.nuocSXTb.TabIndex = 8;
            // 
            // btnSuaSP
            // 
            this.btnSuaSP.Location = new System.Drawing.Point(187, 164);
            this.btnSuaSP.Name = "btnSuaSP";
            this.btnSuaSP.Size = new System.Drawing.Size(122, 23);
            this.btnSuaSP.TabIndex = 3;
            this.btnSuaSP.Text = "Sửa sản phẩm";
            this.btnSuaSP.UseVisualStyleBackColor = true;
            this.btnSuaSP.Click += new System.EventHandler(this.BtnSuaSP_Click);
            // 
            // SuaTTSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 202);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tenSPTb);
            this.Controls.Add(this.maSPTb);
            this.Controls.Add(this.donViTb);
            this.Controls.Add(this.donGiaTb);
            this.Controls.Add(this.nuocSXTb);
            this.Controls.Add(this.btnSuaSP);
            this.Name = "SuaTTSanPham";
            this.Text = "SuaTTSanPham";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tenSPTb;
        private System.Windows.Forms.TextBox maSPTb;
        private System.Windows.Forms.TextBox donViTb;
        private System.Windows.Forms.TextBox donGiaTb;
        private System.Windows.Forms.TextBox nuocSXTb;
        private System.Windows.Forms.Button btnSuaSP;
    }
}