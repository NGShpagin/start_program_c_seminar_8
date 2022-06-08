// Задача 2. Решение задач в группах.
// Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива

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
    int lenRow = matr.GetLength(0);
    int lenColumn = matr.GetLength(1);
    if (lenRow != lenColumn) Console.WriteLine("Impossuble");
    else
    {    
        for (int i = 0; i < lenRow; i++)
        {
            for (int j = 0; j < lenColumn; j++)
            {
                matr[i, j] = new Random().Next(1, 10);
            }
        }
    }
}


// Вариант решения 1. (на уроке)
void TransMatr(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            (matr[i, j], matr[j, i]) = (matr[j, i], matr[i, j]);
        }
    }
}


// Вариант решения 2. (мой)
// void TransMatr(int[,] matr)
// {
//     int j = 0;
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         j = i;
//         while (j < matr.GetLength(1))
//         {
//             (matr[i, j], matr[j, i]) = (matr[j, i], matr[i, j]);
//             j++;
//         }
//     }
// }

int[,] matrix = new int[4, 4];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
TransMatr(matrix);
PrintArray(matrix);