// Программа показывающая по заданному номеру четверти диапазон возможных координат точек.

Console.Clear();

int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
string getRangeFromQuarter(int quarter)
{
    string result = $"Диапазон значений в {quarter} четверти";
    switch (quarter) // конструкция if else
    {
        case 1:
            {
                result += " x>0 и y>0";// + перед равно добавит текст к шаблону из метода
                break;
            }
        case 2:
            {
                result += " x<0 и y>0";
                break;
            }
        case 3:
            {
                result += " x<0 и y<0";
                break;
            }
        case 4:
            {
                result += " x>0 и y<0";
                break;
            }
        default:
            {
                result = $" Такой четверти не существует";
                break;
            }
    }
    return result;

}

int quarter = getUserValue("Введите номер четверти");
string RangeDescription = getRangeFromQuarter(quarter);
Console.WriteLine(RangeDescription);
