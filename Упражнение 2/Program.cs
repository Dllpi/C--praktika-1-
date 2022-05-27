using System;

namespace Упражнение_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Book b1 = new Book();*/

            Book b2 = new Book("Толстой Л.Н.", "Война и мир", "Наука и жизнь", 1234, 2013);

            /*b1.SetBook("Пушкин А.С.", "Капитанская дочка", "Вильямс", 123, 2012);*/

            Book.SetPrice(12);

            b2.Show();

            /*b1.Show();*/
            Console.WriteLine($"\n Итоговая стоимость аренды: {b2.PriceBook(3)} p.");
        }
    }
}
