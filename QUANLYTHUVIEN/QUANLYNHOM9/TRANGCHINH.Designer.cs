namespace QUANLYNHOM9
{
    partial class TRANGCHINH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TRANGCHINH));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvTRANGCHINH = new System.Windows.Forms.DataGridView();
            this.Name_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Writer_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dateofpublishing_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đĂNGXUẤTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pHIÊUMƯỢNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tÌMKIẾMToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pHIẾUSÁCHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tÀIKHOẢNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTRANGCHINH)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SFU Machine", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(242, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "THƯ VIỆN SÁCH ONLINE";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvTRANGCHINH);
            this.panel2.Location = new System.Drawing.Point(3, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(770, 273);
            this.panel2.TabIndex = 0;
            // 
            // dtgvTRANGCHINH
            // 
            this.dtgvTRANGCHINH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTRANGCHINH.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgvTRANGCHINH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTRANGCHINH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_,
            this.Writer_,
            this.Category_,
            this.Dateofpublishing_,
            this.soluong,
            this.NXB});
            this.dtgvTRANGCHINH.Location = new System.Drawing.Point(2, 2);
            this.dtgvTRANGCHINH.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvTRANGCHINH.Name = "dtgvTRANGCHINH";
            this.dtgvTRANGCHINH.RowHeadersWidth = 51;
            this.dtgvTRANGCHINH.RowTemplate.Height = 24;
            this.dtgvTRANGCHINH.Size = new System.Drawing.Size(766, 256);
            this.dtgvTRANGCHINH.TabIndex = 2;
            this.dtgvTRANGCHINH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTRANGCHINH_CellContentClick_1);
            // 
            // Name_
            // 
            this.Name_.HeaderText = "TÊN SÁCH";
            this.Name_.MinimumWidth = 6;
            this.Name_.Name = "Name_";
            // 
            // Writer_
            // 
            this.Writer_.HeaderText = "TÁC GIẢ";
            this.Writer_.MinimumWidth = 6;
            this.Writer_.Name = "Writer_";
            // 
            // Category_
            // 
            this.Category_.HeaderText = "Thể loại";
            this.Category_.MinimumWidth = 6;
            this.Category_.Name = "Category_";
            // 
            // Dateofpublishing_
            // 
            this.Dateofpublishing_.HeaderText = "NHÀ XUẤT BẢN";
            this.Dateofpublishing_.MinimumWidth = 6;
            this.Dateofpublishing_.Name = "Dateofpublishing_";
            // 
            // soluong
            // 
            this.soluong.HeaderText = "SỐ LƯỢNG";
            this.soluong.Name = "soluong";
            // 
            // NXB
            // 
            this.NXB.HeaderText = "GIÁ";
            this.NXB.Name = "NXB";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.pHIÊUMƯỢNToolStripMenuItem,
            this.tÌMKIẾMToolStripMenuItem1,
            this.pHIẾUSÁCHToolStripMenuItem,
            this.tÀIKHOẢNToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(776, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đĂNGXUẤTToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.adminToolStripMenuItem.Text = "ADMIN";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // đĂNGXUẤTToolStripMenuItem
            // 
            this.đĂNGXUẤTToolStripMenuItem.Name = "đĂNGXUẤTToolStripMenuItem";
            this.đĂNGXUẤTToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đĂNGXUẤTToolStripMenuItem.Text = "ĐĂNG XUẤT";
            this.đĂNGXUẤTToolStripMenuItem.Click += new System.EventHandler(this.đĂNGXUẤTToolStripMenuItem_Click_1);
            // 
            // pHIÊUMƯỢNToolStripMenuItem
            // 
            this.pHIÊUMƯỢNToolStripMenuItem.Name = "pHIÊUMƯỢNToolStripMenuItem";
            this.pHIÊUMƯỢNToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.pHIÊUMƯỢNToolStripMenuItem.Text = "SÁCH";
            this.pHIÊUMƯỢNToolStripMenuItem.Click += new System.EventHandler(this.pHIÊUMƯỢNToolStripMenuItem_Click);
            // 
            // tÌMKIẾMToolStripMenuItem1
            // 
            this.tÌMKIẾMToolStripMenuItem1.Name = "tÌMKIẾMToolStripMenuItem1";
            this.tÌMKIẾMToolStripMenuItem1.Size = new System.Drawing.Size(103, 20);
            this.tÌMKIẾMToolStripMenuItem1.Text = "THỂ LOẠI SÁCH";
            this.tÌMKIẾMToolStripMenuItem1.Click += new System.EventHandler(this.tÌMKIẾMToolStripMenuItem1_Click);
            // 
            // pHIẾUSÁCHToolStripMenuItem
            // 
            this.pHIẾUSÁCHToolStripMenuItem.Name = "pHIẾUSÁCHToolStripMenuItem";
            this.pHIẾUSÁCHToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.pHIẾUSÁCHToolStripMenuItem.Text = "PHIẾU SÁCH";
            this.pHIẾUSÁCHToolStripMenuItem.Click += new System.EventHandler(this.pHIẾUSÁCHToolStripMenuItem_Click);
            // 
            // tÀIKHOẢNToolStripMenuItem
            // 
            this.tÀIKHOẢNToolStripMenuItem.Name = "tÀIKHOẢNToolStripMenuItem";
            this.tÀIKHOẢNToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.tÀIKHOẢNToolStripMenuItem.Text = "TÀI KHOẢN";
            this.tÀIKHOẢNToolStripMenuItem.Click += new System.EventHandler(this.tÀIKHOẢNToolStripMenuItem_Click);
            // 
            // TRANGCHINH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 444);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TRANGCHINH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRANGCHINH";
            this.Load += new System.EventHandler(this.TRANGCHINH_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTRANGCHINH)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvTRANGCHINH;
        private System.Windows.Forms.ToolStripMenuItem pHIÊUMƯỢNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tÌMKIẾMToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Writer_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dateofpublishing_;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NXB;
        private System.Windows.Forms.ToolStripMenuItem đĂNGXUẤTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pHIẾUSÁCHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tÀIKHOẢNToolStripMenuItem;
    }
}