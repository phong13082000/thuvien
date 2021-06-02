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
    public partial class fAccount : Form
    {
        BindingSource accountList = new BindingSource();

        public fAccount()
        {
            InitializeComponent();
            dtgvAccount.DataSource = accountList;
            LoadListAccount();
            AddAccountBinding();
        }
        void AddAccountBinding()
        {
            txbDisplayname.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Displayname", true, DataSourceUpdateMode.Never));
            txbUsername.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Username", true, DataSourceUpdateMode.Never));
            txbPassword.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Password", true, DataSourceUpdateMode.Never));
        }

        void LoadListAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string displayname = txbDisplayname.Text;
            string username = txbUsername.Text;
            string password = txbPassword.Text;

            if (AccountDAO.Instance.InsertAccount(displayname, username, password))
            {
                MessageBox.Show("       Thêm thành công");
                LoadListAccount();
            }
            else
            {
                MessageBox.Show("         Lỗi");
            }
        }

        private void btnEditBorrow_Click(object sender, EventArgs e)
        {
            string displayname = txbDisplayname.Text;
            string username = txbUsername.Text;

            if (AccountDAO.Instance.UpdateAccount(displayname, username))
            {
                MessageBox.Show("        Sửa thành công");
                LoadListAccount();
            }
            else
            {
                MessageBox.Show("         Lỗi");
            }
        }

        private void btnDeleteBorrow_Click(object sender, EventArgs e)
        {
            string username = txbUsername.Text;

            if (AccountDAO.Instance.DeleteAccount(username))
            {
                MessageBox.Show("        Xóa thành công");
                LoadListAccount();
            }
            else
            {
                MessageBox.Show("         Lỗi");
            }
        }

        private void btnShowBorrow_Click(object sender, EventArgs e)
        {
            LoadListAccount();
        }

        private void btnRePassword_Click(object sender, EventArgs e)
        {
            string password = txbNewPass.Text;
            string username = txbUsername.Text;
            string renewpass = txbReNewPass.Text;

            if (!password.Equals(renewpass))
            {
                MessageBox.Show("      Nhập lại mật khẩu đúng với mật khẩu mới");
            }
            else
            {
                if (AccountDAO.Instance.UpdatePassword(password, username))
                {
                    MessageBox.Show("      Đặt lại mật khẩu thành công");
                    LoadListAccount();
                    txbNewPass.Text = null;
                    txbReNewPass.Text = null;
                }
                else
                {
                    MessageBox.Show("         Lỗi");
                }
            }
        }

        private void fAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
