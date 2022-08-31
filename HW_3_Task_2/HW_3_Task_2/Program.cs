using System;
using System.Linq;

/*Задание 2
Напишите метод, который проверяет является ли переданное число «палиндромом». Число передаётся в
качестве параметра. Если число палиндром нужно вернуть из метода true, иначе false.*/

namespace HW_3_Task_2
{
    class Program
    {
        static bool Palindrom(int number)
        {
            string line = Convert.ToString(number);
            var s = new string(line.Reverse().ToArray());
            if (Convert.ToInt32(s) == number)
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            int a = 1221;
            int b = 2232;
            int c = 7557;
            int d = 232;
            int e = 1002;
            int f = 10101;
            Console.WriteLine($"a = {a} {Palindrom(a)}");
            Console.WriteLine($"b = {b} {Palindrom(b)}");
            Console.WriteLine($"c = {c} {Palindrom(c)}");
            Console.WriteLine($"d = {d} {Palindrom(d)}");
            Console.WriteLine($"e = {e} {Palindrom(e)}");
            Console.WriteLine($"f = {f} {Palindrom(f)}");
        }
    }
}
