using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace understandingOO
{
    class Auto
    {
        public int Speed;
        public int Year;
        public int Miles;
        private string make;
        public string Model;
        public string Color;

        public string Maker
        {
            get { return make ; }
            set
            {
                switch (value)
                {
                    case "OldsMobile":
                        make = value;
                        break;
                    case "BMW":
                        make = value;
                        break;
                    default:
                        make = "invalid maker";
                }
              
            }
        }

        public int Accelerator(int incrementedSpeed)
        {
            Speed +=incrementedSpeed;
            //Console.WriteLine("the current speed:" + speed);
            return Speed;

        }
        public int Decelerator(int decrementedSpeed)
        {
            Speed -=decrementedSpeed;
            //Console.WriteLine("The current speed:" +speed);
            return Speed;
        }
        public string speedLimitViolation(int speedLimit,string initialMessage)
        {
            string message = "";
            if (Speed > speedLimit)
               // initialMessage = "warning!";
                message = initialMessage+ "Too Fast!";
            else
                message = "No worries !! It's ok!";
            //initialMessage = "No worries!";
            return message;
            
                
        }
    }
}
