// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет



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


 int Promt(string message)
 {
     Console.WriteLine(message);
     int number = int.Parse(Console.ReadLine()!);
     return number;
 }

int num = Promt("Введите первый индекс: ");
int num1 = Promt("Введите второй индекс: ");

if (num > array2D.GetLength(0) || num1 >= array2D.GetLength(1)) 
{
    Console.WriteLine("Такого числа в массиве нет ");
    
}

else
{
    Console.WriteLine($"Число = {array2D [num,num1]}");

}

