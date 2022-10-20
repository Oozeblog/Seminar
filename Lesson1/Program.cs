// Ввод число. Вывод - удвоенное число.
/*
        Console.Write("Input a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        num = num * 2;
        Console.WriteLine("Your new number is " + num);
*/

// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
/*
Console.Write("Input a ferst number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int quat2 = n2 * n2;

if(n1 == quat2)

{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
*/

// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
/*
Console.Write("Input a positiv intrger number: ");
int n = Convert.ToInt32(Console.ReadLine());

int current = -n;
while(current <= n)
{
    Console.Write(current + " ");
    current++;
}
*/

// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
/*
Console.Write("Input three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = num % 10;
Console.WriteLine($"Lust digit of {num} is {result}");
*/