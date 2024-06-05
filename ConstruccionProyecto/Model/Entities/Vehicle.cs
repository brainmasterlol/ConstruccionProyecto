using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConstruccionProyecto.Model.Entitys
{
    public class Vehicle
    {
        private int vehicleId { get; set; }
        private string plate { get; set; }
        private string model { get; set; }
        private double mileage { get; set; }
        private double fuelConsumption { get; set; }
        private DateTime manufacturingDate { get; set; }

        public Vehicle() { }

        public Vehicle(int vehicleId, string plate, string model, double mileage, double fuelConsumption, DateTime manufacturingDate)
        {
            this.vehicleId = vehicleId;
            this.plate = plate;
            this.model = model;
            this.mileage = mileage;
            this.fuelConsumption = fuelConsumption;
            this.manufacturingDate = manufacturingDate;
        }
    }
}
