// Задача 1. Домашнее задание
// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr, int from, int to)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(from, to);
        }
    }
}

void FiltArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(1); k++)
            {
                if (matr[i, j] < matr[i, k])
                    (matr[i, j], matr[i, k]) = (matr[i, k], matr[i, j]);
            }
        }
    }
}

int[,] matrix = new int[5, 4];
FillArray(matrix, 0, 10);
PrintArray(matrix);

Console.WriteLine();

FiltArray(matrix);
PrintArray(matrix);

// Решение Марии

// void OrderElMin(int[,] arr)
// {
//     int row_size = arr.GetLength(0);
//     int column_size = arr.GetLength(1);

//     for (int i = 0; i < row_size; i++)
//     {
//         for (int j = 0; j < column_size; j++)
//         {
//             for (int k = 0; k < column_size - j - 1; k++)
//                 if (arr[i, j] < arr[i, k + 1])
//                     (arr[i, j], arr[i, k + 1]) = (arr[i, k + 1], arr[i, j]);
//         }
//     }
// }