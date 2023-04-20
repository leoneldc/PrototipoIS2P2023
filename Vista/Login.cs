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
    public partial class Login : Form
    {
        Controlador.Controlador controlador = new Controlador.Controlador();
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(controlador.validarLogin(user.Text, password.Text))
            {
                Vista.MDI mdi = new Vista.MDI();
                mdi.Show();
                this.Hide();
            }
        }
    }
}
