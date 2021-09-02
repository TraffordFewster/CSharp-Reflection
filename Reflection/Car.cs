using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Car
    {

        public string Make { get; set; }
        public string Model { get; set; }
        public string Registration { get; set; }
        public string YearOfRegistration { get; set; }
        public decimal CurrentValue { get; set; }

        /// <summary>
        /// The car model contructor
        /// </summary>
        /// <param name="make">The make of the car</param>
        /// <param name="model">The model of the car</param>
        /// <param name="registration">The registration of the car</param>
        /// <param name="yearOfRegistration">The year the car was registered</param>
        /// <param name="currentValue">The current value of the car</param>
        public Car(string make, string model, string registration, string yearOfRegistration, decimal currentValue)
        {
            Make = make;
            Model = model;
            Registration = registration;
            YearOfRegistration = yearOfRegistration;
            CurrentValue = currentValue;
        }


    }
}
