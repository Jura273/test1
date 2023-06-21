// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21



int XA =  Promt ("введите координаты точка xА: ");
int YA =  Promt ("введите координаты точка yА: ");
int XB =  Promt ("введите координаты точка xВ: ");
int YB =  Promt ("введите координаты точка yB: ");

int Promt(string message) 
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

double AB = Math.Sqrt((XB-XA)*(XB-XA)+(YB-YA)*(YB-YA));

Console.WriteLine(AB);





AB = Math.Sqrt((XB-XA)*(XB-XA)+(YB-YA)*(YB-YA));