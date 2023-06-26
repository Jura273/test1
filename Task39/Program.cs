
// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

using System;
class HelloWorld {
  static void Main()
  {
        int [] arr=GetArray(200,-100,100);
        PrintArray(arr);
        int key=10;
        if(find(arr,key))
        {
            Console.Write("нашёл");
        }
        else
        {
            Console.Write("не нашёл:(");
        }
    }
  static bool find(int[] arr,int key)
  {
      foreach(int num in arr)
      {
          if(num==key)
          {
              return true;
          }
      }
      return false;
  }
  
  static void PrintArray(int[] arr)
    {
        // for (int i = 0; i < arr.Length; i++)
    // {
    //     Console.Write($"{arr[i]} ");
    // }
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
