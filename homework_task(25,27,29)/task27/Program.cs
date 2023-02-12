// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
    
//     int Dlina = Convert.ToString(n).Length;
//     int result = 0;

//     for (int i = 0; i < Dlina; i++)
//     {
//       result = result + (n % 10);
//       n = n / 10;
//     }

// Console.WriteLine(result);

Console.Write("Введите число: ");
string? stroka = Console.ReadLine();
int summa = 0;
for(int i = 0; i<stroka.Length; i++)
{
summa = summa + Convert.ToInt32(stroka[i].ToString());
}
Console.WriteLine(summa);


