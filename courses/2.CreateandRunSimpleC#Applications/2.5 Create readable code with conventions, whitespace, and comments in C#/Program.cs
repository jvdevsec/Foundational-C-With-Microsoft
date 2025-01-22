namespace CreateReadableCode;

internal static class Program
{
    public static void Main(string[] args)
    {
        /*
         Challenge - Improve code readability
          
         In this challenge, you'll use the techniques you learned in this module to 
         improve the readability of a code sample. You are provided with a code sample 
         that is poorly styled and commented. Your goal is to update the code using style 
         guidelines for variable names, code comments, and whitespace to improve code readability.
        */
        
        // The variable where I store the message
        string defaultMessage = "The quick brown fox jumps over the lazy dog.";
        
        // convert the message into a char type array
        char[] charMessage = defaultMessage.ToCharArray();
        Array.Reverse(charMessage); // this method is used to reverse the order of the characters 
        
        // the following foreach loop counts each 'o' character in the Array
        int characterCounter = 0; // Initialize the counter variable
        foreach (char i in charMessage)
        {
            if (i == 'o')
            {
                characterCounter++;
            }
        } 
        
        // convert the array back to a text string
        string newMessage = new String(charMessage);
        
        // outputs - print in the screen the reversed order message and the number of characters
        Console.WriteLine(newMessage);
        Console.WriteLine($"'o' appears {characterCounter} times.");
    }
}