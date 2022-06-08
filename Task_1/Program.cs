// Задача 1. Решение задач в группах
// Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void ChangeRows(int[,] matr)
{
    int lastRow = matr.GetLength(0) - 1;
    int firstRow = 0;
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        (matr[firstRow, i], matr[lastRow, i]) = (matr[lastRow, i], matr[firstRow, i]);
    }
}

int[,] matrix = new int[3, 4];
FillArray(matrix);
PrintArray(matrix);

Console.WriteLine();

ChangeRows(matrix);
PrintArray(matrix);