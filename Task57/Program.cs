// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет

//Не рабочий !!!!!!

int userM = TakeUserNum();
int userN = TakeUserNum();
const int M = 3;
const int N = 4;

int[,] array2D = GetRandomArray2D(M, N);
PrintArray2D(array2D);

var cortage = GetArrayElement(array2D, M, N);

if(cortage.Item1) 
    Console.WriteLine(cortage.Item1);
else
    Console.WriteLine("Такого элемента нет");

(bool, int) GetArrayElement(int[,] array2D, int m, int n)
{
    if(m >= array2D.GetLength(0) | n >= array2D.GetLength(1)) return(false, 0);

    return(true, array2D[m, n]);
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

int TakeUserNum()
{
    int userNum;

    while(!int.TryParse(Console.ReadLine(), out userNum))
        Console.WriteLine("Пожалуйста введите число!");

    return userNum;
}