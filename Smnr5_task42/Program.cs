// Задача 42. Напишите программу , которая переводит десятичное число в двоичное.
// 45 ->101101
// 3->11
// 2->10

Console.Clear();

int GetFromUser(string message)
{
    Console.WriteLine(message);
    int userInt = int.Parse(Console.ReadLine()!);
    return userInt;
}
string GetBinaryNumber(int number)
{
    string result = string.Empty;
    while (number > 0)
    {
        result = number % 2 + result; // деление на два с остатком (если есть остаток то это 1 нет это два)
        number = number / 2;
    }
    return result;

}

int number = GetFromUser("введите число");
string binary = GetBinaryNumber(number);
Console.WriteLine($" Число {number} в двоичной системе = {binary} ");
