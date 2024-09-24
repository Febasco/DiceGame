using System;

namespace DiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Blackjack with Dice!");
            Console.WriteLine();

            Random rand = new Random();
            int playerPoints = 0;
            int dealerPoints = 0;
            string answer = "";

            
            Console.WriteLine("Do you want to throw the dice? (yes/no)");
            answer = Console.ReadLine();

            while (answer.ToLower() == "yes")
            {
                
                Console.WriteLine();

                
                int playerRoll = rand.Next(1, 7);
                playerPoints += playerRoll;
                Console.WriteLine("You rolled a " + playerRoll + ". Your total is now " + playerPoints);

                if (playerPoints > 21)
                {
                    Console.WriteLine("You went over 21! You fucked up dude, you bust! Dealer wins");
                    return;
                }

                
                if (dealerPoints < 17)
                {
                    int dealerRoll = rand.Next(1, 7);
                    dealerPoints += dealerRoll;
                    Console.WriteLine("Dealer rolled a " + dealerRoll + ". Dealer's total is now " + dealerPoints );

                    if (dealerPoints > 21)
                    {
                        Console.WriteLine("Dealer went over 21! I guess even he wasn't smart enough, Dealer busts! You win");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Dealer stays with a total of " + dealerPoints + " points");
                }

                
                Console.WriteLine();
                Console.WriteLine("Do you want to throw the dice again? (yes/no)");
                answer = Console.ReadLine();
            }

           
            Console.WriteLine();
            Console.WriteLine("Dealer's turn...");
            while (dealerPoints < 17) 
            {
                int dealerRoll = rand.Next(1, 7);
                dealerPoints += dealerRoll;

                Console.WriteLine("Dealer rolled a " + dealerRoll + ". Dealer's total is now " + dealerPoints );

                if (dealerPoints > 21)
                {
                    Console.WriteLine("Dealer went over 21! Should of programmed him better, Dealer busts! You win");
                    return;
                }
            }

            Console.WriteLine("Dealer stays with a total of " + dealerPoints + " points");

            
            Console.WriteLine();
            Console.WriteLine("Final results:");
            Console.WriteLine("Your points: " + playerPoints);
            Console.WriteLine("Dealer's points: " + dealerPoints);

            if (playerPoints > dealerPoints)
            {
                Console.WriteLine("Congratulations! You outplayed the dealer, You win!");
            }
            else if (dealerPoints > playerPoints)
            {
                Console.WriteLine("Dealer wins, somehow...");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }
        }
    }
}