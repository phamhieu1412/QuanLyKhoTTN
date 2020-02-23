namespace AppQuanLyKho.View
{
    partial class Loai
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMaLoai = new System.Windows.Forms.TextBox();
            this.textBoxTenLoai = new System.Windows.Forms.TextBox();
            this.textBoxMota = new System.Windows.Forms.TextBox();
            this.buttonThem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã loại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên loại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mô tả:";
            // 
            // textBoxMaLoai
            // 
            this.textBoxMaLoai.Location = new System.Drawing.Point(79, 24);
            this.textBoxMaLoai.Name = "textBoxMaLoai";
            this.textBoxMaLoai.Size = new System.Drawing.Size(238, 20);
            this.textBoxMaLoai.TabIndex = 1;
            // 
            // textBoxTenLoai
            // 
            this.textBoxTenLoai.Location = new System.Drawing.Point(79, 66);
            this.textBoxTenLoai.Name = "textBoxTenLoai";
            this.textBoxTenLoai.Size = new System.Drawing.Size(238, 20);
            this.textBoxTenLoai.TabIndex = 2;
            // 
            // textBoxMota
            // 
            this.textBoxMota.Location = new System.Drawing.Point(79, 106);
            this.textBoxMota.Name = "textBoxMota";
            this.textBoxMota.Size = new System.Drawing.Size(238, 20);
            this.textBoxMota.TabIndex = 3;
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(140, 138);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(75, 23);
            this.buttonThem.TabIndex = 4;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // Loai
            // 
            this.AcceptButton = this.buttonThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 173);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.textBoxMota);
            this.Controls.Add(this.textBoxTenLoai);
            this.Controls.Add(this.textBoxMaLoai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Loai";
            this.Text = "Loai";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMaLoai;
        private System.Windows.Forms.TextBox textBoxTenLoai;
        private System.Windows.Forms.TextBox textBoxMota;
        private System.Windows.Forms.Button buttonThem;
    }
}