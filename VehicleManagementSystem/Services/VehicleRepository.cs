using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementSystem.Models;

namespace VehicleManagementSystem.Services
{
    internal class VehicleRepository
    {   private List<Vehicle> _vehicles = new List<Vehicle>();
        public bool Add(Vehicle vehicle )
        {    if (vehicle != null)
            {

                vehicle.Id = GenerateId();
                _vehicles.Add(vehicle);
                return true;

            }
            return false;
                

        }


        public List<Vehicle> GetAll ()
        {  
            return _vehicles.ToList();

        }

        public List<Vehicle>? SerchByBrand(string brand)
        {
            if (string.IsNullOrEmpty(brand))
            {
                return new List<Vehicle>();
            }
            return _vehicles
        .Where(v => v.Brand.ToLower().Contains(brand.ToLower()))
        .ToList();


        }


        public List<Vehicle>? SerchByType(string type)
        {
            if (string.IsNullOrEmpty(type))
            {
                return new List<Vehicle>();
            }
            else
            { return _vehicles.Where(v=>v.GetType().Name.ToLower()== type.ToLower()).ToList(); }
            
        }
        public bool Remove (int id)
        {
            var V= _vehicles.FirstOrDefault(v=>v.Id== id);
            if (V != null)
            {
                _vehicles.Remove(V);
                return true;
            }

            return false;


        }
        public double CalculateRentalPrice(int id, int numberOfDays)
        {
            var V = _vehicles.FirstOrDefault(v => v.Id == id);
            if (V != null)
            {
                return V.CalculateRentalPrice(numberOfDays);
            }
            return 0;
        }
                private int GenerateId()
                {
                    if (_vehicles.Any())
                        return _vehicles.Max(v => v.Id) + 1;
                    else
                        return 1;
                }
    }
}
