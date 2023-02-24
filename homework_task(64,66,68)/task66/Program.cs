//  Задайте значения M и N. Напишите программу, 
//  которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int rec(int a, int b)
{
    if (b == a)
        return 0+b ;
    return rec(a,(b-1))+b;
}


Console.Clear();
Console.Write("Введите 1-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(m, n));