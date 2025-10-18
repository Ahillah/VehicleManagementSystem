using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementSystem.Models;

namespace VehicleManagementSystem
{
    internal class Helper
    {
        public static string TakeString(string text)
        {
            string? result;
            do
            {
                Console.WriteLine(text);
                result = Console.ReadLine();
            } while (result is null);
            return result;
        }
        public static int TakeInteger(string text)
        {
            int result;

            do
            {
                Console.WriteLine(text);

            }
            while (!(int.TryParse(Console.ReadLine(), out result)));
            return result;
        }

        public static double TakeDouble(string text)
        {
            double result;

            do
            {
                Console.WriteLine(text);

            }
            while (!(double.TryParse(Console.ReadLine(), out result)));
            return result;
        }
        public static void Display(List<Vehicle> vehicles)
        {
            foreach (var v in vehicles)
                Console.WriteLine(v.ToString());
        }
        public static void TakeBasicData(Vehicle v)
        {
        
            v.Brand = TakeString("Enter the Brand:");
            v.Model = TakeString("Enter the Model:");
           
           
            v.Year = TakeInteger("Enter the Year:");
            v.MaxSpeed = TakeInteger("Enter the Max Speed (km/h):");
        }
    }
}
