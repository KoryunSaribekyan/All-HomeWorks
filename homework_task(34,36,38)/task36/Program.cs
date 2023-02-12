// Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.Clear();
int [] array = new int [10];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0, 11);
    Console.WriteLine($"[{string.Join(", ", array)}]");
int summa = 0;
for (int i = 1; i < array.Length; i=i+2)
    {
    summa = summa + array[i];
    }
Console.WriteLine($"Сумма элементов,стоящих на нечётных позициях: {summa} ");

