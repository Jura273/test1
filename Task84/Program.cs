// Задача 64: Задайте значение N.
//  Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

//Console.WriteLine("Введите значение: N ");

//int number = Prompt("Введите число: ");
//Console.WriteLine($"{SumDigit(number)}");


// Console.WriteLine("Введите большее значение: ");

// int n = 5;
// int Promt(string message)
// {
//     Console.Write(message);
//     int number = int.Parse(Console.ReadLine());
//     return number;
// }
// int n = Promt("Введиче число: ");


int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{Range(n)}");

string Range (int n)
{
    if(n == 1)
    {
        return "1";
    }
    return n + ", " + Range(n-1);
}
