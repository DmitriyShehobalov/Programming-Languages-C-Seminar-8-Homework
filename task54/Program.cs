// Задача 54: Задайте двумерный массив. 
// 1.Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
void MatrixSort(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int k = 0; k < matr.GetLength(1)-1; k++)
        {
            int max = k;
            for (int j = k + 1; j < matr.GetLength(1); j++)
            {
                if (matr[i, max] < matr[i, j]) max = j;
            }
            (matr[i, max], matr[i, k]) = (matr[i, k], matr[i, max]);
        }
    }
}
int[,] matrix = CreateMatrixRndInt(5, 5, 10, 99);
PrintMatrix(matrix);
System.Console.WriteLine();
MatrixSort(matrix);
PrintMatrix(matrix);



