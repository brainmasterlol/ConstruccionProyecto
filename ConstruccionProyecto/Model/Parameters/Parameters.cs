using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstruccionProyecto.Model.Parameters
{
    public class Parameters
    {
        public string? parameterName { get; set; }
        public SqlDbType parameterType { get; set; }
        public object? parameterValue { get; set; }
    }
}
