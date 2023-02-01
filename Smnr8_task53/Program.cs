// Задача 53 : Задайте двумерный массив . Напишите программу , которая пменяет местами первую и последнюю строки массива.



int[,] Get2DIntArray(int colLength, int rowLenght, int start, int end)
{
    int[,] array = new int[colLength, rowLenght];

    for (int i = 0; i < colLength; i++)
    {

        for (int j = 0; j < rowLenght; j++)
        {
            array[i, j] = new Random().Next(start, end + 1);
        }
    }
    return array;
}
void printInColor(string data, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(data);
    Console.ResetColor();
}
void printHeadOfArray(int lenght)
{
    Console.Write(" \t");
    for (int i = 0; i < lenght; i++)
    {
        printInColor(i + "\t", ConsoleColor.DarkGreen);
    }
    Console.WriteLine();
}
void print2DArray(int[,] array)
{
    printHeadOfArray(array.GetLength(1));
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printInColor(i + "\t", ConsoleColor.Cyan);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t"); // знак табуляции , что бы всё выстроилось с правильными отступами
        }
        Console.WriteLine();
    }

}
int[,] swapRows(int[,] array, int row1, int row2)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int tmp = array[row1, i];
        array[row1, i] = array[row2, i];
        array[row2, i] = tmp;
    }
    return array;
}

Console.Clear();
int[,] array = Get2DIntArray(5, 5, -5, 5);
print2DArray(array);
int[,] swappedArray = swapRows(array, 0, array.GetLength(0) - 1);
print2DArray(array);