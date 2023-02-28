// Will Boguslawski 
// Jude Pitschka
// Jessica Nguyen
// 2/24/2023
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Lizard_Spock
{
    class Spock : Chooser
    {
        public override void Play(string choice)
        {
            if (choice == "rock")
            {
                ComputerScore = 0;
                PlayerScore = 0;
                Console.WriteLine("Spock beats rock");
                Console.WriteLine("You lose");
                ComputerScore = ComputerScore + 1;

            }
            else if (choice == "paper")
            {
                ComputerScore = 0;
                PlayerScore = 0;
                Console.WriteLine("paper beats spock");
                Console.WriteLine("You win");
                PlayerScore = PlayerScore + 1;

            }
            else if (choice == "scissors")
            {
                ComputerScore = 0;
                PlayerScore = 0;
                Console.WriteLine("Spock beats scissors");
                Console.WriteLine("You lose");
                ComputerScore = ComputerScore + 1;


            }
            else if (choice == "lizard")
            {
                ComputerScore = 0;
                PlayerScore = 0;
                Console.WriteLine("Lizard beats spock");
                Console.WriteLine("You Win");
                PlayerScore = PlayerScore + 1;
  
            }
            else if (choice == "spock")
            {
                ComputerScore = 0;
                PlayerScore = 0;
                Console.WriteLine("Spock doesn't fight Spock");
                Console.WriteLine("You tie");
                ComputerScore = ComputerScore + 1;                
                PlayerScore = PlayerScore + 1;

            }
        }
    }
}
