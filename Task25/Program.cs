
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int number = Promt ("введите число: ");
int i = 1;
int Promt(string message) 
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
while (i<=number)
{
    Console.Write(i*i + " ");
    i++;
}
int num = Promt ("введите число: ");
Square (num);
int Promt(string message) 
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void Square(int number)
{
int i = 1;
while (i<=number)
{
    Console.Write(i*i + " ");
    i++;
}
}