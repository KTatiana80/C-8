// Задача 53: 
// Задайте двумерный массив. 
// Напишите программу, которая поменяет местами 
// первую и последнюю строку массива.

// Создание двумерного массива
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

// Вывод двумерного массива
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} | ");
            else Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("|");
    }
}

// Замена строки в массиве
void RowReplacing(int[,] matrix)
{
    int tmp = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        tmp = matrix[0, i];
        matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
        matrix[matrix.GetLength(0) - 1, i] = tmp;
    }
}


int[,] array2D = CreateMatrixRndInt(3, 5, 10, 100);
PrintMatrix(array2D);
Console.WriteLine();

RowReplacing(array2D);
PrintMatrix(array2D);
