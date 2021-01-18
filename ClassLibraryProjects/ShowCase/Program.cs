using System;
using LinkedListExample.Lib;
//using UtilityLibraries;

class Program
{
    static void Main(string[] args)
    {
        IntegerLinkedList ill = new IntegerLinkedList(5);
        
        ill.Append(4);

        Console.WriteLine(ill.ToStr);
    }

    static int tester() {
        return 0;
    }
}