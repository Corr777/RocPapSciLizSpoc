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
        public string Gesture;

        public Computer()  //Constructor (SPAWN)
        {
            


        }
       

        public override void ChooseGesture()     //CAN DO
        {
            Random random = new Random();
            Console.Write("Computer's Turn");
            int num = random.Next(6);
            gestures[0];
            System.Convert.ToInt32(gestures[1]);
            System.Convert.ToInt32(gestures[2]);
            System.Convert.ToInt32(gestures[3]);
            System.Convert.ToInt32(gestures[4]);
            //  num++;
            Console.WriteLine(num);

            Gesture = gestures[num];

            //return Gesture;

            Console.WriteLine(Gesture);
           
        }


















    }
}
