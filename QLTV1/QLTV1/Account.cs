using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLTV1
{
    public class Account
    {
        public Account(string displayname, string username, string password = null)
        {
            this.Displayname = displayname;
            this.Username = username;
            this.Password = password;
        }

        public Account(DataRow row)
        {
            this.Displayname = row["displayname"].ToString();
            this.Username = row["username"].ToString();
            this.Password = row["password"].ToString();
        }

        private string displayname;
        private string username;
        private string password;

        public string Displayname
        {
            get { return displayname; }
            set { displayname = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}

