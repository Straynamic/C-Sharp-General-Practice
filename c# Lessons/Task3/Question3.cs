using System;

namespace Task3
{
    public static class Question3
    {
        //Question 3: What is the difference between constant and readonly in C#?
        /*
            Const is nothing but "constant", a variable of which the value is constant but at compile time. It's mandatory to assign a value to it.
            By default, a const is static and we cannot change the value of a const variable throughout the entire program.
            Readonly is the keyword whose value we can change during runtime or we can assign it at run time but only through the non-static constructor.
        */
        public static void RunQuestion(){
            Test obj = new Test();    
            obj.Check();    
            //Console.ReadLine(); 
        }
    }

    class Test {    
        readonly int read = 10;    
        const int cons = 10;    
        public Test() {    
            read = 1000;    
        }    
        public void Check() {    
            Console.WriteLine("Read only : {0}", read);    
            Console.WriteLine("const : {0}", cons);    
        }  
    }
}

