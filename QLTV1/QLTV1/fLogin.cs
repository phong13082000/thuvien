using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV1
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        bool Login(string username, string password)
        {
            return AccountDAO.Instance.Login(username, password);
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txbUserName.Text;
            string password = txbPassWord.Text;
            if (Login(username, password))
            {
                fTableManager f = new fTableManager();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("      Sai tài khoản hoặc mật khẩu");
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("         THOÁT CHƯƠNG TRÌNH ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

