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
    public partial class ReportBook : Form
    {
        public ReportBook()
        {
            InitializeComponent();
        }

        private void ReportBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLTV1DataSet.TableBook' table. You can move, or remove it, as needed.
            this.TableBookTableAdapter.Fill(this.QLTV1DataSet.TableBook);

            this.reportViewer1.RefreshReport();
        }
    }
}
