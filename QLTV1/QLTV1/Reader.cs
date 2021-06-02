using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLTV1
{
    public class Reader
    {
        public Reader(int idreader, string name, int idcard, string address, string email, int phone, DateTime cardissuedate, DateTime expirationdate, string typecard)
        {
            this.IdReader = idreader;
            this.Name = name;
            this.IDCard = idcard;
            this.Address = address;
            this.Email = email;
            this.Phone = phone;
            this.Cardissuedate = cardissuedate;
            this.Expirationdate = expirationdate;
            this.Typecard = typecard;
        }

        public Reader(DataRow row)
        {
            this.IdReader = (int)row["idreader"];
            this.Name = row["name"].ToString();
            this.IDCard = (int)row["idcard"];
            this.Address = row["address"].ToString();
            this.Email = row["email"].ToString();
            this.Phone = (int)row["phone"];
            this.Cardissuedate = (DateTime)row["cardissuedate"];
            this.Expirationdate = (DateTime)row["expirationdate"];
            this.Typecard = row["typecard"].ToString();
        }

        private string name;
        private int idreader;
        private int idcard;
        private string address;
        private string email;
        private int phone;
        private DateTime cardissuedate;
        private DateTime expirationdate;
        private string typecard;

        public int IdReader
        {
            get { return idreader; }
            set { idreader = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int IDCard
        {
            get { return idcard; }
            set { idcard = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public DateTime Cardissuedate
        {
            get { return cardissuedate; }
            set { cardissuedate = value; }
        }

        public DateTime Expirationdate
        {
            get { return expirationdate; }
            set { expirationdate = value; }
        }

        public string Typecard
        {
            get { return typecard; }
            set { typecard = value; }
        }
    }
}

