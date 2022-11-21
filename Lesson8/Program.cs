// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива 
// две любые строки массива, которые укажет пользователь).
/*
int [,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void ChangeRows(int[,] array, int row1, int row2)
{
    if(row1 >= 0 && row1 < array.GetLength(0) && 
       row2 >= 0 && row2 < array.GetLength(0) &&
       row1!=row2)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1, j];
            array[row1, j] = array[row2, j];
            array[row2, j] = temp;
        }
    }
    else Console.WriteLine("Incorrect rows for changing");
}

Console.Write("Введите колличество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Console.WriteLine("Исходный массив: ");
Show2dArray(myArray);

Console.Write("Введите индекс первой строки для замены: ");
int r1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс второй строки для замены: ");
int r2 = Convert.ToInt32(Console.ReadLine());

ChangeRows(myArray, r1, r2);
Show2dArray(myArray);
*/
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

/*
int [,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void ReplaceArray(int[,] array)
{
    if(array.GetLength(0) == array.GetLength(1))
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i+1; j < array.GetLength(1); j++)
        {
            int temp = array[i, j];
            array[i, j] = array[j,i];
            array[j, i] = temp;
        }
    }
    else Console.WriteLine("Ошибка");
}

Console.Write("Введите колличество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Console.WriteLine("Исходный массив: ");
Show2dArray(myArray);
Console.WriteLine();

ReplaceArray(myArray);
Show2dArray(myArray);
*/
// Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.


int [,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,]DeleteElement(int[,] array)
{
    int min = array[0,0];
    int posI = 0;
    int posY = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(min>array[i, j])
            {
                min = array[i, j];
                posI = i;
                posY = j;
            }
        }
    }

    int [,] arr1 = new int [array.GetLength(0) - 1, array.GetLength(1) - 1];
    //int x = 0, y = 0;

    for (int i = 0, x = 0; i < array.GetLength(0); i++, x++)
    {
        if(i != posI)
        {
            for (int j = 0, y = 0; j < array.GetLength(1); j++, y++)
            {
                if(j != posY)
                {
                    arr1[x, y] = array[i, j];
                }
                else y--;
            }
        }
        else x--;
    }
    return arr1;
}

Console.Write("Введите колличество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Console.WriteLine("Исходный массив: ");
Show2dArray(myArray);
Console.WriteLine();

int [,] newArr = DeleteElement(myArray);
Show2dArray(newArr);