using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstruccionProyecto.Repositories.DB
{
    internal class ConnectionDB
    {
        private SqlConnection connectionString = new SqlConnection("server=(local); database=CAMIONCITO_SERVER; integrated security=true; Uid = sa; Pwd=sa");

        public SqlConnection openConnection()
        {
            if (connectionString.State == System.Data.ConnectionState.Closed)
                connectionString.Open();
            return connectionString;
        }

        public SqlConnection closeConnection()
        {
            if (connectionString.State == System.Data.ConnectionState.Open)
                connectionString.Close();
            return connectionString;

        }
    }
}
