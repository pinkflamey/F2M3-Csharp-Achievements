using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_5___Getters_and_Setters
{
    internal class Dog
    {

        

        private Ball ball;
        public string FetchBall(Ball ball)
        {
            this.ball = ball;
            return "໒( 0ᴥ 0)ʋ: I fetched the ball!";
        }
        public Ball PickUpBall()
        {
            return ball;
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
        

    }
}
