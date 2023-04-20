using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class Controlador
    {
        Modelo.Sentencias sentencias = new Modelo.Sentencias();
        public Boolean validarLogin(string usuario, string contraseña)
        {

            OdbcDataAdapter dataAdapter = sentencias.queryUser(usuario);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            foreach (DataRow row in dataTable.Rows)
            {
                string username = row["username"].ToString();
                string password = row["password"].ToString();
                if (contraseña.Equals(password))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
