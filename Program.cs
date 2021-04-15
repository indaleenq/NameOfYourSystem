using System;

public class HelloWorld
{
    static public void Main ()
    {
        Console.WriteLine ("Hello World");

        //Reading Input
        //Enter the following codes in the Source tab and a number in the Input tab
        Console.Write("Enter a number - ");
        string input = Console.ReadLine();
        Console.WriteLine("You entered '{0}'", input);
    }
}
