using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R.P.S.L.S
{


    class Game
    {//Member Variables(Has A)
        public Player Player1;
        public Player Player2;


        public Game()
        {//Constructor (SPAWN)


        }



        public string ChooseNumberOfPlayers() //Can Do (INTRO, RULES)
        {
            Console.WriteLine("Lets Get Ready To Rock, Paper, Scissors, Lizard, and Spock!");
            Console.ReadLine();


            Console.Write("There's rules to this game, believe it or not. All you have to do is type: Rock, Paper, Scissors, Lizzard OR Spock. Nothing more, nothing less. Get it? Got it? Good! Let's Play!");
            Console.ReadLine();


            Console.WriteLine("Please select 1 for single player or 2 for two players");
            string numberOfPlayers = Console.ReadLine();
            return numberOfPlayers;

        }

        public void SetPlayers(string numberOfPlayers)
        {
            if (numberOfPlayers == "1")
            {
                Player1 = new Human();
                Player2 = new Computer();
                Console.WriteLine("Player 1 VS. Computer");
                Console.ReadLine();
            }
            //Selection of single or 2 player
            else if (numberOfPlayers == "2")
            {
                Player1 = new Human();
                Player2 = new Human();
                Console.WriteLine("Player 1 VS. Player 2");
                Console.ReadLine();
            }
            Console.ReadLine();

        }

        public void CompareGestures()
        {
            if (Player1.Gesture == "Rock")
            {
                if (Player2.Gesture == "Scissors")
                {
                    Player1.score++;
                }
                else if (Player2.Gesture == "Paper")
                {
                    Player2.score++;
                }
                else if (Player2.Gesture == "Rock")
                {
                    Console.WriteLine("Whoa, it's a TIE!");
                }
                else if (Player2.Gesture == "Lizard")
                {

                    Player1.score++;
                }
                else if (Player2.Gesture == "Spock")
                {
                    Player2.score++;
                }
            }

            if (Player1.Gesture == "Paper")
            {
                if (Player2.Gesture == "Rock")
                {
                    Player1.score++;
                }
                else if (Player2.Gesture == "Paper")
                {
                    Console.WriteLine("Whoa, it's a TIE!");
                }
                else if (Player2.Gesture == "Scissior")
                {
                    Player2.score--;
                }
                else if (Player2.Gesture == "Lizard")
                {
                    Player2.score++;
                }
                else if (Player2.Gesture == "Spock")
                {
                    Player1.score--;
                }

            }

            if (Player1.Gesture == "Scissor")
            {
                if (Player2.Gesture == "Rock")
                {
                    Player2.score++;
                }
                else if (Player2.Gesture == "Paper")
                {
                    Player1.score++;
                }
                else if (Player2.Gesture == "Scissior")
                {
                    Console.WriteLine("Whoa, it's a TIE!");
                }
                else if (Player2.Gesture == "Lizard")
                {
                    Player1.score++;
                }
                else if (Player2.Gesture == "Spock")
                {
                    Player2.score--;
                }

            }

            if (Player1.Gesture == "Lizard")
            {
                if (Player2.Gesture == "Scissors")
                {
                    Player2.score++;
                }
                else if (Player2.Gesture == "Paper")
                {
                    Player1.score++;
                }
                else if (Player2.Gesture == "Rock")
                {
                    Player2.score++;
                }
                else if (Player2.Gesture == "Lizard")
                {

                    Console.WriteLine("Whoa, it's a TIE! Keep it going dude.");
                }
                else if (Player2.Gesture == "Spock")
                {
                    Player1.score++;
                }
            }

            if (Player1.Gesture == "Spock")
            {
                if (Player2.Gesture == "Scissors")
                {
                    Player1.score++;
                }
                else if (Player2.Gesture == "Paper")
                {
                    Player2.score++;
                }
                else if (Player2.Gesture == "Rock")
                {
                    Player1.score++;
                }
                else if (Player2.Gesture == "Lizard")
                {

                    Player2.score++;
                }
                else if (Player2.Gesture == "Spock")
                {
                    Console.WriteLine("Whoa, it's a TIE!");
                }
            }

        }

        public void RunGame() // master method
        {
            string numberOfPlayers = ChooseNumberOfPlayers();
            SetPlayers(numberOfPlayers);

            Console.WriteLine("Player 1 is up");
            Console.ReadLine();
            Player1.ChooseGesture();


            Console.WriteLine("Player 2 is up");
            Console.ReadLine();
            Player2.ChooseGesture();


        }
        public void RoundsInGame()
        {

            if (Player1.score >= 2)
            {
                Console.WriteLine("Better luck next time");
                Console.ReadLine();
            }
            Console.ReadLine();

            if (Player2.score >= 2)
            {

                Console.WriteLine("Better luck next time");
                Console.ReadLine();
            }


        }
         
            



              


















































































































































































































































              









































































































































































    }
}

