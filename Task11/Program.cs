// Урок 2. Базовые алгоритмы
// Задача 10: Напишите программу, 
//которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.WriteLine("Введите первое число: ");
int a = int.Parse (Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse (Console.ReadLine()!);
Console.WriteLine("Введите третье число: ");
int c = int.Parse (Console.ReadLine()!);
int[] array = {a,b,c};
 
 Console.Write(b);



