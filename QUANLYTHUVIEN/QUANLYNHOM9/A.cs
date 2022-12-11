using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYNHOM9
{
    public partial class A : Form
    {
        QUANLITHUVIENK45Entities1 db = new QUANLITHUVIENK45Entities1();
        List<TINHTRANG> listStatus ;
        public A()
        {
            InitializeComponent();
            loadBookDaTa();
            loadListCategoryStatus();
            loadBookDataToCombobox();
        }
        private static string Getramdomid()
        {
            Random obj = new Random();
            return obj.Next(1000000).ToString() ;
        }
        private void loadBookDataToCombobox()
        {
            List<KESACH> listkesach = db.KESACHes.ToList();
            foreach(KESACH item in listkesach)
            {
                cbCategory.Items.Add(item.TenTheLoaiSach);
            }
            cbCategory.SelectedIndex = -1;
        }
        private void loadBookDaTa()
        {
            dataGridView1.Rows.Clear();
            List<PHIEUSACH> listPHIEUSACH = db.PHIEUSACHes.ToList();
            foreach (PHIEUSACH item in listPHIEUSACH)
            {
                string phieusach = item.MaSach;
                KESACH kesach = db.KESACHes.Where(w => w.MaSach == phieusach).SingleOrDefault();
                string[] row = { item.ID, item.Hoten, item.Diachi, item.Tensach, kesach.TenTheLoaiSach, item.Thoigianmuon + "", item.Thoigiantra + "" ,item.Tinhtrang};
                dataGridView1.Rows.Add(row);
            }
        }
        private void loadListCategoryStatus()
        {
            listStatus = new List<TINHTRANG>();
            listStatus.Add(new TINHTRANG() { id = 0 });
            listStatus.Add(new TINHTRANG() { id = 1, name = "CHƯA CHỌN" });
            listStatus.Add(new TINHTRANG() { id = 2, name = "ĐÃ TRẢ" });
            listStatus.Add(new TINHTRANG() { id = 3, name = "CHƯA TRẢ" });
            listStatus.Add(new TINHTRANG() { id = 4, name = "TRẢ TRỄ" });
            listStatus.Add(new TINHTRANG() { id = 5, name = "MẤT SÁCH" });
            listStatus.Add(new TINHTRANG() { id = 5, name = "ĐÃ ĐK MƯỢN" });
            cbStatus.DataSource = listStatus;
            cbStatus.DisplayMember = "name";
        }
        private void cbStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if(cb.SelectedValue!=null)
            {
                TINHTRANG status = cb.SelectedValue as TINHTRANG;
            }
        }
        int currentRows;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentRows = dataGridView1.CurrentCell.RowIndex;

            
           
            txbName.Text= dataGridView1.Rows[currentRows].Cells[1].Value.ToString();
            txbAddress.Text= dataGridView1.Rows[currentRows].Cells[2].Value.ToString();
            txbNameBook.Text= dataGridView1.Rows[currentRows].Cells[3].Value.ToString();
            cbCategory.SelectedItem = dataGridView1.Rows[currentRows].Cells[4].Value.ToString();
            txbTimeBorrow.Text= DateTime.Parse(dataGridView1.Rows[currentRows].Cells[5].Value.ToString())+"";
            txbTimePay.Text= DateTime.Parse(dataGridView1.Rows[currentRows].Cells[6].Value.ToString()) + "";

            
            string siii = dataGridView1.Rows[currentRows].Cells[7].Value.ToString();
            TINHTRANG pppp = listStatus.Where(w => w.name == siii).SingleOrDefault();
            cbStatus.Text = pppp.name;
            

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int dem = 0;
            PHIEUSACH newPHIEUSACH = new PHIEUSACH();
            string pucava = cbCategory.Text;
            bool tacjaCategory = false;
            bool tacjaStatus = false;
            if (cbCategory.SelectedIndex >= 0)
            {
                KESACH ngububu = db.KESACHes.Where(w => w.TenTheLoaiSach == pucava).SingleOrDefault();
                newPHIEUSACH.MaSach = ngububu.MaSach;
                dem++;
                tacjaCategory = true;
            }
            if (txbName.Text != "")
            {
                newPHIEUSACH.Hoten = txbName.Text;
                dem++;
            }
            if (txbAddress.Text != "")
            {
                newPHIEUSACH.Diachi = txbAddress.Text;
                dem++;
            }
            if (txbNameBook.Text != "")
            {
                newPHIEUSACH.Tensach = txbNameBook.Text;
                dem++;
            }

            if (txbTimeBorrow.Text != "")
            {
                newPHIEUSACH.Thoigianmuon = DateTime.Parse(txbTimeBorrow.Text);
                dem++;
            }

            if (txbTimePay.Text != "")
            {
                newPHIEUSACH.Thoigiantra = DateTime.Parse(txbTimePay.Text);
                dem++;
            }


            string bakaka = cbStatus.Text;
            if (cbStatus.SelectedIndex >= 1)
            {
                TINHTRANG munaca = listStatus.Where(w => w.name == bakaka).SingleOrDefault();
                newPHIEUSACH.Tinhtrang = munaca.name;
                dem++;
                tacjaStatus = true;
            }
            if (dem == 7)
            {
                newPHIEUSACH.ID = "NINE" + Getramdomid();
                db.PHIEUSACHes.Add(newPHIEUSACH);
                db.SaveChanges();
                loadBookDaTa();
                MessageBox.Show("Thêm thành công");
            }
            else if (tacjaCategory == false && tacjaStatus == false)
            {
                MessageBox.Show("Mời bạn chọn thể loại và tình trạng hiện có trong combobox!!!");
            }
            else if (tacjaCategory == false && tacjaStatus == true)
            {
                MessageBox.Show("Mời bạn chọn thể loại hiện có trong combobox!!!");
            }
            else if (tacjaCategory == true && tacjaStatus == false)
            {
                MessageBox.Show("Mời bạn chọn tình trạng hiện có trong combobox!!!");
            }
            else if (tacjaCategory == true && tacjaStatus == true)
            {
                MessageBox.Show("Mời bạn nhập đầy đủ!!!");
            }
        }
        private void btnSearchBorrow_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            bool test = false;
            bool bakabi = false;
            foreach (TINHTRANG item in listStatus)
            {
                if (item.name == cbStatus.Text)
                {
                    bakabi = true;
                }
            }
            if (bakabi == true)
            {
                List<PHIEUSACH> listPHIEUSACH = db.PHIEUSACHes.ToList();
                foreach (PHIEUSACH item in listPHIEUSACH)
                {
                    if (item.Tinhtrang == cbStatus.Text)
                    {
                        string phieusach = item.MaSach;
                        KESACH kesach = db.KESACHes.Where(w => w.MaSach == phieusach).SingleOrDefault();
                        string[] row = { item.ID, kesach.MaSach, item.Hoten, item.Diachi, item.Tensach, item.Thoigianmuon + "", item.Thoigiantra + "", item.Tinhtrang };
                        dataGridView1.Rows.Add(row);
                        test = true;
                    }
                }
                if (test == false)
                {
                    MessageBox.Show("Không tình trạng nào đang diễn ra!!!");
                    loadBookDaTa();
                }
            }
            else
            {
                MessageBox.Show("Mời bạn chọn tình trạng hiện có trong combobox!");
                loadBookDaTa();
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadBookDaTa();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AXOA f = new AXOA();
            f.Show();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            A settings = new A();
            this.Close();
            settings.Close();
        }

        private void btnResetText_Click(object sender, EventArgs e)
        {
            cbStatus.SelectedIndex = 0;
            txbName.Text = "";
            txbAddress.Text = "";
            txbNameBook.Text = "";
            cbCategory.SelectedIndex = -1;
            txbTimeBorrow.Text = "";
            txbTimePay.Text = "";
        }
    }
}
