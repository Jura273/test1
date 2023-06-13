
// вход два числа и проверяет, является ли одно 
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет



Console.WriteLine("Введите число:");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число:");
int numberTwo = Convert.ToInt32(Console.ReadLine());

string res = ("");
if(numberTwo * numberTwo != numberOne && numberOne * numberOne != numberTwo){
    res = ("Нет");
}

else {
    res = ("Да");
}
Console.WriteLine(res);