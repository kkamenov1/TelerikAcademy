using System;

class HorribleCode
{
    static void Main()
    {
        Console.WriteLine("Hi, Im Horribly formated program");
        Console.WriteLine("Numbers and Squares: ");
        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine(i + " --> " + i * i);
        }
    }
}