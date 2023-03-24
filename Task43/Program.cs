// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] Array()
{
    double[] array = new double[2];
    for (int i = 0; i < 2; i++)
    {
        Console.Write($"Введите {i + 1} значение: ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    return array;
}

void Peresechenie(double[] array1, double[] array2)
{
    if (array1[0] == array2[0])
        if (array1[1] == array2[1])
            Console.WriteLine("Прямые совпадают");
        else
            Console.WriteLine("Прямые параллельны");
    else
    {
        double x = (array2[0] - array1[0]) / (array1[1] - array2[1]);
        double y = array1[1] * x + array1[0];
        Console.WriteLine($"Точка пересечения линий ({x};{y})");
    }
}

try
{
    Console.WriteLine("Введите значения для первой прямой");
    double[] first = Array();
    Console.WriteLine("Введите значения для второй прямой");
    double[] second = Array();
    Peresechenie(first, second);
}
catch
{
    Console.WriteLine("Введено некорректное значение");
}

// void Peresechenie(double b1, double k1, double b2, double k2)
// {
//     if (b1 == b2)
//         if (k1 == k2)
//             Console.WriteLine("Прямые совпадают");
//         else
//             Console.WriteLine("Прямые параллельны");
//     else
//     {
//         double x = (b2 - b1) / (k1 - k2);
//         double y = k1 * x + b1;
//         Console.WriteLine($"Точка пересечения линий ({x};{y})");
//     }
// }

// Console.Write("Введите первую точку первой прямой: ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите вторую точку первой прямой: ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите первую точку второй прямой: ");
// double b2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите вторую точку второй прямой: ");
// double k2 = Convert.ToDouble(Console.ReadLine());
// Peresechenie(b1,k1,b2,k2);