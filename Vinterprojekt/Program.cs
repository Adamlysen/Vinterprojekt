using System;
using System.ComponentModel;

class Program
{

    

    static void Main()
    {
        
        Console.WriteLine("Welcome to the Driving license simulator 2024!");
        Console.WriteLine();
        Console.WriteLine("Press enter to play");
        Console.WriteLine("Write ESC to exit");
        string begin = Console.ReadLine();


        if (begin == "ESC" || begin == "esc") {
            return;
        }
        

        Console.WriteLine("You are about to get 3 questions");
        Console.WriteLine("Get them all right to advance to the driving test");
        Console.WriteLine();
        Console.WriteLine("Press enter to start the test!");
        Console.ReadLine();
        Console.WriteLine("Starting test...");
        Thread.Sleep(3000);
        Console.WriteLine("3");
        Thread.Sleep(1000);
        Console.WriteLine("2");
        Thread.Sleep(1000);
        Console.WriteLine("1");
        Thread.Sleep(1000);
        Console.WriteLine("First question:");
        Console.WriteLine("difrifrifjifidfk");
        string answer1 = Console.ReadLine();




    }
}