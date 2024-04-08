// See https://aka.ms/new-console-template for more information
using Standard_Algorithms;

Console.WriteLine("Hello, World!");

int[] arr = {8,4,7,1,2};

Sorting_standard a = new Sorting_standard();

a.RevBubbleInvSort(ref arr);

for (int i = 0; i < arr.Length; i++)
    Console.Write(arr[i] + " ");
Console.WriteLine("\n##########################################");
Console.WriteLine(a.Factorial(10));
Console.WriteLine(a.FactorialFor(10));
Console.WriteLine("##########################################");
Console.WriteLine(a.Fibonachi(5));
Console.WriteLine(a.FibonachiFor(5));

Console.WriteLine("##########################################");
