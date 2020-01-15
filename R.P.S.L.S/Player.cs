using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R.P.S.L.S
{


    public abstract class Player
    {
        //Member Variables
        public int score;
        public string Gesture;
        public List<string> gesture = new List<string> { "Rock", "Paper", "Scissors", "Lizzard", "Spock" };


        public Player()//Constructor (SPAWN)
        {
          


        }

        public abstract string ChooseGesture();
       



       
        
        
        
    
        

      








    }

















}

