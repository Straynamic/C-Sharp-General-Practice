using System;

namespace c__Lessons
{
    public class ExtraFunctions
    {
        public static int Seven() {
            {
                return 7;
            }
        }
        public static string PizzaPopperCounter(int poppers)
        {
            if(poppers == 1)
                return "I've eaten " + poppers + " Pizza popper!";
            else
                return "I've eaten " + poppers + " Pizza poppers!";
        }
    }
}
