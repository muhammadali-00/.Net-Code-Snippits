using System;
using System.Collections.Generic;
using System.Text;

namespace AS3Q5ItemBook
{
    abstract class Item
    {
        string title;
        public void setTitle(string t)
        {
            this.title = t;
        }

        public string getTitle()
        {
            return title;
        }

        public Item()
        {
            this.title = "";
        }

        public Item(string t)
        {
            this.title = t;
        }

        public abstract string getListing();

        public override string ToString()
        {
            return title;
        }

    }
    
    class Book : Item
    {
        string isbn_number;
        string Author;

        public void setISBNNUMBER(string inn)
        {
            this.isbn_number = inn;
        }

        public string getISBNNUMBER()
        {
            return isbn_number;
        }

        public void setAuthor(string s)
        {
            this.Author = s;
        }

        public string getAuthor()
        {
            return Author;

        }

        public Book()
        {

        }

        public Book(string isbn, string aut, string tit):base(tit)
        {
            this.isbn_number = isbn;
            this.Author = aut;
        }

        public override string getListing()
        {
           return "Book Name - " + getTitle() + "\n" +
                "Author - " + getAuthor() + "\n" +
                "ISBN Number - " + getISBNNUMBER();
        }
    }

    class Periodical : Item
    {
        int issueNum;
        public void setIS(int isn)
        {
            this.issueNum = isn;
        }
        public int getIS()
        {
            return issueNum;
        }

        public Periodical()
        {

        }

        public Periodical(int isn, string tit):base(tit)
        {
            this.issueNum = isn;
        }
        public override string getListing()
        {
           return "Periodical Title -  " + getTitle() + "\n" +
                "Issue# - " + getIS();
        }

    }
}
