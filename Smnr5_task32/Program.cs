// Задача 32. Замена элементов массива : положительные меняем на отрицательные и наооборот.
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

int GetFromUser(string message)
{
    Console.WriteLine(message);
    int userInt = int.Parse(Console.ReadLine());
    return userInt;
}

int[] invertArray(int[] arrayToInvert)
{
    for (int i = 0; i < arrayToInvert.Length; i++)
    {
        arrayToInvert[i] = -arrayToInvert[i];
    }
    return arrayToInvert;

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
int lenght = GetFromUser("введите длину массива");
int[] array = GetArrayRandom(lenght, -100, 100);
showArray(array);
int[] inverted = invertArray(array);
showArray(inverted);