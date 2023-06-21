//Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
int number = Promt("Введите пятизначное число N:  ");

int Promt(string message) 
{
    Console.Write(message);
     int  number = int.Parse(Console.ReadLine()!);
    return number;
}

int k1 = (number % 10);
int z1 = ((number - k1) / 10);
int k2 = (z1 % 10);
int z2 = ((z1 - k2) / 10);
int k3 = (z2 % 10);
int z3 = ((z2 - k3) / 10);
int k4 = (z3 % 10);
int z4 = ((z3 - k4) / 10);
int k5 = (z4 % 10);

 Console.WriteLine($" {number} -> {k5} {k4} {k3} {k2} {k1}" );
   
    if ((k1 == k5) && (k2 == k4))
    {
        Console.WriteLine(" Число зеркальное ");
    }
    else
    {
        Console.WriteLine(" Число незеркальное ");
    }

