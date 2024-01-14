using System;

class Program
{
    static void Main()
    {
        int number = 1;

        do
        {
            int square = number * number;
            Console.WriteLine($"Kwadrat liczby {number}: {square}");
            number++;
        } while (number <= 20);
    }
}

