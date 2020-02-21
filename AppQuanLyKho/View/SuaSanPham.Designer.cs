namespace AppQuanLyKho.View
{
    partial class SuaSanPham
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
            this.nuocSXTb = new System.Windows.Forms.TextBox();
            this.donGiaTb = new System.Windows.Forms.TextBox();
            this.maSPTb = new System.Windows.Forms.TextBox();
            this.tenSPTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.donViTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sửa sản phẩm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // nuocSXTb
            // 
            this.nuocSXTb.Location = new System.Drawing.Point(115, 77);
            this.nuocSXTb.Name = "nuocSXTb";
            this.nuocSXTb.Size = new System.Drawing.Size(130, 20);
            this.nuocSXTb.TabIndex = 1;
            // 
            // donGiaTb
            // 
            this.donGiaTb.Location = new System.Drawing.Point(372, 77);
            this.donGiaTb.Name = "donGiaTb";
            this.donGiaTb.Size = new System.Drawing.Size(130, 20);
            this.donGiaTb.TabIndex = 1;
            // 
            // maSPTb
            // 
            this.maSPTb.Location = new System.Drawing.Point(115, 28);
            this.maSPTb.Name = "maSPTb";
            this.maSPTb.Size = new System.Drawing.Size(130, 20);
            this.maSPTb.TabIndex = 1;
            // 
            // tenSPTb
            // 
            this.tenSPTb.Location = new System.Drawing.Point(372, 28);
            this.tenSPTb.Name = "tenSPTb";
            this.tenSPTb.Size = new System.Drawing.Size(130, 20);
            this.tenSPTb.TabIndex = 1;
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
            // donViTb
            // 
            this.donViTb.Location = new System.Drawing.Point(372, 125);
            this.donViTb.Name = "donViTb";
            this.donViTb.Size = new System.Drawing.Size(130, 20);
            this.donViTb.TabIndex = 1;
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
            // SuaSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 226);
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
            this.Controls.Add(this.button1);
            this.Name = "SuaSanPham";
            this.Text = "Nhap San Pham";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nuocSXTb;
        private System.Windows.Forms.TextBox donGiaTb;
        private System.Windows.Forms.TextBox maSPTb;
        private System.Windows.Forms.TextBox tenSPTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox donViTb;
        private System.Windows.Forms.Label label4;
    }
}