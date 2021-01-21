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

        private void enlaceDePerfilesDeUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PerfilesDeUsuario perfilesDeUsuario = new PerfilesDeUsuario();
            this.Hide();
            perfilesDeUsuario.Show();
        }

        private void MenuDeAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void enlaceDeControlDeEmpleados_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ControlDeEmpleados controlDeEmpleados = new ControlDeEmpleados();
            this.Hide();
            controlDeEmpleados.Show();
        }

        private void enlaceDeVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdministradorInicioDeSesion administradorInicioDeSesion = new AdministradorInicioDeSesion();
            this.Hide();
            administradorInicioDeSesion.Show();
        }

        private void enlaceDeSolicitudes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Solicitudes solicitudes = new Solicitudes();
            this.Hide();
            solicitudes.Show();
        }

        private void enlaceDeReportes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reportes reportes = new Reportes();
            this.Hide();
            reportes.Show();
        }
    }
}
