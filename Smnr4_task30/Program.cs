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
int[] array = GetArrayRandom(8);

void kvadrat(int n)
{
    for (int i = 0; i < array.Length; i = i++)
    {
        if (i !< n)
    }
    
    
    {
        Console.Write($"{temp},");
    }
    else
    {
       Console.Write($"{temp}");
    }
}
