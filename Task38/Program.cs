// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

using System;
class HelloWorld {
  static void Main()
  {
        int [] arr=GetArray(20,-100,100);
        PrintArray(arr);
        Console.Write("\n");
        int [] carr=changesign(arr);
        PrintArray(carr);
    }
  static int [] changesign(int[] arr)
  {
      int [] result=new int[arr.Length];
      for(int i=0; i<arr.Length;++i)
      {
          result[i]=-1*arr[i];
      }
      return result;
  }
  static void PrintArray(int[] arr)
    {
    
    foreach (int el in arr)
    {
        Console.Write($"{el} ");
    }
    }
    static int Prompt(string message)
    {
        Console.Write(message);
        int number = int.Parse(Console.ReadLine());
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
}

