// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
/*
void ShowNumbers(int n)
{
    if(n > 1) ShowNumbers(n-1);
    Console.Write(n + " ");
}

ShowNumbers(5);
*/

// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
/*
int SumOfDigits(int num)
{
    if(num != 0) return SumOfDigits(num / 10) + num % 10;
    return 0;
}

Console.WriteLine(SumOfDigits(1234));
*/
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
void ShowNumbers(int m, int n)
{
    if (m > n)  
    {
        ShowNumbers(m - 1, n);
        Console.Write(m + " ");
    }
    else 
    {
        if(n > m) ShowNumbers(n - 1, m);
        Console.Write(n + " ");
    }
}

Console.WriteLine("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNumbers(m, n);
*/

// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B.

double PowNumber(double a, double b)
{
    if (b > 0) return PowNumber(a, b - 1) * a;
    if (b < 0) return PowNumber(a, b + 1) / a;
    return 1;
}
Console.WriteLine("Введите число: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(PowNumber(a, b));
