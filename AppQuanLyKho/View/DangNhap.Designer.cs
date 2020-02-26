namespace AppQuanLyKho.View
{
    partial class DangNhap
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbShowPass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(79, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(111, 82);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(164, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(111, 119);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(164, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mật khẩu";
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(66, 185);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(75, 23);
            this.btnLogIn.TabIndex = 4;
            this.btnLogIn.Text = "Đăng nhập";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.BtnLogIn_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(159, 185);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // cbShowPass
            // 
            this.cbShowPass.AutoSize = true;
            this.cbShowPass.Location = new System.Drawing.Point(111, 151);
            this.cbShowPass.Name = "cbShowPass";
            this.cbShowPass.Size = new System.Drawing.Size(109, 17);
            this.cbShowPass.TabIndex = 3;
            this.cbShowPass.Text = "Hiển thị mật khẩu";
            this.cbShowPass.UseVisualStyleBackColor = true;
            this.cbShowPass.CheckedChanged += new System.EventHandler(this.CbShowPass_CheckedChanged);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 235);
            this.Controls.Add(this.cbShowPass);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dang nhap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox cbShowPass;
    }
}

