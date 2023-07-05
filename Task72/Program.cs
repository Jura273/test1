// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.

using System;

Console.Clear();
Console.WriteLine("Введите количество строк: ");
int rows = int.Parse (Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse (Console.ReadLine()!);


int[,] array = GetArray(rows, columns, 0, 10);


int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = rnd.Next(min, max+1);
        }
    }
    return result;
}

    static void PrintArray(int[,] array)
        {
            for (int a = 0; a < array.GetLength(0); a++)
            {
                for (int b = 0; b < array.GetLength(1); b++)
                {
                    Console.Write(array[a, b] + " ");
                }
                Console.WriteLine();
            }
        }




static void BubbleSort1(int[] inArray)
    {
        for (int i = 0; i < inArray.Length; i++)
            for (int j = 0; j < inArray.Length - i - 1; j++)
            {
                if (inArray[j] < inArray[j + 1])
                {
                    int temp = inArray[j];
                    inArray[j] = inArray[j + 1];
                    inArray[j + 1] = temp;
                }
            }
    }



static void Insert(bool isRow, int dim, int[] source, int[,] dest)
    {
        for (int k = 0; k < source.Length; k++)
        {
            if (isRow)
                dest[dim, k] = source[k];
            else
                dest[k, dim] = source[k];
        }
    }



            Console.WriteLine("Исходный массив");
            PrintArray(array);
              Console.WriteLine("Сортировка по строкам с убыванием: ");
              int[] r = new int[columns];

                  for (int i = 0; i < rows; i++)
                  {
                      for (int j = 0; j < columns; j++)
                           r[j] = array[i, j];
                    BubbleSort1(r);                   
                    Insert(true, i, r, array);                     
                  }                
            
              PrintArray(array);

              

    

        

