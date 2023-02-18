// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этот элемент или же указание, что такого элемента нет.
// Например, задан массив: 3 4
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(10, 100);
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

void IskomyElement(int[,] matrix)
{
    Console.WriteLine("Введите искомый элемент: ");
    int a = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < matrix.GetLength(0) + 1; i++)
    {
        for (int j = 0; j < matrix.GetLength(1) + 1; j++)
            if (i == a / 10 && j == a % 10)
                Console.WriteLine($"Искомый элемент : {matrix[i - 1, j - 1]}");
    }
    if ((a / 10) * (a % 10) > matrix.Length)
        Console.WriteLine("такого числа в массиве нет");
}


Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
IskomyElement(matrix);
