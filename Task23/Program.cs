// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// 12:01
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21


int number = Prompt("Введите номер четверти: ");
FindNumberQuarter(number);
int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void FindNumberQuarter(int number)
{
    if (number == 1)
    {
        Console.WriteLine("X > 0 и Y > 0");
    }
    else if (number == 2)
    {
        Console.WriteLine("X < 0 и Y > 0");
    }
    else if (number == 3)
    {
        Console.WriteLine("X < 0 и Y < 0");
    }
    else
    {
        Console.WriteLine("Такой четверти нет");
    }
}

