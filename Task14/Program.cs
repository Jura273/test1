// Задача 13: Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

//int number;
// int number2;
//     number = 3454;
//     number2 = number;
// int number1;
// int number2;
// int number3;

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


//int a1 =  (k % 10);

// int Max(int ard1, int ard2, int ard3)
// После этого опишем тело метода:
// {
// int result = arg1;
// if(arg2>result) result=arg2;
// if(arg3>result) result=arg3;
// return result;
// }
int a1;
int k1;
int k2;
int result;
int result1;
//int result2;
   result = k;
 //  result1 =0;

int M1(int result)

{
    a1 = result % 10;
    k1 = result - a1;
    k2 = k1 / 10;
    result = k2;
    result1 = result;
    return result;
    
}
//result1 = result;

Console.WriteLine("Второе число = " + M1(result) );

Console.WriteLine("Третье число = " + M1(result1) );



// int a2 = k2 % 10;
// int l1 = k2 - a2;
// int l2 = l1 / 10;

// int a3 = l2 % 10;
// int z1 = l2 - a3;
// int z2 = z1 / 10;

//  Console.WriteLine($" {k} -> {a3} {a2} {a1}" );

// int secondValue = number / 100;

// int gValue = (number - firstValue) % 100;
// int midleValue = gValue / 10;

// Console.WriteLine($" {number} -> {secondValue} {midleValue} {firstValue}" );
// Console.WriteLine ( midleValue);

// Console.WriteLine("Вторая цифра числа = " + midleValue );



