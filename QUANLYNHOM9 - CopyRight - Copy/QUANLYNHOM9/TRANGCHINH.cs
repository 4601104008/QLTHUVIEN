using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QUANLYNHOM9
{
    public partial class TRANGCHINH : Form
    {
        QUANLITHUVIENK45Entities1 db = new QUANLITHUVIENK45Entities1();
        public TRANGCHINH()
        {
            InitializeComponent();
            loadDataBook();
        }

        private void loadDataBook()
        {
            dtgvTRANGCHINH.Rows.Clear();
            List<SACH> listSach = db.SACHes.ToList();
            foreach (SACH item in listSach)
            {
                string phieusach = item.MaSach;
                KESACH kesach = db.KESACHes.Where(w => w.MaSach == phieusach).SingleOrDefault();
                string[] row = 
                { item.TenSach, 
                item.TacGia,
                kesach.TenTheLoaiSach,
                item.NXB + "",
                item.SoLuong,
                item.GiaSach,
                };
                dtgvTRANGCHINH.Rows.Add(row);
            }
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tÌMKIẾMToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Form2 f = new Form2();
            //f.Show();
        }

        private void tHOÁTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TRANGCHINH settings = new TRANGCHINH();
            this.Close();
            settings.Close();
        }

        private void dtgvTRANGCHINH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tHAYĐỖIMKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fACCOUNT f = new fACCOUNT();

            f.Show();
        }

        private void cHỈNHSỬASÁCHToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TRANGCHINH_Load(object sender, EventArgs e)
        {

        }

        private void đĂNGXUẤTToolStripMenuItem_Click(object sender, EventArgs e)
        {

            TRANGCHINH settings = new TRANGCHINH();
            this.Close();
            settings.Close();
        }

        private void pHIEUMUONToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cÔNGCỤToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pHIÊUMƯỢNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            book f = new book();

            f.Show();
        }

        private void pHIẾUTRẢToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void dtgvTRANGCHINH_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tÌMKIẾMToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            QLTHELOAI f = new QLTHELOAI();

            f.Show();
        }

        private void pHIẾUSÁCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A f = new A();

            f.Show();
        }

        private void tÀIKHOẢNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fACCOUNT f = new fACCOUNT();

            f.Show();
        }

        private void đĂNGXUẤTToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TRANGCHINH settings = new TRANGCHINH();
            this.Close();
            settings.Close();
        }
    }
}
