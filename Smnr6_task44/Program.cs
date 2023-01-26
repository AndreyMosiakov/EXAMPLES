// Задача 44. Введите первые N чисел Фибонначи . Первые два числа это 0 и 1.
// Число Фибонначи = каждое следуещее это сумма двух предыдущих.
Console.Clear();

int GetFromUser(string message)
{
    Console.WriteLine(message);
    int userInt = int.Parse(Console.ReadLine()!);
    return userInt;
}

string Fibbonachi(int number)
{

    int n1=0;
    int n2=1;
    string result =$"{n1}{n2}";
    if (number==1)
    {
       result =$"{n1}";
    }
     if (number==2)
     {
        result =$"{n1}{n2}";
     }
     else
     {
        for (int i = 2; i < number; i++)
        {
            int n =n1+n2;
            result=result+n;
            n1=n2;
            n2=n;
        }
     }
     return result;

}
 int number = GetFromUser("n");
 string result = Fibbonachi(number);
 Console.WriteLine(result);
