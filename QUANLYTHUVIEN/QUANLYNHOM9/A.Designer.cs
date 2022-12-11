namespace QUANLYNHOM9
{
    partial class A
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Category_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameBook_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeBorrow_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimePay_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearchBorrow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ádf = new System.Windows.Forms.Label();
            this.lbff = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.txbNameBook = new System.Windows.Forms.TextBox();
            this.txbTimeBorrow = new System.Windows.Forms.TextBox();
            this.txbTimePay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDEL = new System.Windows.Forms.Button();
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
            this.Category_,
            this.Name_,
            this.Address_,
            this.NameBook_,
            this.TimeBorrow_,
            this.TimePay_,
            this.status_,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(3, 96);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(953, 455);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Category_
            // 
            this.Category_.HeaderText = "MÃ SÁCH";
            this.Category_.MinimumWidth = 6;
            this.Category_.Name = "Category_";
            // 
            // Name_
            // 
            this.Name_.HeaderText = "HỌ VÀ TÊN";
            this.Name_.MinimumWidth = 6;
            this.Name_.Name = "Name_";
            // 
            // Address_
            // 
            this.Address_.HeaderText = "ĐỊA CHỈ";
            this.Address_.MinimumWidth = 6;
            this.Address_.Name = "Address_";
            // 
            // NameBook_
            // 
            this.NameBook_.HeaderText = "TÊN SÁCH";
            this.NameBook_.MinimumWidth = 6;
            this.NameBook_.Name = "NameBook_";
            // 
            // TimeBorrow_
            // 
            this.TimeBorrow_.HeaderText = "THỂ LOẠI SÁCH";
            this.TimeBorrow_.MinimumWidth = 6;
            this.TimeBorrow_.Name = "TimeBorrow_";
            // 
            // TimePay_
            // 
            this.TimePay_.HeaderText = "THỜI GIAN MƯỢN";
            this.TimePay_.MinimumWidth = 6;
            this.TimePay_.Name = "TimePay_";
            // 
            // status_
            // 
            this.status_.HeaderText = "THỜI GIAN TRẢ";
            this.status_.MinimumWidth = 6;
            this.status_.Name = "status_";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "TÌNH TRẠNG";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(192, -7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(708, 69);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ PHIẾU MƯỢN";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(148, 430);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(153, 39);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "THÊM";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearchBorrow
            // 
            this.btnSearchBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBorrow.Location = new System.Drawing.Point(276, 97);
            this.btnSearchBorrow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchBorrow.Name = "btnSearchBorrow";
            this.btnSearchBorrow.Size = new System.Drawing.Size(51, 28);
            this.btnSearchBorrow.TabIndex = 6;
            this.btnSearchBorrow.Text = "LỌC";
            this.btnSearchBorrow.UseVisualStyleBackColor = true;
            this.btnSearchBorrow.Click += new System.EventHandler(this.btnSearchBorrow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(141, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "CÔNG CỤ";
            // 
            // ádf
            // 
            this.ádf.AutoSize = true;
            this.ádf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ádf.Location = new System.Drawing.Point(35, 282);
            this.ádf.Name = "ádf";
            this.ádf.Size = new System.Drawing.Size(59, 17);
            this.ádf.TabIndex = 10;
            this.ádf.Text = "Thể loại";
            // 
            // lbff
            // 
            this.lbff.AutoSize = true;
            this.lbff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbff.Location = new System.Drawing.Point(40, 146);
            this.lbff.Name = "lbff";
            this.lbff.Size = new System.Drawing.Size(50, 17);
            this.lbff.TabIndex = 10;
            this.lbff.Text = "Họ tên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Địa chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tên sách";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 334);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Thời gian mượn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(35, 382);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Thời gian trả";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(148, 146);
            this.txbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(116, 22);
            this.txbName.TabIndex = 7;
            // 
            // txbAddress
            // 
            this.txbAddress.Location = new System.Drawing.Point(148, 191);
            this.txbAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(116, 22);
            this.txbAddress.TabIndex = 7;
            // 
            // txbNameBook
            // 
            this.txbNameBook.Location = new System.Drawing.Point(148, 236);
            this.txbNameBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbNameBook.Name = "txbNameBook";
            this.txbNameBook.Size = new System.Drawing.Size(116, 22);
            this.txbNameBook.TabIndex = 7;
            // 
            // txbTimeBorrow
            // 
            this.txbTimeBorrow.Location = new System.Drawing.Point(148, 334);
            this.txbTimeBorrow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTimeBorrow.Name = "txbTimeBorrow";
            this.txbTimeBorrow.Size = new System.Drawing.Size(152, 22);
            this.txbTimeBorrow.TabIndex = 7;
            // 
            // txbTimePay
            // 
            this.txbTimePay.Location = new System.Drawing.Point(148, 382);
            this.txbTimePay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTimePay.Name = "txbTimePay";
            this.txbTimePay.Size = new System.Drawing.Size(152, 22);
            this.txbTimePay.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tình trạng";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(148, 97);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 24);
            this.cbStatus.TabIndex = 12;
            this.cbStatus.SelectedValueChanged += new System.EventHandler(this.cbStatus_SelectedValueChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(40, 430);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 39);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "LÀM MỚI";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(148, 282);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(137, 24);
            this.cbCategory.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnResetText);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnDEL);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbff);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnSearchBorrow);
            this.panel1.Controls.Add(this.cbCategory);
            this.panel1.Controls.Add(this.txbName);
            this.panel1.Controls.Add(this.txbAddress);
            this.panel1.Controls.Add(this.cbStatus);
            this.panel1.Controls.Add(this.txbNameBook);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbTimeBorrow);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txbTimePay);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.ádf);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(977, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 535);
            this.panel1.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(201, 475);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 41);
            this.button1.TabIndex = 17;
            this.button1.Text = "QUAY VỀ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnDEL
            // 
            this.btnDEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDEL.Location = new System.Drawing.Point(40, 475);
            this.btnDEL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDEL.Name = "btnDEL";
            this.btnDEL.Size = new System.Drawing.Size(148, 41);
            this.btnDEL.TabIndex = 16;
            this.btnDEL.Text = "XÓA VÀ SỬA";
            this.btnDEL.UseVisualStyleBackColor = true;
            this.btnDEL.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnResetText
            // 
            this.btnResetText.Location = new System.Drawing.Point(20, 7);
            this.btnResetText.Name = "btnResetText";
            this.btnResetText.Size = new System.Drawing.Size(66, 49);
            this.btnResetText.TabIndex = 18;
            this.btnResetText.Text = "Nhập lại";
            this.btnResetText.UseVisualStyleBackColor = true;
            this.btnResetText.Click += new System.EventHandler(this.btnResetText_Click);
            // 
            // A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1339, 565);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "A";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRANG QUẢN LÍ PHIẾU";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearchBorrow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ádf;
        private System.Windows.Forms.Label lbff;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.TextBox txbNameBook;
        private System.Windows.Forms.TextBox txbTimeBorrow;
        private System.Windows.Forms.TextBox txbTimePay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address_;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameBook_;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeBorrow_;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimePay_;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDEL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnResetText;
    }
}

