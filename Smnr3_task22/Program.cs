// Программа принимает на вход число (N) и выдаёт таблицу квадратов чисел.

Console.Clear();

Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()!);
int num1 = 1;

while (num1 <= num)
{
    Console.Write(Math.Pow(num1, 2) + ","); // функция введения в степень
    num1 = num1 + 1;
}

// вариант решения через функцию

Console.Clear();

int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
void kvadrat(int n)
{
    for (int i = 1; i < n + 1; i = i + 1)
 //   int temp = i*i;
    if (i < n)
    {
  //      Console.Write($"{temp},");
    }
    else
    {
   //     Console.Write($"{temp}");
    }
}
//int n = getUserValue("Введите n");
//kvadrat(n);







