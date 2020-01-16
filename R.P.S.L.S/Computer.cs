using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R.P.S.L.S
{
    

   public class Computer : Player //Inheritance (TYPE OF)
    {
        //Member Variables
        Random randomNumber;
        
        //private readonly string Rock;
        //private readonly string Scissor;
        //private readonly string Paper;
        //private readonly string Lizzard;
        //private readonly string Spock;
        public Computer()  //Constructor (SPAWN)
        {
            
            


        }
       

        public override void ChooseGesture()     //CAN DO
        {
            Random random = new Random();
            //Gesture = (gestures[randomNumber.Next(0, 6)]);
            Console.Write("Computer's Turn");
            int num = random.Next(6);
            Gesture = gestures[num];
            Console.WriteLine(num);
            Console.WriteLine(Gesture);
            
            
            
            
            
            //return Gesture;




            //gestures[0]
            //gestures[1]
            //gestures[2]
            //gestures[3]
            //gestures[4]

            //  num++;




            ///



        }


















    }
}
