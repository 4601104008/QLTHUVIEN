
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
    public partial class fACCOUNT : Form
    {
        QUANLITHUVIENK45Entities1 db = new QUANLITHUVIENK45Entities1();
        public fACCOUNT()
        {
            InitializeComponent();
            loadDataTAIKHOAN();
        }
        private void loadDataTAIKHOAN()
        {
            dtgvTAIKHOAN.Rows.Clear();
            List<TAIKHOAN> listTaikhoan = db.TAIKHOANs.ToList();
            foreach (TAIKHOAN item in listTaikhoan)
            {
                string[] row = { item.ID + "", item.TenDangNhap,  item.MatKhau + "" };
                dtgvTAIKHOAN.Rows.Add(row);
            }
        }
        private void dtgvTAIKHOAN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int currenRow;
            currenRow = dtgvTAIKHOAN.CurrentCell.RowIndex;
            txtID.Text = dtgvTAIKHOAN.Rows[currenRow].Cells[0].Value.ToString();
            txbTAIKHOAN.Text = dtgvTAIKHOAN.Rows[currenRow].Cells[1].Value.ToString() ;
            txbMATKHAU.Text = dtgvTAIKHOAN.Rows[currenRow].Cells[2].Value.ToString() ;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int dem = 0;
            bool christmas = true;
            TAIKHOAN newtaikhoan = new TAIKHOAN();
            if (txtID.Text!="")
            {
                newtaikhoan.ID = txtID.Text;
                dem++;
            }
            if (txbTAIKHOAN.Text != "")
            {
                newtaikhoan.TenDangNhap = txbTAIKHOAN.Text;
                dem++;
            }
            if (txbMATKHAU.Text != "")
            {
                newtaikhoan.MatKhau = txbMATKHAU.Text;
                dem++;
            }
            List<TAIKHOAN> listtaikhoan = db.TAIKHOANs.ToList();
            foreach (TAIKHOAN item in listtaikhoan )
            {
                if(item.ID == txtID.Text)
                {
                    christmas = false;
                }
            }
            if(dem==3)
            {
                if(christmas == true)
                {
                    db.TAIKHOANs.Add(newtaikhoan);
                    db.SaveChanges();
                    loadDataTAIKHOAN();
                    MessageBox.Show("Đăng kí thành công!!!");
                } else
                {
                    MessageBox.Show("ID bạn muốn đã bị trùng, mời bạn nhập ID khác!");
                }
            } else
            {
                MessageBox.Show("Mời bạn nhập đầy đủ!!!");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            List<TAIKHOAN> listTaikhoan = db.TAIKHOANs.ToList();
            TAIKHOAN newtaikhoan = new TAIKHOAN();
            int dem = 0;
            bool pikachu = false;
            bool test = false;
            if(txtID.Text!="")
            {
                newtaikhoan.ID = txtID.Text;
                dem++;
                test = true;
            }
            if(txbTAIKHOAN.Text!="")
            {
                newtaikhoan.TenDangNhap = txbTAIKHOAN.Text;
                dem++;
            }
            if(txbMATKHAU.Text!="")
            {
                newtaikhoan.MatKhau = txbMATKHAU.Text;
                dem++;
            }
            foreach (TAIKHOAN item in listTaikhoan)
            {
                if (item.ID == txtID.Text)
                {
                    pikachu = true;
                }
            }
            if(dem == 3  )
            {
                if( pikachu == true)
                {
                    string idChange = txtID.Text;
                    List<TAIKHOAN> query = db.TAIKHOANs.ToList();
                    TAIKHOAN bbbb = db.TAIKHOANs.Where(w => w.ID == idChange).SingleOrDefault();
                    foreach (TAIKHOAN item in query)
                    {
                        if (item.ID == idChange)
                        {
                            item.ID = newtaikhoan.ID;
                            item.TenDangNhap = newtaikhoan.TenDangNhap;
                            item.MatKhau = newtaikhoan.MatKhau;

                        }
                    }
                    db.SaveChanges();
                    loadDataTAIKHOAN();
                    MessageBox.Show("Sửa thành công!!!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tài khoản cần sửa!!!");
                }
            }else if(test == true)
            {
                MessageBox.Show("Mời bạn nhập đầy đủ!!!");
            } else if(test == false)
            {
                MessageBox.Show("Không nhập ID lấy đâu mà sửa???");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            bool bikiba = false;
            List<TAIKHOAN> listtaikhoan = db.TAIKHOANs.ToList();
            foreach (TAIKHOAN item in listtaikhoan)
            {
                if(item.ID == txtID.Text) { bikiba = true; }
            }
            if (txtID.Text != "" && bikiba == true)
            {
                string idToDelete = txtID.Text;
                TAIKHOAN toDelete = db.TAIKHOANs.Where(w => w.ID == idToDelete).SingleOrDefault();
                db.TAIKHOANs.Remove(toDelete);
                db.SaveChanges();
                loadDataTAIKHOAN();
                MessageBox.Show("Xóa thành công!");
            }
            else if(txtID.Text != "" && bikiba == false)
            {
                MessageBox.Show("Không tìm thấy tài khoản cần xóa!!!");
            }else { MessageBox.Show("Không nhập ID lấy gì để xóa???"); }
        }
        private void button4_Click(object sender, EventArgs e)
        {
           fACCOUNT settings = new fACCOUNT();
            this.Close();
            settings.Close();
        }

        private void btnRefreshText_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txbTAIKHOAN.Text = "";
            txbMATKHAU.Text = "";
        }
    }
}
