// Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
int [] array = new int [10];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(100, 1000);
    Console.WriteLine($"[{string.Join(", ", array)}]");
int count = 0;
foreach(int element in array)
{
    if (element%2 == 0)
        count++;
}
Console.WriteLine($"Количество четных чисел: {count}");