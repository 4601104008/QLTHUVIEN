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
    public partial class Form2 : Form
    {
        QUANLYNHOM9Entities3 db = new QUANLYNHOM9Entities3();
       
        public Form2()
        {
            InitializeComponent();
            loadDataBook();
            loadCategoryToCombobox();
        }
        private void loadDataBook()
        {
            dataGridViewBook.Rows.Clear();
            List<SACH> listSach = db.SACHes.ToList();
            foreach (SACH item in listSach)
            {
                int theloaiIder = (int)item.TheLoai_id; 
                THELOAI theloai = db.THELOAIs.Where(w => w.ID_ == theloaiIder).SingleOrDefault();
                string[] row = { item.ID_ + "", item.Ten_, item.TacGia_, theloai.Ten,item.NXB_ + "" };
                dataGridViewBook.Rows.Add(row);
            }
        }
        private void loadCategoryToCombobox()
        {
            List<THELOAI> listSach = db.THELOAIs.ToList();
            foreach (THELOAI item in listSach)
            {
                cbCategory.Items.Add(item.Ten);
            }
            cbCategory.SelectedIndex = 0;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SACH newSach = new SACH();
            newSach.ID_ = int.Parse(txbID.Text);
            newSach.Ten_ = txbName.Text;
            newSach.TacGia_ = txbWriter.Text;
            string departmentName = cbCategory.Text;
            THELOAI department = db.THELOAIs.Where(w => w.Ten == departmentName).SingleOrDefault();
            newSach.TheLoai_id = department.ID_;
            newSach.NXB_ = DateTime.Parse(txbDateofpublishing.Text);
            db.SACHes.Add(newSach);
            db.SaveChanges();
            loadDataBook();
        }
        private void dataGridViewBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int currenRow;
            currenRow = dataGridViewBook.CurrentCell.RowIndex;

            txbID.Text = int.Parse(dataGridViewBook.Rows[currenRow].Cells[0].Value.ToString()) + "";
            txbName.Text = dataGridViewBook.Rows[currenRow].Cells[1].Value.ToString();
            txbWriter.Text = dataGridViewBook.Rows[currenRow].Cells[2].Value.ToString();
            cbCategory.SelectedItem = dataGridViewBook.Rows[currenRow].Cells[3].Value.ToString();
            txbDateofpublishing.Text = dataGridViewBook.Rows[currenRow].Cells[4].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            int idToDelete = int.Parse(txbID.Text);
            SACH toDelete = db.SACHes.Where(w => w.ID_ == idToDelete).SingleOrDefault();
            db.SACHes.Remove(toDelete);
            db.SaveChanges();
            loadDataBook(); 

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SACH newSach = new SACH();
            newSach.ID_ = int.Parse(txbID.Text);
            newSach.Ten_ = txbName.Text;
            newSach.TacGia_ = txbWriter.Text;
            string theloaisach = cbCategory.Text;
            THELOAI TLS = db.THELOAIs.Where(w => w.Ten == theloaisach).SingleOrDefault();
            newSach.TheLoai_id = TLS.ID_;
            newSach.NXB_ = DateTime.Parse(txbDateofpublishing.Text);
            // Lay ra...
            int idChange = int.Parse(txbID.Text);
            //var query = from old in db.SACHes where old.ID_ == idChange select old;
            List<SACH> query = db.SACHes.ToList();
            SACH bbbb = db.SACHes.Where(w => w.ID_ == idChange).SingleOrDefault();
            foreach (SACH item in query)
            {
                if (item.ID_ == idChange)
                {
                    item.ID_ = newSach.ID_;
                    item.Ten_ = newSach.Ten_;
                    item.TacGia_ = newSach.TacGia_;
                    item.NXB_ = newSach.NXB_;
                    item.TheLoai_id = newSach.TheLoai_id;
                    //item.THELOAI = newSach.THELOAI;
                }
            }
            db.SaveChanges();
            loadDataBook();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txbID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}