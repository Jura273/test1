// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string mess = "Введите число: ";
int number1 = Prompt(mess);

int result = FindThirdNumber(number1);
if (result == -1)
{
    Console.WriteLine("Такой цифры нет! ");
}
else
{
    Console.WriteLine($"Третья цифра числа {result}");
}



int Prompt(string message)
{
    Console.Clear();
    Console.WriteLine(message);
    int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    return num;
}

int FindThirdNumber(int num)
{
    if (num < 100)
    {
        return -1;

    }
    else
    {
        while (num >= 1000)
        {
            num = num / 10;
        }
        int thirdNumber = num % 10;
        return thirdNumber;
    }
}
