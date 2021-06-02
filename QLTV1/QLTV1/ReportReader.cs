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
    public partial class ReportReader : Form
    {
        public ReportReader()
        {
            InitializeComponent();
        }

        private void ReportReader_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLTV1DataSet2.TableReader' table. You can move, or remove it, as needed.
            this.TableReaderTableAdapter.Fill(this.QLTV1DataSet2.TableReader);

            this.reportViewer1.RefreshReport();
        }
    }
}
