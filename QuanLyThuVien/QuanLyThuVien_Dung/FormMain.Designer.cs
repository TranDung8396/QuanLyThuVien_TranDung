namespace QuanLyThuVien_Nhom7
{
    partial class FormMain
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txtMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.txtdausach = new System.Windows.Forms.ToolStripMenuItem();
            this.txtdocgia = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMTS = new System.Windows.Forms.ToolStripMenuItem();
            this.btnhep = new System.Windows.Forms.ToolStripButton();
            this.btndangxuat = new System.Windows.Forms.ToolStripButton();
            this.lblten = new System.Windows.Forms.ToolStripLabel();
            this.btndangky = new System.Windows.Forms.ToolStripButton();
            this.btnhelp = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btndocgia = new System.Windows.Forms.Button();
            this.btndausach = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtMenu,
            this.btnhep,
            this.btndangxuat,
            this.lblten,
            this.btndangky});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(787, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // txtMenu
            // 
            this.txtMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtdausach,
            this.txtdocgia,
            this.txtMTS});
            this.txtMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.txtMenu.Name = "txtMenu";
            this.txtMenu.Size = new System.Drawing.Size(51, 22);
            this.txtMenu.Text = "&Menu";
            // 
            // txtdausach
            // 
            this.txtdausach.Name = "txtdausach";
            this.txtdausach.Size = new System.Drawing.Size(153, 22);
            this.txtdausach.Text = "&Đầu Sách";
            this.txtdausach.Click += new System.EventHandler(this.txtdausach_Click);
            // 
            // txtdocgia
            // 
            this.txtdocgia.Name = "txtdocgia";
            this.txtdocgia.Size = new System.Drawing.Size(153, 22);
            this.txtdocgia.Text = "&Độc Giả";
            this.txtdocgia.Click += new System.EventHandler(this.txtdocgia_Click);
            // 
            // txtMTS
            // 
            this.txtMTS.Name = "txtMTS";
            this.txtMTS.Size = new System.Drawing.Size(153, 22);
            this.txtMTS.Text = "&Mượn Trả Sách";
            this.txtMTS.Click += new System.EventHandler(this.txtMTS_Click);
            // 
            // btnhep
            // 
            this.btnhep.Image = global::QuanLyThuVien_Nhom7.Properties.Resources._1493873182_help_browser;
            this.btnhep.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnhep.Name = "btnhep";
            this.btnhep.Size = new System.Drawing.Size(72, 22);
            this.btnhep.Text = "&Trợ Giúp";
            this.btnhep.Click += new System.EventHandler(this.btnhep_Click);
            // 
            // btndangxuat
            // 
            this.btndangxuat.Image = global::QuanLyThuVien_Nhom7.Properties.Resources._1493874057_logout;
            this.btndangxuat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btndangxuat.Name = "btndangxuat";
            this.btndangxuat.Size = new System.Drawing.Size(82, 22);
            this.btndangxuat.Text = "&Đăng Xuất";
            this.btndangxuat.Click += new System.EventHandler(this.btndangxuat_Click);
            // 
            // lblten
            // 
            this.lblten.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblten.Name = "lblten";
            this.lblten.Size = new System.Drawing.Size(22, 22);
            this.lblten.Text = "???";
            // 
            // btndangky
            // 
            this.btndangky.Checked = true;
            this.btndangky.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btndangky.Image = global::QuanLyThuVien_Nhom7.Properties.Resources.Add_User_Group_Man_Man_48;
            this.btndangky.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btndangky.Name = "btndangky";
            this.btndangky.Size = new System.Drawing.Size(70, 22);
            this.btndangky.Text = "&Đăng Ký";
            this.btndangky.Click += new System.EventHandler(this.btndangky_Click);
            // 
            // btnhelp
            // 
            this.btnhelp.Image = global::QuanLyThuVien_Nhom7.Properties.Resources._1493873182_help_browser;
            this.btnhelp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnhelp.Location = new System.Drawing.Point(593, 116);
            this.btnhelp.Name = "btnhelp";
            this.btnhelp.Size = new System.Drawing.Size(81, 79);
            this.btnhelp.TabIndex = 8;
            this.btnhelp.Text = "&Help";
            this.btnhelp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnhelp.UseVisualStyleBackColor = true;
            this.btnhelp.Click += new System.EventHandler(this.btnhelp_Click);
            // 
            // button3
            // 
            this.button3.Image = global::QuanLyThuVien_Nhom7.Properties.Resources.muontra;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(416, 116);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 79);
            this.button3.TabIndex = 7;
            this.button3.Text = "&Mượn Trả";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btndocgia
            // 
            this.btndocgia.Image = global::QuanLyThuVien_Nhom7.Properties.Resources.people;
            this.btndocgia.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btndocgia.Location = new System.Drawing.Point(260, 116);
            this.btndocgia.Name = "btndocgia";
            this.btndocgia.Size = new System.Drawing.Size(75, 79);
            this.btndocgia.TabIndex = 6;
            this.btndocgia.Text = "&Độc Giả";
            this.btndocgia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btndocgia.UseVisualStyleBackColor = true;
            this.btndocgia.Click += new System.EventHandler(this.btndocgia_Click);
            // 
            // btndausach
            // 
            this.btndausach.Image = global::QuanLyThuVien_Nhom7.Properties.Resources.book;
            this.btndausach.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btndausach.Location = new System.Drawing.Point(111, 116);
            this.btndausach.Name = "btndausach";
            this.btndausach.Size = new System.Drawing.Size(75, 79);
            this.btndausach.TabIndex = 5;
            this.btndausach.Text = "&Đầu Sách";
            this.btndausach.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btndausach.UseVisualStyleBackColor = true;
            this.btndausach.Click += new System.EventHandler(this.btndausach_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(787, 319);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnhelp);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btndocgia);
            this.Controls.Add(this.btndausach);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed_1);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndausach;
        private System.Windows.Forms.Button btndocgia;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnhelp;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton txtMenu;
        private System.Windows.Forms.ToolStripMenuItem txtdausach;
        private System.Windows.Forms.ToolStripMenuItem txtdocgia;
        private System.Windows.Forms.ToolStripMenuItem txtMTS;
        private System.Windows.Forms.ToolStripButton btnhep;
        private System.Windows.Forms.ToolStripButton btndangxuat;
        private System.Windows.Forms.ToolStripLabel lblten;
        private System.Windows.Forms.ToolStripButton btndangky;
    }
}