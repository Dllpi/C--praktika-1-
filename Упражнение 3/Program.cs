using System;

namespace Упражнение_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Book b1 = new Book();*/

            Book b3 = new Book("Лермонтов М.Ю.", "Мцыри");

            /*Book b2 = new Book("Толстой Л.Н.", "Война и мир", "Наука и жизнь", 1234, 2013);*/

            /*b1.SetBook("Пушкин А.С.", "Капитанская дочка", "Вильямс", 123, 2012);*/

            Book.SetPrice(12);

            /*b3.Show();*/

            string p = b3.Author;
            Console.WriteLine(p);

            /*b2.Show();*/

            /*b1.Show();*/
/*            Console.WriteLine($"\n Итоговая стоимость аренды: {b3.PriceBook(3)} p.");*/
        }
    }
}
