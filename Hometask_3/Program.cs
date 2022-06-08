// Задача 3. Домашнее задание
// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

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


void CupArray(int[,] matr1, int[,] matr2, int[,] matr3)
{
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr1.GetLength(1); j++)
        {
            matr3[i,j] = matr1[i,j] * matr2[i,j];
        }
    }
}


int[,] matrix1 = new int[3, 3];
int[,] matrix2 = new int[3, 3];
int[,] matrix3 = new int[3, 3];
FillArray(matrix1, 0, 10);
PrintArray(matrix1);
Console.WriteLine();
FillArray(matrix2, 0, 10);
PrintArray(matrix2);
Console.WriteLine();
CupArray(matrix1, matrix2, matrix3);
PrintArray(matrix3);