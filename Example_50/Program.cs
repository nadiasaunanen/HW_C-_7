// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное число: ");
int minRandom = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное число: ");
int maxRandom = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первое число искомого индекса: ");
int findIndexRows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число искомого индекса: ");
int findIndexColumns = Convert.ToInt32(Console.ReadLine());


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


if (findIndexRows > rows || findIndexColumns > columns)
{
    Console.WriteLine("Такого числа в массиве нет");
}
else
{
    Console.WriteLine($"Число под данным индексом = {matrix[findIndexRows, findIndexColumns]}");
}