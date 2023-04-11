using Classes;
using System.Xml.Schema;

namespace Classes
{

    class Program
    {
       
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Audi";
            myCar.Model = "Q3";
            myCar.Year = 2020;

            var Audi = new Car()
            {
                Make = "Audi",
                Model = "A4",
                Year = 2020 
            };

            var Honda = new Car("Honda", "Civic", 2022);

            var carList = new List<Car>() { myCar, Audi, Honda, new Car (), new Car () };
           
            foreach(var vehicle in carList)
            {
                Console.WriteLine($"{ vehicle.Make} { vehicle.Model} {vehicle.Year}");
            }
        }
    }
}
