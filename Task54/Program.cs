// Задача 49: Задайте двумерный массив. Найдите элементы, у 
// которых оба индекса чётные, и замените эти элементы на их 
// квадрат

const int M = 3;
const int N = 4;

Console.Clear();
int[,] array2D = GetRandomArray2D(M, N);

PrintArray2D(array2D);
MagicArray2D(array2D);

Console.WriteLine();
PrintArray2D(array2D);

void MagicArray2D(int[,] array2D)
{
    for(int i = 0; i < array2D.GetLength(0); i++)
    {
        for(int j = 0; j < array2D.GetLength(1); j++)
        {
            if(((i + 1) % 2 == 0) & ((j + 1) % 2 == 0)) 
                array2D[i, j] *= array2D[i, j];
        }
    }
}

int[,] GetRandomArray2D(int m, int n)
{
    int[,] array2D = new int[m, n];
    Random random = new Random();

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            array2D[i, j] = random.Next(2, 10);
        }
    }

    return array2D;
}

void PrintArray2D(int[,] array2D)
{
    for(int i = 0; i < array2D.GetLength(0); i++)
    {
        for(int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write($"{array2D[i, j]} ");
        }
        Console.WriteLine();
    }
}
