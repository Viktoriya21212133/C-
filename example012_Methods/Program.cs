// Методы

// 1 вид. Метод ничего не принимает, ничего не возвращает
void Method1()
{
    Console.WriteLine ("Author ...");
}

// Вызов метода
Method1 (); // Правильно со скобочками
//Method1; - неправильно без скобочек


// 2 вид. Метод что-то принимает, ничего не возвращает, 1 вариант 
void Method20 (string msg)
{
    Console.WriteLine (msg);
}
// Вызов метода
Method20 (msg: "Message: ");

// 2 вид. Метод что-то принимает, ничего не возвращает, 2 вариант
void Method21 (string msg, int count)
{
    int i = 0;
    while (i<count)
    {
        Console.WriteLine (msg);
        i++;
    }
    Console.WriteLine (msg);
}
// Вызов метода
Method21 (msg: "Message: ", count:4);
Method21 (count: 4, msg: "New message");


// 3 вид. Метод ничего не принимает, что-то возвращает
int Method3 ()
{
    return DateTime.Now.Year;
}

// Вызов метода
int Year = Method3();
Console.WriteLine (Year);

// 4 вид. Самый важный! Метод что-то принимает, что-то возвращает
string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty;

        while (i < count)
        {
            result = result + text;
            i++;
        }
    return result;
}

// Вызов метода
string res = Method4(3, "Message text, ");
Console.WriteLine(res);