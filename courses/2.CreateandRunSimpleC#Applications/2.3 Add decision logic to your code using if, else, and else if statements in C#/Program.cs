﻿namespace AddDecisionLogicToYourCode;

internal static class Program
{
    public static void Main(string[] args)
    {
        /*
        Exercise 
        
        Random dice = new Random();

        int roll1 = dice.Next(1,7);
        int roll2 = dice.Next(1,7);
        int roll3 = dice.Next(1,7); 

        int total = roll1 + roll2 + roll3;

        Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
        
        // Conditionals
        if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) // Boolean Expression to evaluate doubles
        {
            // Nested if statements
            if ((roll1 == roll2) && (roll2 == roll3)) 
            {
                Console.WriteLine("You rolled triples! +6 bonus to total!"); // Evaluate triples 
                total += 6;
            }
            else
            {
                Console.WriteLine("You rolled doubles! +2 bonus to total!");
                total += 2;
            }
        } 
        
        if (total >= 16)
        {
            Console.WriteLine("You win a new car!");
        }
        else if (total >= 10)
        {
            Console.WriteLine("You win a new laptop!");
        }
        else if (total == 7)
        {
            Console.WriteLine("You win a trip for two!");
        }
        else
        {
            Console.WriteLine("You win a kitten!");
        }
        */
        
        // Challenge - Improve Renewal of Subscriptions
        
        Random random = new Random();
        var daysUntilExpiration = random.Next(12);
        int discountPercentage;
        
        Console.WriteLine(daysUntilExpiration); // Testing 
        // Business rules
        if (daysUntilExpiration == 0)
        {
            Console.WriteLine("Your subscription has expired");
        }
        
        else if (daysUntilExpiration == 1)
        {
            discountPercentage = 20;
            Console.WriteLine($"Your subscription expires within a day!\nRenew now and save {discountPercentage}%");
               
        }
        else if (daysUntilExpiration <= 5)
        {
            discountPercentage = 10;
            Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days\nRenew now and save {discountPercentage}%");
        }
        else if (daysUntilExpiration <= 10)
        {
            Console.WriteLine("Your subscription will expire soon!. Renew now!");
        }
        else
        {
            Console.WriteLine($"Your subscription is up to day. Days until expiration:{daysUntilExpiration}");
        }
    }
}    
