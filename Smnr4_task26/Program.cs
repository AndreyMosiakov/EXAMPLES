// Задача 26 . Прграмма принимает на вход число и выдаёт кол-во цифр в числе.

Console.Clear();

int getUserDate(string message)  // `функция получения информации от пользователя
{
    Console.WriteLine(message);
    int userDate = int.Parse(Console.ReadLine()!);
    return userDate;
}
int getNumberOfDigit(int number)
{
    int numberOfDigit = 0;
    while (number > 0)
    {
        number = number / 10;
        numberOfDigit++;
    }
    return numberOfDigit;
}
int number = getUserDate("Введите число ");
int numberOfDigit = getNumberOfDigit(number);
Console.WriteLine($"В числе {number} присутствует {numberOfDigit} цифр(ы)");