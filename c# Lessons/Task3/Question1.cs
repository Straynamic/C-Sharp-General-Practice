using System;

namespace Task3
{
    public static class Question1
    {
        //Question 1: What is Boxing and Unboxing in C#?
        public static void RunQuestion(){
            Boxing();
            Unboxing();
        }

        //Convert a value to an object
        static void Boxing(){
            // Boxing  
            int anum = 123;  
            Object obj = anum;  
            Console.WriteLine(anum);  
            Console.WriteLine(obj); 
        }

        //Convert and object to a value
        static void Unboxing(){
            // Unboxing  
            Object obj2 = 123;  
            int anum2 = (int)obj2;  
            Console.WriteLine(anum2);  
            Console.WriteLine(obj2);  
        }
    }
}
