// Задача 6: Напишите программу, которая на вход принимает число
// и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();
Console.WriteLine("Введите число: ");
int a = int.Parse (Console.ReadLine()!);
int n = (a % 2);
if ( n == 0)
{

Console.WriteLine("Число четное");

}
else
{
   Console.WriteLine("Число нечетное"); 
}

