using System;
using System.Security.Cryptography;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n\n********** Welcome to 21! ***********\n\n");
        Console.WriteLine("Keep taking numbers up total of 21. Go over and lose. Get as close as you can.");
        
        //properties
        Random rgen = new Random();
        int compScore = rgen.Next(15, 20);
        int playerScore = rgen.Next(1, 11);
        String playerNums = playerScore + " ";
        bool gameOver = false;

        while(!gameOver) {
            //render
            Console.WriteLine("Current Cards: " + playerNums);

            //get user input
            Console.Write("Would you like another card (y or n): ");
            String cmd = Console.ReadLine();

            //update
            if(cmd == "y") {
                int card = rgen.Next(1, 11);
                playerScore += card;
                playerNums += card + " ";
            }
            if(cmd == "n" || playerScore > 21) {
                gameOver = true;
            }
        }

        Console.WriteLine("Current Cards: " + playerNums); //render one more time.

        if(playerScore <= 21 && playerScore > compScore) {
            Console.WriteLine("Congrats! Comp got " + compScore);
        }
        else if(playerScore > 21) {
            Console.WriteLine("You Busted!");
        }
        else {
            Console.WriteLine("Computer won with " + compScore);
        }




    }
}
