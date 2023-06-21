// Напишите программу, которая по номеру четверти определяет диапазон значений х и у;



int number = Prompt("Введите номер четверти: ");
FindNumberQuarter(number);
int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
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

