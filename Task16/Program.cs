// Задача 15: Напишите программу, которая
// принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите число N: ");
int number = int.Parse (Console.ReadLine()!);
//int k = number;
    


    
if (5< number && number < 8 )
{
    Console.WriteLine("Выходной"); }
 else
 {
    Console.WriteLine("Рабочий день"); 
 }

