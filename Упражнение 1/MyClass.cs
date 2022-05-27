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

        public void SetBook(String author, String title, String publisher, int pages, int year)

        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }

        public static void SetPrice(double price)
        {
            Book.price = price;
        }

        public void Show()
        {
            Console.WriteLine($"\nКнига:\nАвтор: {author}\nНазвание: {title}\nиздания: {year}\nИздательство: {publisher}\n{pages} стр.\nСтоимость аренды: {Book.price}");
        }

        public double PriceBook(int s)
        {
            double cust = s * price;
            return cust;
        }
    }
}
