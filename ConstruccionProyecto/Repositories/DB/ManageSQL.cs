using ConstruccionProyecto.Model.Parameters;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstruccionProyecto.Repositories.DB
{
    public class ManageSQL
    {
        private ConnectionDB connection = new ConnectionDB();

        public DataTable runSPQuery(string nameSP, List<Parameters> list)
        {
            var command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = nameSP;
            foreach (var parameter in list)
            {
                command.Parameters.Add(parameter.parameterName, parameter.parameterType).Value = parameter.parameterValue;
            }

            command.Connection = connection.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            using (var table = new DataTable())
            {
                table.Load(reader);
                reader.DisposeAsync();
                connection.closeConnection();
                return table;
            }
        }

        public List<string?> runSPQueryLogin(string nameSP, string columnName, List<Parameters> list)
        {
            var command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = nameSP;
            foreach (var parameter in list)
            {
                command.Parameters.Add(parameter.parameterName, parameter.parameterType).Value = parameter.parameterValue;
            }
            command.Connection = connection.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            using (var table = new DataTable())
            {
                table.Load(reader);
                reader.DisposeAsync();
                connection.closeConnection();
                List<string?> objectList = table.AsEnumerable()
                    .Select(row => row.Field<string>(columnName))
                    .ToList();
                return objectList;
            }
        }

        public bool runSPNonQuery(string nameSP, List<Parameters> list)
        {
            var command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = nameSP;
            foreach (var parameter in list)
            {
                command.Parameters.Add(parameter.parameterName, parameter.parameterType).Value = parameter.parameterValue;
            }
            command.Connection = connection.openConnection();
            var result = command.ExecuteNonQuery();
            connection.closeConnection();
            if (result > 0)
                return true;
            else return false;
        }
    }
}
