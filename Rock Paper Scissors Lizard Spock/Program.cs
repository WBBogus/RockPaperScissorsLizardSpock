// Will Boguslawski 
// Jude Pitschka
// Jessica Nguyen
// 2/24/2023
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Lizard_Spock
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // variables
            int computerScore = 0;
            int playerScore = 0;
            int count = 1; // for while loop so it can make 3 rounds

            Console.WriteLine("Welcome to the Rock Paper Scissors Lizard Spock Game!");
            Console.WriteLine("\n");


            while (true)
            {
                


                Console.Write("Enter rock, paper, scissors, lizard, or spock: ");
                string playerChoice = Console.ReadLine();   // gets player input
                Console.Write("\n");

                Random random = new Random();
                int enemyChoice = random.Next(1, 6); // makes computer pick 1-5 based on each choice


                if (enemyChoice == 1)
                {
                    Console.WriteLine("Round " + count);
                    Console.WriteLine("Player Score: " + playerScore + " Computer Score: " + computerScore);
                    Console.WriteLine("The computer choose: rock");
                    Console.WriteLine("You chose          : " + playerChoice);
                    Rock rock = new Rock();
                    rock.Play(playerChoice);
                    if (rock.PlayerScore == 1 && rock.ComputerScore == 1)
                    {
                        playerScore = playerScore + 1;
                        computerScore = computerScore + 1;
                    }
                    else if (rock.ComputerScore == 1)
                        computerScore = computerScore + 1;
                    else if (rock.PlayerScore == 1)
                        playerScore = playerScore + 1;               
                    count++;
                    Console.WriteLine("\n");

                }
                if (enemyChoice == 2)
                {
                    Console.WriteLine("Round " + count);
                    Console.WriteLine("Player Score: " + playerScore + " Computer Score: " + computerScore);
                    Console.WriteLine("The computer chose: paper");
                    Console.WriteLine("You chose         : " + playerChoice);
                    Paper paper = new Paper();
                    paper.Play(playerChoice);
                    if (paper.PlayerScore == 1 && paper.ComputerScore == 1)
                    {
                        playerScore = playerScore + 1;
                        computerScore = computerScore + 1;
                    }
                    else if (paper.ComputerScore == 1)
                        computerScore = computerScore + 1;
                    else if (paper.PlayerScore == 1)
                        playerScore = playerScore + 1;
                    count++;
                    Console.WriteLine("\n");
                }
                if (enemyChoice == 3)
                {

                    Console.WriteLine("Round " + count);
                    Console.WriteLine("Player Score: " + playerScore + " Computer Score: " + computerScore);
                    Console.WriteLine("The computer chose: scissors");
                    Console.WriteLine("You chose         : " + playerChoice);
                    Scissors scissors = new Scissors();
                    scissors.Play(playerChoice);
                    if (scissors.PlayerScore == 1 && scissors.ComputerScore == 1)
                    {
                        playerScore = playerScore + 1;
                        computerScore = computerScore + 1;
                    }
                    else if (scissors.ComputerScore == 1)
                        computerScore = computerScore + 1;
                    else if (scissors.PlayerScore == 1)
                        playerScore = playerScore + 1;
                    count++;
                    Console.WriteLine("\n");
                }
                if (enemyChoice == 4)
                {

                    Console.WriteLine("Round " + count);
                    Console.WriteLine("Player Score: " + playerScore + " Computer Score: " + computerScore);
                    Console.WriteLine("The computer chose: lizard");
                    Console.WriteLine("You chose         : " + playerChoice);
                    Lizard lizard = new Lizard();
                    lizard.Play(playerChoice);
                    if (lizard.PlayerScore == 1 && lizard.ComputerScore == 1)
                    {
                        playerScore = playerScore + 1;
                        computerScore = computerScore + 1;
                    }
                    else if (lizard.ComputerScore == 1)
                        computerScore = computerScore + 1;
                    else if (lizard.PlayerScore == 1)
                        playerScore = playerScore + 1;
                    count++;
                    Console.WriteLine("\n");
                }
                if (enemyChoice == 5)
                {

                    Console.WriteLine("Round " + count);
                    Console.WriteLine("Player Score: " + playerScore + " Computer Score: " + computerScore);
                    Console.WriteLine("The computer chose: spock");
                    Console.WriteLine("You chose         : " + playerChoice);
                    Spock spock = new Spock();
                    spock.Play(playerChoice);
                    if (spock.PlayerScore == 1 && spock.ComputerScore == 1)
                    {
                        playerScore = playerScore + 1;
                        computerScore = computerScore + 1;
                    }
                    else if (spock.ComputerScore == 1)
                        computerScore = computerScore + 1;
                    else if (spock.PlayerScore == 1)
                        playerScore = playerScore + 1;
                    count++;
                    Console.WriteLine("\n");
                }

                if (count == 4)
                {
                    Console.WriteLine("Final Score:  Player: " + playerScore + " - Computer: " + computerScore);

                    if (playerScore > computerScore)
                        Console.WriteLine("You won the game! ");
                    else if (playerScore == computerScore)
                        Console.WriteLine("You tied the game! ");
                    else
                        Console.WriteLine("You lost the game! ");
                    
                    Console.Write("Would you like to play another game? (enter yes or no) ");
                    string anotherGame = Console.ReadLine();
                    Console.WriteLine("\n");
                    if (anotherGame == "yes")
                    {
                        count = 1;
                        playerScore = 0;
                        computerScore = 0;
                    }
                    else
                    {
                        break;
                    }

                    
                }

            }
        }
    }
}
