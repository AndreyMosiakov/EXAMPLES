// Задача 37. Найдите произведение пар чисел в одномерном массиве.Парой считать первый и последний элемент, 
// второй и предпоследний и тд. Результат запишите в новом массиве.
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
int newArray(int[] array)
{
    int newLenght = (int)Math.Ceiling(array.Length / 2.0); // метод округления
    int[] arr2 = new int[newLenght];
    for (int i = 0; i < newLenght; i++)
    {
        if (i < newLenght - 1 || array.Length % 2 == 0)
        {
            arr2[i] = array[i] * array[array.Length - i - 1];
        }
        else
        {
            arr2[i] = array[i];
        }
    }
    return arr2;
}

int number = GetFromUser("введите кол-во элементов массива");
int[] array = GetArrayRandom(number, 1, 11);
showArray(array);
int[] array2 = newArray(array);
Console.WriteLine(array2);
