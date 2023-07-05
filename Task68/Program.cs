// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.

using System;
//namespace BabbleSort;

Console.Clear();
Console.WriteLine("Введите количество строк: ");
int rows = int.Parse (Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse (Console.ReadLine()!);



int[,] array = GetArray(rows, columns, 0, 10);
//PrintArray(array);
 //double[] averageColumns = GetResultArray(array);
 //Console.WriteLine($"Среднее арифметическое каждого столбца = {String.Join ("; ",  averageColumns)}");

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

//  void PrintArray(int[,] inArray)
//  {
//       for (int i = 0; i < inArray.GetLength(0); i++)
//       {
//          for (int j = 0; j < inArray.GetLength(1); j++)
//          {
//              Console.Write($"{inArray[i,j]} ");
//          }
//          Console.WriteLine();
//       }   
//  }



           // int colCount = 6;//m
            //int rowCount = 5;//n
            //double[] arr = new double[array.GetLength()];
           //int[,] arr = result; //GenerateArray(rows, columns);
            Console.WriteLine("Исходный массив");
            PrintArray(array);
              Console.WriteLine("Сортировка по строкам: ");
              int[] r = new int[columns];
              for (int i = 0; i < rows; i++)
              {
                  for (int j = 0; j < columns; j++)
                      r[j] = array[i, j];
                  BubbleSort(r);
                  Insert(true, i, r, array);
              }
              PrintArray(array);


        static int[,] GenerateArray(int t, int i)
        {
            int[,] table = new int[t, i];
            Random random = new Random();
            for (int a = 0; a < t; a++)
            {
                for (int b = 0; b < i; b++)
                {
                    table[a, b] = random.Next(0, 9);
                }
            }
            return table;
        }



static void BubbleSort(int[] inArray)
        {
            for (int i = 0; i < inArray.Length; i++)
                for (int j = 0; j < inArray.Length - i - 1; j++)
                {
                    if (inArray[j] > inArray[j + 1])
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


// static void Main(string[] args)
//  {
//      int colCount = 6;//m
//      int rowCount = 5;//n
//      int[,] arr = GenerateArray(rowCount, colCount);
//      Console.WriteLine("Исходный массив");
//      PrintArray(arr);
//      Console.WriteLine("Сортировка по строкам: ");
//      int[] row = new int[colCount];
//      for (int i = 0; i < rowCount; i++)
//      {
//          for (int j = 0; j < colCount; j++)
//              row[j] = arr[i, j];
//          BubbleSort(row);
//          Insert(true, i, row, arr);
//      }
//      PrintArray(arr);
//      Console.WriteLine("Сортировка по столбцам: ");
//      int[] col = new int[rowCount];
//      for (int i = 0; i < colCount; i++)
//      {
//          for (int j = 0; j < rowCount; j++)
//              col[j] = arr[j, i];
//          BubbleSort(col);
//          Insert(false, i, col, arr);
//      }
//      PrintArray(arr);
//  }
// public static void Insert(bool isRow, int dim, int[] source, int[,] dest)
//  {
//      for (int k = 0; k < source.Length; k++)
//      {
//          if (isRow)
//              dest[dim, k] = source[k];
//          else
//              dest[k, dim] = source[k];
//      }
//  }






//  static void Main(string[] args)
//  {
//      int colCount = 6;//m
//      int rowCount = 5;//n
     
//      //int[,] arr = GenerateArray(rowCount, colCount);
//      Console.WriteLine("Исходный массив");
//      PrintArray(result);
//      Console.WriteLine("Сортировка по строкам: ");
//      int[] row = new int[colCount];
//      for (int i = 0; i < rowCount; i++)
//      {
//          for (int j = 0; j < colCount; j++)
//              row[j] = arr[i, j];
//          BubbleSort(row);
//          Insert(true, i, row, arr);
//      }
//      PrintArray(result);
//      Console.WriteLine("Сортировка по столбцам: ");
//      int[] col = new int[rowCount];
//      for (int i = 0; i < colCount; i++)
//      {
//          for (int j = 0; j < rowCount; j++)
//              col[j] = arr[j, i];
//          BubbleSort(col);
//          Insert(false, i, col, arr);
//      }
//      PrintArray(result);
//  }
// public static void Insert(bool isRow, int dim, int[] source, int[,] dest)
//  {
//      for (int k = 0; k < source.Length; k++)
//      {
//          if (isRow)
//              dest[dim, k] = source[k];
//          else
//              dest[k, dim] = source[k];
//      }
//  }