// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.WriteLine("Введите первое число N: ");
int number1 = int.Parse (Console.ReadLine()!);
Console.WriteLine("Введите второе число N: ");
int number2 = int.Parse (Console.ReadLine()!);

int i = 0;
int num = 1;

while ( i < number2)
{

    num = num * number1;

    i++;
    
}

Console.Write(num);