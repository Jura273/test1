// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);
int i = m;
int sum = 0;
    while (i <= n)
    {
        Console.Write(i + " ");
        sum = sum + i;
        i++;
    }
Console.WriteLine();
Console.Write($"Сумма -> {sum} ");

