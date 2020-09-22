using System;

namespace Lesson_2
{
    public class ExtraFunctions
    {
        public static string PrintARandomNumber() {
            {
                var random = new Random();
                Console.WriteLine(random.Next(0,50));
                return "hi";
            }
        }
    }
}
