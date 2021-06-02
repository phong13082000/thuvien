using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QLTV1
{
    public partial class fTableManager : Form
    {
        public fTableManager()
        {
            InitializeComponent();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccount f = new fAccount();
            f.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fBook f = new fBook();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void thôngTinĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fReader f = new fReader();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void mượnTrảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fBorrow f = new fBorrow();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void thôngTinĐăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
