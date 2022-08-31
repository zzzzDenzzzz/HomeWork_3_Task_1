using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Напишите метод, фильтрующий массив на основании переданных параметров. Метод принимает параметры:
оригинальный_массив, массив_с_данными_для_фильтрации.Метод возвращает оригинальный массив без элементов,
которые есть в массиве для фильтрации.*/

namespace HW_3_Task_3
{
    class Program
    {
        static int[] Filtration(int[] arr, int[] arrFiltr)
        {
            IEnumerable<int> a = arr.Except(arrFiltr);
            return a.ToArray();
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 6, -1, 88, 7, 6 };
            int[] arrFiltr = new int[] { 6, 7, 88};
            arr = Filtration(arr, arrFiltr);
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
