/*  Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
[3 7 22 2 78] -> 76   */

//узнаем длину массива от пользователя, переводим в число
int LengthArray(string message)
{
    int dimension = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out dimension)) break;
        else Console.WriteLine("Ввели не корректное число, повторите ввод: ");
    }
    return Math.Abs(dimension);
}

//инициализируем массив                    
double[] InitArray(int dimension)
{
    double[] arr = new double[dimension];
    Random rnd = new Random();
    double num = rnd.NextDouble() * 200 - 100;
    for (int i = 0; i < dimension; i++)
    {
        arr[i] = rnd.NextDouble();
        arr[i] = Math.Round(arr[i], 2);
    }
    return (arr);
}

// нахождение максимального и минимального элемента
(double, double) MaxMinNumbers(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];
        if (arr[i] < min)
            min = arr[i];
    }
    return (max, min);
}

int dimension = LengthArray("Задайте колличество элементов в массиве: ");
double[] array = InitArray(dimension);
(double max, double min) = MaxMinNumbers(array);

Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"Разница между максимальным элементом ({max}) и минимальным элементом ({min}) в массиве равна {max - min}");
