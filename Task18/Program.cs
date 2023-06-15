// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.WriteLine("Введите первое число N: ");
int number1 = int.Parse (Console.ReadLine()!);
Console.WriteLine("Введите второе число N: ");
int number2 = int.Parse (Console.ReadLine()!);
Console.WriteLine("Введите третье число N: ");
int number3 = int.Parse (Console.ReadLine()!);
int max = 0;
    
    
if (number1 > number2)
{
    max = number1;
}
 else
{
    max = number2;
}
if (max < number3)
{
    max = number3;
}

Console.WriteLine("Наибольшое число: max -> " + max ); 

