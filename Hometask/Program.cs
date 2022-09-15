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

