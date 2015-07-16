using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWinForm
{
    public partial class FormDangNhap : Form
    {
        string[,] ArrAccount = new string[3, 2];
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnCencal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string UserName = txtUserName.Text;
            string Password = txtPassword.Text;

            if(UserName == "")
            {
                MessageBox.Show("Xin nhập UserName !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return;
            }
            if (Password == "")
            {
                MessageBox.Show("Xin nhập Password !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            for (int i = 0; i < 3; i++)
            {
                string user = ArrAccount[i, 0];
                string pass = ArrAccount[i, 1];

                if (user == UserName && pass == Password)
                {
                    MessageBox.Show("Dang Nhap thanh cong !", "Chúc Mừng", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
            }
            MessageBox.Show("Sai Username/Password !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

            ArrAccount[0, 0] = "admin1";
            ArrAccount[0, 1] = "pass1";

            ArrAccount[1, 0] = "admin2";
            ArrAccount[1, 1] = "pass2";

            ArrAccount[2, 0] = "admin3";
            ArrAccount[2, 1] = "pass3";
        }
    }
}
