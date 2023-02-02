// Задача 57 .Составить частотный словарь элементов двумерного массива. Информация о том сколько раз в массиве встречается
// элемент входных данных.
Console.Clear();

//int GetDataFromUser(string messege)
//{
 //   Console.ForegroundColor = ConsoleColor.DarkGreen;
 //   Console.WriteLine(messege);
  //  Console.ResetColor();
 //   int result = int.Parse(Console.ReadLine()!);
 //   return result;
//}

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
int[] getFreqDict(int [,] array, int maxNumber)
{
    int[] result = new int[maxNumber];
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[array[i,j]] +=1;
        }
    }
    return result;
}
void printFreqDict(int[] freqDict)
{
    for (int i = 0; i < freqDict.Length; i++)
    {
        if(freqDict[i]>0)
        {
        Console.WriteLine($"{i} встречается {freqDict[i]} раза");
        }
    }
}

int [,] array = Get2Darray(5,5,0,20);
print2DArray(array);
Console.WriteLine("--------------------------------");
int[] freqDict = getFreqDict(array,21);
printFreqDict(freqDict);