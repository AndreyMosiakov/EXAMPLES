// задача 48. задайте двумерный массив размера m  на n, каждый элемент находится по формуле Amn = m+n
// выведите полученный массив на экран.
Console.Clear();

int GetDataFromUser(string messege)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(messege);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
void printInColor(string data)
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.Write(data);
    Console.ResetColor();
}

int[,] Get2DIntArray(int colLength, int rowLenght, int start, int end)
{
    int[,] array = new int[colLength, rowLenght];
    
    for (int i = 0; i < colLength; i++)
    {

        for (int j = 0; j < rowLenght; j++)
        {
            array[i, j] = i+j;
        }
    }
    return array;
}
void print2DArray(int[,] array)
{   
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printInColor(i + "\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t"); // знак табуляции , что бы всё выстроилось с правильными отступами
        }
        Console.WriteLine();
    }

}
int n = GetDataFromUser("введите количество строк");
int m = GetDataFromUser("введите количество столбцов");
int[,] array = Get2DIntArray(n, m, 0, 1000);
print2DArray(array);

