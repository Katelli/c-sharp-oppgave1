using System.Globalization;
using System.Security.Cryptography.X509Certificates;

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
        char l = 'A';

        Console.WriteLine(myString);
        Console.WriteLine(myNumber);
        Console.WriteLine(myDecimal);
        Console.WriteLine(myNumber + myDecimal);
        Console.WriteLine(l);

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

        Console.WriteLine("\n");

        Dictionary<int, string> myDictionary = new Dictionary<int, string>();
        myDictionary.Add(1, "John");
        myDictionary.Add(2, "Jane");
        foreach (var item in myDictionary)
        {
            Console.WriteLine($"i: {item.Key}, id: {item.Value}");
        }

        Console.WriteLine("\n");

        Console.WriteLine("The answer is");
        Console.WriteLine(MyIntMethod(5, 3));

        Console.WriteLine("\n");

        Console.WriteLine("Your name?");
        string? name = Console.ReadLine();
        if(name != null && name != ""){
            Console.WriteLine(MyStringMethod(name));
        } else {
            Console.WriteLine("Please just write SOMETHING!");
        }
    }

    static public int MyIntMethod(int a, int b)
    {
        int total;
        total = a + b;
        return total;
    }

    static public string MyStringMethod(string name)
    {
        switch(name)
        {
            case "John Snow":
            Console.WriteLine("You know nothing " + name);
            break;
            case "Katrine":
            Console.WriteLine("You know absolutely nothing " + name);
            break;
            case "Kai":
            Console.WriteLine("You're amazing " + name + "!");
            break;
            default:
            Console.WriteLine("You're doing great " + name);
            break;
        } return "Goodbye";
    }
}