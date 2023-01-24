// Задача 40. Напишите программу , которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой
// длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
Console.Clear();

int getUserDate(string message)  // `функция получения информации от пользователя
{
    Console.WriteLine(message);
    int userDate = int.Parse(Console.ReadLine()!);
    return userDate;
}

bool IsTriangleExist(int a, int b, int c) // тип данных правда или ложь
{
    bool isExist = false;
    if (a < b + c && b < a + c && c < a + b)
    {
        isExist = true;
    }
    return isExist;
}

int a = getUserDate("введите длину стороны a");
int b = getUserDate("введите длину стороны b");
int c = getUserDate("введите длину стороны c");
bool isExist = IsTriangleExist(a, b, c);
Console.WriteLine($" Треугольник со сторонами [{a},{b},{c}] {((isExist) ? "существует" : "не существует")} ");// тернарная функция