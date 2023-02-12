//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ Math.Pow();
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine()); 
int result = A;
for(int i = 0; i<B; i++)
{
    result = result*A;
}
Console.Write(result/A);