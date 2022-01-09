// Задача: Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел.
// Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. При решении не
// рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами
int [] FstArray(int length, int min, int max)
{int [] array = new int [length];
for (int i = 0; i< length; i++)
 {array[i] = new Random().Next(min, max + 1);}
 return array;}
 
 void PrintArray (int [] arr)
 {
     for (int i = 0; i < arr.Length; i++)
     {Console.Write($"{arr[i]} ");}}
 
 int [] CheckEvenElements (int[] a)
 { int[] b = new int [a.Length];
    int j = 0;
    for (int i = 0; i< a.Length; i++)
    { if (a[i] % 2 == 0)
    {b[j]= a[i];j++;}}
Array.Resize(ref b,j);
return b;}
int [] A =FstArray(10, 0, 100);
int [] B =CheckEvenElements (A);
Console.WriteLine($"Элементы массива А");
PrintArray(A);
Console.WriteLine();
Console.WriteLine($"Элементы массива B");
PrintArray(B);
