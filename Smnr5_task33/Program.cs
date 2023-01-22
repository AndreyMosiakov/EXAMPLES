// Задача 33. Введите массив , напишите программу которая определяет присутствует ли заданное число в массиве.
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
int searchNumber(int[] array, int number)
{
    int result = -1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            result = i;
            break;
        }
    }
    return result;
}
int number = GetFromUser("введите число");
int[] array = GetArrayRandom(15, -10, 10);
showArray(array);
int findnumber = searchNumber(array, number);
if(findnumber==-1)
{
    Console.WriteLine("Число не найдено");
}
else
{
    Console.WriteLine($"Число{number} есть в списке под индексом {findnumber}");
}