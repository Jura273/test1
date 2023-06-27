// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10
// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

int Promt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
// string Change(int decimalNumber)
// {
//     int remainder;
//     string result = string.Empty;
//     while (decimalNumber > 0)
//     {
//         remainder = decimalNumber % 2;
//         decimalNumber /= 2;
//         result = remainder.ToString() + result;
//     }
//     return result;
// }


int num = Promt("Введите число: ");
string res1 = Convert.ToString(num, 2);
Console.WriteLine(res1);