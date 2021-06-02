using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLTV1
{
    public class ReaderDAO
    {
        private static ReaderDAO instance;

        public static ReaderDAO Instance
        {
            get { if (instance == null) instance = new ReaderDAO(); return ReaderDAO.instance; }
            private set { ReaderDAO.instance = value; }
        }

        private ReaderDAO() { }

        public List<Reader> GetListReader()
        {
            List<Reader> list = new List<Reader>();
            string query = "select * from dbo.TableReader";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Reader reader = new Reader(item);
                list.Add(reader);
            }
            return list;
        }

        public List<Reader> SearchReaderByName(string name)
        {
            List<Reader> list = new List<Reader>();
            string query = string.Format("select * from TableReader where name like N'%{0}%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Reader reader = new Reader(item);
                list.Add(reader);
            }
            return list;
        }

        public Reader GetListReaderByReaderID(int id)
        {
            Reader reader = null;
            string query = "select * from dbo.TableReader where idreader = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                reader = new Reader(item);
                return reader;
            }
            return reader;
        }

        public bool InsertReader(string name, int idcard, string address, string email, int phone, DateTime cardissuedate, DateTime expirationdate, string typecard)
        {
            string query = string.Format("insert dbo.TableReader (name, idcard, address, email, phone, cardissuedate, expirationdate, typecard) values (N'{0}', {1}, N'{2}', N'{3}', {4}, N'{5}', N'{6}', N'{7}')", name, idcard, address, email, phone, cardissuedate.ToString("yyyy-MM-dd"), expirationdate.ToString("yyyy-MM-dd"), typecard);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateReader(int idreader, string name, int idcard, string address, string email, int phone, DateTime cardissuedate, DateTime expirationdate, string typecard)
        {
            string query = string.Format("update dbo.TableReader set name = N'{0}', idcard = {1}, address = N'{2}', email = N'{3}', phone = {4}, cardissuedate = N'{5}', expirationdate = N'{6}', typecard = N'{7}' where idreader = {8}", name, idcard, address, email, phone, cardissuedate.ToString("yyyy-MM-dd"), expirationdate.ToString("yyyy-MM-dd"), typecard, idreader);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteReader(int idreader)
        {
            BorrowDAO.Instance.DeleteBorrowByReaderID(idreader);
            string query = string.Format("delete from dbo.TableReader where idreader = {0}", idreader);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}

