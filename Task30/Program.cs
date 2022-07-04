

int[] array= new int[8];
// int[] array

int index = 0;
var rnd = new Random();
while (index <array.Length)
{
    array[index]= rnd.Next(0,2);  
    index ++;
}

for (int i = 0; i < array.Length; i++)
{
    if (i == 0) Console.Write("[");
    if (i<array.Length - 1) Console.Write(array [i] + " , ");
    else Console.Write(array[i] + " ] ");

}
