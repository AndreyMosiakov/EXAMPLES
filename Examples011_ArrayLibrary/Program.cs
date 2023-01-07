// Поиск элемента массива равному определнному значению используя методы
Console.Clear();
void FillArray(int[] collection)   // метод заполнения массива рандомными значениями
{
    int lenght = collection.Length; // ввод и определение длины массива
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10); // задаем рандомное число в диапазоне от 1 до 10
        index++;
    }
}

void PrintArray(int[] col)  // метод вывода значений массива 

{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find) // метод поиска элемента массива
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while(index<count)
    {
        if (collection[index] == find)
        {
            position = index;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; //ввод массива , new int[10]-создай новый массив длиной 10 элементов

FillArray(array); // заполняем массив array - вызов методов
PrintArray(array); // печатаем значения массива
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);