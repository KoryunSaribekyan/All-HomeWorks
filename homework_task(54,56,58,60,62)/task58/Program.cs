// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 6 16
// 9 6

void InputMatrix1(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 10);

    }
}
void InputMatrix2(int[,] matrix2)
{
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
            matrix2[i, j] = new Random().Next(1, 10);

    }
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();

    }
}
void PrintMatrix2(int[,] matrix2)
{
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
            Console.Write($"{matrix2[i, j]} \t");
        Console.WriteLine();

    }
}

void Product(int[,] matrix, int[,] matrix2)
{
    int[,] matrix3 = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix3[i,j] = matrix[i,j] * matrix2[i,j];
            Console.Write($"{matrix3[i, j]} \t");
        }

        Console.WriteLine();
    }   
}

Console.Clear();
Console.Write("Введите размер массива 1: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix1(matrix);
PrintMatrix(matrix);
Console.Write("Введите размер массива 2, равный размеру матрицы 1: ");
int[] size2 = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix2 = new int[size[0], size[1]];
InputMatrix2(matrix2);
PrintMatrix2(matrix2);
Console.WriteLine();
Console.WriteLine("Результирующая матрица: ");
Product(matrix, matrix2);
