using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
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

            int[,] arr = new int[row, col];
            int sum = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr[i, j] = rnd.Next(10);
                    Console.Write($"{arr[i, j]} ");
                    sum += arr[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Сумма всех элементов :{sum}");
            Console.ReadLine();
        }
    }
}
