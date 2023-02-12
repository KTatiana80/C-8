// Задача 54: 
// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] GreatMatrixRndInt(int rows, int columns, int min, int max)
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

void PrintMatrix(int[,] matrix)
{
    string str = string.Empty;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        str += "|";
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == matrix.GetLength(1) - 1) str += $" {matrix[i, j],3} ";
            else str += $" {matrix[i, j],3}  |";
        }
        str += " |\n";
    }
    Console.WriteLine(str);
}

int[] GetRow(int[,] arr, int rowNumber)
{
    int[] result = new int[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        result[i] = arr[rowNumber, i];
    }
    return result;
}

void BubbleSort(int[] mas)
{
    int temp;
    for (int i = 0; i < mas.Length; i++)
    {
        for (int j = i + 1; j < mas.Length; j++)
        {
            if (mas[i] < mas[j])
            {
                temp = mas[i];
                mas[i] = mas[j];
                mas[j] = temp;
            }
        }
    }
}

int[,] array2D = GreatMatrixRndInt(4, 4, -100, 100);
int[,] result = new int[array2D.GetLength(0), array2D.GetLength(1)];
PrintMatrix(array2D);
for (int i = 0; i < array2D.GetLength(0); i++)
{
    int[] row = GetRow(array2D, i);
    BubbleSort(row);
    for (int k = 0; k < row.Length; k++)
    {
        result[i, k] = row[k];
    }
}
PrintMatrix(result);

