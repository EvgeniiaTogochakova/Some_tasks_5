// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19  
// [-4, -6, 89, 6] -> 0 

int[] CreateArray(int length)
{
    return new int[length];
}

string FillArrayRandomNumbers(int[] array)
{
    string str = "";
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-100, 101);
        str += array[i] + " ";
    }
    return str;
}

string SumOnOddPositions(int[] array)
{
    string sti = "";
    int size = array.Length;
    int sum = 0;
    for (int i = 1; i < size; i += 2)
    {
        sum += array[i];
    }
    sti += sum;
    return sti;
}

int[] arr = CreateArray(10);
string s = FillArrayRandomNumbers(arr);
Console.WriteLine(s);
string st = SumOnOddPositions(arr);
Console.WriteLine(st);