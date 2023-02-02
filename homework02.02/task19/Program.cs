// // Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// // 14212 -> нет
// // 12821 -> да
// // 23432 -> да..

Console.Clear();
Console.WriteLine("Введите 5ти значное число ");
int n = Convert.ToInt32(Console.ReadLine());
while(n>99999||n<=10000)
{
    Console.WriteLine("Вы ошиблись,Введите 5ти значное число ");
    n = Convert.ToInt32(Console.ReadLine());
}

if ((n%100)-(n/1000)==9)
{
    Console.WriteLine("Yes");
}
else if ((n/1000)-(n%100)==9)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
