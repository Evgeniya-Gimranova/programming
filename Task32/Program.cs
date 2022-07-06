// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


 int[] array = new int[12];
 var rnd = new Random();
 int index = 0;

 while (index < array.Length)
 {
     array[index] = rnd.Next(-9, 10);
     Console.Write($"{array[index]} ");
     index++;
}
Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * -1;
    Console.Write($"{array[i]} ");
}

// void printRndMassive(int [] arr)
// {
// int index = 0 ;
// var rnd = new Random();

// while (index < arr.Length)
// {
//     arr[index] = rnd.Next(-9, 10);
//     Console.Write($" {arr[index]} ");
//     arr[index] = arr[index] *-1;
//   index++;
// }
// // }
// // void printMassive(int [] arr) 
// // {
// for ( int i  = 0; i < arr.Length; i ++)
// {
//     if (i == 0) Console.Write("[");
//     if (i < arr.Length -1) Console.Write(arr[i] + ",");
//     else Console.Write(arr[i]+"]");
// }
// }   

// int [] array = new int [8];
// printRndMassive(array);
// // printMassive(array);
