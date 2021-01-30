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
    public partial class MenuDeEmpleado : Form
    {
        public MenuDeEmpleado()
        {
            InitializeComponent();
        }

        private void enlaceDeVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EmpleadoInicioDeSesion empleadoInicioDeSesion = new EmpleadoInicioDeSesion();
            this.Hide();
            empleadoInicioDeSesion.Show();
        }

        private void enlaceDePerfiles_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MenuPerfilesEmpleado menuPerfilesEmpleado = new MenuPerfilesEmpleado();
            this.Hide();
            menuPerfilesEmpleado.Show();
        }

        private void enlaceDeVerHorasExtras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EmpleadoVerHorasExtra empleadoVerHorasExtra = new EmpleadoVerHorasExtra();
            this.Hide();
            empleadoVerHorasExtra.Show();
        }

        private void enlaceDeSolicitudes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SolicitudesEmpleados solicitudesEmpleados = new SolicitudesEmpleados();
            this.Hide();
            solicitudesEmpleados.Show();
        }

        private void MenuDeEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void MenuDeEmpleado_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
