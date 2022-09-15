// Метод выбора значений массива длинной менее или равной 3
string[] StrSelect(string[] array, int arg)
{
    string[] newarr = new string[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= arg)
        {
            newarr[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref newarr, count);
    return newarr;
}
//Для вывода массивов как в Примере создал 2 версии метода печати массивов
//В первом продемонстрирована рекурсия
void PrintFirstArr(string[] arr, int i = 0)
{
    if (arr.Length > 0)
    {
        if(i == 0) System.Console.Write($"[");
        if (i < arr.Length - 1) 
        {
            System.Console.Write($"{arr[i]}, ");
            PrintFirstArr(arr, i + 1);
        }
        else System.Console.Write($"{arr[arr.Length - 1]}] -> ");
    }
    else System.Console.WriteLine($"[]");
}
void PrintOnlyArr(string[] arr)
{
    if (arr.Length > 0)
    {
        System.Console.Write($"[");
        for (int i = 0; i < arr.Length - 1; i++)
        {
            System.Console.Write($"{arr[i]}, ");
        }
        System.Console.WriteLine($"{arr[arr.Length - 1]}]");
    }
    else System.Console.WriteLine($"[]");
}

string[] array = new string[] {"1234", "1567", "-2", "computer science"};
int num = 3;
string[] wanted = StrSelect(array, num);

PrintFirstArr(array);
PrintOnlyArr(wanted);


