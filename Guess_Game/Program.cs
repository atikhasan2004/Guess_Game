using System;
class Guess_Game
{
    static void Main(string[]args)
    {
        Random random = new Random();
        int secretNumber = random.Next(10, 51);
        int count = 0;  // int Attempts = 0;
        int maxCount = 10; // int maxAttempts = 10;
        int[] wrong = new int[maxCount];
       // int[] right = new int[5];
        int guess;
        Console.WriteLine("\nGuess the number between 10 and 50.");
        Console.WriteLine("I have " + maxCount + " chances!");
        for (int i = 1; i <= maxCount; i++)
        {
            Console.Write($"\n{i}. Guess number is: ");
            guess = int.Parse(Console.ReadLine());
            count++;
            if (guess > secretNumber)
            {
                Console.WriteLine("My guess number is higher than the number.....!\n");
                wrong[count-1] = guess;
            }
            else if (guess < secretNumber)
            {
                Console.WriteLine("My guess number is lower than the number....!!\n");
                wrong[count-1] = guess;
            }
            else
            {
                Console.WriteLine($"I guessed the correct number in {count} tries...!!!\n");
                //right[0] = guess;
                break;
            }
        }
        if (count == maxCount)
        {
            Console.WriteLine("\nI have already uesd my all chances.\n");
        }
        Console.WriteLine("\nMy wrong guess numbers are: ");
        for (int num = 0; num < count; num++)
        {
            Console.WriteLine(wrong[num]);
        }
        Console.WriteLine("\n.......... Game Over ..........");
        Console.WriteLine($"\nTotal number of Attempts: {count}");
        Console.WriteLine($"Correct number was: {secretNumber}\n");
    }
}