using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R.P.S.L.S
{
    //Member Variables

   public class Human : Player //Inheritance (TYPE OF)
    {
        //CONSTRUCTOR (SPAWN)
        public Human() 
        {
            
        
        
        
        }

        //CAN DO
        public override string ChooseGesture() 
        {
            Console.WriteLine("Rock, Paper, Scissor, Lizzard, SPOCK...CHOOOOSE!!!:");
            Gesture = Console.ReadLine();
            return Gesture;
            
        
        }













    }
}
