using System;
using System.Collections.Generic;
using System.Text;

namespace Упражнение_1
{
    class Book
    {
        private String author; // автор
        private String title; // название
        private String publisher; // издательство
        private int pages; // кол-во страниц
        private int year; // год издания

        private static double price = 9;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        public int Pages
        {
            get { return pages; }
            set { pages = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public Book(String author, String title)
        {
            this.author = author;
            this.title = title;
        }

        static Book() //статический конструктор
        {
            price = 10;
        }

        public Book()
        {
        }

        public Book(String author, String title, String publisher, int pages, int year)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }

/*        public void SetBook(String author, String title, String publisher, int pages, int year)

        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }*/

        public static void SetPrice(double price)
        {
            Book.price = price;
        }

        public void Show()
        {
            Console.WriteLine($"\nКнига:\n Автор: {author}\n Название: {title}\n  издания: {year}\n Издательство: {publisher}\n {pages} стр.\n Стоимость аренды: {Book.price}");
        }

        public double PriceBook(int s)
        {
            double cust = s * price;
            return cust;
        }
    }
}
