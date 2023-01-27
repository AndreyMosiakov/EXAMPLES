// Задача 46: Задайте двумерный массив размерм M*N ,заполненый случайными цифрами.

Console.Clear();

int GetDataFromUser(string messege)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(messege);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine());
    return result;
}
void printInColor(string data)
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.Write(data);
    Console.ResetColor();
}

double[,] Get2DDoubleArray(int colLength, int rowLenght, int start, int end)
{
    double[,] array = new double[colLength, rowLenght];
    int divider = 100; // const переменная которую больше нельзя изменить
    for (int i = 0; i < colLength; i++)
    {
        
        for (int j = 0; j < rowLenght; j++)
        {
            array[i, j] = new Random().Next(start * divider, end + 1 * divider) / (divider + 0.0);// конструкция перевода в дабл
        }
    }
    return array;
}
void print2DArray(double[,] array)
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
double[,] array = Get2DDoubleArray(n, m, 0, 1000);
print2DArray(array);
