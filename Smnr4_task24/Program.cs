// Задача 24,Программа принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
Console.Clear();

int getUserDate(string message)  // `функция получения информации от пользователя
{
    Console.WriteLine(message);
    int userDate = int.Parse(Console.ReadLine()!);
    return userDate;
}

int getSumOfRange(int start, int end)
{
    int sum = 0;
    for (int i = start; i <= end; i++)
    {
        sum += i; // sum=sum+1
    }
    return sum;
}

int end = getUserDate("Введите число "); // запуск функции
int sum = getSumOfRange(1, end);
Console.WriteLine($"Сумма чисел от 1 до {end} = {sum}");
