/*  Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0   */

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
        arr[i] = rnd.Next(-100, 100);        
    }
    return arr;
}

//сумма элементов, стоящих на нечётных позициях
int SumNumbers(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + arr[i];
        }
    }
    return sum;
}

int dimension = LengthArray("Задайте колличество элементов в массиве: ");
int[] array = InitArray(dimension);
int sum = SumNumbers(array);

Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"Сумма элеменов, стоящих на нечетных позициях - {sum}");