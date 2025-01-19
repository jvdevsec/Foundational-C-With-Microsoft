﻿namespace StoreAndIterateThroughArrays;

internal static class Program
{
    public static void Main(string[] args)
    { 
        /* Exercise 2
         
        // Declare a new array
        string[] fraudulentOrderIDs = new string[3];

        // Assign values to elements of an array
        fraudulentOrderIDs[0] = "A123";
        fraudulentOrderIDs[1] = "B456";
        fraudulentOrderIDs[2] = "C789";

        // Attempt to use an index that is out of bounds of the array
        // fraudulentOrderIDs[3] = "D000";

        // Retrieve values from elements of an array
        Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
        Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
        Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

        // Reassign a value to an element of an array
        fraudulentOrderIDs[0] = "F000";

        Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

        // Initialize an array
        string[] fraudulentOrderIDs2 = new string[] { "A123", "B456", "C789" };

        // Use the Length property of an array
        Console.WriteLine($"There are {fraudulentOrderIDs2.Length} fraudulent orders to process.");
        */
        
        /* Exercise 2
         int[] inventory = [200, 450, 700, 175, 250];
         int sum = 0;

         int bin = 0;
            
         foreach (int item in inventory)
         {
            sum += item;
            bin++;
            Console.WriteLine($"Bin {bin} = {item} items (Running total: {sum})");
         }
        
         Console.WriteLine($"We have {sum} items in inventory.");
        */
        
        // Array
        string[] orderIDs= ["B123", "C234", "A345", "C15", "B177", "G30003", "C235", "B179"];
        foreach (string orderID in orderIDs)
        {
            // This condition evaluates if the ID is fraudulent
            if (orderID.StartsWith('B'))
            {
                Console.WriteLine($"order ID Number {orderID} is fraudulent");
            }
        }


    }
}