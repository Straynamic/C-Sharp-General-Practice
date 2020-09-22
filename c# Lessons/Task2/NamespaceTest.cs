using System;

namespace TestSpace{
    class EvenMoreFunctions{
        public static void PrintARandomNumber() {
            {
                var random = new Random();
                Console.WriteLine(random.Next(50,101));
            }
        }
    }
}
