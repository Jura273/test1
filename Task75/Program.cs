// Задача 56: Задайте прямоугольный двумерный массив. Напишите 
// программу, которая будет находить строку с наименьшей суммой элементов



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаб_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            double sum = 0;
            int m,n;
            bool f;
            do
            {
                Console.Write("Введите количество строк m: ");
                f = int.TryParse(Console.ReadLine(), out m);
                if (f == false)
                    Console.WriteLine("Ошибка! Введите еще раз.");
            }
            while (!f);

            do
            {
                Console.Write("Введите количество столбцов n: ");
                f = int.TryParse(Console.ReadLine(), out n);
                if (f == false)
                    Console.WriteLine("Ошибка! Введите еще раз.");
            }
            while (!f);


            double[,] mas = new double[n,m];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    double x = rnd.Next(-33531, 33110);
                    x = x / 100.000;
                    mas[i, j] = x;
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Массив: ");
            
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,8:F3}\t", mas[i, j]);
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Сумма каждой строки: ");
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    sum += Math.Abs(mas[i,j]);
                }
              Console.WriteLine("{0} - sum = {1:F3}",i, sum);
              sum = 0;
          
            }
           


            double swap;
            for (int c = 0; c <= (m * n); c++)
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n - 1; j++)
                    {
                        if (mas[i, j] > mas[i, j + 1])
                        {
                            swap = mas[i, j];
                            mas[i, j] = mas[i, j + 1];
                            mas[i, j + 1] = swap;
                        }
                    }
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Отсортированный массив: ");
           
            for (int i = 0; i < n; i++)
            {
                
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,8:F3}\t",  mas[i, j]);
                }
            }
            Console.ReadKey();
        }
    }
}
