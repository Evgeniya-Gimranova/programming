// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.


Console.WriteLine("Введите число 1 ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2 ");
int b = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите число 3 ");
int c = Convert.ToInt32(Console.ReadLine());

bool Triangle(int a1, int b1, int c1)
{
 
    return (a1 < b1 + c1 && b1 < a1 + c1 && c1 < a1 + b1);
}
bool res = Triangle(a, b, c);
Console.WriteLine(res ? "Да" : "Нет");

// if (a < b + c && b < a + c && c < a + b)
// {
//     Console.WriteLine("Да");
// }
// else Console.WriteLine("Нет");
