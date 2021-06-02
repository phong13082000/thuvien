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
    public partial class fReader : Form
    {
        BindingSource readerList = new BindingSource();

        public fReader()
        {
            InitializeComponent();
            dtgvReader.DataSource = readerList;
            LoadListReader();
            AddReaderBinding();
        }

        void AddReaderBinding()
        {
            txbReaderID.DataBindings.Add(new Binding("Text", dtgvReader.DataSource, "IdReader", true, DataSourceUpdateMode.Never));
            txbReaderName.DataBindings.Add(new Binding("Text", dtgvReader.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txbReaderIDCard.DataBindings.Add(new Binding("Text", dtgvReader.DataSource, "IDCard", true, DataSourceUpdateMode.Never));
            txbReaderAddress.DataBindings.Add(new Binding("Text", dtgvReader.DataSource, "Address", true, DataSourceUpdateMode.Never));
            txbReaderEmail.DataBindings.Add(new Binding("Text", dtgvReader.DataSource, "Email", true, DataSourceUpdateMode.Never));
            txbReaderPhone.DataBindings.Add(new Binding("Text", dtgvReader.DataSource, "Phone", true, DataSourceUpdateMode.Never));
            dtpkReaderFromDate.DataBindings.Add(new Binding("Value", dtgvReader.DataSource, "Cardissuedate", true, DataSourceUpdateMode.Never));
            dtpkReaderToDate.DataBindings.Add(new Binding("Value", dtgvReader.DataSource, "Expirationdate", true, DataSourceUpdateMode.Never));
            txbReaderTypeCard.DataBindings.Add(new Binding("Text", dtgvReader.DataSource, "Typecard", true, DataSourceUpdateMode.Never));
        }

        void LoadListReader()
        {
            readerList.DataSource = ReaderDAO.Instance.GetListReader();
        }

        private void btnAddReader_Click(object sender, EventArgs e)
        {
            string name = txbReaderName.Text;
            int idcard = Convert.ToInt32(txbReaderIDCard.Text);
            string address = txbReaderAddress.Text;
            string email = txbReaderEmail.Text;
            int phone = Convert.ToInt32(txbReaderPhone.Text);
            DateTime cardissuedate = dtpkReaderFromDate.Value;
            DateTime expirationdate = dtpkReaderToDate.Value;
            string typecard = txbReaderTypeCard.Text;

            if (ReaderDAO.Instance.InsertReader(name, idcard, address, email, phone, cardissuedate, expirationdate, typecard))
            {
                MessageBox.Show("       Thêm thành công");
                LoadListReader();
            }
            else
            {
                MessageBox.Show("         Lỗi");
            }
        }

        private void btnEditReader_Click(object sender, EventArgs e)
        {
            int idreader = Convert.ToInt32(txbReaderID.Text);
            string name = txbReaderName.Text;
            int idcard = Convert.ToInt32(txbReaderIDCard.Text);
            string address = txbReaderAddress.Text;
            string email = txbReaderEmail.Text;
            int phone = Convert.ToInt32(txbReaderPhone.Text);
            DateTime cardissuedate = dtpkReaderFromDate.Value;
            DateTime expirationdate = dtpkReaderToDate.Value;
            string typecard = txbReaderTypeCard.Text;

            if (ReaderDAO.Instance.UpdateReader(idreader, name, idcard, address, email, phone, cardissuedate, expirationdate, typecard))
            {
                MessageBox.Show("        Sửa thành công");
                LoadListReader();
            }
            else
            {
                MessageBox.Show("         Lỗi");
            }
        }

        private void btnDeleteReader_Click(object sender, EventArgs e)
        {
            int idreader = Convert.ToInt32(txbReaderID.Text);

            if (ReaderDAO.Instance.DeleteReader(idreader))
            {
                MessageBox.Show("        Xóa thành công");
                LoadListReader();
            }
            else
            {
                MessageBox.Show("         Lỗi");
            }
        }

        private void btnShowReader_Click(object sender, EventArgs e)
        {
            LoadListReader();
        }

        List<Reader> SearchReaderByName(string name)
        {
            List<Reader> listReader = ReaderDAO.Instance.SearchReaderByName(name);
            return listReader;
        }

        private void btnSearchReader_Click(object sender, EventArgs e)
        {
            readerList.DataSource = SearchReaderByName(txbSearchReader.Text);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportReader reportreader = new ReportReader();
            reportreader.ShowDialog();
        }
    }
}
