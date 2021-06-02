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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLTV1DataSet1.TableBorrow' table. You can move, or remove it, as needed.
            this.TableBorrowTableAdapter.Fill(this.QLTV1DataSet1.TableBorrow, Convert.ToInt32(txbReport.Text));

            this.reportViewer1.RefreshReport();
        }
    }
}
