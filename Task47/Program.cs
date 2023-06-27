// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
//  Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

// Console.Write("Введите количество чисел Фибоначчи: ");
// int n = int.Parse(Console.ReadLine());
// int a = 0, b = 1, c;
// Console.Write(a + " " + b + " ");
// for (int i = 2; i < n; i++)
// {
//     c = a + b;
//     Console.Write(c + " ");
//     a = b;
//     b = c;
// }

// Задача 44: Не используя рекурсию, выведите первые
// N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и
// 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int Promt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int N = Promt("Введиче число: ");
Console.Write(Fibonacci(N));
string Fibonacci(int n)
{
    int a = 0, b = 1, c;
    string result = a + " " + b + " ";
    for (int i = 2; i < n; i++)
    {
        c = a + b;
        result = result + c + " ";
        a = b;
        b = c;
    }
    return result;
}