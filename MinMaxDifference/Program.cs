// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
//[3 7 22 2 78] -> 76
float[] CreateArray(int length)
{
    return new float[length];
}

string FillArray(float[] array)
{
    string st = "";
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 100);
        st += array[i] + " ";
    }
    return st;
}

string MinMaxDifference(float[] array)
{
    string st = "";
    int length = array.Length;
    int pos_min = 0;
    int pos_max = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i] > array[pos_max]) pos_max = i;
        if (array[i] < array[pos_min]) pos_min = i;
    }
    float difference = array[pos_max] - array[pos_min];
    st += difference;
    return st;
}


float[] arr = CreateArray(20);
string s = FillArray(arr);
Console.WriteLine(s);
string str = MinMaxDifference(arr);
Console.WriteLine(str);