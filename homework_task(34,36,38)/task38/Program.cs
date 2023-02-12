// Задайте массив целых чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3, 7, 22, 2, 78] -> 76

Console.Clear();
int [] array = new int [10];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0, 100);
    Console.WriteLine($"[{string.Join(", ", array)}]");
int max = 0;
int min = 100;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
}
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }
}
Console.WriteLine($"Paзницa между максимальным и минимальным элементов массива: {max-min}");