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
        Random random = new Random();


        public Computer()  //Constructor (SPAWN)
        {
            


        }
       

        public override string ChooseGesture()     //CAN DO
        {
            Gesture =  random.Next(1, 6);
            Console.WriteLine(gesture);
            Gesture = Console.ReadLine();
            return Gesture;


           
        }


















    }
}
