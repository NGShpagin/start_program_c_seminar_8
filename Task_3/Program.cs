// Задача 3. Решение в группах задач (Д/З)
// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// Значения элементов массива 0...9.

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

int ArrSize(int[,] matr)
{
    int size = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++) size++;
    }
    return size;
}

void Dict(int[,] matr, int arrSize)
{
    int ind = -1;
    int[] arr = new int[arrSize];
    int[] count = new int[arrSize];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            string flag = "False";
            for (int index = 0; index < arr.Length; index++)
            {
                if (arr[index] == matr[i, j])
                {
                    count[index]++;
                    flag = "True";
                }
            }
            if (flag == "False")
            {
                ind++;
                arr[ind] = matr[i, j];
                count[ind] = 1;
            }
        }
    }
    for (int index = 0; index < arr.Length; index++)
    {
        if (arr[index] != 0) Console.WriteLine($"Number {arr[index]} -> {count[index]}");
    }
}

int[,] matrix = new int[7, 5];
FillArray(matrix, 1, 10);
PrintArray(matrix);
int arrSize = ArrSize(matrix);
Dict(matrix, arrSize);

// Решение Марии ()

// int[] FrequencyDict(int[,] arr)
// {
//     int[] freq = new int[10];
//     foreach (int item in arr) freq[item] += 1;
//     return freq;
// }

// void PrintMass(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//         Console.WriteLine($"{i} meets: {arr[i]}");
//     Console.WriteLine();
// }