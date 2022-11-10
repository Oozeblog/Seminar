// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; // инициализация массива
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int FindNegativSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

Console.WriteLine("Введите колличество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите манимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);
int negativSum = FindNegativSum(myArray);
Console.WriteLine($"Сумма отрицательных элементов массива равна {negativSum}");
*/

// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; // инициализация массива
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

bool FindDigit (int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == num)
        {
            return true;
        }
    }
    return false;
}
Console.WriteLine("Введите колличество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите манимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число которое нужно найти: ");
int a = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);
bool res = FindDigit(myArray, a);
Console.WriteLine($"В массиве присутствует число {a} - {res}");
*/

// Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b].
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; // инициализация массива
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int HowManyElements (int[] array, int a, int b)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if (array [i] >= a && array [i] <= b)
            count++;
    return count;
}

Console.WriteLine("Введите колличество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный порог диапазона значений массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный порог диапазона значений массива: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите начало отрезка для поиска: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конец отрезка для поиска: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);

int res = HowManyElements(myArray, a, b);
Console.WriteLine($"В отрезке между {a} и {b} лежит {res} элементов");
*/

// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; // инициализация массива
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] InversionArray( int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
    return array;
}

Console.WriteLine("Введите колличество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный порог диапазона значений массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный порог диапазона значений массива: ");
int max = Convert.ToInt32(Console.ReadLine());


int[] myArray = CreateRandomArray(n, min, max);
Console.Write("Исходный массив: ");
ShowArray(myArray);

Console.Write("Массив с противоположными значениями: ");
InversionArray(myArray);
ShowArray(myArray);
*/
