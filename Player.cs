using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_C
{
    public class Player
    {
        //member variables
        int wins;
        string name;
        string chosenGesture;
        int rounds;
        List<string> gestureList;

        //constructor
        public Player()
        {

        wins = 0;
        name = "";
        chosenGesture = "";
        rounds = 0;
        gestureList = new List<string> { "Rock", "Paper", "Scissors", "Lizard", "Spock" };

        }
        //member methods
    }
}
