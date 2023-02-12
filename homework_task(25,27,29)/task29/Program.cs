Console.Clear();
Console.Write("Введите колличество элементов массива " );
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
    array[i] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"[{string.Join(", ", array)}]");

Console.WriteLine("Какое число нужно найти: ");
int k = Convert.ToInt32(Console.ReadLine());
int count = 0;
for(int i=0;i<array.Length;i++)
{
     if (array[i]==k)
     count = count +1;
}
 Console.WriteLine($"Число [{k}] встречается: {count} раз");
