using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.Write("Введите количество строк: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int col = int.Parse(Console.ReadLine());

            int[,] arr1 = new int[row, col];
            int[,] arr2 = new int[row, col];
            int[,] sumArr = new int[row, col];
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr1[i, j] = rnd.Next(-5, 6);
                    Console.Write($"{arr1[i, j],3}");
                    sum1 += arr1[i, j];
                }
                Console.Write("\t");
                for (int j = 0; j < col; j++)
                {
                    arr2[i, j] = rnd.Next(-5, 6);
                    Console.Write($"{arr2[i, j],3}");
                    sum2 += arr2[i, j];
                }
                Console.Write("\t");
                for (int j = 0; j < col; j++)
                {
                    sumArr[i, j] = arr1[i, j] + arr2[i, j];
                    Console.Write($"{sumArr[i, j],3}");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Сумма первого массива: {sum1}");
            Console.WriteLine($"Сумма второго массива: {sum2}");
            Console.WriteLine($"Сумма двух массивов: {(sum1 + sum2)}");
            Console.ReadLine();
        }
    }
}
