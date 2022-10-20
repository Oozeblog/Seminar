//Напишите программу, которая выводит слечайное трехзначное число и удаляет вторую цифру этого числа 346 -> 36

// Шаг 1. Прописываем метод:
/*
int CutNumber(int number)
{
    int ed = number % 10;
    int sot = number / 100;
    number = sot * 10 + ed;
    return number;
}
// Шаг 2. Пишем программу, вызывая вышенаписанный метод:
int num = new Random().Next(100, 1000);
int result = CutNumber(num);
Console.WriteLine($"Если удалить вторую цифру из числа {num}, получится число {result}");
*/

//Напишите программу, которая выводит случайное число из отрезка от 10 до 99 и показывает наибольшую цифру числа.
/*
int MaxNum(int max)
{
    int ed = max % 10;
    int des = max / 10 - ed;
    if(ed > des)
    {
        max = ed;
    }
    else
    {
        max = des;
    }
    return max;
}

int num = new Random().Next(10, 100);
int result = MaxNum(num);
Console.WriteLine($"Наибольшая цифра числа {num} - это цифра {result}");
*/
//Напишите программу которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
/*
bool Square (int a, int b)
{
    if (a==b*b || b==a*a)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.WriteLine("Введите первую цифру ");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую цифру ");
int second = Convert.ToInt32(Console.ReadLine());

bool result = Square(first, second);
Console.Write("Одно из этих чисел я вляется квадратом второго - ");
Console.WriteLine(result);
*/

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
/*
bool Multiplicity(int num1, int num2)
{
    if(num2 % num1 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.WriteLine("Введите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int second = Convert.ToInt32(Console.ReadLine());

bool result = Multiplicity(first, second);
Console.Write("Второе числе кратно первому - ");
Console.WriteLine(result);
*/
