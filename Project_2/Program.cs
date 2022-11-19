// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4


int[,] InitMatrix()
{
    Random rnd = new Random();
    int[,] mtrx = new int[rnd.Next(1,10),rnd.Next(1,10)];
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            mtrx[i,j] = rnd.Next(-10,11); 
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

void FindElementOfMassive(Position pos, int[,] matrix)
{
    if(pos.Row < matrix.GetLength(0) && pos.Column < matrix.GetLength(1))
    Console.WriteLine($"Элемент на позиции ({pos.Row},{pos.Column}) равен {matrix[pos.Row,pos.Column]}");
    else Console.WriteLine("Элемента с такой позицией не существует");
}
Position findingPosition = new Position();
int[,] matrix = InitMatrix();
PrintMatrix(matrix);
Console.WriteLine("Введите значение строки на которой хотите найти элемент: ");
findingPosition.Row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение столбца на котором хотите найти элемент: ");
findingPosition.Column = Convert.ToInt32(Console.ReadLine());
FindElementOfMassive(findingPosition,matrix);



class Position
{
    public int Row{get;set;}
    public int Column{get; set;}
}


