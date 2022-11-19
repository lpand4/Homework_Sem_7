// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] InitMatrix(int m,int n)
{
    Random rnd = new Random();
    int[,] mtrx = new int[m,n];
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            mtrx[i,j] = rnd.Next(0,11); 
        }
    }
    return mtrx;
}

void PrintMatrix(int[,] mtrx)
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
void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"Среднее арифметическое столбца {i+1} равно: {arr[i]}");
        }
    
}

double[] SredneeArifm(int[,] mtrx)
{
    double sum = 0;
    double[] srednee = new double[mtrx.GetLength(1)];
    
    for (int i = 0; i < mtrx.GetLength(1); i++)
    {
        for (int j = 0; j < mtrx.GetLength(0); j++)
        {
            sum = sum + mtrx[j,i];
           
        }
        srednee[i] = sum/mtrx.GetLength(0);
        sum = 0;
    }
    
    return srednee;
}
Console.WriteLine("Введите кол-во строк матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = InitMatrix(m,n);
Console.WriteLine();
PrintMatrix(matrix);
double[] result = SredneeArifm(matrix);
Console.WriteLine("============================");
PrintArray(result);