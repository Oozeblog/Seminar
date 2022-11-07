// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
int FindSum(int number)
{
    int sum = 0;
    for (int current = 1; current <= number; current++)
    {
        //sum = sum + current;
        sum += current;
    }
    return sum;
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма чисел от 1 до {a} равна {FindSum(a)}");
*/
//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
int HMDigits(int num)
{
    int digits = 0;
    while(num != 0)
    {
        digits++;
        num = num / 10;
    }
    return digits;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"В этом числе {HMDigits(num)} цифр");
*/
//Написать программу, которая определит произведение чисел от 1 до N

int FindProduct(int number)
{
    int product = 1;
    for (int current = 1; current <= number; current++)
    {
        product = product * current;
    }
    return product;
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Произведение чисел от 1 до {a} равно {FindProduct(a)}");