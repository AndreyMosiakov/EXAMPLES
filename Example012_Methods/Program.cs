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

void Method21(string msg, int count) // принимает данные(несколько аргументов)на вход но ничего не возвращает 
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
//string Method4 (int count, string text)
//{
//  int i = 0; // цикл
//string result = string.Empty;

//while (i<count)
//{
//    result = result + text;
//    i++;
//} 
//return result;
//}
//  string resu = Method4(10, "какой то текст ");
//    Console.WriteLine(resu);

//Пример с циклом FOR  

string Method4(int count, string text)
{
    string result = string.Empty;

    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
//string resu = Method4(10, "Z ");
//Console.WriteLine(resu);


// пример цикла в цикле с приминением FOR для создания таблицы умножения

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        //       Console.WriteLine($"{i} * {j} = {i*j}"); // интерпаляция строк
    }
    //   Console.WriteLine("------------");
}

// Работа с текстом
// Дан текст.Нужно заменить все пробелы черточками,
// маленькие буквы к на большие К, а большие С заменить на маленькие с

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля.";

// string s = "qwerty"  
//             0123   ----  позиция символа
// s[3]     --обращение к символу 

string Replace(string text, char oldValue, char newValue) // метод и аргументы
{
    string result = String.Empty; // инициализация пустой строки

    int lenght = text.Length; // ввод длины строки
    for (int i = 0; i < lenght; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

        return result;
}

string newText = Replace(text, ' ', '|'); // замена в тексте

Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к','К');  // замена в тексте
Console.WriteLine(newText);