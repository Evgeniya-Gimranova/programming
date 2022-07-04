// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120



Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
int multi = 1;
while (count <= num)
{
    checked
    {
        multi = multi * count;
        count++;
    }
}
Console.WriteLine($"Произведение чисел {multi}");