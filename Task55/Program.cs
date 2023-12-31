﻿//Задача 51

onst int M = 3;
const int N = 4;

Console.Clear();
int[,] array2D = GetRandomArray2D(M, N);
PrintArray2D(array2D);
Console.WriteLine($"\n{DiagonalSum(array2D)}");

int DiagonalSum(int[,] array2D)
{
    int size = (array2D.GetLength(0) > array2D.GetLength(1)) ? array2D.GetLength(1) : array2D.GetLength(0);
    int sum = 0;

    for(int i = 0; i < size; i++)
    {
        sum += array2D[i, i];
    }

    return sum;
}

int[,] GetRandomArray2D(int m, int n)
{
    int[,] array2D = new int[m, n];
    Random random = new Random();

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            array2D[i, j] = random.Next(1, 10);
        }
    }

    return array2D;
}

void PrintArray2D(int[,] array2D)
{
    for(int i = 0; i < array2D.GetLength(0); i++)
    {
        for(int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write($"{array2D[i, j]} ");
        }
        Console.WriteLine();
    }
}

12:18
const int M = 4;
const int N = 4;

Console.Clear();
int[,] array2D = GetRandomArray2D(M, N);
PrintArray2D(array2D);
Console.WriteLine($"\n{DiagonalSum(array2D)}");

int DiagonalSum(int[,] array2D)
{
    int size = (array2D.GetLength(0) > array2D.GetLength(1)) ? array2D.GetLength(1) : array2D.GetLength(0);
    int sum = 0;

    for(int i = 0; i < size; i++)
    {
        sum += array2D[i, i];
    }

    return sum;
}

int[,] GetRandomArray2D(int m, int n)
{
    int[,] array2D = new int[m, n];
    Random random = new Random();

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            array2D[i, j] = random.Next(1, 10);
        }
    }

    return array2D;
}

void PrintArray2D(int[,] array2D)
{
    for(int i = 0; i < array2D.GetLength(0); i++)
    {
        for(int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write($"{array2D[i, j]} ");
        }
        Console.WriteLine();
    }
}
