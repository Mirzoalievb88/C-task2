﻿//task1

// using System;

// class Program
// {

//     static int EvenCount(int n)
//     {
//         int count = 0;
//         while (n != 0)
//         {
//             if (n % 10 % 2 == 0)
//             {
//                 count++;
//             }
//             n /= 10;
//         }
//         return count;
//     }

//     static int OddCount(int n)
//     {
//         int count = 0;
//         while (n != 0)
//         {
//             if (n % 10 % 2 != 0)
//             {
//                 count++;
//             }
//             n /= 10;
//         }
//         return count;
//     }

//     static int DigitCount(int n)
//     {
//         int count = 0;
//         while (n != 0)
//         {
//             n /= 10;
//             count++;
//         }
//         return count;
//     }

//     static int SumDigit(int n)
//     {
//         int sum = 0;
//         while (n != 0)
//         {
//             sum += n % 10;
//             n /= 10;
//         }
//         return sum;
//     }

//     static void Main()
//     {
//         int n = 12345; 

//         Console.WriteLine("Even: " + EvenCount(n));
//         Console.WriteLine("Odd: " + OddCount(n));
//         Console.WriteLine("Digit: " + DigitCount(n));
//         Console.WriteLine("Sum: " + SumDigit(n));
//     }
// }

//task2

// using System;

// class Program
// {
//     static int Add(int a, int b)
//     {
//         return a + b;
//     }

//     static int Subtract(int a, int b)
//     {
//         return a - b;
//     }

//     static int Multiply(int a, int b)
//     {
//         return a * b;
//     }

//     static int Division(int a, int b)
//     {
       
//         if (b == 0)
//         {
//             Console.WriteLine("Error: Division by zero");
//             return 0;
//         }
//         return a / b;
//     }

//     static void Main()
//     {
//         int a = 8;
//         int b = 4;

//         Console.WriteLine("Add: " + Add(a, b));
//         Console.WriteLine("Subtract: " + Subtract(a, b));
//         Console.WriteLine("Multiply: " + Multiply(a, b));
//         Console.WriteLine("Division: " + Division(a, b));
//     }
// }

//task3


static int MinDigit(int n)
{
    int min = 9; 
    while (n != 0)
    {
        int digit = n % 10;
        if (digit < min)
        {
            min = digit;
        }
        n /= 10;
    }
    return min;
}

static int MaxDigit(int n)
{
    int max = 0;
    while (n != 0)
    {
        int digit = n % 10;
        if (digit > max)
        {
            max = digit;
        }
        n /= 10;
    }
    return max;
}


int n = 1234;

int min = MinDigit(n);
int max = MaxDigit(n);

Console.WriteLine(min + " + " + max + " = " + (min + max));
