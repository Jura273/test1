﻿// Задача 43. Напишите программу, которая найдёт 
// точку пересечения двух прямых, заданных 
// уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, 
// k2 = 9 -> (-0,5; -0,5)

// В школьном курсе математики прямые часто задаются уравнением с угловым коэффициентом,
//  рассмотрим этот случай. Пусть две прямые заданы таким образом: y1 = k1*x + b1 и y2 = k2*x + b2.
//  Очевидно, что в точке пересечения y1 = y2, тогда k1*x + b1 = k2*x + b2. Получаем, что ордината точки пересечения x = (b2 - b1)/(k1 - k2).
//  Подставим x в любое уравнение прямой и получим y = k1(b2 - b1)/(k1 - k2) + b1 = (k1b2 - b1k2)/(k1 - k2).



Console.Clear();
int Promt(string message)
 {
     Console.WriteLine(message);
     int number = int.Parse(Console.ReadLine()!);
     return number;
 }
 float x;
 float y;

 float b1 = Promt("Введите число b1: ");
 float k1 = Promt("Введите число k1: ");
 float b2 = Promt("Введите число b2: ");
 float k2 = Promt("Введите число k2: ");


 x = (b1-b2)/(k1-k2);
 y = (k1*b2 - b1*k2)/(k1 - k2);

 Console.WriteLine("Прямые пересекаются в точке X -> {0}, Y -> {1}", x,y);

