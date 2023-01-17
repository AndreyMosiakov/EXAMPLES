// Программа , которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

Console.Clear();

int[] GetArrayRandom ( int lenght) // функция ввода рандомного массива
{
    int[] arr = new int [lenght];
    for(int i =0; i<lenght; i++)
    {
        arr[i]= new Random().Next(0,2);
    }
    return arr;
}

void showArray(int[] array)  // функция для вывода массива ,, сто бы после последнего символа не было запятой
{
    Console.Write($"[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length -1) // !=  -оператор не равно
        {
        Console.Write($"{array[i]},");
        }
        else
        {
        Console.Write($"{array[i]}]");
        }
    }
}
int[] array = GetArrayRandom(8);
showArray(array);
