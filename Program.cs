// Justin Lebbon February 12, 2025
//Lab 3 - Mastermind
Console.Clear();
Console.WriteLine("Hello, and Welcome to your favorite guessing game!");
Console.Write("Press any key to continue...");
Console.ReadKey();
Console.WriteLine("I have chosen 4 letters between 'a' and 'g' and have arranged them in a particular order.");
Console.WriteLine("Your job is to guess the letters and put them in the right order.");

string answerKey = "bcfe";
string guess = "";

int numGuess = 0;
int matchlettercount = 0;  // Count of letters in the correct position


do
{   
    numGuess++;

    Console.WriteLine($"Guess #{numGuess} :Please guess a sequence of 4 lowercase letters with no repeats.");
    guess = Console.ReadLine();

        for (int i = 0; i < answerKey.Length; i++)
        {
            if (guess[i] == answerKey[i])
            {
                matchlettercount++;
            }
           
        }

    Console.WriteLine($" {matchlettercount} - correctly placed letters");
    
}
while (guess != "bcfe");

