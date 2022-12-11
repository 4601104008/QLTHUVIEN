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
    public partial class QLTHELOAI : Form
    {
        QUANLITHUVIENK45Entities1 db = new QUANLITHUVIENK45Entities1();
        public QLTHELOAI()
        {
            InitializeComponent();
            loadDataTHELOAI();
        }
        private void loadDataTHELOAI()
        {
            dtgvTHELOAI.Rows.Clear();
            List<KESACH> listTHELOAI = db.KESACHes.ToList();
            foreach (KESACH item in listTHELOAI)
            {
                string[] row = { item.MaSach, item.TenTheLoaiSach};
                dtgvTHELOAI.Rows.Add(row);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int dem = 0;
            KESACH newTHELOAI = new KESACH();
            if(txtID.Text!="")
            {
                newTHELOAI.MaSach = txtID.Text;
                dem++;
            }
            if(txtID.Text!="")
            {
                newTHELOAI.TenTheLoaiSach = txbTHELOAI.Text;
                dem++;
            }
            bool operaID = true;
            bool operaName = true;
            List<KESACH> listkesach = db.KESACHes.ToList();
            foreach(KESACH item in listkesach)
            {
                if(item.MaSach == txtID.Text)
                {
                    operaID = false;
                }
                if(item.TenTheLoaiSach == txbTHELOAI.Text)
                {
                    operaName = false;
                }
            }
            if(dem==2)
            {
                if(operaID == true&&operaName == true)
                {
                    db.KESACHes.Add(newTHELOAI);
                    db.SaveChanges();
                    loadDataTHELOAI();
                    MessageBox.Show("Thêm thành công!");
                } else if(operaID == false && operaName == true)
                {
                    MessageBox.Show("Đã có ID bị trùng, mời bạn nhập ID khác!");
                } else if(operaID == true && operaName == false)
                {
                    MessageBox.Show("Đã có tên thể loại bị trùng, mời bạn nhập tên khác!");
                } else if(operaID == false && operaName == false)
                {
                    MessageBox.Show("Đã có tên thể loại và ID bị trùng, mời bạn nhập ID và tên khác!");
                }
                
            }else
            {
                MessageBox.Show("Mời bạn nhập đầy đủ!!!");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            List<KESACH> listkesach = db.KESACHes.ToList();
            bool midata = false;
            foreach(KESACH item in listkesach)
            {
                if(item.MaSach == txtID.Text)
                {
                    midata = true;
                }
            }
            string idToDelete = txtID.Text;
            KESACH toDelete = db.KESACHes.Where(w => w.MaSach == idToDelete).SingleOrDefault();
            if (txtID.Text != "" && midata == true)
            {
                db.KESACHes.Remove(toDelete);
                db.SaveChanges();
                loadDataTHELOAI();
                MessageBox.Show("Xóa thành công!");
            }else if(txtID.Text=="")
            {
                MessageBox.Show("Không nhập iD lấy gì để xóa!");
            }else if(midata == false)
            {
                MessageBox.Show("Không tồn tại ID trong kệ sách!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KESACH newKESACH = new KESACH();
            int dem = 0;
            bool bimono = false;
            if(txtID.Text!="")
            {
                newKESACH.MaSach = txtID.Text;
                dem++;
            }
            if(txbTHELOAI.Text!="")
            {
                newKESACH.TenTheLoaiSach = txbTHELOAI.Text;
                dem++;
            }
            List<KESACH> query = db.KESACHes.ToList();
            foreach (KESACH item in query )
            {
                if(item.MaSach == txtID.Text)
                {
                    bimono = true;
                }
            }
            if (dem == 2)
            {
                if (bimono == true)
                {
                    foreach (KESACH item in query)
                    {
                        if (item.MaSach == txtID.Text)
                        {
                            item.MaSach = newKESACH.MaSach;
                            item.TenTheLoaiSach = newKESACH.TenTheLoaiSach;
                        }
                    }
                    db.SaveChanges();
                    loadDataTHELOAI();
                    MessageBox.Show("Sửa thành công!");
                }else
                {
                    MessageBox.Show("Không có quyển sách trong danh sách để sửa!!!");
                }
            }else if(bimono == false)
            {
                MessageBox.Show("Không nhập ID lấy đâu để sửa!!!");
            }else if(bimono == true)
            {
                MessageBox.Show("Mời bạn nhập đầy đủ!");
            }
        }

        private void dtgvTHELOAI_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int currenRow;
            currenRow = dtgvTHELOAI.CurrentCell.RowIndex;
            txtID.Text =dtgvTHELOAI.Rows[currenRow].Cells[0].Value.ToString();
            txbTHELOAI.Text = dtgvTHELOAI.Rows[currenRow].Cells[1].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            QLTHELOAI settings = new QLTHELOAI();
            this.Close();
            settings.Close();
        }

        private void btnRefreshText_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txbTHELOAI.Text = "";
        }
    }
}
