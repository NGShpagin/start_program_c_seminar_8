// Задача 2. Домашнее задание
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

void SumArray(int[,] matr)
{
    int[] minSumArr = new int[matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr[i, j];
            minSumArr[i] = sum;
        }
    }
    int min = 0;
    int minSum = minSumArr[0];
    for (int i = 0; i < minSumArr.Length; i++)
    {
        if (minSum > minSumArr[i])
        {
            minSum = minSumArr[i];
            min = i;
        }
        Console.Write($"{minSumArr[i]} ");
    }
    Console.WriteLine();
    Console.WriteLine($"Line with min number sum ({minSum}) is in the {min + 1} line");
}

int[,] matrix = new int[5, 4];
FillArray(matrix, 0, 10);
PrintArray(matrix);

Console.WriteLine();

SumArray(matrix);

// Решение Марии
// void RowSmallAmount(int[,] arr)
// {
//     int row_size = arr.GetLength(0);
//     int column_size = arr.GetLength(1);
//     int amount = 1000;
//     int num;
//     int smallest = 0;

//     for (int i = 0; i < row_size; i++)
//     {
//         num = 0;
//         for (int j = 0; j < column_size; j++)
//             num += arr[i,j];
        
//         if (amount > num)
//         {
//             amount = num;
//             smallest = i;
//         }

//     }
// }