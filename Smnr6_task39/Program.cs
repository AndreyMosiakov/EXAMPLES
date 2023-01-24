// Задача 39 . Программа переворачивающая массив( последний элемент на первом месте и наооборот)
Console.Clear();

int[] GetArrayRandom(int lenght, int deviation) // функция ввода рандомного массива
{
    int[] array = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(-deviation, deviation + 1);
    }
    return array;
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
int[] reversArray(int[] array)
{
    int fullLenght = array.Length;
    int lenght = array.Length / 2;
    for (int i = 0; i < lenght; i++)
    {
        int buf = array[i];
        array[i] = array[fullLenght - i - 1];
        array[fullLenght - i - 1] = buf;
    }
    return array;
}

int[] array = GetArrayRandom(11, 20);
showArray(array);
int[] reversed = reversArray(array);
showArray(reversed);