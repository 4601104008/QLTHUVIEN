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
    public partial class Form1 : Form
    {
        QUANLITHUVIENK45Entities1 db = new QUANLITHUVIENK45Entities1();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            TRANGCHINH f = new TRANGCHINH();
            bool user = false;
            bool pass = false;
            List<TAIKHOAN> listtaikhoan = db.TAIKHOANs.ToList();
            foreach (TAIKHOAN item in listtaikhoan )
            {
                if(item.MatKhau==txbPass.Text)
                {
                    pass = true;
                }
                if(item.TenDangNhap==txbUser.Text)
                {
                    user = true;
                }
            }
            if (user==true&&pass==true)
            {
                f.ShowDialog();
            }else if(txbUser.Text.Length != 0 && txbPass.Text.Length != 0) { 
                MessageBox.Show("Tên đăng nhập và mật khẩu có thể không đúng!!!"); 
            } 
            else if (txbUser.Text.Length == 0 && txbPass.Text.Length != 0)
            {
                MessageBox.Show("Bạn chưa nhập tài khoản!");
            }
            else if(txbUser.Text.Length != 0 && txbPass.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu!");
            }
            else if(txbUser.Text.Length == 0 && txbPass.Text.Length == 0)
            {
                MessageBox.Show("Mời bạn nhập tài khoản và mật khẩu để xác minh danh tính!!!");
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1 settings = new Form1();
            this.Close();
            settings.Close();
        }
        private void TRANGCHINH_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
