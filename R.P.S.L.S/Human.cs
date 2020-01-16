using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R.P.S.L.S
{
    

   public class Human : Player //Inheritance (TYPE OF)
    {
        //CONSTRUCTOR (SPAWN)
        public Human() 
        {
            
        
        
        
        }

        //CAN DO (METHOD)
        public override void ChooseGesture() 
        {
            Console.WriteLine("Rock, Paper, Scissor, Lizard, SPOCK...CHOOOOSE!!!:");
            Gesture = Console.ReadLine();
            
            
        
        }













    }
}
