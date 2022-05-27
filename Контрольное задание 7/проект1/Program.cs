using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace space
{
    class Test
    {
        static void Main(string[] args)
        {
            MyStr s = new MyStr("Привет, как ты? Что у тебя с лицом? Всего хорошего!", 51);
            Console.WriteLine("Строка: {0} Длина: {1}", s, s.Length);
            Console.WriteLine("Число пробелов: {0}",
            s.CountSpaces());
            s.RemovePuncts();
            Console.WriteLine("Без знаков препинания: {0} Длина: {1}", s, s.Length);
        }
    }
}
