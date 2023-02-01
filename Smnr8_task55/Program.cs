// Задача 55 , Задайте двумерный массив. Напишите программу , которая заменяет строки на столбцы, если это невозможно ,
// программа выдаёт сообщение.

Console.Clear();

int GetDataFromUser(string messege)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(messege);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int[,] Get2Darray(int rowlenght, int cowlenght, int start, int end)
{
    int[,] array = new int[rowlenght, cowlenght];

    for (int i = 0; i < rowlenght; i++)
    {

        for (int j = 0; j < cowlenght; j++)
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
        //printInColor(i + "\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " \t");
        }
        Console.WriteLine();
    }
}

bool CheckCanRotate(int rows, int cols)
{
    return rows == cols;
}
int[,] swapRowsAndColumns(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
        int tmp = array[i, j];
        array[i, j] = array[j, i];
        array[j, i] = tmp;
        }
    }
    return array;
}


int rows=GetDataFromUser("введите кол-во строк");
int cols=GetDataFromUser("введите кол-во колонок");
bool canContinue = CheckCanRotate(rows,cols);
if(canContinue)
{
  int[,] array = Get2Darray(rows, cols, 0, 50);
  print2DArray(array);
  Console.WriteLine("---------------------------------");
  int[,] rotatedArray =swapRowsAndColumns(array);
  print2DArray(rotatedArray); 
}
else
{
    Console.WriteLine("Для переворота нужны одинаковые значения!");
}

//int[,] swappedArray = swapRows(array, 0, array.GetLength(0) - 1);
//print2DArray(array);