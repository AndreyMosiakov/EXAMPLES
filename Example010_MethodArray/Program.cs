// Найти элемент массива равный find
Console.Clear();

int[] array = { 1, 4, 4, 5, 66, 78, 34, 55, 4, 3 }; // ввод массива

int n = array.Length; // ввод длины массива

int find = 4; // ввод числа чей элемент массива надо найти

int index = 0; // ввод значения индекс

while (index < n)
{
    if (array[index] == find) // поиск элемента массива равного 4( значению find)
    {
        Console.WriteLine(index);
        break;  // оперетор позволяющий прекратить цикл как только один элемент будет найден    
    }
        index++; // index=index+1
}