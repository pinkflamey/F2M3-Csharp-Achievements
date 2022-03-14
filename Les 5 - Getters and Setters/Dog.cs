using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_5___Getters_and_Setters
{
    internal class Dog
    {

        public string dogName;
        public Dog(string dogName)
        {
            this.dogName = dogName;
        }
        
        private Ball ball = new Ball();

        public string FetchBall()
        {
            switch (ball.GiveBall())
            {
                case "a ball": return "I have caught the ball!";
                default: return "I could not find a ball...";
            }
        }

        public string Pet(int intensity)
        {
            switch (intensity)
            {
                case 1: return "▼oᴥo▼ <3";
                case 2: return "໒( 0ᴥ 0)ʋ : woof!";
                case 3: return "V^ω^V : *jumps at you, lovingly*";
                case > 3: return "U(. n.)U : ouch...";
                default: return "(oᴥoʋ) : ...";
            }
        }

        public string GetName()
        {
            return dogName;
        }
        

    }
}
