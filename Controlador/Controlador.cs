using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controlador
{
    public class Controlador
    {
        Modelo.Sentencias sentencias = new Modelo.Sentencias();


        public DataTable MostrarReportes()
        {
            OdbcDataAdapter data = sentencias.DisplayUsuarios();
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }

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

        public void ABC(TextBox[] textBoxs, string funcion)
        {
            string sql = string.Empty;
            string columnasTemp = "";
            string valoresTemp = "";
            foreach (TextBox textBox in textBoxs)
            {
                string columna = textBox.Tag.ToString();
                string valor = textBox.Text;
                switch (funcion)
                {
                    case "insert":
                        columnasTemp = columnasTemp + columna + ",";
                        valoresTemp = valoresTemp + "'" +valor + "',";
                        break;

                    case "delete":
                        break;

                    case "update":
                        sql += columna + " = '" + valor + "', ";
                        break;
                }
            }
            if (!string.IsNullOrEmpty(sql))
            {
                sql = sql.Substring(0, sql.Length - 2);
            }

            if (!string.IsNullOrEmpty(columnasTemp))
            {
                columnasTemp = columnasTemp.Substring(0, columnasTemp.Length - 1);
                valoresTemp = valoresTemp.Substring(0, valoresTemp.Length - 1);
            }
            switch (funcion)
            {
                case "insert":
                    sql = "insert into usuarios (" + columnasTemp + ") values(" + valoresTemp + ");";
                    sentencias.ejecutarSentecias(sql);
                    break;

                case "delete":
                    sql = "DELETE FROM usuarios WHERE id = '" + textBoxs[0].Text + "';";
                    sentencias.ejecutarSentecias(sql);
                    break;

                case "update":
                    sql = "UPDATE usuarios SET "+sql + " WHERE id='" + textBoxs[0].Text + "';";
                    sentencias.ejecutarSentecias(sql);
                    break;
            }
        }

    }
}
