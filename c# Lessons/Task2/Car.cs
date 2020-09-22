using System;

namespace Lesson_2
{
    public class Car
    {
        public string model;
        public string brand;
        public string year;
        public void CarInfo(string _model, string _brand, string _year) {
            {
                model = _model;
                brand = _brand;
                year = _year;
            }
        }
        public string GetAllCarInfo()
        {
            return (model + ", " + brand + ", " + year).ToString();
        }
    }
}
