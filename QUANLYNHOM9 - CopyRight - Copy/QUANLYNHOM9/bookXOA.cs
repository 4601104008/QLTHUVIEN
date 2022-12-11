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
    public partial class bookXOA : Form
    {
        QUANLITHUVIENK45Entities1 db = new QUANLITHUVIENK45Entities1();
        public bookXOA()
        {
            InitializeComponent();
            loadBookData();
            loadSachDataToCombobox();
        }
        private void loadBookData()
        {
            dataGridView1.Rows.Clear();
            List<SACH> listsach = db.SACHes.ToList();
            foreach (SACH item in listsach)
            {
                string sachid = item.MaSach;
                KESACH kesach = db.KESACHes.Where(w => w.MaSach == sachid).SingleOrDefault();
                string[] row = { item.ID, item.TenSach, item.TacGia, kesach.TenTheLoaiSach, item.GiaSach, item.SoLuong, item.NXB };
                dataGridView1.Rows.Add(row);
            }
        }
        private void loadSachDataToCombobox()
        {
            List<KESACH> listkesach = db.KESACHes.ToList();
            foreach (KESACH item in listkesach)
            {
                cbCategory.Items.Add(item.TenTheLoaiSach);
            }
            cbCategory.SelectedIndex = -1;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool ff = false;
            List<SACH> listSACH = db.SACHes.ToList();
            if (txbID.Text != "")
            {
                foreach (SACH item in listSACH)
                {
                    if (item.ID == txbID.Text)
                    {
                        string delete = txbID.Text;
                        SACH sach = db.SACHes.Where(w => w.ID == delete).SingleOrDefault();
                        db.SACHes.Remove(sach);
                        db.SaveChanges();
                        loadBookData();
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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                currentRows = dataGridView1.CurrentCell.RowIndex;
                txbID.Text = dataGridView1.Rows[currentRows].Cells[0].Value.ToString();
                txbBookName.Text = dataGridView1.Rows[currentRows].Cells[1].Value.ToString();
                txbReadDer.Text = dataGridView1.Rows[currentRows].Cells[2].Value.ToString();
                cbCategory.SelectedItem = dataGridView1.Rows[currentRows].Cells[3].Value.ToString();
                txbPrice.Text = dataGridView1.Rows[currentRows].Cells[4].Value.ToString();
                txbNumber.Text = dataGridView1.Rows[currentRows].Cells[5].Value.ToString();
                txbPublishingHouse.Text = dataGridView1.Rows[currentRows].Cells[6].Value.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bookXOA settings = new bookXOA();
            this.Close();
            settings.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int dem = 0;
            bool ff = false;
            bool fifa = false;
            bool comboboxbe = false;
            SACH newSACH = new SACH();
            if (txbID.Text != "")
            {
                //newSACH.ID = txbID.Text;
                dem++;
                fifa = true;
            }
            if (txbBookName.Text != "")
            {
                newSACH.TenSach = txbBookName.Text;
                dem++;
            }
            if (txbReadDer.Text != "")
            {
                newSACH.TacGia = txbReadDer.Text;
                dem++;
            }
            if (cbCategory.SelectedIndex >= 0)
            {
                string cccc = cbCategory.Text;
                KESACH kesach = db.KESACHes.Where(w => w.TenTheLoaiSach == cccc).SingleOrDefault();
                newSACH.MaSach = kesach.MaSach;
                dem++;
                comboboxbe = true;
            }
            if (txbPrice.Text != "")
            {
                newSACH.GiaSach = txbPrice.Text;
                dem++;
            }
            if (txbNumber.Text != "")
            {
                newSACH.SoLuong = txbNumber.Text;
                dem++;
            }
            if (txbPublishingHouse.Text != "")
            {
                newSACH.NXB = txbPublishingHouse.Text;
                dem++;
            }
            string idchange = txbID.Text;
            List<SACH> listsach = db.SACHes.ToList();
            if (dem == 7)
            {
                foreach (SACH item in listsach)
                {
                    if (item.ID == idchange)
                    {
                        item.TenSach = newSACH.TenSach;
                        item.TacGia = newSACH.TacGia;
                        item.MaSach = newSACH.MaSach;
                        item.GiaSach = newSACH.GiaSach;
                        item.SoLuong = newSACH.SoLuong;
                        item.NXB = newSACH.NXB;
                        ff = true;
                        break;
                    }
                }
                if (ff == true) { MessageBox.Show("Sửa thành công"); }
                else { MessageBox.Show("Không có khách hàng nào để sửa cả!!!"); }
                db.SaveChanges();
                loadBookData();
            }
            else if (fifa == true && comboboxbe == true) { MessageBox.Show("Mời bạn nhập đầy đủ!!!"); }
            else if (fifa == true && comboboxbe == false) { MessageBox.Show("Vui lòng chọn thể loại sách trong danh sách cần chọn!"); }
            else if (fifa == false) { MessageBox.Show("Không nhập ID lấy đâu để sửa!!!"); }
        }

        private void btnResetText_Click(object sender, EventArgs e)
        {
            txbID.Text = "";
            txbBookName.Text = "";
            txbReadDer.Text = "";
            cbCategory.SelectedIndex = -1;
            txbPrice.Text = "";
            txbNumber.Text = "";
            txbPublishingHouse.Text = "";
        }
    }
}
