using ConstruccionProyecto.Model.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstruccionProyecto.Model.Interfaces
{
    internal interface IGetVehicleListBy
    {
        List<Vehicle> getListByPlate();
    }
}
