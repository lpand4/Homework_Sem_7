// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] InitMatrix()
{
    Console.WriteLine("Введите количество строк m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Random rnd = new Random();

    double[,] mtrx = new double[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            mtrx[i,j] = Math.Round(rnd.Next(-10,11) + rnd.NextDouble(),1); 
        }
    }
    return mtrx;
}

void PrintMatrix(double[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            Console.Write($"{mtrx[i,j]}   ");
        }
        Console.WriteLine();
    }
}

double[,] matrix = InitMatrix();
PrintMatrix(matrix);