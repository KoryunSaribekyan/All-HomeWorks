// // Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// // 14212 -> нет
// // 12821 -> да
// // 23432 -> да..

Console.Clear();
Console.WriteLine("Введите 5ти значное число ");
int n = Convert.ToInt32(Console.ReadLine());
while (n > 99999 || n <= 10000)
{
    Console.WriteLine("Вы ошиблись,Введите 5ти значное число ");
    n = Convert.ToInt32(Console.ReadLine());
}
int n1 = n / 10;
n1 = n1 % 10;
int n2 = n / 1000;
n2 = n2 % 10;


if (n2 == n1 && n % 10 == n / 10000)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
