// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом 
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого 
// столбца: 4,6; 5,6; 3,6; 3



const int M = 3;
const int N = 4;

double[,] array2D = GetRandomArray2D(M, N);
PrintArray2D(array2D);
PrintArray1D(array2D);


double[,] GetRandomArray2D(int m, int n)
{
    double[,] array2D = new double[m, n];
    Random random = new Random();

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            array2D[i, j] = random.NextDouble() * 100;
        }
    }

    return array2D;
}

  void PrintArray2D(double[,] array2D)
  {
      for(int i = 0; i < array2D.GetLength(0); i++)
      {
          for(int j = 0; j < array2D.GetLength(1); j++)
          {
              Console.Write($"{array2D[i, j ]:f1} ");
          }
          Console.WriteLine();
      }
  }

 void PrintArray1D(double[,] array2D)
 {
 Console.WriteLine();
           double col = 0;
           double col1 = 0;
           double col2 = 0;
           double col3 = 0;
           

            col = col + array2D[0,0] + array2D[M-2,0] + array2D[M-1,0];
            col1 = col1 + array2D[0,N-3] + array2D[M-2,N-3] + array2D[M-1,N-3];
            col2 = col2 + array2D[0,N-2] + array2D[M-2,N-2] + array2D[M-1,N-2];
            col3 = col3 + array2D[0,N-1] + array2D[M-2,N-1] + array2D[M-1,N-1];



               Console.Write($"{col/M  :f1} ");
               Console.Write($"{col1/M  :f1} ");
               Console.Write($"{col2/M  :f1} ");
               Console.Write($"{col3/M  :f1} ");
 }

