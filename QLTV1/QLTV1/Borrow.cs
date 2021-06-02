using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLTV1
{
    public class Borrow
    {
        public Borrow(int id, int idBook, int idReader, DateTime dateBorrow, DateTime dateReturn, int countBorrow)
        {
            this.iD = id;
            this.iDBook = idBook;
            this.iDReader = idReader;
            this.DateBorrow = dateBorrow;
            this.DateReturn = dateReturn;
            this.CountBorrow = countBorrow;
        }

        public Borrow(DataRow row)
        {
            this.iD = (int)row["id"];
            this.iDBook = (int)row["idBook"];
            this.iDReader = (int)row["idReader"];
            this.DateBorrow = (DateTime)row["dateBorrow"];
            this.DateReturn = (DateTime)row["dateReturn"];
            this.CountBorrow = (int)row["countBorrow"];
        }

        private int id;
        private int idBook;
        private int idReader;
        private DateTime dateBorrow;
        private DateTime dateReturn;
        private int countBorrow;

        public int iD
        {
            get { return id; }
            set { id = value; }
        }

        public int iDBook
        {
            get { return idBook; }
            set { idBook = value; }
        }

        public int iDReader
        {
            get { return idReader; }
            set { idReader = value; }
        }

        public DateTime DateBorrow
        {
            get { return dateBorrow; }
            set { dateBorrow = value; }
        }

        public DateTime DateReturn
        {
            get { return dateReturn; }
            set { dateReturn = value; }
        }

        public int CountBorrow
        {
            get { return countBorrow; }
            set { countBorrow = value; }
        }
    }
}

