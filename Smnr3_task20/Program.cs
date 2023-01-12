// Программа принимает на вход две точки и находит расстояние между ними в 2D пространстве

Console.Clear();

int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
double getDistanceCoordinate(int userAx, int userAy, int userBx, int userBy)
{
    double result = Math.Sqrt(Math.Pow((userAx - userBx), 2) + Math.Pow((userAy - userBy), 2));  // формула вычисления
    return result;
}

int userAx = getUserValue("Введите X");
int userAy = getUserValue("Введите Y");

int userBx = getUserValue("Введите X");
int userBy = getUserValue("Введите Y");

double distance = getDistanceCoordinate (userAx, userAy,  userBx, userBy);
Console.WriteLine($"Расстояние между точками {distance}");