using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLTV1
{
    public class Book
    {
        public Book(int idbook, string name, int idcategory, string language, string author, string translator, string company, int count)
        {
            this.IdBook = idbook;
            this.Name = name;
            this.CategoryID = idcategory;
            this.Language = language;
            this.Author = author;
            this.Translator = translator;
            this.Company = company;
            this.Count = count;
        }

        public Book(DataRow row)
        {
            this.IdBook = (int)row["idbook"];
            this.Name = row["name"].ToString();
            this.CategoryID = (int)row["idcategory"];
            this.Language = row["language"].ToString();
            this.Author = row["author"].ToString();
            this.Translator = row["translator"].ToString();
            this.Company = row["company"].ToString();
            this.Count = (int)row["count"];
        }

        private string name;
        private int idbook;
        private int idcategory;
        private string language;
        private string author;
        private string translator;
        private string company;
        private int count;



        public int IdBook
        {
            get { return idbook; }
            set { idbook = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int CategoryID
        {
            get { return idcategory; }
            set { idcategory = value; }
        }

        public string Language
        {
            get { return language; }
            set { language = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string Translator
        {
            get { return translator; }
            set { translator = value; }
        }

        public string Company
        {
            get { return company; }
            set { company = value; }
        }

        public int Count
        {
            get { return count; }
            set { count = value; }
        }
    }
}

