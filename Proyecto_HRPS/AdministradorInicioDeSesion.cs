using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_HRPS
{
    public partial class AdministradorInicioDeSesion : Form
    {
        public AdministradorInicioDeSesion()
        {
            InitializeComponent();
        }

        private void botonDeIniciarSesion_Click(object sender, EventArgs e)
        {
            MenuDeAdministrador menuDeAdministrador = new MenuDeAdministrador();
            Empleado.Cedula = textBoxDeCedula.Text;
            this.Hide();
            menuDeAdministrador.Show();
        }

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            MenuInicial menuInicial = new MenuInicial();
            this.Hide();
            menuInicial.Show();
        }
    }
}
