// Задача 56: 
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 
// 1 строка

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
    int[] line = new int[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        line[i] = arr[rowNumber, i];
    }
    return line;
}


int SumElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum = sum + array[i];
    }
    return sum;
}

int GetIndexMinElem(int[] array)
{
    int indexMin = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < array[indexMin])
        {
            indexMin = i;
        }
    }
    return indexMin;
}

int[,] array2D = GreatMatrixRndInt(4, 4, 0, 10);
int[] sum = new int[array2D.GetLength(0)];
PrintMatrix(array2D);

for (int i = 0; i < array2D.GetLength(0); i++)
{
    int[] array = GetRow(array2D, i);
    sum[i] = SumElements(array);
    Console.WriteLine(sum[i]);
}
int indexMin = GetIndexMinElem(sum);
Console.WriteLine($"Наимен6шая сумма элементов в строке {indexMin + 1}");

