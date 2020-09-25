using System;

namespace Task3
{
    //Question 2: What is enum in C#?

    /*
        An enum is a value type with a set of related named constants often referred to as an enumerator list. The enum keyword is used to declare an enumeration. 
        It is a primitive data type that is user-defined.
        An enum type can be an integer (float, int, byte, double, etc.). But if you use it beside int it has to be cast.
    */
    public static class Question2
    {
        enum Dow {Sat, Sun, Mon, Tue, Wed, Thu, Fri};
        enum Level{
            Low,
            Medium,
            High
        }
        enum Difficulty {Easy, Normal, Hard}
        enum Months{Jaunary, Febuary, March, April, May, June, July, August, September, October, November, December}
        enum CarGear{First,Second,Third,Fourth}
        public static void RunQuestion(){
            Difficulty myDifficulty = Difficulty.Hard;
            switch(myDifficulty)
            {
                case Difficulty.Easy:
                    Console.WriteLine("Easy");
                    break;
                case Difficulty.Normal:
                    Console.WriteLine("Normal");
                    break;
                case Difficulty.Hard:
                    Console.WriteLine("Hard");
                    break;
            }
        }
    }
}
