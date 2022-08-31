using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Задание 1
Напишите метод, который отображает квадрат из некоторого символа. Метод принимает
в качестве параметра: длину стороны квадрата, символ.*/

namespace HW_3_Task_1
{
    class Program
    {
        static void printSquare(int length, char symbol)
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.Write($"{symbol} ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int length = 10;
            char symbol = '@';
            printSquare(length, symbol);
        }
    }
}
