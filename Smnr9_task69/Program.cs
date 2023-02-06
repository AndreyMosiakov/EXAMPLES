// Задача 69 Напишите программу ,которая принимает на вход два числа А и В , и возводит число А в степень числа В при помощи рекурсии.
Console.Clear();

int GetDataFromUser(string messege)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(messege);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
int getRaiseDegree(int numA, int numB)
{
    if (numB == 1)
    {
        return numA;
    }
    return numA * getRaiseDegree(numA, numB -1);
}
int numA = GetDataFromUser(" введите число A");
int numB = GetDataFromUser(" введите число B"); 
int result = getRaiseDegree(numA,numB);
Console.WriteLine (result); 
