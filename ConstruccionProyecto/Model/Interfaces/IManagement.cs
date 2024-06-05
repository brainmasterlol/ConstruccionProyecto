using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstruccionProyecto.Model.Interfaces
{
    internal interface IManagement<T> where T : class
    {
        bool create (T entity);
        bool read (T entity);
        bool update (T entity);
        bool delete (T entity);
        List<T> getList ();
    }
}
