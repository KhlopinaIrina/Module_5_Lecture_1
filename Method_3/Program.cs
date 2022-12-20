// Вид 3: Группа методов, которые что-то возвращают, но ничего не принимают
int Method3()
{
    return DateTime.Now.Year;
}

// Вызов метода внутри какой-то программы
int year = Method3();
Console.WriteLine(year);