// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();
Console.WriteLine("Введите первое число N: ");
int number1 = int.Parse (Console.ReadLine()!);

 int k = (number1 % 2);   
    
if (k == 0)
{
  Console.WriteLine("Число четное: " + number1 );   
}
else
{
  Console.WriteLine("Число нечетное: " + number1 );   
}
 