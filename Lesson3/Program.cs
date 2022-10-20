// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
/*
void ShowRange(int quart)
{
    if(quart == 1)
    
        Console.WriteLine("x > 0, y > 0");
    
    else if(quart == 2)
    
        Console.WriteLine("x < 0, y > 0");
    
    else if(quart == 3)
    
        Console.WriteLine("x < 0, y < 0");
    
    else if(quart == 4)
    
        Console.WriteLine("x > 0, y < 0");
    
    else
    
        Console.WriteLine("Wrong number!");
    
}

Console.WriteLine("Ведите номер четверти: ");
int num = Convert.ToInt32(Console.ReadLine());
ShowRange(num);
*/

// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
int ShowQuart(int x, int y)
{
    int quart;
    if(x > 0 && y > 0)
        quart = 1;
    else if(x < 0 && y > 0)
        quart = 2;
    else if(x < 0 && y < 0)
        quart = 3;
    else if(x > 0 && y < 0)
        quart = 4;
    else
        quart = -1;
    return quart;
    
}

Console.WriteLine("Введите координы точки по оси х: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координы точки по оси y: ");
int y = Convert.ToInt32(Console.ReadLine());
int res = ShowQuart(x, y);

Console.WriteLine($"Точка находится в {res} четверти.");
*/




// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
/*
double Distance(double x1, double y1, double x2, double y2)
{
    double x = x2 - x1;
    double y = y2 - y1;
    double dist = Math.Sqrt(x*x + y*y);
    return dist;
}

Console.WriteLine("Введите координаты первой точки по оси х: ");
double x= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты первой точки по оси y: ");
double y= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки по оси х: ");
double x2= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки по оси y: ");
double y2= Convert.ToInt32(Console.ReadLine());

double res = Distance(x, y, x2, y2);
Console.WriteLine($"Расстояние между точками {res}");
*/
// Напишите программу, которая принимает на вход число (N) и выводит квадраты чисел от 1 до N.

void Square(int n)
{
    int index = 1;
    while(index <= n)
    {
        Console.Write(index*index + " ");
        index++;
    }
}
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Square(n);