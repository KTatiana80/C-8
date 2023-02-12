// Задача 58: 
// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] ProductMtrices(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int rowMatrix1 = 0; rowMatrix1 < matrix1.GetLength(0); rowMatrix1++)
    {
        for (int colMatrix2 = 0; colMatrix2 < matrix2.GetLength(1); colMatrix2++)
        {
            for (int rowMatrix2 = 0; rowMatrix2 < matrix2.GetLength(0); rowMatrix2++)
            {
                result[rowMatrix1, colMatrix2] += matrix1[rowMatrix1, rowMatrix2] * matrix2[rowMatrix2, colMatrix2];
            }
        }
    }
    return result;
}

int[,] matrix1 = GreatMatrixRndInt(2, 2, 0, 10);
PrintMatrix(matrix1);
int[,] matrix2 = GreatMatrixRndInt(2, 2, 0, 10);
PrintMatrix(matrix2);
int[,] result = ProductMtrices(matrix1, matrix2);
PrintMatrix(result);