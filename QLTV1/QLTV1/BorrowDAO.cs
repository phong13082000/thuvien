using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLTV1
{
    public class BorrowDAO
    {
        private static BorrowDAO instance;

        public static BorrowDAO Instance
        {
            get { if (instance == null) instance = new BorrowDAO(); return BorrowDAO.instance; }
            private set { BorrowDAO.instance = value; }
        }

        private BorrowDAO() { }

        public List<Borrow> GetListBorrow()
        {
            List<Borrow> list = new List<Borrow>();
            string query = "select * from dbo.TableBorrow";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Borrow borrow = new Borrow(item);
                list.Add(borrow);
            }
            return list;
        }

        public List<Borrow> SearchBorrowByBookID(int idBook)
        {
            List<Borrow> list = new List<Borrow>();
            string query = string.Format("select * from TableBorrow where idBook like N'%{0}%'", idBook);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Borrow borrow = new Borrow(item);
                list.Add(borrow);
            }
            return list;
        }

        public List<Borrow> SearchBorrowByReaderID(int idReader)
        {
            List<Borrow> list = new List<Borrow>();
            string query = string.Format("select * from TableBorrow where idReader like N'%{0}%'", idReader);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Borrow borrow = new Borrow(item);
                list.Add(borrow);
            }
            return list;
        }

        public bool InsertBorrow(int idBook, int idReader, DateTime dateBorrow, DateTime dateReturn, int countBorrow)
        {
            string query = string.Format("insert dbo.TableBorrow (idBook, idReader, dateBorrow, dateReturn, countBorrow) values ({0}, {1}, N'{2}', N'{3}', {4})", idBook, idReader, dateBorrow.ToString("yyyy-MM-dd"), dateReturn.ToString("yyyy-MM-dd"), countBorrow);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateBorrow(int id, int idBook, int idReader, DateTime dateBorrow, DateTime dateReturn, int countBorrow)
        {
            string query = string.Format("update dbo.TableBorrow set idBook = {0}, idReader = {1}, dateBorrow = N'{2}', dateReturn = N'{3}', countBorrow = {4} where id = {5}", idBook, idReader, dateBorrow.ToString("yyyy-MM-dd"), dateReturn.ToString("yyyy-MM-dd"), countBorrow, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public void DeleteBorrowByBookID(int idbook)
        {
            DataProvider.Instance.ExecuteQuery("delete from dbo.TableBorrow where idBook = " + idbook);
        }

        public void DeleteBorrowByReaderID(int idreader)
        {
            DataProvider.Instance.ExecuteQuery("delete from dbo.TableBorrow where idReader = " + idreader);
        }

        public bool DeleteBorrow(int id)
        {
            string query = string.Format("delete from dbo.TableBorrow where id = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}

