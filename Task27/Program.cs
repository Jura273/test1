// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


int XA =  Promt ("введите координаты точка xА: ");
int YA =  Promt ("введите координаты точка yА: ");
int ZA =  Promt ("введите координаты точка zA: ");
int XB =  Promt ("введите координаты точка xВ: ");
int YB =  Promt ("введите координаты точка yB: ");
int ZB =  Promt ("введите координаты точка zB: ");

int Promt(string message) 
{
    Console.Write(message);
        int number = int.Parse(Console.ReadLine()!);
    return number;
};

double AB = double.Sqrt((XB-XA)*(XB-XA)+(YB-YA)*(YB-YA)+(ZB-ZA)*(ZB-ZA));

Console.WriteLine(AB);

