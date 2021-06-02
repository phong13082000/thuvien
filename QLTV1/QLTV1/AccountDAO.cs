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
    class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public bool Login(string username, string password)
        {
            string query = "USP_Login @username , @password";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });
            return result.Rows.Count > 0;
        }

        public List<Account> GetListAccount()
        {
            List<Account> list = new List<Account>();
            string query = "select * from TableAccount";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Account account = new Account(item);
                list.Add(account);
            }
            return list;
        }

        public bool InsertAccount(string displayname, string username, string password)
        {
            string query = string.Format("insert dbo.TableAccount (displayname, username, password) values (N'{0}', N'{1}', N'{2}')", displayname, username, password);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateAccount(string displayname, string username)
        {
            string query = string.Format("update dbo.TableAccount set displayname = N'{0}' where username = N'{1}'", displayname, username);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteAccount(string username)
        {
            string query = string.Format("delete from dbo.TableAccount where username = '{0}'", username);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdatePassword(string password, string username)
        {
            string query = string.Format("update dbo.TableAccount set password = N'{0}' where username = N'{1}'", password, username);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}

