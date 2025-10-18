using VehicleManagementSystem.Models;
using VehicleManagementSystem.Services;
using static System.Net.Mime.MediaTypeNames;

namespace VehicleManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VehicleRepository repository = new VehicleRepository();
            do
            {
                Console.WriteLine("Please Enter the corresponding number:" +
          "\n1. View All Vehicles" +
          "\n2. Search by Brand" +
          "\n3. Search by Type" +
          "\n4. Add New Vehicle" +
          "\n5. Remove Vehicle by ID" +
          "\n6. Calculate Rental Price by ID" +
          "\n7. Exit");
                int result;
                do
                {
                    result = Helper.TakeInteger("Enter a valied choose");

                } while (result < 1 || result > 7);

                switch (result)
                {
                    case 1:
                        {
                            List<Vehicle> vehicles = repository.GetAll();
                            if (vehicles.Count == 0 || vehicles is null)
                            {
                                Console.WriteLine("No Vehicle to display");
                            }
                            else
                            {
                                Helper. Display(vehicles);

                            }
                        }
                        break;
                    case 2:
                        {

                            string brand = Helper.TakeString("Enter a valid brand");
                           
                            List<Vehicle>? vehicles = repository.SerchByBrand(brand);
                            if (vehicles is null || vehicles.Count == 0)
                                Console.WriteLine("No vehicle has this brand");
                            else
                            {
                                Helper. Display(vehicles);
                            }

                        }
                        break;
                        case 3:
                        {
                            string type = Helper.TakeString("Enter a valid type");
                            List<Vehicle>? vehicles =repository.SerchByType(type);

                            if (vehicles is null || vehicles.Count == 0)
                                Console.WriteLine("No vehicle has this brand");
                            else
                            {
                                Helper.Display(vehicles);
                            }

                        }
                        break;

                        case 4:
                        {
                            Console.WriteLine("Which vehicle type would you like to add?");
                            Console.WriteLine("1. Car \n2. Truck \n3. Motorcycle");

                            int typeChoice = Helper.TakeInteger("Enter the number (1, 2, or 3):");
                            if (typeChoice == 1)
                            {
                                Car car = new Car();
                                Helper.TakeBasicData(car);
                               
                                car.EngineCapacity = Helper.TakeDouble("Enter the Engine Capacity");
                                bool isCompled = repository.Add(car);
                                if (isCompled)
                                    Console.WriteLine("Car is Added");
                                else
                                    Console.WriteLine("Error is occure");



                            }
                            else if (typeChoice == 2)
                            {
                                Truck truck = new Truck();
                                Helper.TakeBasicData(truck);
                          
                                truck.NumberOfTrailers = Helper.TakeInteger("Enter Number of trailers");
                                bool isCompled = repository.Add(truck);
                                if (isCompled)
                                    Console.WriteLine("Truck is Added");
                                else
                                    Console.WriteLine("Error is occure");

                            }
                            else if (typeChoice == 3)
                            {
                                Motorcycle motorcycle = new Motorcycle();
                                Helper.TakeBasicData(motorcycle);
                        
                                motorcycle.weight = Helper.TakeDouble("Enter weight");
                                bool isCompled = repository.Add(motorcycle);
                                if (isCompled)
                                    Console.WriteLine("motorcycle is Added");
                                else
                                    Console.WriteLine("Error is occure");
                            }
                            else
                                Console.WriteLine("invalid Choose");
                            break;
                        }

                    case 5:
                        {
                            int id = Helper.TakeInteger("Enter Id of vehicle that yoy want to remove");
                            bool isDeleted= repository.Remove(id);
                            if (isDeleted)
                                Console.WriteLine("Vehicle is deleted");
                            else Console.WriteLine("Can not delete this vehicle (no vehicle has this id)");


                        }

                        break;

                    case 6:
                        {
                            int numberofDay = Helper.TakeInteger("Enter number of days you want to rental the vehicle ");
                            int id = Helper.TakeInteger("Enter Id of vehicle that yoy want to rental");
                            double price =repository.CalculateRentalPrice(id, numberofDay);
                            if (price > 0)
                            {
                                Console.WriteLine($"\n[Calculation] Total rental price is: {price:C}");
                            }
                            else
                            {
                                
                                Console.WriteLine($"Error: Vehicle with ID {id} not found or invalid rental period.");
                            }

                        }
                        break;
                    case 7:
                        return;
                  

                }
             

            }
            while (true);
        }


      
    }
}