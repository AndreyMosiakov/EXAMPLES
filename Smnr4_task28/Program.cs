// Программа принимающая на вход число Т и выдаёт произведение чисел от 1 до N
Console.Clear();

int getUserDate(string message)  // `функция получения информации от пользователя
{
    Console.WriteLine(message);
    int userDate = int.Parse(Console.ReadLine()!);
    return userDate;
}

int getMultOfRange(int start, int end)
{
    int mult = 1;
    for (int i = start; i <= end; i++)
    {
        mult = mult * i  ; // mult=sum+1
    }
    return mult;
}

int number = getUserDate("Введите число ");
int result = getMultOfRange (1, number);
Console.WriteLine(result);