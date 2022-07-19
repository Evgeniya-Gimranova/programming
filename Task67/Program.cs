// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();
Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

int sum = SumNumber(num);
Console.Write(sum);
int SumNumber(int n)
{

    if (n > 0)  return n % 10 + SumNumber(n / 10);

    return 0;
}
