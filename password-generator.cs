using System;

class Program
{
    static void Main()
    {
        // Characters that can be used in the password
        string characters =
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
            "abcdefghijklmnopqrstuvwxyz" +
            "0123456789" +
            "!@#$%^&*";

        // Ask the user how long they want their password
        Console.Write("How long should the password be? ");
        int length = Convert.ToInt32(Console.ReadLine());

        // Create a Random object.
        // This allows us to pick random characters.
        Random random = new Random();

        // This variable will store our new password
        string password = "";

        // Repeat this loop until we have enough characters
        for (int i = 0; i < length; i++)
        {
            // Pick a random position from the characters string
            int randomIndex = random.Next(characters.Length);

            // Add the randomly selected character to the password
            password += characters[randomIndex];
        }

        // Display the finished password
        Console.WriteLine();
        Console.WriteLine("-------------------------");
        Console.WriteLine("    PASSWORD GENERATOR");
        Console.WriteLine("-------------------------");

        Console.WriteLine("Your password is:");
        Console.WriteLine(password);

        // Keep the console open
        Console.WriteLine();
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
