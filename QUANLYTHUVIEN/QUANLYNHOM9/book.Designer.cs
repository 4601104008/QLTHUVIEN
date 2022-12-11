namespace QUANLYNHOM9
{
    partial class book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(book));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReadDer_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublishingHouse_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbBookName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbReadDer = new System.Windows.Forms.TextBox();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.txbNumber = new System.Windows.Forms.TextBox();
            this.txbPublishingHouse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnXOA = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnResetText = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_,
            this.BookName_,
            this.ReadDer_,
            this.Category_,
            this.Price_,
            this.Number_,
            this.PublishingHouse_});
            this.dataGridView1.Location = new System.Drawing.Point(12, 124);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(783, 401);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ID_
            // 
            this.ID_.HeaderText = "ID";
            this.ID_.MinimumWidth = 6;
            this.ID_.Name = "ID_";
            // 
            // BookName_
            // 
            this.BookName_.HeaderText = "Tên Sách";
            this.BookName_.MinimumWidth = 6;
            this.BookName_.Name = "BookName_";
            // 
            // ReadDer_
            // 
            this.ReadDer_.HeaderText = "Tác giả";
            this.ReadDer_.MinimumWidth = 6;
            this.ReadDer_.Name = "ReadDer_";
            // 
            // Category_
            // 
            this.Category_.HeaderText = "Thể loại";
            this.Category_.MinimumWidth = 6;
            this.Category_.Name = "Category_";
            // 
            // Price_
            // 
            this.Price_.HeaderText = "Đơn giá";
            this.Price_.MinimumWidth = 6;
            this.Price_.Name = "Price_";
            // 
            // Number_
            // 
            this.Number_.HeaderText = "Số lượng";
            this.Number_.MinimumWidth = 6;
            this.Number_.Name = "Number_";
            // 
            // PublishingHouse_
            // 
            this.PublishingHouse_.HeaderText = "Nhà xuất bản";
            this.PublishingHouse_.MinimumWidth = 6;
            this.PublishingHouse_.Name = "PublishingHouse_";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(196, 198);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(125, 25);
            this.cbCategory.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sách";
            // 
            // txbBookName
            // 
            this.txbBookName.Location = new System.Drawing.Point(196, 97);
            this.txbBookName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbBookName.Name = "txbBookName";
            this.txbBookName.Size = new System.Drawing.Size(125, 23);
            this.txbBookName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thể loại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tác giả";
            // 
            // txbReadDer
            // 
            this.txbReadDer.Location = new System.Drawing.Point(196, 143);
            this.txbReadDer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbReadDer.Name = "txbReadDer";
            this.txbReadDer.Size = new System.Drawing.Size(125, 23);
            this.txbReadDer.TabIndex = 3;
            // 
            // txbPrice
            // 
            this.txbPrice.Location = new System.Drawing.Point(196, 254);
            this.txbPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(125, 23);
            this.txbPrice.TabIndex = 3;
            // 
            // txbNumber
            // 
            this.txbNumber.Location = new System.Drawing.Point(196, 297);
            this.txbNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbNumber.Name = "txbNumber";
            this.txbNumber.Size = new System.Drawing.Size(125, 23);
            this.txbNumber.TabIndex = 3;
            // 
            // txbPublishingHouse
            // 
            this.txbPublishingHouse.Location = new System.Drawing.Point(196, 342);
            this.txbPublishingHouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbPublishingHouse.Name = "txbPublishingHouse";
            this.txbPublishingHouse.Size = new System.Drawing.Size(125, 23);
            this.txbPublishingHouse.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Đơn giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Số lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nhà xuất bản";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(209, 393);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(201, 41);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(336, 201);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 31);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "LỌC";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(57, 393);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(147, 41);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(315, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 69);
            this.label8.TabIndex = 4;
            this.label8.Text = "SÁCH";
            // 
            // btnXOA
            // 
            this.btnXOA.Location = new System.Drawing.Point(57, 439);
            this.btnXOA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(213, 38);
            this.btnXOA.TabIndex = 8;
            this.btnXOA.Text = "XÓA VÀ SỬA";
            this.btnXOA.UseVisualStyleBackColor = true;
            this.btnXOA.Click += new System.EventHandler(this.btnXOA_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnResetText);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cbCategory);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnXOA);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txbPublishingHouse);
            this.panel1.Controls.Add(this.txbBookName);
            this.panel1.Controls.Add(this.txbNumber);
            this.panel1.Controls.Add(this.txbReadDer);
            this.panel1.Controls.Add(this.txbPrice);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(825, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 492);
            this.panel1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 439);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "QUAY VỀ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "CÔNG CỤ";
            // 
            // btnResetText
            // 
            this.btnResetText.Location = new System.Drawing.Point(14, 21);
            this.btnResetText.Name = "btnResetText";
            this.btnResetText.Size = new System.Drawing.Size(94, 36);
            this.btnResetText.TabIndex = 10;
            this.btnResetText.Text = "Nhập lại";
            this.btnResetText.UseVisualStyleBackColor = true;
            this.btnResetText.Click += new System.EventHandler(this.btnResetText_Click);
            // 
            // book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1279, 539);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRANG QUẢN LÍ SÁCH";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbBookName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbReadDer;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.TextBox txbNumber;
        private System.Windows.Forms.TextBox txbPublishingHouse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName_;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReadDer_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number_;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublishingHouse_;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnXOA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnResetText;
    }
}