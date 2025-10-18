using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagementSystem.Models
{
    internal abstract class Vehicle
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int MaxSpeed { get; set; }


        public abstract double CalculateRentalPrice(int numberOfDays);
        public override string ToString()
        {
           
            return $"[ID: {Id}] " +
                   $"Type: {this.GetType().Name}, " + 
                   $"Brand: {Brand}, " +
                   $"Model: {Model}, " +
                   $"Year: {Year}, " +
                   $"Max Speed: {MaxSpeed} km/h";
        }
    }
}
