// Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Clear();
Console.WriteLine("Введите числа: ");
int count = 0;
for(int i=0;i<7;i++)
{
    Console.Write("");
    int n = Convert.ToInt32(Console.ReadLine());

if (n>0)
{
    count++;
}
}
Console.WriteLine($"Количество чисел больше 0: {count}");
