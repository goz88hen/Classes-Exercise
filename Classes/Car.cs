using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Car
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Car()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        { 
            
        }
        public Car(string makeInput, string modelInput, int yearInput) 
        { 
            Make = makeInput;
            Model = modelInput;
            Year = yearInput;
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }


}
