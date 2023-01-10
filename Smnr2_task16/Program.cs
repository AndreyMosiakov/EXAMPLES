// Напишите программу , которая принимает на вход два числа и проверяет является ли одно число квадратом другого

Console.Clear();

Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine()!);

if (num1 == num2*num2)
{
    Console.WriteLine($"первое число {num1} является квадратом второго {num2}");
}
else if (num2 == num1*num1)
{
    Console.WriteLine($"второе число {num2} является квадратом первого {num1}");
}
else
{
    Console.WriteLine("введеные числа не отвечают условиям задачи");
}