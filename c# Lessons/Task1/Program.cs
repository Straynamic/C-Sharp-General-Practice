using System;
using System.Security.Cryptography;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            int pizzapoppers = 17;
            for(int i = 1; i <= pizzapoppers; i++)
            {
                Console.WriteLine(ExtraFunctions.PizzaPopperCounter(i));
            }
        }
    }
}
