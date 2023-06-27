

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

int Promt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void Check(int a, int b, int c)
{
    if (a < b + c & b < a + c & c < a + b)
    {
        Console.WriteLine("Может существовать");
    }
    else
    {
        Console.WriteLine("Не может существовать");
    }
}


int A = Promt("Введите первое число: ");
int B = Promt("Введите второе число: ");
int C = Promt("Введите третье число: ");
Check(A, B, C);