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

        public OdbcDataAdapter DisplayUsuarios()// metodo  que obtinene el contenio de la tabla reportes
        {
            string sql = "SELECT * FROM usuarios ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter();
            try
            {
                dataTable = new OdbcDataAdapter(sql, conexion.conexion());
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla usuarios");
            }
            return dataTable;
        }

        public OdbcDataAdapter queryUser(string user)
        {
            string sql = "SELECT * FROM usuarios WHERE username = ?";
            OdbcCommand command = new OdbcCommand(sql, conexion.conexion());
            command.Parameters.AddWithValue("username", user);
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter(command);
            return dataAdapter;
        }

        public void ejecutarSentecias(string sql)
        {
            Console.WriteLine(sql);
            try
            {
                OdbcCommand command = new OdbcCommand(sql, conexion.conexion());
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("error con la setencias" + sql + "\n"+e);
            }
        }

    }
}
