
namespace _2._2_Call_methods_from_the_.NET_class_library_using_C_;

internal static class Program
    {
        public static void Main(string[] args)
        {
            /* Class instance = object
            
            Random dice = new Random();
            int roll= dice.Next(1,7);
            Console.WriteLine(roll);
            */

            /*
            Random dice = new Random();
            int roll1 = dice.Next();
            int roll2 = dice.Next(101);
            int roll3 = dice.Next(50, 101);

            Console.WriteLine($"First roll: {roll1}");
            Console.WriteLine($"Second roll: {roll2}");
            Console.WriteLine($"Third roll: {roll3}");
            */
             
            //Exercise
            int firstValue = 600;
            int secondValue = 500;

            int largerValue = Math.Max(firstValue, secondValue); //Math class, and max method 
            Console.WriteLine(largerValue);
            
            
             
        }
    }

