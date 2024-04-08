using Standard_Algorithms;

Console.WriteLine("Hello, World!");

int[] arr = {8,4,7,1,2};

Sorting_standard a = new Sorting_standard();

a.RevBubbleInvSort(ref arr);

for (int i = 0; i < arr.Length; i++)
    Console.Write(arr[i] + " ");
FactAndFib b = new FactAndFib();
Console.WriteLine("\n##########################################");
Console.WriteLine(b.Factorial(10));
Console.WriteLine(b.FactorialFor(10));
Console.WriteLine("##########################################");
Console.WriteLine(b.Fibonachi(5));
Console.WriteLine(b.FibonachiFor(5));

Console.WriteLine("##########################################");
