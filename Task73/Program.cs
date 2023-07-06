// Задача 56: Задайте прямоугольный двумерный массив. Напишите 
// программу, которая будет находить строку с наименьшей суммой элементов

Console.Clear();
Console.WriteLine("Введите количество строк: ");
int rows = int.Parse (Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse (Console.ReadLine()!);



int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = rnd.Next(min, max+1);
        }
    }
    return result;
}

    static void PrintArray(int[,] array)
        {
            for (int a = 0; a < array.GetLength(0); a++)
            {
                for (int b = 0; b < array.GetLength(1); b++)
                {
                    Console.Write(array[a, b] + " ");
                }
                Console.WriteLine();
            }
        }

      
             List<int> sums = new List<int>();
   
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int sum = 0;
                
                
                for (int j = 0; j < array.GetLength(1); j++) 
                {
                
                    sum += array[i, j];
                    
                    
                }
                sums.Add(sum);
                
                Console.Write(sum + " ");
               
             }
            Console.WriteLine("Суммы по строкам ");