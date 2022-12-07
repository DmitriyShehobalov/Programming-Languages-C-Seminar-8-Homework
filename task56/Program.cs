// Задача 56: Задайте прямоугольный двумерный массив. 
// 1.Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i < arr.Length - 1) Console.Write(", ");


    }
    Console.WriteLine("]");
}
void PrintMatrix(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j],4} |");
            else Console.Write($"{matr[i, j],4}");
        }
        Console.WriteLine(" ]");
    }
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

int[] GetSumRow(int[,] matr)
{
    int[] arr = new int[matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum = sum + matr[i, j];
        }
        arr[i] = sum;
    }
    return arr;
}
void ReturnStringSumMatrix(int[] array)
{
    int indexMinSum = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[indexMinSum] >array[i]) indexMinSum = i;
    }
    System.Console.WriteLine($"Line number with the smallest sum elements -> {indexMinSum+1}");
}
int[,] matrix = CreateMatrixRndInt(4, 4, 1, 99);
PrintMatrix(matrix);
Console.WriteLine();

int[] getSumRow = GetSumRow(matrix);
PrintArray(getSumRow);
ReturnStringSumMatrix(getSumRow);