namespace QuanLyThuVien_Nhom7
{
    partial class FormDangKy
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
            this.btnhuy = new System.Windows.Forms.Button();
            this.btndangky = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpassword2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpassword1 = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(475, 443);
            this.btnhuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(176, 75);
            this.btnhuy.TabIndex = 30;
            this.btnhuy.Text = "&Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btndangky
            // 
            this.btndangky.Location = new System.Drawing.Point(163, 443);
            this.btndangky.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btndangky.Name = "btndangky";
            this.btndangky.Size = new System.Drawing.Size(176, 75);
            this.btndangky.TabIndex = 29;
            this.btndangky.Text = "&Đăng Ký";
            this.btndangky.UseVisualStyleBackColor = true;
            this.btndangky.Click += new System.EventHandler(this.btndangky_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(274, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 61);
            this.label4.TabIndex = 28;
            this.label4.Text = "Đăng Ký";
            // 
            // txtpassword2
            // 
            this.txtpassword2.Location = new System.Drawing.Point(374, 349);
            this.txtpassword2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpassword2.Name = "txtpassword2";
            this.txtpassword2.Size = new System.Drawing.Size(322, 26);
            this.txtpassword2.TabIndex = 27;
            this.txtpassword2.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 354);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // txtpassword1
            // 
            this.txtpassword1.Location = new System.Drawing.Point(374, 265);
            this.txtpassword1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpassword1.Name = "txtpassword1";
            this.txtpassword1.Size = new System.Drawing.Size(322, 26);
            this.txtpassword1.TabIndex = 25;
            this.txtpassword1.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(374, 169);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(322, 26);
            this.txtUsername.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 269);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tên đăng nhập";
            // 
            // FormDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 575);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btndangky);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpassword2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpassword1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDangKy";
            this.Load += new System.EventHandler(this.FormDangKy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btndangky;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpassword2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpassword1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}