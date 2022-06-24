// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int rndNum = new Random().Next(10, 100);
Console.WriteLine($"Случайное числоиз отрезка 10-99 => {rndNum}");
 int firstDigit = rndNum / 10;
 int secondDigit = rndNum % 10;
// Console.Write($"Наибольшая цифра числа {rndNum} => ");

// if (firstDigit > secondDigit) Console.WriteLine(firstDigit);
// else Console.WriteLine(secondDigit);

Console.WriteLine(firstDigit > secondDigit ? firstDigit : secondDigit);

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    if (firstDigit == secondDigit) return 0;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}
int maxDigit = MaxDigit (rndNum);
string result = maxDigit > 0 ? maxDigit.ToString() : "цифры одинаковые";
Console.WriteLine($"Наибольшая цифра числа {rndNum} => {result}");