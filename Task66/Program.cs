﻿// 55: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// //****************** удалит строку и столбец, на пересечении которых 
// // расположен наименьший элемент массива.

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Минимальный элемент находится -> {String.Join(" ", GetIndexMinEl(array))}");
Console.WriteLine();
PrintArray(GetResultArray(array, GetIndexMinEl(array)));

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
}

int[] GetIndexMinEl(int[,] inArray)
{
    int[] result = new int[2];
    int min = inArray[0, 0];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (min > inArray[i, j])
            {
                min = inArray[i, j];
                result[0] = i;
                result[1] = j;
            }
        }
    }
    return result;
}

int[,] GetResultArray(int[,] inArray, int[] indexes)
{
    int[,] result = new int[inArray.GetLength(0) - 1, inArray.GetLength(1) - 1];
    int row = 0;
    int column = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        if (i == indexes[0]) continue;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (j == indexes[1]) continue;
            result[row, column] = inArray[i, j];
            column++;
        }
        column = 0;
        row++;
    }
    return result;
}
Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Минимальный элемент находится -> {String.Join(" ", GetIndexMinEl(array))}");
Console.WriteLine();
PrintArray(GetResultArray(array, GetIndexMinEl(array)));

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
}

int[] GetIndexMinEl(int[,] inArray)
{
    int[] result = new int[2];
    int min = inArray[0, 0];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (min > inArray[i, j])
            {
                min = inArray[i, j];
                result[0] = i;
                result[1] = j;
            }
        }
    }
    return result;
}

int[,] GetResultArray(int[,] inArray, int[] indexes)
{
    int[,] result = new int[inArray.GetLength(0) - 1, inArray.GetLength(1) - 1];
    int row = 0;
    int column = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        if (i == indexes[0]) continue;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (j == indexes[1]) continue;
            result[row, column] = inArray[i, j];
            column++;
        }
        column = 0;
        row++;
    }
    return result;
}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
