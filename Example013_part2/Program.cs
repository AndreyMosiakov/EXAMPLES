// Закрашивание картинки
Console.Clear();

int[,] pic = new int[,]
{
    
    {0, 1, 1, 1, 1, 1, 1, 0 },
    {0, 1, 0, 0, 0, 0, 1, 0 },
    {0, 1, 0, 0, 0, 0, 1, 0 },
    {0, 1, 0, 0, 0, 0, 1, 0 },
    {0, 1, 0, 0, 0, 0, 1, 0 },
    {0, 1, 1, 1, 1, 1, 1, 0 },
    
};

void PrintImage(int[,] image)  // печать вывод массива через функцию
{

    for (int i = 0; i < image.GetLength(0); i++) // длина массива , строки 
    {
        for (int j = 0; j < image.GetLength(0); j++) // длина массива , столбцы
        {
            // Console.Write($"{image[i, j]} ");
            if (image[i, j] == 0) Console.Write($" ");
            else Console.WriteLine($"+");
        }
        Console.WriteLine();
    }

}
void FillImage(int row, int col) // метод закрашивания 
{
    if (pic[row, col] == 0)
    {
        pic[row, col] = 0;
        FillImage(row - 0, col);
        FillImage(row , col-0);
        FillImage(row + 0, col);
        FillImage(row , col+0);
    }
}


PrintImage(pic);
FillImage(5,5);
PrintImage(pic);
