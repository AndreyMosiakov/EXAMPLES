// Напишите программу , которая принимает на вход два числа и проверяет является ли первое число квадратом второго.

Console.Clear();
Console.WriteLine("Введите первое число:");
int firstnumber = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число:");
int secondnumber = int.Parse(Console.ReadLine()!);

if (firstnumber == secondnumber * secondnumber)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}