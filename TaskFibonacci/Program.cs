// Задача НЕГАФИБОНАЧЧИ. Задайте число. Составьте массив чисел НегаФибоначчи, в том числе для отрицательных индексов.
// *Пример:*
// - для k = 9 массив будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]

int[] Fib(int a)
{
    int[] array = new int[a];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < a; i++)
        array[i] = array[i - 1] + array[i - 2];
    return array;
}

void PrintFib(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item} ");
    Console.WriteLine();
}


void PrintReverseFib(int[] array, int num)
{
    for (int i = num - 1; i > 0; i--)
    {
        if (i % 2 == 0)
            array[i] *= (-1);
        Console.Write($"{array[i]} ");
    }
}

try
{
    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    PrintReverseFib(Fib(num), num);
    PrintFib(Fib(num));
}
catch
{
    Console.WriteLine("Введено некорректное число");
}