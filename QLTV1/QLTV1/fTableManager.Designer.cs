
namespace QLTV1
{
    partial class fTableManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTableManager));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thôngTinSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinĐộcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mượnTrảSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinĐăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinSáchToolStripMenuItem,
            this.thôngTinĐộcGiảToolStripMenuItem,
            this.mượnTrảSáchToolStripMenuItem,
            this.thôngTinĐăngNhậpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(976, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thôngTinSáchToolStripMenuItem
            // 
            this.thôngTinSáchToolStripMenuItem.Image = global::QLTV1.Properties.Resources.book;
            this.thôngTinSáchToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.thôngTinSáchToolStripMenuItem.Name = "thôngTinSáchToolStripMenuItem";
            this.thôngTinSáchToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.thôngTinSáchToolStripMenuItem.Text = "Thông tin sách";
            this.thôngTinSáchToolStripMenuItem.Click += new System.EventHandler(this.thôngTinSáchToolStripMenuItem_Click);
            // 
            // thôngTinĐộcGiảToolStripMenuItem
            // 
            this.thôngTinĐộcGiảToolStripMenuItem.Image = global::QLTV1.Properties.Resources.reader;
            this.thôngTinĐộcGiảToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.thôngTinĐộcGiảToolStripMenuItem.Name = "thôngTinĐộcGiảToolStripMenuItem";
            this.thôngTinĐộcGiảToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.thôngTinĐộcGiảToolStripMenuItem.Text = "Thông tin độc giả";
            this.thôngTinĐộcGiảToolStripMenuItem.Click += new System.EventHandler(this.thôngTinĐộcGiảToolStripMenuItem_Click);
            // 
            // mượnTrảSáchToolStripMenuItem
            // 
            this.mượnTrảSáchToolStripMenuItem.Image = global::QLTV1.Properties.Resources.holding;
            this.mượnTrảSáchToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mượnTrảSáchToolStripMenuItem.Name = "mượnTrảSáchToolStripMenuItem";
            this.mượnTrảSáchToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.mượnTrảSáchToolStripMenuItem.Text = "Mượn trả sách";
            this.mượnTrảSáchToolStripMenuItem.Click += new System.EventHandler(this.mượnTrảSáchToolStripMenuItem_Click);
            // 
            // thôngTinĐăngNhậpToolStripMenuItem
            // 
            this.thôngTinĐăngNhậpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinĐăngNhậpToolStripMenuItem.Image = global::QLTV1.Properties.Resources.user;
            this.thôngTinĐăngNhậpToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.thôngTinĐăngNhậpToolStripMenuItem.Name = "thôngTinĐăngNhậpToolStripMenuItem";
            this.thôngTinĐăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.thôngTinĐăngNhậpToolStripMenuItem.Text = "Thông tin đăng nhập";
            this.thôngTinĐăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.thôngTinĐăngNhậpToolStripMenuItem_Click);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.Image = global::QLTV1.Properties.Resources.user__2_;
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            this.tàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.tàiKhoảnToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Image = global::QLTV1.Properties.Resources.exit;
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(950, 535);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 579);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "fTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý thư viện";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinĐăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinĐộcGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mượnTrảSáchToolStripMenuItem;
    }
}