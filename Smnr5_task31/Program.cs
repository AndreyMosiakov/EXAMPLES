// Задача 31. Задайте массив из 12 элементов от -9 до 9 и найдите сууму отрицательных и положительных элементов

Console.Clear();

int[] GetArrayRandom(int lenght, int strt, int end) // функция ввода рандомного массива
{
    int[] arr = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        arr[i] = new Random().Next(strt, end + 1); // ограничил диапазон случайных чисел
    }
    return arr;
}
int GetSumOfPositive(int[] array)
{
    int sum1 = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum1 += array[i];
        }
    }
    return sum1;
}

int GetSumOfNegative(int[] array)
{
    int sum2 = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sum2 += array[i];
        }
    }
    return sum2;
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


int[] array = GetArrayRandom(12, -9, 9);
showArray(array);
int SumOfPositive=GetSumOfPositive(array);
int SumOfNegative=GetSumOfNegative(array);
Console.WriteLine($"Сумма положительных {SumOfPositive}");
Console.WriteLine($"Сумма отрицательных {SumOfNegative}");