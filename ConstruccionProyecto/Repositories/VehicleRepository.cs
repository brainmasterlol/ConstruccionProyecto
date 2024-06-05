using ConstruccionProyecto.Model.Entitys;
using ConstruccionProyecto.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstruccionProyecto.Repositories
{
    internal class VehicleRepository : IManagement<Vehicle>, IGetVehicleListBy
    {
        public bool create(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public bool delete(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public List<Vehicle> getList()
        {
            throw new NotImplementedException();
        }

        public List<Vehicle> getListByPlate()
        {
            throw new NotImplementedException();
        }

        public bool read(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public bool update(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }
    }
}
