using ConstruccionProyecto.Model.Entitys;
using ConstruccionProyecto.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstruccionProyecto.Repositories
{
    internal class DriverRepository : IManagement<Driver>, IGetDriverListBy
    {
        public bool create(Driver driver)
        {
            throw new NotImplementedException();
        }

        public bool delete(Driver driver)
        {
            throw new NotImplementedException();
        }

        public List<Driver> getList()
        {
            throw new NotImplementedException();
        }

        public List<Driver> getListByDni()
        {
            throw new NotImplementedException();
        }

        public List<Driver> getListByName()
        {
            throw new NotImplementedException();
        }

        public bool read(Driver driver)
        {
            throw new NotImplementedException();
        }

        public bool update(Driver driver)
        {
            throw new NotImplementedException();
        }
    }
}
