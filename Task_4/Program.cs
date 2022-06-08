// Задача 4. Решение в группах задач.
// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на пересечении которыхрасположен наименьший элемент массива.

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
    int lenRow = matr.GetLength(0);
    int lenColumn = matr.GetLength(1);
    if (lenRow != lenColumn) Console.WriteLine("Impossuble");
    else
    {
        for (int i = 0; i < lenRow; i++)
        {
            for (int j = 0; j < lenColumn; j++)
            {
                matr[i, j] = new Random().Next(from, to);
            }
        }
    }
}

int[] FindMinValue(int[,] matr)
{
    int min = matr[0, 0];
    int[] arr = new int[2];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] < min)
            {
                min = matr[i, j];
                arr[0] = i;
                arr[1] = j;
            }
        }
    }
    Console.WriteLine($"Min value - {min}");
    return arr;
}

// Доработанный вариант решения

void NewArr(int[,] matr)
{
    int[] arr1 = FindMinValue(matr);
    int a = matr.GetLength(0) - 1;
    int b = matr.GetLength(1) - 1;
    int[,] newArr = new int[a, b];
    Console.WriteLine();
    int newRow = 0;
    int newCol;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        if (i != arr1[0])
        {
            newCol = 0;
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                if (j != arr1[1])
                {
                    newArr[newRow, newCol] = matr[i, j];
                    Console.Write(newArr[newRow, newCol] + "\t");
                    newCol++;
                }
            }
            Console.WriteLine();
            newRow++;
        }
    }
}

// Вариант решения на уроке
// void NewArray(int[,] matr)
// {
//     int[] arr = FindMinValue(matr);
//     Console.WriteLine();
//     for (int i = 0; i < a; i++)
//     {
//         if (i == arr[0]) continue;
//         for (int j = 0; j < b; j++)
//         {
//             if (j == arr[1]) continue;
//             Console.WriteLine(matr[i, j]);
//         }
//         Console.WriteLine();
//     }
// }

int[,] matrix = new int[4, 4];
FillArray(matrix, -10, 10);
PrintArray(matrix);

Console.WriteLine();
NewArr(matrix);


