// Brendon Carter

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;


public class GenBinSearchTest
{
    public static void Main(string[] args)
    {
        int[] a1 = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
        double[] a2 = { 5.0, 10.0, 15.0, 20.0, 25.0, 30.0, 35.0, 40.0, 45.0, 50.0 };

        Console.WriteLine("Search int array");
        foreach (int e in a1)
            Console.Write("{0:d} ", e);
        Console.WriteLine();

        Console.WriteLine("Where is 50?");
        Console.WriteLine("Position: {0}", BinarySearch(a1, 50));
        Console.WriteLine("Where is 42?");
        Console.WriteLine("Position: {0}", BinarySearch(a1, 42));

        Console.WriteLine();
        Console.WriteLine(); //create some space between the 2 for easier viewing
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Search double array");
        foreach (double e in a2)
            Console.Write("{0:f1} ", e);
        Console.WriteLine();

        Console.WriteLine("Where is 50.0?");
        Console.WriteLine("Position: {0}", BinarySearch(a2, 50.0));
        Console.WriteLine("Where is 42.0?");
        Console.WriteLine("Position: {0}", BinarySearch(a2, 42.0));

        Pause();
    }

    public static int BinarySearch<T>(T[] data, T searchElement)
    where T : IComparable<T>
    {
        int low = 0; // low end of the search area
        int high = data.Length - 1; // high end of the search area
        int middle = (low + high + 1) / 2; // middle element
        int location = -1; // return value; -1 if not found

        do // loop to search for element
        {
            // if the element is found at the middle
            if (searchElement.CompareTo(data[middle]) == 0)
                location = middle; // location is the current middle

            // middle element is too high
            else if (searchElement.CompareTo(data[middle]) < 0)
                high = middle - 1; // eliminate the higher half
            else // middle element is too low
                low = middle + 1; // eliminate the lower half

            middle = (low + high + 1) / 2; // recalculate the middle
        } while ((low <= high) && (location == -1));

        return location; // return location of search key
    } // end method BinarySearch


    //added a pause method so i can see the output to make sure it is correct
    static void Pause()
    {
        Console.WriteLine("Press enter to continue...");
        Console.ReadLine();
    }
}