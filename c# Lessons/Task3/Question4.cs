using System;

namespace Task3
{
    public static class Question4
    {
        //Question 4: How do I inherit another class?
        // If you DONT want a class to be inherited. Use "sealed class Vehicle"
        public static void RunQuestion(){
            // Create a myCar object
            Car myCar = new Car();

            // Call the honk() method (From the Vehicle class) on the myCar object
            myCar.honk();

            // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
            Console.WriteLine(myCar.brand + " " + myCar.modelName);
        }
    }

    class Vehicle  // base class (parent) 
{
        public string brand = "Ford";  // Vehicle field
        public void honk()             // Vehicle method 
            {                    
                Console.WriteLine("Tuut, tuut!");
            }
        }

        class Car : Vehicle  // derived class (child)
        {
            public string modelName = "Mustang";  // Car field
        }
}

