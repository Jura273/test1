// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.
// 25 мин
// Набор данных Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 } 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза


using System;
class HelloWorld {
  static void Main() {
      int m=10;
      int n=10;
      int [,]arr=GetArray(m,n,0,1000);
      PrintArray(arr);
      Console.WriteLine();
      var res=friquency(arr,m,n);
      PrintArray(res.Item1,res.Item2);
    
  }
  static int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max); // [0,0] , [0,1] , [0,2]....//[1,0], [1,1] , [1,2]

        }
    }
    return result;
}
    static void swap(int[,]arr,int m, int swapfirst,int swapsecond)
    {
        for(int i=0;i<m;++i)
        {
            int tmp=arr[swapfirst,i];
            arr[swapfirst,i]=arr[swapsecond,i];
            arr[swapsecond,i]=tmp;
        }
    }
    static
    void PrintArray(int[,] arr)
{
      for(int i = 0; i < arr.GetLength(0); i++)  // длина строки
    {
        for(int j = 0; j < arr.GetLength(1); j++)  // длина столбца
        {
            Console.Write(arr[i,j] + " ");
         
        }
        Console.WriteLine();
    }
}
static void PrintArray(int[] arr,int[] arr2)
{
      for(int i = 0; i < arr.GetLength(0); i++)  // длина строки
    {
        
            Console.Write(arr[i]  +" "+arr2[i]);
         
        
        Console.WriteLine();
    }
}
static int [,] transposition(int[,]arr ,int m,int n)
{
    int [,]result =new int[n,m];
    for(int i=0;i<m;++i)
    {
        for(int j=0;j<n;++j)
        {
            result[j,i]=arr[i,j];
        }
    }
    return result;
}
    static (int[] ,int[]) friquency(int [,]arr,int m,int n)
    {   
        int []num=new int[m*n];
        int []count=new int[m*n];
        int realsize=0;
        for(int i=0;i<m;++i)
        {
            for(int j=0;j<n;++j)
            {
                bool find=false;
                for(int k=0;k<realsize;++k)
                {
                    if(num[k]==arr[i,j])
                    {
                        ++count[k];
                        find=true;
                        break;
                    }
                    //k++(l=k;++k;return l;)
                    //++k(k+=1;return k)
                }
                if(!find)
                {
                    ++realsize;
                    num[realsize-1]=arr[i,j];
                    count[realsize-1]=1;
                }                
            }
        }
        return (num,count);
        
    }
}