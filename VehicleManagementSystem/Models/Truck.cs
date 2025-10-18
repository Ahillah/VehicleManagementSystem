using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagementSystem.Models
{
    internal class Truck: Vehicle
    {
        public int NumberOfTrailers { get; set; }

        public override double CalculateRentalPrice(int numberOfDays)
        {
           return numberOfDays* (Year/10)*NumberOfTrailers;
        }

        public override string ToString()
        {


            return base.ToString() +
                   $", Number Of Trailers: {NumberOfTrailers}";
        }
    }

}
