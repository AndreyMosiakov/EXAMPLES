// Напишите программу , которая выводит случайное число из отрезка[10, 99] и показывает наибольшую цифру числа.
Console.Clear();

int GetNumberFromRange(int start, int end)
{
    int number = new Random().Next(start, end + 1);
    return number;
}
int GetMaxDigit(int number)
{
    int max = number % 10;
    int digit2 = number / 10;
    
    if (digit2 > max)
    {
      max = digit2; 
    }
    return max;
}

int randomNumber = GetNumberFromRange(10, 99);
int maxDigit = GetMaxDigit(randomNumber);
Console.WriteLine(randomNumber);
Console.WriteLine(maxDigit);