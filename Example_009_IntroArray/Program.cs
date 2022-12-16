int [] array = {11, 21, 13, 14, 15, 18, 61, 17, 18};

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{

    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index + 1;
    index++;
}