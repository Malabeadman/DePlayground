// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

int[] xBits = { 22, 24, 11, 12, 9, 2, 4, 92, 89 };
SortByBits(xBits);

// loop through the array
/// use Array Sort to sort in asscending order
static int[] SortByBits(int[] arr)
{
    int[] sortBits = new int[arr.Length - 1];
    int[] binaryBits = new int[arr.Length - 1];

    Array.Sort(arr);
    int loopcount = 0;
    foreach (int i in arr)
    {
        Console.WriteLine(i);
        sortBits[loopcount] = i;
        string binaryBit = Convert.ToString(i, 2);
        binaryBits[loopcount] = i;
        Console.WriteLine(binaryBits[loopcount]);

        loopcount++;
    }
    Console.WriteLine("Sorted Array End");
    return sortBits;
}


