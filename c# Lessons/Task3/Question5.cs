using System;

namespace Task3
{
    public static class Question5
    {
        //Question 5: What are partial classes?
        //A split class definition, will be compiled as one class at runtime. Can access all the methonds from a single object call.


        partial class Class1{
            public void Function1(){
                Console.WriteLine("Function 1 ");
            }
        }
        partial class Class1{
            public void Function2(){
                Console.WriteLine("Function 2 ");
            }
        }

        static partial class Class2{
            public static void Function1(){
                Console.WriteLine("Function 1 ");
            }
        }
        static partial class Class2{
            public static void Function2(){
                Console.WriteLine("Function 2 ");
            }
        }

        public static void RunQuestion(){
            Class1 obj = new Class1();
            obj.Function1();
            obj.Function2();

            Class2.Function1();
            Class2.Function2();

        }
    }
}