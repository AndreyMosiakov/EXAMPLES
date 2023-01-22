// Задача 35. Задайте одномерный массив из 123 элементов, найдите кол-во элементов массива в отрезке[10,99].
Console.Clear();

int[] GetArrayRandom(int lenght, int strt, int end) // функция ввода рандомного массива
{
    int[] arr = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        arr[i] = new Random().Next(strt, end + 1);
    }
    return arr;
}
int GetFromUser(string message)
{
    Console.WriteLine(message);
    int userInt = int.Parse(Console.ReadLine()!);
    return userInt;
}

void showArray(int[] array)  // функция для вывода массива , что бы после последнего символа не было запятой
{
    Console.Write($"[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) // !=  -оператор не равно
        {
            Console.Write($"{array[i]},");
        }
        else
        {
            Console.WriteLine($"{array[i]}]");
        }
    }
}
int FindOfCount(int[] array, int strt, int end)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= strt && array[i] <= end)
        {
            count += 1;
        }
    }
    return count;
}

int[] array = GetArrayRandom(20, -100, 100);
showArray(array);
int strt = GetFromUser("введите начальное число диапазона");
int end = GetFromUser("введите конечное число диапазона");
int count = FindOfCount(array, strt, end);
Console.WriteLine($" Кол-во элементов массива в диапазоне от {strt} до {end} равно {count}.");