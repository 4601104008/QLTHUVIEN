namespace QUANLYNHOM9
{
    partial class AXOA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AXOA));
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ID_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameBook_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeBorrow_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimePay_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbID = new System.Windows.Forms.TextBox();
            this.ládf = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbff = new System.Windows.Forms.Label();
            this.ádf = new System.Windows.Forms.Label();
            this.txbTimePay = new System.Windows.Forms.TextBox();
            this.txbTimeBorrow = new System.Windows.Forms.TextBox();
            this.txbNameBook = new System.Windows.Forms.TextBox();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHUY = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnResetText = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(29, 369);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 39);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_,
            this.Category_,
            this.Name_,
            this.Address_,
            this.NameBook_,
            this.TimeBorrow_,
            this.TimePay_,
            this.status_});
            this.dataGridView2.Location = new System.Drawing.Point(12, 81);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(793, 357);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // ID_
            // 
            this.ID_.HeaderText = "ID";
            this.ID_.MinimumWidth = 6;
            this.ID_.Name = "ID_";
            // 
            // Category_
            // 
            this.Category_.HeaderText = "HỌ TÊN";
            this.Category_.MinimumWidth = 6;
            this.Category_.Name = "Category_";
            // 
            // Name_
            // 
            this.Name_.HeaderText = "ĐỊA CHỈ";
            this.Name_.MinimumWidth = 6;
            this.Name_.Name = "Name_";
            // 
            // Address_
            // 
            this.Address_.HeaderText = "TÊN SÁCH";
            this.Address_.MinimumWidth = 6;
            this.Address_.Name = "Address_";
            // 
            // NameBook_
            // 
            this.NameBook_.HeaderText = "THỂ LOẠI";
            this.NameBook_.MinimumWidth = 6;
            this.NameBook_.Name = "NameBook_";
            // 
            // TimeBorrow_
            // 
            this.TimeBorrow_.HeaderText = "TG MƯỢN";
            this.TimeBorrow_.MinimumWidth = 6;
            this.TimeBorrow_.Name = "TimeBorrow_";
            // 
            // TimePay_
            // 
            this.TimePay_.HeaderText = "TG TRẢ";
            this.TimePay_.MinimumWidth = 6;
            this.TimePay_.Name = "TimePay_";
            // 
            // status_
            // 
            this.status_.HeaderText = "TÌNH TRẠNG";
            this.status_.MinimumWidth = 6;
            this.status_.Name = "status_";
            // 
            // txbID
            // 
            this.txbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.Location = new System.Drawing.Point(137, 10);
            this.txbID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(201, 23);
            this.txbID.TabIndex = 8;
            // 
            // ládf
            // 
            this.ládf.AutoSize = true;
            this.ládf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ládf.Location = new System.Drawing.Point(68, 12);
            this.ládf.Name = "ládf";
            this.ládf.Size = new System.Drawing.Size(21, 17);
            this.ládf.TabIndex = 11;
            this.ládf.Text = "ID";
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(137, 193);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(201, 25);
            this.cbCategory.TabIndex = 28;
            // 
            // cbStatus
            // 
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(137, 316);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(201, 25);
            this.cbStatus.TabIndex = 27;
            this.cbStatus.SelectedValueChanged += new System.EventHandler(this.cbStatus_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tình trạng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(39, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Thời gian trả";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Thời gian mượn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Tên sách";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Địa chỉ";
            // 
            // lbff
            // 
            this.lbff.AutoSize = true;
            this.lbff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbff.Location = new System.Drawing.Point(48, 54);
            this.lbff.Name = "lbff";
            this.lbff.Size = new System.Drawing.Size(50, 17);
            this.lbff.TabIndex = 24;
            this.lbff.Text = "Họ tên";
            // 
            // ádf
            // 
            this.ádf.AutoSize = true;
            this.ádf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ádf.Location = new System.Drawing.Point(39, 197);
            this.ádf.Name = "ádf";
            this.ádf.Size = new System.Drawing.Size(59, 17);
            this.ádf.TabIndex = 25;
            this.ádf.Text = "Thể loại";
            // 
            // txbTimePay
            // 
            this.txbTimePay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTimePay.Location = new System.Drawing.Point(140, 279);
            this.txbTimePay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTimePay.Name = "txbTimePay";
            this.txbTimePay.Size = new System.Drawing.Size(199, 23);
            this.txbTimePay.TabIndex = 15;
            // 
            // txbTimeBorrow
            // 
            this.txbTimeBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTimeBorrow.Location = new System.Drawing.Point(140, 240);
            this.txbTimeBorrow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTimeBorrow.Name = "txbTimeBorrow";
            this.txbTimeBorrow.Size = new System.Drawing.Size(199, 23);
            this.txbTimeBorrow.TabIndex = 16;
            // 
            // txbNameBook
            // 
            this.txbNameBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNameBook.Location = new System.Drawing.Point(137, 144);
            this.txbNameBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbNameBook.Name = "txbNameBook";
            this.txbNameBook.Size = new System.Drawing.Size(201, 23);
            this.txbNameBook.TabIndex = 17;
            // 
            // txbAddress
            // 
            this.txbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAddress.Location = new System.Drawing.Point(137, 101);
            this.txbAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(201, 23);
            this.txbAddress.TabIndex = 18;
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Location = new System.Drawing.Point(137, 52);
            this.txbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(201, 23);
            this.txbName.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnResetText);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnHUY);
            this.panel1.Controls.Add(this.ládf);
            this.panel1.Controls.Add(this.cbCategory);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.txbID);
            this.panel1.Controls.Add(this.cbStatus);
            this.panel1.Controls.Add(this.txbName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbAddress);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txbNameBook);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txbTimeBorrow);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txbTimePay);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.ádf);
            this.panel1.Controls.Add(this.lbff);
            this.panel1.Location = new System.Drawing.Point(854, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 422);
            this.panel1.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 369);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 39);
            this.button1.TabIndex = 30;
            this.button1.Text = "SỬA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHUY
            // 
            this.btnHUY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHUY.Location = new System.Drawing.Point(251, 369);
            this.btnHUY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHUY.Name = "btnHUY";
            this.btnHUY.Size = new System.Drawing.Size(89, 39);
            this.btnHUY.TabIndex = 29;
            this.btnHUY.Text = "HỦY";
            this.btnHUY.UseVisualStyleBackColor = true;
            this.btnHUY.Click += new System.EventHandler(this.btnHUY_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(145, -5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 58);
            this.label1.TabIndex = 30;
            this.label1.Text = "TRANG XÓA";
            // 
            // btnResetText
            // 
            this.btnResetText.Location = new System.Drawing.Point(395, 12);
            this.btnResetText.Name = "btnResetText";
            this.btnResetText.Size = new System.Drawing.Size(60, 61);
            this.btnResetText.TabIndex = 31;
            this.btnResetText.Text = "Nhập lại";
            this.btnResetText.UseVisualStyleBackColor = true;
            this.btnResetText.Click += new System.EventHandler(this.btnResetText_Click);
            // 
            // AXOA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1325, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AXOA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRANG XÓA PHIẾU";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label ládf;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbff;
        private System.Windows.Forms.Label ádf;
        private System.Windows.Forms.TextBox txbTimePay;
        private System.Windows.Forms.TextBox txbTimeBorrow;
        private System.Windows.Forms.TextBox txbNameBook;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHUY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address_;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameBook_;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeBorrow_;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimePay_;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnResetText;
    }
}