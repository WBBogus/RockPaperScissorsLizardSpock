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
    class Lizard : Chooser
    {
        public override void Play(string choice)
        {
            if (choice == "rock")
            {
                ComputerScore = 0;
                PlayerScore = 0;
                Console.WriteLine("Rock beats lizard");
                Console.WriteLine("You win");
                PlayerScore = PlayerScore + 1;

            }
            else if (choice == "paper")
            {
                ComputerScore = 0;
                PlayerScore = 0;
                Console.WriteLine("Lizard beats paper");
                Console.WriteLine("You lose");
                ComputerScore = ComputerScore + 1;

            }
            else if (choice == "scissors")
            {
                ComputerScore = 0;
                PlayerScore = 0;
                Console.WriteLine("Scissors beat lizard");
                Console.WriteLine("You win");
                PlayerScore = PlayerScore + 1;

            }
            else if (choice == "lizard")
            {
                ComputerScore = 0;
                PlayerScore = 0;
                Console.WriteLine("Lizard ties with Lizard");
                Console.WriteLine("You tie");
                ComputerScore = ComputerScore + 1;               
                PlayerScore = PlayerScore + 1;

            }
            else if (choice == "spock")
            {
                ComputerScore = 0;
                PlayerScore = 0;
                Console.WriteLine("Lizard beats spock");
                Console.WriteLine("You lose");
                ComputerScore = ComputerScore + 1;

            }

        }
    }
}
