//  Задача 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0  

using System;
class HelloWorld {
  static void Main()
  {

        double [] arr=GetArrayDouble(20,-1000,1000);
        PrintArrayDouble(arr);
        double result=distace(arr);
        Console.Write($"\n{result}");
    }
  static double distace(double[] arr)
  {

        double maxValue=arr[0];
        double minValue=arr[0];
      foreach(int num in arr)//ноль не четноё так как в реальности счёт с 1
      {
          if(maxValue<num)
          {
              maxValue=num;
          }
          if(minValue>num){
            minValue=num; 
          }
      }
      return maxValue-minValue;
  }

  static void PrintArrayDouble(double[] arr)
    {
            foreach (double el in arr)
    {
        Console.Write($"{el} ");
    }
    }
    static int Prompt(string message)
    {
        Console.Write(message);
        int number = int.Parse(Console.ReadLine()!);
            return number;
    }   
    static int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);

    }
    return result;
}
 static double[] GetArrayDouble(int size, double minValue, double maxValue)
{
    double[] result = new double[size];
    for (int i = 0; i < result.Length; i++)
    {
        double coeff= new Random().NextDouble();
        result[i] =minValue+(maxValue-minValue)*coeff;

    }
    return result;
}
}