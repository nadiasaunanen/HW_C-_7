// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Задайте количество строк двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int n = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[m, n];
Random random = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = random.NextDouble() * 100; 
        Console.Write($"{matrix[i, j]} \t");
    }
    Console.WriteLine();
}


// Не получается сделать через методы, выходят ошибки, никак не могу понять, как исправить. 
// Ниже привела вариант, но он не работает.

// int[,] matrix = GetMatrix(rows, columns, minRandom, maxRandom);

// double[,] matrix = GetMatrix(m, n);

// double[,] GetMatrix(int m, int n)
// {
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++) 
//         {
//             matrix[i,j] = random.NextDouble() * 100;
//         }
//         return matrix;
//     }
// }

// Random random = new Random();
// void PrintMatrix(double[,] matrix)
// { 
//     for (int i = 0; i < m; i++)
//     { 
//         for (int j = 0; j < n; j++)
//         {
//              Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// GetMatrix(matrix);

// PrintMatrix(matrix);

