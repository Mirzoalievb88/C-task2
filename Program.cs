using System;

class Program
{

    static int EvenCount(int n)
    {
        int count = 0;
        while (n != 0)
        {
            if (n % 10 % 2 == 0)
            {
                count++;
            }
            n /= 10;
        }
        return count;
    }

    static int OddCount(int n)
    {
        int count = 0;
        while (n != 0)
        {
            if (n % 10 % 2 != 0)
            {
                count++;
            }
            n /= 10;
        }
        return count;
    }

    static int DigitCount(int n)
    {
        int count = 0;
        while (n != 0)
        {
            n /= 10;
            count++;
        }
        return count;
    }

    static int SumDigit(int n)
    {
        int sum = 0;
        while (n != 0)
        {
            sum += n % 10;
            n /= 10;
        }
        return sum;
    }

    static void Main()
    {
        int n = 12345; 

        Console.WriteLine("Even: " + EvenCount(n));
        Console.WriteLine("Odd: " + OddCount(n));
        Console.WriteLine("Digit: " + DigitCount(n));
        Console.WriteLine("Sum: " + SumDigit(n));
    }
}
