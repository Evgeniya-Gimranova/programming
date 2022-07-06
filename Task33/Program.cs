// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

// int[] CreateArrayRndInt(int size)
// {
//     int[] array = new int[size];
//     var rnd = new Random();
//     int index = 0;

//     while (index < array.Length)
//     {
//         array[index] = rnd.Next(-300, 301);
//         index++;
//     }
//     return array;
// }
// int[] array1 = CreateArrayRndInt(10);

// void PrintArray(int [] array1)
// {
//     for (int i = 0; i < array1.Length; i++)
// {
//     if (i == 0) Console.Write("[");
//     if (i<array1.Length - 1) Console.Write(array1 [i] + " , ");
//     else Console.Write(array1[i] + " ] ");

// }
// }
// Console.WriteLine("Введите проверяемое число ");
// int num = Convert.ToInt32(Console.ReadLine());

// for (int i = 0; i < array1.Length; i++)
// {
//     if (array1[i] == num)
//     Console.Write("-> да");
//     else
//     Console.Write("-> нет");
// }



Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
//int[] array = new int[5];
int[] array = { 6, 7, 19, 345, 3 };
var rnd = new Random();
int index = 0;
// while (index < array.Length)
// {
//     array[index] = rnd.Next(0, 1000);
//     Console.Write($"{array[index]}  ");
//     index++;
// }
Console.WriteLine();
string CheckNumber(int[] arr, int num)
{
    string res = "нет";
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num) res = "Да";
    }
    return res;
}
string result = CheckNumber(array, number);
Console.WriteLine(result);
