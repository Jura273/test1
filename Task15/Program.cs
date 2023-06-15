// Задача 13: Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6



Console.Clear();
Console.WriteLine("Введите число N: ");
int number = int.Parse (Console.ReadLine()!);
int k = number;

int digits = 0; // кол-во цифр
while (number > 0)
{
  digits++;
  number = (number / 10);
}
Console.WriteLine("Количество цифр в числе = " + digits );

int M1(int arg)
{
    int a1;
    int k1;
    int k2;
    int resul;
    resul = arg;

    a1 = resul % 10;
    k1 = resul - a1;
    k2 = k1 / 10;
    //result1 = k2;
    
    return k2;   
}
int result1 = M1(k);
int result2 = M1(result1);
int result3 = M1(result2);
int result4 = M1(result3);

Console.WriteLine("Первое число для вычислений = " + M1(k));
Console.WriteLine("Второе число для вычислений = " + M1(result1) );
Console.WriteLine("Третье число для вычислений = " + M1(result2) );
Console.WriteLine("Четвертое число для вычислений = " + M1(result3) );

Console.WriteLine($" {k} -> {result3 % 10 } {result2 % 10} {result1 % 10} {k % 10}" );

Console.WriteLine("Третья цифра из заданного числа = " + result1 % 10 );


