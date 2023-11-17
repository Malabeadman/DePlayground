// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

int[] xBits = { 22, 24, 11, 12, 9, 2, 4, 92, 89 };
SortByBits(xBits);

 public int[] SortByBits(int[] arr) {
// loop through the array and taking number on the right if its larger          /// than the number on the left take number on right and move it to the front
    int[] sortBits = new int[arr.Length];

    // custom compair by 1s in the numbers in the array 
    // var used to call private method for custom compair
    Array.Sort(arr, (frst, scnd) => {
        int firstBit = SortBinary(frst);
        int secondBit = SortBinary(scnd);
// check to see if both numbers are equal
        if(firstBit != secondBit){
            return firstBit - secondBit;
        }
        return frst - scnd;
    });
    return arr;
    }

    private int SortBinary(int x){
        int placeholder = 0;

        while(x > 0){
            placeholder += x & 1;
            // bitwise right shift operater number of bits defined by its         right-hand operand
            x >>= 1;
        }
        return placeholder; 
    }