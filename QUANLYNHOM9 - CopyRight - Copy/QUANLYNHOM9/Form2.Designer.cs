namespace QUANLYNHOM9
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewBook = new System.Windows.Forms.DataGridView();
            this.ID_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Writer_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dateofpublishing_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.txbWriter = new System.Windows.Forms.TextBox();
            this.txbDateofpublishing = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tHOÁTToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SFU Machine", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(778, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "SÁCH";
            // 
            // dataGridViewBook
            // 
            this.dataGridViewBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_,
            this.Name_,
            this.Writer_,
            this.Category_,
            this.Dateofpublishing_});
            this.dataGridViewBook.Location = new System.Drawing.Point(11, 72);
            this.dataGridViewBook.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewBook.Name = "dataGridViewBook";
            this.dataGridViewBook.RowHeadersWidth = 51;
            this.dataGridViewBook.RowTemplate.Height = 24;
            this.dataGridViewBook.Size = new System.Drawing.Size(612, 291);
            this.dataGridViewBook.TabIndex = 1;
            this.dataGridViewBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBook_CellClick);
            this.dataGridViewBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBook_CellContentClick);
            // 
            // ID_
            // 
            this.ID_.HeaderText = "ID";
            this.ID_.MinimumWidth = 6;
            this.ID_.Name = "ID_";
            // 
            // Name_
            // 
            this.Name_.HeaderText = "Tên";
            this.Name_.MinimumWidth = 6;
            this.Name_.Name = "Name_";
            // 
            // Writer_
            // 
            this.Writer_.HeaderText = "Tác giả";
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
            this.Dateofpublishing_.HeaderText = "Ngày xuất bản";
            this.Dateofpublishing_.MinimumWidth = 6;
            this.Dateofpublishing_.Name = "Dateofpublishing_";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Oswald", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(645, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "MÃ SÁCH:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Oswald", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(645, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "TÊN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Oswald", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(645, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "THỂ LOẠI:";
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(738, 135);
            this.txbID.Margin = new System.Windows.Forms.Padding(2);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(195, 20);
            this.txbID.TabIndex = 5;
            this.txbID.TextChanged += new System.EventHandler(this.txbID_TextChanged);
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(738, 166);
            this.txbName.Margin = new System.Windows.Forms.Padding(2);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(195, 20);
            this.txbName.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Oswald", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(649, 331);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 32);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Oswald", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(765, 331);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(99, 32);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Oswald", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(873, 331);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 32);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(738, 199);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(195, 21);
            this.cbCategory.TabIndex = 7;
            // 
            // txbWriter
            // 
            this.txbWriter.Location = new System.Drawing.Point(738, 231);
            this.txbWriter.Margin = new System.Windows.Forms.Padding(2);
            this.txbWriter.Name = "txbWriter";
            this.txbWriter.Size = new System.Drawing.Size(195, 20);
            this.txbWriter.TabIndex = 8;
            // 
            // txbDateofpublishing
            // 
            this.txbDateofpublishing.Location = new System.Drawing.Point(738, 262);
            this.txbDateofpublishing.Margin = new System.Windows.Forms.Padding(2);
            this.txbDateofpublishing.Name = "txbDateofpublishing";
            this.txbDateofpublishing.Size = new System.Drawing.Size(195, 20);
            this.txbDateofpublishing.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Oswald", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(645, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "TÁC GIẢ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Oswald", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(645, 261);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "NGÀY XUẤT BẢN:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(114, 26);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tHOÁTToolStripMenuItem1});
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.thoátToolStripMenuItem.Text = "ADMIN";
            // 
            // tHOÁTToolStripMenuItem1
            // 
            this.tHOÁTToolStripMenuItem1.Name = "tHOÁTToolStripMenuItem1";
            this.tHOÁTToolStripMenuItem1.Size = new System.Drawing.Size(111, 22);
            this.tHOÁTToolStripMenuItem1.Text = "THOÁT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(744, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "(tháng/ngày/năm  giờ : phút : giây)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(943, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "(số)";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(994, 441);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbDateofpublishing);
            this.Controls.Add(this.txbWriter);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewBook);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRANG SÁCH";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox txbWriter;
        private System.Windows.Forms.TextBox txbDateofpublishing;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Writer_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dateofpublishing_;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tHOÁTToolStripMenuItem1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}