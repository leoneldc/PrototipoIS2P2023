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
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void MDI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MDI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void mantUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.MantUsuarios mantUsuarios = new Vista.MantUsuarios();
            mantUsuarios.MdiParent = this;
            mantUsuarios.Show();
        }
    }
}
