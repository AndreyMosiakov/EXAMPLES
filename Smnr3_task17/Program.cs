// Программа принимает на вход координаты  X Y ( не равны 0) и выдаёт номер четверти плоскости в которой наход. точка.


int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
int getQuarterNumber(int x, int y)
{
    int quarter = 0;
    if (x > 0 && y > 0)
    {
        quarter = 1;
    }
    else if (x < 0 && y > 0)
    {
        quarter = 2;
    }
    if (x < 0 && y < 0)
    {
        quarter = 3;
    }
    if (x > 0 && y < 0)
    {
        quarter = 4;
    }
    return quarter;
}
int userX = getUserValue("Введите X");
int userY = getUserValue("Введите Y");
int quarter = getQuarterNumber(userX, userY);
if (quarter > 0)
{
    Console.WriteLine($"Точка [{userX},{userY}] находятся в {quarter} четверти");
}
else
{
    Console.WriteLine($"Точка [{userX},{userY} находится на оси координат]");
}