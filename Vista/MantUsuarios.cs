using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class MantUsuarios : Form
    {
        Controlador.Controlador controlador = new Controlador.Controlador();
        public MantUsuarios()
        {
            InitializeComponent();
            displayDatos();
        }

        void displayDatos()
        {
            DataTable data = controlador.MostrarReportes();
            usuarios.DataSource = data;
            usuarios.Columns[0].HeaderText = "Id";
            usuarios.Columns[1].HeaderText = "Username";
            usuarios.Columns[2].HeaderText = "Passwod";
            usuarios.Columns[3].HeaderText = "Nombre";
            usuarios.Columns[4].HeaderText = "Apellido";
            usuarios.Columns[5].HeaderText = "Dpi";
            usuarios.Columns[6].HeaderText = "Edad";
            usuarios.Columns[7].HeaderText = "Estado";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox[] arrayTextbox = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8 };
            controlador.ABC(arrayTextbox,"insert");
            displayDatos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBox[] arrayTextbox = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8 };
            controlador.ABC(arrayTextbox, "update");
            displayDatos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TextBox[] arrayTextbox = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8 };
            controlador.ABC(arrayTextbox, "delete");
            displayDatos();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            TextBox[] arrayTextbox = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8 };

            foreach (TextBox textBox in arrayTextbox)
            {
                textBox.Text = "";
            }
        }

        private void usuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = usuarios.Rows[e.RowIndex];

                textBox1.Text = filaSeleccionada.Cells[0].Value.ToString();
                textBox2.Text = filaSeleccionada.Cells[1].Value.ToString();
                textBox3.Text = filaSeleccionada.Cells[2].Value.ToString();
                textBox4.Text = filaSeleccionada.Cells[3].Value.ToString();
                textBox5.Text = filaSeleccionada.Cells[4].Value.ToString();
                textBox6.Text = filaSeleccionada.Cells[5].Value.ToString();
                textBox7.Text = filaSeleccionada.Cells[6].Value.ToString();
                textBox8.Text = filaSeleccionada.Cells[7].Value.ToString();
            }
        }
    }
}
