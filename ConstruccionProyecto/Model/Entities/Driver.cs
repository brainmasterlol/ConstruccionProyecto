using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstruccionProyecto.Model.Entitys
{
    public class Driver
    {
        private int driverId { get; set; }
        private String firstName { get; set; }
        private String lastName { get; set; }
        private String dni { get; set; }
        private String phoneNumber { get; set; }
        private String address { get; set; }
        private String typeOfLicense { get; set; }
        private DateTime birthDate { get; set; }
        private Vehicle vehicle { get; set; }

        public Driver() { }

        public Driver(int driverId, string firstName, string lastName, string dni, string phoneNumber, string address, string typeOfLicense, DateTime birthDate, Vehicle vehicle)
        {
            this.driverId = driverId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dni = dni;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.typeOfLicense = typeOfLicense;
            this.birthDate = birthDate;
            this.vehicle = vehicle;
        }
    }
}
