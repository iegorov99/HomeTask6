// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void PositiveCount()
{
    int count = 0;
    Console.Write("Введите число: ");
    try
    {
        for (var num = Console.ReadLine(); num != null;)
        {
            if (Convert.ToInt32(num) > 0) count++;
            Console.Write("Введите число: ");
            num = Console.ReadLine();
        }
    }
    catch
    {
        Console.WriteLine(count);
    }
}

PositiveCount();

// int Enter(string message)
// {
//     Console.Write(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }

// int[] Array(int length)
// {
//     int[] array = new int[length];
//     for (int i = 0; i < length; i++)
//     {
//         Console.Write($"Введите {i+1} значение: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void Positive(int[] array)
// {
//     int count = 0;
//     foreach (int item in array)
//         if (item > 0) count++;
//     Console.WriteLine($"Количество положительных чисел {count}");
// }

// int length = Enter("Введите количество значений: ");
// int[] arr = Array(length);
// Positive(arr);

// int Enter(string message)
// {
//     Console.Write(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }