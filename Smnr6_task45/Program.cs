// Напишите программу которая будет создавать копию задааного массива с помощью полементного копирования .
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

int[] GetCopyArray(int[] array)
{
    int[] copyarray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copyarray[i] = array[i];
    }
    return copyarray;
}

int[] array = GetArrayRandom(10, -10, 10);
showArray(array);
int[] copyarray=GetCopyArray(array);
showArray(copyarray);