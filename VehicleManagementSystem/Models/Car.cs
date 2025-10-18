using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagementSystem.Models
{
    internal class Car: Vehicle
    {
        public double EngineCapacity { get; set; }

        public override double CalculateRentalPrice(int numberOfDays)
        {
            return numberOfDays * (Year / 10);
        }

        public override string ToString()
        {
           
            return base.ToString() +
                   $", Engine Capacity: {EngineCapacity}";
        }
    }
}
