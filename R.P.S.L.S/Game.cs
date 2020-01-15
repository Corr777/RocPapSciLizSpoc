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
        
        //Can Do
        public string ChooseNumberOfPlayers() 
        {
            Console.WriteLine("How many players?");
            string numberOfPlayers = Console.ReadLine();
            return numberOfPlayers;
        
        }


        public void SetPlayers(string numberOfPlayers)
        { 
            if (numberOfPlayers == "1") 
            {
                Player1 = new Human();
                Player2 = new Computer();
                Console.WriteLine("");
            }
            
            else if (numberOfPlayers == "2") 
            {
                Player1 = new Human();
                Player2 = new Human();
                Console.WriteLine("");
            }
            Console.ReadLine();

        }
       
        public string SelectGestures()
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
                else if (Player2.Gesture == "Lizzard")
                {

                    Player1.score++;
                }
                else if (Player2.Gesture == "Spock")
                {
                    Player2.score++;
                }
            }
            else if (Player1.score >=2) 
            {
                Console.WriteLine("Hey, you won dude!");    
            
            }
            Console.ReadLine();

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
                else if (Player2.Gesture == "Lizzard")
                {
                    Player2.score++;
                }
                else if (Player2.Gesture == "Spock")
                {
                    Player1.score--;
                }

            }
            else if (Player1.score >= 2) 
            {
                Console.WriteLine("You won show off!");
            }
            Console.ReadLine();

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
                else if (Player2.Gesture == "Lizzard")
                {
                    Player1.score++;
                }
                else if (Player2.Gesture == "Spock")
                {
                    Player2.score--;
                }

            }
            else if (Player1.score >= 2)
            {
                Console.WriteLine("You won show off!");
            }
            Console.ReadLine();

            if (Player1.Gesture == "Lizzard")
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
                else if (Player2.Gesture == "Lizzard")
                {
                    
                    Console.WriteLine("Whoa, it's a TIE! Keep it going dude.");
                }
                else if (Player2.Gesture == "Spock")
                {
                    Player1.score++;
                }
            }
            else if (Player1.score >= 2)
            {
                Console.WriteLine("You won dude!");


            }
            Console.ReadLine();

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
                else if (Player2.Gesture == "Lizzard")
                {

                    Player2.score++;
                }
                else if (Player2.Gesture == "Spock")
                {
                    Console.WriteLine("Whoa, it's a TIE!");
                }
            }
            else if (Player1.score >= 2)
            {
                Console.WriteLine("You won dude!");

            }


            







        }

        public void RunGame()
        {
          ;

        }















    }
}

