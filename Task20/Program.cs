// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.WriteLine("Введите первое число N: ");
int number1 = int.Parse (Console.ReadLine()!);

int i = 1;

while (i <= number1)
{
    int k;
    k = (i % 2); 
   if (k == 0)
   {
   Console.WriteLine (i + " "); 
   } 

    i++;
}
