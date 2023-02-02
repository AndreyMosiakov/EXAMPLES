// Задайте двумкрный массив, 
// Найдите сумму главной диагонали.
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
            array[i, j] = new Random().Next(start, end + 1);
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
int[,] GetTrasformArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i = i + 2)
    {
        for (int j = 0; j < array.GetLength(1); j = j + 2)
        {
            array[i, j] = (int)Math.Pow(array[i, j], 2);

        }
    }
    return array;
}

int findSumOfDiagonal(int[,] array)
{
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                result = result + array[i, j];
            }

        }
    }
    return result;
}



int n = GetDataFromUser("введите количество строк");
int m = GetDataFromUser("введите количество столбцов");
int[,] array = Get2DIntArray(n, m, 0, 10);
print2DArray(array);

int sumofdig = findSumOfDiagonal(array);
Console.WriteLine($"Сумма элементов главной диагонали равна {sumofdig}");