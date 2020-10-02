using System;

namespace Lesson_2
{
    public static class ExtraFunctions
    {
        public static string PrintARandomNumber() {
            {
                var random = new Random();
                Console.WriteLine(random.Next(0,51));
                return "hi";
            }
        }
    }

    public delegate int PerformCalculation(int x, int y);

    class TestDelegate {
        
        
    }

    
}
