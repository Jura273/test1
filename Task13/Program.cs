// Задача 13: Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

//int number;
// int number2;
//     number = 3454;
//     number2 = number;
// int number1;
// int number2;
// int number3;

Console.Clear();
Console.WriteLine("Введите число N: ");
int number = int.Parse (Console.ReadLine()!);
int k = number;

int digits = 0; // кол-во цифр
while (number > 0)
{
  digits++;
  number = (number / 10);
}

Console.WriteLine("Количество цифр в числе = " + digits );


//int a1 =  (k % 10);

int a1 = k % 10;
int k1 = k - a1;
int k2 = k1 / 10;
int a2 = k2 % 10;
int l1 = k2 - a2;
int l2 = l1 / 10;
int a3 = l2 % 10;
int z1 = l2 - a3;
int z2 = z1 / 10;

 Console.WriteLine($" {k} -> {a3} {a2} {a1}" );

// int secondValue = number / 100;

// int gValue = (number - firstValue) % 100;
// int midleValue = gValue / 10;

// Console.WriteLine($" {number} -> {secondValue} {midleValue} {firstValue}" );
// Console.WriteLine ( midleValue);

// Console.WriteLine("Вторая цифра числа = " + midleValue );








// Console.Clear();
// int number = new Random().Next(100,1000);
// int firstValue = number % 10;
// int secondValue = number / 100;

// int gValue = (number - firstValue) % 100;
// int midleValue = gValue / 10;

// Console.WriteLine($" {number} -> {secondValue} {midleValue} {firstValue}" );
// Console.WriteLine ( midleValue);

// Console.WriteLine("Вторая цифра числа = " + midleValue );

