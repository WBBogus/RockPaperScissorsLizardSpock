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
    abstract class Chooser
    {
        // private variables
        private int playerScore = 0;
        private int computerScore = 0;

        public int PlayerScore
        {
            get { return this.playerScore; }
            set { this.playerScore = value; }
        }

        public int ComputerScore
        {
            get { return this.computerScore; }
            set { this.computerScore = value; }
        }

        // methods
        public abstract void Play(string choice);


        
    }
}
