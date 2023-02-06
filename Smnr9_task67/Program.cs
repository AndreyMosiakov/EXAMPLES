// Задача 67 : Напишите программу , которая будет принимать на вход число и возвращать сумму его чисел.

Console.Clear();

int GetDataFromUser(string messege)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(messege);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
int getSumOfDigit(int number)
{
    if (number == 0)
    {
        return 0;
    }
    return number % 10 + getSumOfDigit(number / 10);// Рекурсия
}

int userNumber = GetDataFromUser("введите число");
int result = getSumOfDigit(userNumber);
Console.WriteLine(result);
