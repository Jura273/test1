// адача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

//Using System;
class HelloWorld {
  static void Main()
  {
      
        int [] arr=GetArray(21,-100,100);
        PrintArray(arr);
        int [] result=productPair(arr);
        Console.Write("\n");
        PrintArray(result);
    }
  static int[] productPair(int[] arr)
  {
      int [] result= new int[(arr.Length+1)/2];
      for(int i=0;i<(arr.Length+1)/2;++i)
      {
          result[i]=arr[i]*arr[arr.Length-i-1];
      }
      if(arr.Length%2==1)
      {
          result[(arr.Length-1)/2]= arr[(arr.Length-1)/2];
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

// //}using System;
// class HelloWorld {
//   static void Main()
//   {
      
//         int [] arr=GetArray(21,-100,100);
//         PrintArray(arr);
//         int [] result=productPair(arr);
//         Console.Write("\n");
//         PrintArray(result);
//     }
//   static int[] productPair(int[] arr)
//   {
//       int [] result= new int[(arr.Length+1)/2];
//       for(int i=0;i<(arr.Length+1)/2;++i)
//       {
//           result[i]=arr[i]*arr[arr.Length-i-1];
//       }
//       if(arr.Length%2==1)
//       {
//           result[(arr.Length-1)/2]= arr[(arr.Length-1)/2];
//       }
//       return result;
//   }
  
//   static void PrintArray(int[] arr)
//     {
       
//     foreach (int el in arr)
//     {
//         Console.Write($"{el} ");
//     }
//     }
//     static int Prompt(string message)
//     {
//         Console.Write(message);
//         int number = int.Parse(Console.ReadLine());
//             return number;
//     }   
//     static int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < result.Length; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1);

//     }
//     return result;
// }
// }