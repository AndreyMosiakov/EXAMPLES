// Программа принимает на вход одно число (N), на выходе показывает все целые числа от -N до N
Console.Clear();
Console.WriteLine("Введите число");
int numberN = int.Parse(Console.ReadLine()!);
int numberC = -numberN;
while(numberC <= numberN)
{
    Console.Write(numberC+ ",");
    numberC++; 
}