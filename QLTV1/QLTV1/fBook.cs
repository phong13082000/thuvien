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
    public partial class fBook : Form
    {
        BindingSource bookList = new BindingSource();

        public fBook()
        {
            InitializeComponent();
            dtgvBook.DataSource = bookList;
            LoadCategory();
            LoadListBook();
            LoadCategoryIntoCombobox(cbBookCategory);
            AddBookBinding();
        }

        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbBookCategory.DataSource = listCategory;
            cbBookCategory.DisplayMember = "name";
        }

        void LoadBookListByCategoryID(int id)
        {
            List<Book> listBook = BookDAO.Instance.GetListBookByCategoryID(id);
        }

        void AddBookBinding()
        {
            txbBookID.DataBindings.Add(new Binding("Text", dtgvBook.DataSource, "IdBook", true, DataSourceUpdateMode.Never));
            txbBookName.DataBindings.Add(new Binding("Text", dtgvBook.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txbBookLanguage.DataBindings.Add(new Binding("Text", dtgvBook.DataSource, "Language", true, DataSourceUpdateMode.Never));
            txbBookAuthor.DataBindings.Add(new Binding("Text", dtgvBook.DataSource, "Author", true, DataSourceUpdateMode.Never));
            txbBookTranslator.DataBindings.Add(new Binding("Text", dtgvBook.DataSource, "Translator", true, DataSourceUpdateMode.Never));
            txbBookCompany.DataBindings.Add(new Binding("Text", dtgvBook.DataSource, "Company", true, DataSourceUpdateMode.Never));
            nmBookCount.DataBindings.Add(new Binding("Value", dtgvBook.DataSource, "Count", true, DataSourceUpdateMode.Never));
        }

        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "name";
        }

        void LoadListBook()
        {
            bookList.DataSource = BookDAO.Instance.GetListBook();
        }

        private void txbBookID_TextChanged(object sender, EventArgs e)
        {
            if (dtgvBook.SelectedCells.Count > 0)
            {
                int id = (int)dtgvBook.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;
                Category category = CategoryDAO.Instance.GetCategoryByID(id);
                cbBookCategory.SelectedItem = category;
                int index = -1;
                int i = 0;
                foreach (Category item in cbBookCategory.Items)
                {
                    if (item.ID == category.ID)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                cbBookCategory.SelectedIndex = index;
            }
        }

        private void cbBookCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            Category selected = cb.SelectedItem as Category;
            id = selected.ID;
            LoadBookListByCategoryID(id);
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string name = txbBookName.Text;
            int idcategory = (cbBookCategory.SelectedItem as Category).ID;
            string language = txbBookLanguage.Text;
            string author = txbBookAuthor.Text;
            string translator = txbBookTranslator.Text;
            string company = txbBookCompany.Text;
            int count = (int)nmBookCount.Value;

            if (BookDAO.Instance.InsertBook(name, idcategory, language, author, translator, company, count))
            {
                MessageBox.Show("       Thêm thành công");
                LoadListBook();
            }
            else
            {
                MessageBox.Show("         Lỗi");
            }
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            string name = txbBookName.Text;
            int idcategory = (cbBookCategory.SelectedItem as Category).ID;
            string language = txbBookLanguage.Text;
            string author = txbBookAuthor.Text;
            string translator = txbBookTranslator.Text;
            string company = txbBookCompany.Text;
            int count = (int)nmBookCount.Value;
            int idbook = Convert.ToInt32(txbBookID.Text);

            if (BookDAO.Instance.UpdateBook(idbook, name, idcategory, language, author, translator, company, count))
            {
                MessageBox.Show("        Sửa thành công");
                LoadListBook();
            }
            else
            {
                MessageBox.Show("         Lỗi");
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            int idbook = Convert.ToInt32(txbBookID.Text);

            if (BookDAO.Instance.DeleteBook(idbook))
            {
                MessageBox.Show("        Xóa thành công");
                LoadListBook();
            }
            else
            {
                MessageBox.Show("         Lỗi");
            }
        }

        private void btnShowBook_Click(object sender, EventArgs e)
        {
            LoadListBook();
        }

        List<Book> SearchBookByName(string name)
        {
            List<Book> listBook = BookDAO.Instance.SearchBookByName(name);
            return listBook;
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            bookList.DataSource = SearchBookByName(txbSearchBook.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportBook reportbook = new ReportBook();
            reportbook.ShowDialog();
        }
    }
}
