using System;
using TestSpace;
namespace Lesson_2{
    class Program{
        static void Main(string[] args){
            ExtraFunctions.PrintARandomNumber();
            Car MyCar = new Car();
            MyCar.CarInfo("Model Y", "Tesla", "2020");
            Console.WriteLine(MyCar.GetAllCarInfo());
            EvenMoreFunctions.PrintARandomNumber();
        }
    }
}
