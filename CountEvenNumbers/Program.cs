// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] CreateArray(int length)
{
    return new int[length];
}

string FillArray3Digits(int[] array)
{
    string str = "";
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
        str += array[i] + " ";
    }
    return str;
}

string CountEvenNumbers(int[] array)
{
    string stri = "";
    int size = array.Length;
    int count_even = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0) count_even++;
    }
    stri += count_even;
    return stri;
}

int[] arra = CreateArray(20);
string s = FillArray3Digits(arra);
Console.WriteLine(s);
string sti = CountEvenNumbers(arra);
Console.WriteLine(sti);



