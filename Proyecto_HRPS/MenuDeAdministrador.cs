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
    public partial class MenuDeAdministrador : Form
    {
        public MenuDeAdministrador()
        {
            InitializeComponent();
        }

        private void MenuDeAdministrador_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void botonDePerfilesDeUsuario_Click(object sender, EventArgs e)
        {
            PerfilesDeUsuario perfilesDeUsuario = new PerfilesDeUsuario();
            this.Hide();
            perfilesDeUsuario.Show();
        }

        private void botonDeControlDeEmpleados_Click(object sender, EventArgs e)
        {
            ControlDeEmpleados controlDeEmpleados = new ControlDeEmpleados();
            this.Hide();
            controlDeEmpleados.Show();
        }

        private void botonDeSolicitudes_Click(object sender, EventArgs e)
        {
            AdminstradorEscogerSolicitud adminstradorEscogerSolicitud = new AdminstradorEscogerSolicitud();
            this.Hide();
            adminstradorEscogerSolicitud.Show();
        }

        private void botonDeReportes_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            this.Hide();
            reportes.Show();
        }

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            AdministradorInicioDeSesion administradorInicioDeSesion = new AdministradorInicioDeSesion();
            this.Hide();
            administradorInicioDeSesion.Show();
        }
    }
}
