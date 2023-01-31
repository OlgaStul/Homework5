/*  Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

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
int[] InitArray(int dimension)
{
    int[] arr = new int[dimension];
    Random rnd = new Random();
    for (int i = 0; i < dimension; i++)
    {
        arr[i] = rnd.Next(100, 1000);        
    }
    return arr;
}

//количество четных чисел в массиве
int NumberOfEvenNumbers(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            sum = sum + 1;
        }
    }
    return sum;
}

int dimension = LengthArray("Задайте колличество элементов в массиве: ");
int[] array = InitArray(dimension);
int evenNumber = NumberOfEvenNumbers(array);

Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"Колличество четных элеменов в массиве - {evenNumber}");
