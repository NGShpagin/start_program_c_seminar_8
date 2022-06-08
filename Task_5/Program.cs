void Paskal(int n)
{
    int m = (n * 2) - 1;
    int[,] matr = new int[n, m];
    for (int j = 0; j < m; j++)
    {
        matr[0, j] = 0;
        if (j == n - 1) matr[0, j] = 1;
        if (matr[0, j] == 0) Console.Write(" ");
        else Console.Write(matr[0, j]);
    }
    Console.WriteLine();
    for (int i = 1; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            if (i == n - 1 && (j == 0 || j == m - 1))
            {
                matr[i, 0] = 1;
                matr[i, m - 1] = 1;
            }
            else if (j < n - 1 - i || j > n - 1 + i)
            {
                matr[i, j] = 0;
                Console.Write(" ");
            }
            else
            {
                matr[i, j] = matr[i - 1, j - 1] + matr[i - 1, j + 1];
                if (matr[i, j] == 0) Console.Write(" ");
                else Console.Write(matr[i, j]);
            }
        }
        Console.WriteLine();
    }
}

Paskal(15);
Console.WriteLine();