using System.Globalization;

namespace c_sharp_oppgave1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Console.WriteLine("\n");

        string myString = "Hello Everyone!";
        int myNumber = 20;
        double myDecimal = 10.25;
        char a = 'A';

        Console.WriteLine(myString);
        Console.WriteLine(myNumber);
        Console.WriteLine(myDecimal);
        Console.WriteLine(myNumber + myDecimal);
        Console.WriteLine(a);

        Console.WriteLine("\n");

        int[] myNumberArray = {1, 2, 3};
        for(int i = 0; i < myNumberArray.Length; i++)
        {
            Console.WriteLine(myNumberArray[i]);
        }

        Console.WriteLine("\n");

        string[] myStringArray = {"Hi", "Hello", "Welcome"};
        foreach(string strings in myStringArray)
        {
            Console.WriteLine(strings);
        }

        Console.WriteLine("\n");

        List<string> myStrings = new List<string>();
        myStrings.Add("Ape");
        myStrings.Add("Bear");
        myStrings.Add("Camel");
        foreach(string animals in myStrings)
        {
            Console.WriteLine(animals);
        }
    }
}