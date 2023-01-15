// Виды методов, вид 1
void Method1() // ничего не возвращает 
{
    Console.WriteLine("Автор...");
}
// Method1(); // вызов метода


// вид 2
void Method2(string msg) // принимает данные на вход но ничего не возвращает 
{
    Console.WriteLine(msg);
}
// Method2(msg:"Текст сообщения"); // вызов метода

void Method21(string msg , int count) // принимает данные(несколько аргументов)на вход но ничего не возвращает 
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21(msg: "Текст", count: 4);

// Вид 3 , Методы возвращают значение, но ничего не принимают

int Method3()
{
    return DateTime.Now.Year; // возврат значения
}

int year = Method3();  // вызов метода
// Console.WriteLine(year);

// Вид 4 , Методы принимающие данные и возвращающие значения
string Method4 (int count, string text)
{
    int i = 0; // цикл
    string result = string.Empty;

    while (i<count)
    {
        result = result + text;
        i++;
    } 
    return result;
}
    string resu = Method4(10, "какой то текст ");
    Console.WriteLine(resu);




