using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace understandingOO
{
    class Auto
    {
        private int speed;
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
        public int CurrentSpeed
        {
            get { return speed; }
            set
            {
                if (value < 0)
                    speed = 0;
                else if (value > 10)
                    speed = 10;
                else
                    speed = value;
            }
        }

        public int Accelerator(int incrementedSpeed)
        {
            CurrentSpeed +=incrementedSpeed;
            //Console.WriteLine("the current speed:" + speed);
            return CurrentSpeed;

        }
        public int Decelerator(int decrementedSpeed)
        {
            CurrentSpeed -=decrementedSpeed;
            //Console.WriteLine("The current speed:" +speed);
            return CurrentSpeed;
        }
        public string speedLimitViolation(int speedLimit,string initialMessage)
        {
            string message = "";
            if (CurrentSpeed > speedLimit)
               // initialMessage = "warning!";
                message = initialMessage+ "Too Fast!";
            else
                message = "No worries !! It's ok!";
            //initialMessage = "No worries!";
            return message;
            
                
        }
    }
}
