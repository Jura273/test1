// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом 
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого 
// столбца: 4,6; 5,6; 3,6; 3
// int Promt(string message)
// {
//     Console.WriteLine(message);
//     int number = int.Parse(Console.ReadLine());
//     return number;
// }



Console.Clear();
Console.WriteLine("Введите количество строк: ");
int rows = int.Parse (Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse (Console.ReadLine()!);



int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
double[] averageColumns = GetResultArray(array);
Console.WriteLine($"Среднее арифметическое каждого столбца = {String.Join ("; ",  averageColumns)}");

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

void PrintArray(int[,] inArray)
{
     for (int i = 0; i < inArray.GetLength(0); i++)
     {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
     }   
}

double[] GetResultArray(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(0); j++)
     {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];
        }
        result [j] = Math.Round(sum / array.GetLength(0),2);
     }   
     return result;   
}

