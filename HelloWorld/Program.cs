using System;

class Program
{
    static UInt32 Getnum()
    {
        UInt32 input = 0;
        input = (UInt32)Console.Read();
        return input;
    }

    static void Main(string[] args)
    {
        UInt32 input = 1;

        Console.WriteLine("Hello World");
        while (input != 0)
        {
            input = Program.Getnum();
            Console.WriteLine("The number is %d ", input);
        }
    }



}
