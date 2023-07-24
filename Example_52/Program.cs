// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное число: ");
int minRandom = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное число: ");
int maxRandom = Convert.ToInt32(Console.ReadLine());

int[,] matrix = GetMatrix(rows, columns, minRandom, maxRandom);
PrintMatrix(matrix);

int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "   ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine();

void ColumnsAverage(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++) 
    {   
        double columnsAverage = 0;     
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            columnsAverage += matrix[j, i];
        }
    Console.WriteLine($"Среднее арифметическое столбца {i} = {Math.Round(columnsAverage / matrix.GetLength(0), 2)}");
    Console.WriteLine();
    }
}
ColumnsAverage(matrix);