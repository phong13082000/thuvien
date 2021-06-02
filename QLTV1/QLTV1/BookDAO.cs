using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLTV1
{
    public class BookDAO
    {
        private static BookDAO instance;

        public static BookDAO Instance
        {
            get { if (instance == null) instance = new BookDAO(); return BookDAO.instance; }
            private set { BookDAO.instance = value; }
        }

        private BookDAO() { }

        public List<Book> GetListBookByCategoryID(int id)
        {
            List<Book> list = new List<Book>();
            string query = "select * from TableBook where idcategory = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Book book = new Book(item);
                list.Add(book);
            }
            return list;
        }

        public List<Book> GetListBook()
        {
            List<Book> list = new List<Book>();
            string query = "select * from TableBook";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Book book = new Book(item);
                list.Add(book);
            }
            return list;
        }

        public List<Book> SearchBookByName(string name)
        {
            List<Book> list = new List<Book>();
            string query = string.Format("select * from TableBook where name like N'%{0}%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Book book = new Book(item);
                list.Add(book);
            }
            return list;
        }

        public Book GetListBookByBookID(int id)
        {
            Book book = null;
            string query = "select * from dbo.TableBook where idbook = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                book = new Book(item);
                return book;
            }
            return book;
        }

        public bool InsertBook(string name, int id, string language, string author, string translator, string company, int count)
        {
            string query = string.Format("insert dbo.TableBook (name, idcategory, language, author, translator, company, count) values (N'{0}', {1}, N'{2}', N'{3}', N'{4}', N'{5}', {6})", name, id, language, author, translator, company, count);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateBook(int idbook, string name, int id, string language, string author, string translator, string company, int count)
        {
            string query = string.Format("update dbo.TableBook set name = N'{0}', idcategory = {1}, language = N'{2}', author = N'{3}', translator = N'{4}', company = N'{5}', count = {6} where idbook = {7}", name, id, language, author, translator, company, count, idbook);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteBook(int idbook)
        {
            BorrowDAO.Instance.DeleteBorrowByBookID(idbook);
            string query = string.Format("delete from dbo.TableBook where idbook = {0}", idbook);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}

