// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
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

void ReverseArray(int[] array)
{
    for (int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

Console.Write("Введите колличество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);
Console.Write("Исходный массив: ");
ShowArray(myArray);
ReverseArray(myArray);
Console.Write("Развёрнутый массив: ");
ShowArray(myArray);
*/

// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
/*
bool Triangle(int a, int b, int c)
{
    if((a + b > c) && (a + c > b) && (c + b > a)) 
    return true;
    else return false;
}

Console.WriteLine("Введите длину первой стороны треугольника:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину второй стороны треугольника:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину третьей стороны треугольника:");
int c = Convert.ToInt32(Console.ReadLine());

bool res = Triangle(a, b, c);
Console.Write("Может ли существовать треугольник с сторонами такой длины? - ");
Console.WriteLine(res);
*/

//Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
/*
int[] Fib( int n, int a, int b)
{
    int[] array = new int[n];
    array[0] = a;
    array[1] = b;
    for(int i = 2; i < n; i++)
        array[i] = array[i-1] + array[i-2];
    return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine(" ");
}

Console.WriteLine("Введите первое число Фибоначчи: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число Фибоначчи: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Последовательность из скольки чисел Фибоначчи вывести на экран?: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] myArray = Fib(n, a, b);
Console.Write("Получившаяся последовательность чисел Фибоначчи: ");
ShowArray(myArray);
*/

//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
/*
int[] CreateRandomArray (int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue+1);
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine(" ");
}

int[] CopyArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for(int i = 0; i< array.Length; i++)
    {
        newArray[i] = array[i];
    }
return newArray;
}

Console.WriteLine("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента массива:");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента массива:");
int min = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);
Console.Write("Исходный массив: ");
ShowArray(myArray);
int[] array2 = CopyArray(myArray);
Console.Write("Копия заданного массива: ");
ShowArray(array2);
*/




