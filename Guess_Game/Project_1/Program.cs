using System;
class GAME
{
    static void Main()
    {
        Random random = new Random();
        int secretNumber = random.Next(10, 51);
        int guess;
        Console.WriteLine("\nGuess the number between 10 and 51.");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write("\nEntre my guess number is: ");
            guess = Convert.ToInt32(Console.ReadLine());
            if (guess > secretNumber)
                Console.WriteLine("My guess is higher than the number....!");
            else if (guess < secretNumber)
                Console.WriteLine("My guess is lower than the number....!!");
            else
            {
                Console.WriteLine("I have guessed correct number....!!!");
                break;
            }
        }
        Console.WriteLine($"\nThe correct answer is : {secretNumber}\n");
    }
}