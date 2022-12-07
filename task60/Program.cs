// Задача 60. ...
// 1.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)
void Print3DMatrix(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
           Console.Write(" ");
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                if (k < matr.GetLength(2) - 1) Console.Write($"{matr[i, j, k],2}({i},{j},{k}) ");
                else Console.Write($"{matr[i, j, k],2}({i},{j},{k})");
            }
        }
        Console.WriteLine("");
    }
}

int[,,] Create3DMatrixRndInt(int rows, int columns, int depth)
{
    int[,,] matrix = new int[rows, columns, depth];
    var rnd = new Random();
    int count = rnd.Next(10, 11);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = count;
                count++;
            }
        }
    }
    return matrix;
}
int[,,] matrix3D = Create3DMatrixRndInt(2, 2, 2);
Print3DMatrix(matrix3D);
Console.WriteLine();
