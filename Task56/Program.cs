// адача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

const int M = 3;
const int N = 4;

double[,] array2D = GetRandomArray2D(M, N);
PrintArray2D(array2D);

double[,] GetRandomArray2D(int m, int n)
{
    double[,] array2D = new double[m, n];
    Random random = new Random();

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            array2D[i, j] = random.NextDouble() * 10;
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
            Console.Write($"{array2D[i, j]:f1} ");
        }
        Console.WriteLine();
    }
}
