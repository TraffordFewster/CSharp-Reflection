using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class Car
    {

        private string Make { get; set; }
        private string Model { get; set; }
        private string Registration { get; set; }
        private string YearOfRegistration { get; set; }
        private decimal CurrentValue { get; set; }

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
        public string Value()
        {
            return CurrentValue.ToString("C2");
        }

        public string Year()
        {
            return YearOfRegistration;
        }
        public override string ToString()
        {
            return $"The {Make} {Model} with the registration of '{Registration}' was registered in {YearOfRegistration} and has a value of {Value()}";
        }

    }
}
