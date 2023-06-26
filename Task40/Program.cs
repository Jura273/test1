// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

using System;
class HelloWorld {
  static void Main()
  {
        int [] arr=GetArray(123,-100,100);
        PrintArray(arr);
        
            Console.Write($"\ncount: {countinrange(arr,10,99)}");
       
    }
  static int countinrange(int[] arr,int rangeMin,int rangeMax)
  {
      int count=0;
      foreach(int num in arr)
      {
          if((num>=rangeMin)&&(num<=rangeMax))
          {
              ++count;
          }
      }
      return count;
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
}
