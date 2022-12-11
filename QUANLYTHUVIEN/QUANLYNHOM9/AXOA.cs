using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYNHOM9
{
    public partial class AXOA : Form
    {
        QUANLITHUVIENK45Entities1 db = new QUANLITHUVIENK45Entities1();
        List<TINHTRANG> listStatus;
        public AXOA()
        {
            InitializeComponent();
            loadBookDaTa();
            loadListCategoryStatus();
            loadBookDataToCombobox();
        }
        private void loadBookDataToCombobox()
        {
            List<KESACH> listkesach = db.KESACHes.ToList();
            foreach (KESACH item in listkesach)
            {
                cbCategory.Items.Add(item.TenTheLoaiSach);
            }
            cbCategory.SelectedIndex = -1;
        }
        private void loadBookDaTa()
        {
            dataGridView2.Rows.Clear();
            List<PHIEUSACH> listPHIEUSACH = db.PHIEUSACHes.ToList();
            foreach (PHIEUSACH item in listPHIEUSACH)
            {
                string phieusach = item.MaSach;
                KESACH kesach = db.KESACHes.Where(w => w.MaSach == phieusach).SingleOrDefault();
                string[] row = { item.ID, item.Hoten, item.Diachi, item.Tensach, kesach.TenTheLoaiSach, item.Thoigianmuon + "", item.Thoigiantra + "", item.Tinhtrang };
                dataGridView2.Rows.Add(row);
            }
        }
        private void loadListCategoryStatus()
        {
            listStatus = new List<TINHTRANG>();
            listStatus.Add(new TINHTRANG() { id = 0, name = "" });
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
            if (cb.SelectedValue != null)
            {
                TINHTRANG status = cb.SelectedValue as TINHTRANG;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool ff = false;
            List<PHIEUSACH> listPHIEUSACH = db.PHIEUSACHes.ToList();
            string nameDelete = txbID.Text;
            if (txbID.Text != "")
            {
                foreach (PHIEUSACH item in listPHIEUSACH)
                {
                    if (item.ID == nameDelete)
                    {
                        PHIEUSACH todelete = db.PHIEUSACHes.Where(w => w.ID == nameDelete).SingleOrDefault();
                        db.PHIEUSACHes.Remove(todelete);
                        db.SaveChanges();
                        loadBookDaTa();
                        ff = true;
                        break;
                    }
                }
                if (ff == true)
                {
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Không có khách hàng trong danh sách!");
                }
            }
            else
            {
                MessageBox.Show("Không nhập ID lấy gì để xóa ???");
            }
        }
        int currentRows;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentRows = dataGridView2.CurrentCell.RowIndex;


            txbID.Text = dataGridView2.Rows[currentRows].Cells[0].Value.ToString();
            txbName.Text = dataGridView2.Rows[currentRows].Cells[1].Value.ToString();
            txbAddress.Text = dataGridView2.Rows[currentRows].Cells[2].Value.ToString();
            txbNameBook.Text = dataGridView2.Rows[currentRows].Cells[3].Value.ToString();
            cbCategory.SelectedItem = dataGridView2.Rows[currentRows].Cells[4].Value.ToString();
            txbTimeBorrow.Text = DateTime.Parse(dataGridView2.Rows[currentRows].Cells[5].Value.ToString()) + "";
            txbTimePay.Text = DateTime.Parse(dataGridView2.Rows[currentRows].Cells[6].Value.ToString()) + "";

            ;
            string siii = dataGridView2.Rows[currentRows].Cells[7].Value.ToString();
            TINHTRANG pppp = listStatus.Where(w => w.name == siii).SingleOrDefault();
            cbStatus.Text = pppp.name;
        }
        private void btnHUY_Click(object sender, EventArgs e)
        {
            AXOA settings = new AXOA();
            this.Close();
            settings.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int dem = 0;
            bool ff = false;
            bool fifa = false;
            bool comboboxBe = false;
            bool comboboxTe = false;
            PHIEUSACH newPHIEUSACH = new PHIEUSACH();
            if (txbID.Text != "")
            {
                //newPHIEUSACH.ID = txbID.Text;
                dem++;
                fifa = true;
            }
            string stausff = cbCategory.Text;
            KESACH bababa = db.KESACHes.Where(w => w.TenTheLoaiSach == stausff).SingleOrDefault();
            if (cbCategory.SelectedIndex >= 0)
            {
                newPHIEUSACH.MaSach = bababa.MaSach;
                dem++;
                comboboxBe = true;
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
            if (cbStatus.SelectedIndex >= 1)
            {
                newPHIEUSACH.Tinhtrang = cbStatus.Text;
                dem++;
                comboboxTe = true;
            }

            string idchange = txbID.Text;
            List<PHIEUSACH> query = db.PHIEUSACHes.ToList();
            if (dem == 8)
            {
                foreach (PHIEUSACH item in query)
                {
                    if (item.ID == idchange)
                    {
                        //item.ID = newPHIEUSACH.ID;
                        item.MaSach = newPHIEUSACH.MaSach;
                        item.Hoten = newPHIEUSACH.Hoten;
                        item.Diachi = newPHIEUSACH.Diachi;
                        item.Tensach = newPHIEUSACH.Tensach;
                        item.Thoigianmuon = newPHIEUSACH.Thoigianmuon;
                        item.Thoigiantra = newPHIEUSACH.Thoigiantra;
                        item.Tinhtrang = newPHIEUSACH.Tinhtrang;
                        ff = true;
                        break;
                    }
                }
                if (ff == true) { MessageBox.Show("Sửa thành công"); }
                else { MessageBox.Show("Không có khách hàng nào để sửa cả!!!"); }

                db.SaveChanges();
                loadBookDaTa();
            }
            else if (fifa == true && comboboxBe == true && comboboxTe == true) { MessageBox.Show("Mời bạn nhập đầy đủ!!!"); }
            else if (fifa == true && comboboxBe == false && comboboxTe == true) { MessageBox.Show("Vui lòng chọn thể loại sách trong danh sách cần chọn!"); }
            else if (fifa == true && comboboxBe == true && comboboxTe == false) { MessageBox.Show("Vui lòng chọn tình trạng sách trong danh sách cần chọn!"); }
            else if (fifa == true && comboboxBe == false && comboboxTe == false) { MessageBox.Show("Tình trạng và thể loại không được để trống!"); }
            else if (fifa == false) { MessageBox.Show("Không nhập ID lấy đâu để sửa!!!"); }
        }

        private void btnResetText_Click(object sender, EventArgs e)
        {
            txbID.Text = "";
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
