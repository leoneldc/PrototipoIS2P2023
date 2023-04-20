using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Sentencias
    {
        Conexion conexion = new Conexion();

        public OdbcDataAdapter queryUser(string user)
        {
            string sql = "SELECT * FROM usuarios WHERE username = ?";
            OdbcCommand command = new OdbcCommand(sql, conexion.conexion());
            command.Parameters.AddWithValue("username", user);
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter(command);
            return dataAdapter;
        }
    }
}
