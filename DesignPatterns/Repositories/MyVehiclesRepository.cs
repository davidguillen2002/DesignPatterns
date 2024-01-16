using DesignPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatterns.Infraestructure.Singletons;


namespace DesignPatterns.Repositories
{
    public class MyVehiclesRepository : IVehicleRepository
    {
        private readonly VehicleMemoryCollection _memoryCollection = VehicleMemoryCollection.Instance;

        public MyVehiclesRepository()
        {

        }

        public void AddVehicle(Vehicle vehicle)
        {
            _memoryCollection.Vehicles.Add(vehicle); // Modificado para usar la propiedad Vehicles
        }

        public Vehicle Find(string id)
        {
            return _memoryCollection.Vehicles.FirstOrDefault(v => v.ID.Equals(new Guid(id))); // Modificado para usar la propiedad Vehicles
        }

        public ICollection<Vehicle> GetVehicles()
        {
            return _memoryCollection.Vehicles; // Devuelve directamente la colección de vehículos
        }
    }



}

