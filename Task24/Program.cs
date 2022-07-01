Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
// for (int i = 1; i <= number; i++)
// {
//     sum += i;
// }
// Console.WriteLine($"{sum}");


int Sum(int num)
{
    int sum1 = 0;
    for (int i = 1; i <= num; i++)
    {
        sum1 += i;
    }
    return sum1;
}
sum = Sum(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sum}");