// Задача 65 Задайте значения M и N . Напишите программу , которая выдаёт все натуральные числа от M до N.
Console.Clear();

int GetDataFromUser(string messege)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(messege);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int userStartNumber = GetDataFromUser("введите значение M");
int userFinishNumber = GetDataFromUser("введите значение N");
string rage = getStrRange(userStartNumber, userFinishNumber);
Console.WriteLine(rage);
string getStrRange ( int start, int finish)
{
   if(start==finish) 
   {
    return start +" ";
   }
   return start +","+ getStrRange(start+1, finish);

}