﻿// Задача 8: Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные числа
// от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.WriteLine("Введите число N: ");
int number = int.Parse (Console.ReadLine()!);
int i = 1;
int k;

while (i < number)
 {
    k = (i % 2 );
    if (k == 0)
    {
        Console.WriteLine(i);        
    }
    i++ ; 


 };




 