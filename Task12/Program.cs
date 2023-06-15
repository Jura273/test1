// Урок 2. Базовые алгоритмы
// Задача 10: Напишите программу, 
//которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
int number = new Random().Next(100,1000);
int firstValue = number % 10;
int secondValue = number / 100;

int gValue = (number - firstValue) % 100;
int midleValue = gValue / 10;

Console.WriteLine($" {number} -> {secondValue} {midleValue} {firstValue}" );
Console.WriteLine ( midleValue);

Console.WriteLine("Вторая цифра числа = " + midleValue );

