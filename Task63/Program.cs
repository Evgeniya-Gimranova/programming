//вывести числа от 1 до N

Console.Clear();
Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
NaturalNumber(num);

void NaturalNumber (int num)
{
    if (num==0) return;
    NaturalNumber (num-1);
    Console.Write($"{num} ");
}
