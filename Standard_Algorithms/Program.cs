﻿using Standard_Algorithms;
using System.Threading.Channels;

Console.WriteLine("Hello, World!");

int[] arr = {8,4,7,1,2};

Sorting_standard a = new Sorting_standard();

a.BubbleSort(ref arr);

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

int[] arr2 = { 8, 4, 7, 1, 2, 8, 4, 7, 1, 2 };

Manipulating_An_Array c = new Manipulating_An_Array();
c.RemoveAt(ref arr2,2);
for (int i = 0; i < arr2.Length; i++)
    Console.Write(arr2[i] + " ");
Console.WriteLine("\n##########################################");
c.RemoveFirst(ref arr2);
for (int i = 0; i < arr2.Length; i++)
    Console.Write(arr2[i] + " ");
Console.WriteLine("\n##########################################");
c.RemoveEnd(ref arr2);
for (int i = 0; i < arr2.Length; i++)
    Console.Write(arr2[i] + " ");
Console.WriteLine("\n##########################################");

int[] arr3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
c.RemoveAllFromIndexBack(ref arr3, 0);
for (int i = 0; i < arr3.Length; i++)
    Console.Write(arr3[i] + " ");
Console.WriteLine("\n##########################################");

c.RemoveAllFromIndexForward(ref arr3, 4);
for (int i = 0; i < arr3.Length; i++)
    Console.Write(arr3[i] + " ");
Console.WriteLine("\n##########################################");
int[] arr4 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
c.ReverArray(ref arr4);
for (int i = 0; i < arr4.Length; i++)
    Console.Write(arr4[i] + " ");
Console.WriteLine("\n##########################################");


int[] arr5 = { 3,1,6,3,8,0,6,1,2 };
a.CocktailSort(ref arr5);
for (int i = 0; i < arr5.Length; i++)
    Console.Write(arr5[i] + " ");

Console.WriteLine("\n##########################################");
a.RevCocktailSort(ref arr5);
for (int i = 0; i < arr5.Length; i++)
    Console.Write(arr5[i] + " ");

Console.WriteLine("\n##########################################");
/*
int[] arr7 = { 3, 1, 6, 3, 8, 7, 6, 1, 2, };
a.BogoSort(ref arr7);
for (int i = 0; i < arr7.Length; i++)
    Console.Write(arr7[i] + " ");
*/
Console.WriteLine("\n##########################################");
int[] arr8 = { 3, 1, 6, 3, 8, 7, 6, 1, 2, };
a.StalinSort(ref arr8);
for (int i = 0; i < arr8.Length; i++)
    Console.Write(arr8[i] + " ");
Console.WriteLine("\n##########################################");
int[] arr0 = { 3, 1, 6, 3, 8, 7, 6, 1, 2, };
a.ThanosSort(ref arr0);
for (int i = 0; i < arr0.Length; i++)
    Console.Write(arr0[i] + " ");
Console.WriteLine("\n##########################################");

int[] arrI = { 3, 1, 2, 5, 1, 2, 6, 8, 0, 4, 1 };
a.InsertSort(ref arrI);
for (int i = 0; i < arrI.Length; i++)
    Console.Write(arrI[i] + " ");
Console.WriteLine("\n##########################################");
int Mult = b.Multi(3, 4);
Console.WriteLine($"Mult: {Mult}");
int MultR = b.MultReq(3,4);
Console.WriteLine($"Mult: {MultR}");
Console.WriteLine("\n##########################################");
