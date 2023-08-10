using System;

public class Program 
{
    public static void Main(string[] args) 
    {
        Random random = new Random();

        int PlayerOne;
        for (int i = 0; i < 10; i++) 
        {
            Console.Write("Prees a key to choose your dice: ");

            Console.ReadKey(); // waiting for a keyboard command

            PlayerOne = random.Next(1, 7);
            Console.WriteLine("Your number is" + PlayerOne);
        }

    }
}