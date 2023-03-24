// задача 40 - HARD необязательная. На вход программы подаются три целых положительных числа. Определить , является ли это сторонами треугольника. 
// Если да, то вывести всю информацию по нему - площадь, периметр, значения углов треугольника в градусах, является ли он прямоугольным, равнобедренным, равносторонним.

bool Triangle(double a, double b, double c)
{
    if (a < b + c && b < a + c && c < a + b)
    {
        Console.WriteLine("Треугольник с такими сторонами существует");
        return true;
    }
    else
        return false;
}

double Perimeter(double a, double b, double c)
{
    return a + b + c;
}

double Square(double a, double b, double c)
{
    double per = Perimeter(a, b, c);
    double square = Math.Sqrt(per * (per - a) * (per - b) * (per - c));
    return Math.Round(square, 2);
}

void Corners(double a, double b, double c)
{
    double A = Math.Acos((a * a + c * c - b * b) / (2 * a * c)) * 180 / Math.PI;
    double B = Math.Acos((a * a + b * b - c * c) / (2 * a * b)) * 180 / Math.PI;
    double C = Math.Acos((b * b + c * c - a * a) / (2 * c * b)) * 180 / Math.PI;
    Console.Write($"Угол альфа равен {Math.Round(A, 2)} градусов, угол бетта равен {Math.Round(B, 2)} градусов, угол гамма равен {Math.Round(C, 2)} градусов");
    Console.WriteLine();
    if (A == 90 || B == 90 || C == 90)
        Console.WriteLine("Это прямоугольный треугольник");
    else if (a == b && a == c)
        Console.WriteLine("Это равносторонний треугольник");
    else if (a == b || a == c || c == b)
        Console.WriteLine("Это равнобедренный треугольник");
}

try
{
Console.Write("Введите первое число: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите третье число: ");
double c = Convert.ToDouble(Console.ReadLine());
if (Triangle(a, b, c))
{
    Console.WriteLine($"Площадь треугольника равна {Square(a, b, c)}");
    Console.WriteLine($"Периметр треугольника равен {Perimeter(a, b, c)}");
    Corners(a, b, c);
}
else Console.WriteLine("Треугольник с такими сторонами не существует");
}
catch
{
    Console.WriteLine("Введено некорректное значение");
}