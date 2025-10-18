using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagementSystem.Models
{
    internal class Motorcycle: Vehicle
    {
        public double weight { get; set; }

        public override double CalculateRentalPrice(int numberOfDays)
        {
            return numberOfDays * (Year / 100);
        }

        public override string ToString()
        {

            return base.ToString() +
                   $",Weight: {weight}";
        }
    }
}
