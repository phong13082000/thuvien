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
    public partial class fBorrow : Form
    {
        BindingSource borrowList = new BindingSource();

        public fBorrow()
        {
            InitializeComponent();
            dtgvBorrow.DataSource = borrowList;
            LoadListBorrow();
            AddBorrowBinding();
            LoadBookIntoCombobox(cbBorrowBook);
            LoadReaderIntoCombobox(cbBorrowReader);
        }

        void AddBorrowBinding()
        {
            txbBorrowID.DataBindings.Add(new Binding("Text", dtgvBorrow.DataSource, "iD", true, DataSourceUpdateMode.Never));
            txbBorrowBookID.DataBindings.Add(new Binding("Text", dtgvBorrow.DataSource, "iDBook", true, DataSourceUpdateMode.Never));
            txbBorrowReaderID.DataBindings.Add(new Binding("Text", dtgvBorrow.DataSource, "iDReader", true, DataSourceUpdateMode.Never));
            dtpkBorrow.DataBindings.Add(new Binding("Value", dtgvBorrow.DataSource, "DateBorrow", true, DataSourceUpdateMode.Never));
            dtpkReturn.DataBindings.Add(new Binding("Value", dtgvBorrow.DataSource, "DateReturn", true, DataSourceUpdateMode.Never));
            nmBorrowCount.DataBindings.Add(new Binding("Text", dtgvBorrow.DataSource, "CountBorrow", true, DataSourceUpdateMode.Never));
        }

        void LoadBookIntoCombobox(ComboBox cb)
        {
            cb.DataSource = BookDAO.Instance.GetListBook();
            cb.DisplayMember = "name";
        }

        void LoadReaderIntoCombobox(ComboBox cb)
        {
            cb.DataSource = ReaderDAO.Instance.GetListReader();
            cb.DisplayMember = "name";
        }

        void LoadListBorrow()
        {
            borrowList.DataSource = BorrowDAO.Instance.GetListBorrow();
        }

        private void txbBorrowID_TextChanged(object sender, EventArgs e)
        {
            if (dtgvBorrow.SelectedCells.Count > 0)
            {
                int id = (int)dtgvBorrow.SelectedCells[0].OwningRow.Cells["iDBook"].Value;
                Book book = BookDAO.Instance.GetListBookByBookID(id);
                cbBorrowBook.SelectedItem = book;
                int index = -1;
                int i = 0;
                foreach (Book item in cbBorrowBook.Items)
                {
                    if (item.IdBook == book.IdBook)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                cbBorrowBook.SelectedIndex = index;
            }
            if (dtgvBorrow.SelectedCells.Count > 0)
            {
                int id = (int)dtgvBorrow.SelectedCells[0].OwningRow.Cells["iDReader"].Value;
                Reader reader = ReaderDAO.Instance.GetListReaderByReaderID(id);
                cbBorrowReader.SelectedItem = reader;
                int index = -1;
                int i = 0;
                foreach (Reader item in cbBorrowReader.Items)
                {
                    if (item.IdReader == reader.IdReader)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                cbBorrowReader.SelectedIndex = index;
            }
        }

        private void btnAddBorrow_Click(object sender, EventArgs e)
        {
            int idBook = (cbBorrowBook.SelectedItem as Book).IdBook;
            int idReader = (cbBorrowReader.SelectedItem as Reader).IdReader;
            DateTime dateBorrow = dtpkBorrow.Value;
            DateTime dateReturn = dtpkReturn.Value;
            int countBorrow = (int)nmBorrowCount.Value;

            if (BorrowDAO.Instance.InsertBorrow(idBook, idReader, dateBorrow, dateReturn, countBorrow))
            {
                MessageBox.Show("       Thêm thành công");
                LoadListBorrow();
            }
            else
            {
                MessageBox.Show("         Lỗi");
            }
        }

        private void btnEditBorrow_Click(object sender, EventArgs e)
        {
            int idBook = (cbBorrowBook.SelectedItem as Book).IdBook;
            int idReader = (cbBorrowReader.SelectedItem as Reader).IdReader;
            DateTime dateBorrow = dtpkBorrow.Value;
            DateTime dateReturn = dtpkReturn.Value;
            int countBorrow = (int)nmBorrowCount.Value;
            int id = Convert.ToInt32(txbBorrowID.Text);

            if (BorrowDAO.Instance.UpdateBorrow(id, idBook, idReader, dateBorrow, dateReturn, countBorrow))
            {
                MessageBox.Show("        Sửa thành công");
                LoadListBorrow();
            }
            else
            {
                MessageBox.Show("         Lỗi");
            }
        }

        private void btnDeleteBorrow_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbBorrowID.Text);

            if (BorrowDAO.Instance.DeleteBorrow(id))
            {
                MessageBox.Show("        Xóa thành công");
                LoadListBorrow();
            }
            else
            {
                MessageBox.Show("         Lỗi");
            }
        }

        private void btnShowBorrow_Click(object sender, EventArgs e)
        {
            LoadListBorrow();
        }

        List<Borrow> SearchBorrowByBookID(int idBook)
        {
            List<Borrow> listBorrow = BorrowDAO.Instance.SearchBorrowByBookID(idBook);
            return listBorrow;
        }

        private void btnSearchBorrowBook_Click(object sender, EventArgs e)
        {
            borrowList.DataSource = SearchBorrowByBookID(Convert.ToInt32(txbSearchBorrowBook.Text));
        }

        List<Borrow> SearchBorrowByReaderID(int idReader)
        {
            List<Borrow> listBorrow = BorrowDAO.Instance.SearchBorrowByReaderID(idReader);
            return listBorrow;
        }

        private void btnSearchBorrowReader_Click(object sender, EventArgs e)
        {
            borrowList.DataSource = SearchBorrowByReaderID(Convert.ToInt32(txbSearchBorrowReader.Text));
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.ShowDialog();
        }
    }
}
