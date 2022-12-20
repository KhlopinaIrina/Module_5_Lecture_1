// Вид 4: Группа методов, которые что-то принимают и что-то возвращают
string Method4(int count, string text) // Возвращать будем стоку, а в качестве аргументов на входе получать число count и строку text
{
    int i = 0;
    string result = String.Empty; // Сначала в result мы кладем пустую сторку (String.Empty)

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "qwerty");
Console.WriteLine(res);