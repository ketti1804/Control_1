using System;
using static System.Console;

Clear();
WriteLine();
string[] arr = new string[6];
for (int i=0; i < arr.Length; i++)
{
WriteLine($"Введите {i+1}-й элемент массива (строка): ");
arr[i] = ReadLine();
}
int s = 0;
for (int i=0; i<arr.Length; i++)
{
    if(arr[i].Length <4) s++;
}
string[] ar_res = new string[s];

int t = 0;

for (int i=0; i<arr.Length; i++)
{
    if(arr[i].Length <4) 
    {ar_res[t]=arr[i];
    t++;
    };
}

WriteLine("Элементы массива с длиной меньше либо равно 3 символам:");
WriteLine(String.Join(" ", ar_res));

