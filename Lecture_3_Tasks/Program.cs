// Подправили пример метода 4 с циклом for
string Method4(int count, string text) // Возвращать будем стоку, а в качестве аргументов на входе получать число count и строку text
{
    string result = String.Empty; // Сначала в result мы кладем пустую сторку (String.Empty)

    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "qwerty");
Console.WriteLine(res);

// Пример конструкции "цикл в цикле". Вывод таблицы умножения на экран
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine(); // Пустая строка для разрыва столбцов
}

// Задание отсортировать массив "от меньшего к большему"
int[] arr = {1, 5, 4, 7, 2, 3, 6, 1, 2};
// Решаем подзадачу вывода массива на экран
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// Пишем метод для сортровки массива
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition])
            {
                minPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}


PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);