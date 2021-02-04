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
        private void MenuDeEmpleado_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void botonDePerfil_Click(object sender, EventArgs e)
        {
            MenuPerfilesEmpleado menuPerfilesEmpleado = new MenuPerfilesEmpleado();
            this.Hide();
            menuPerfilesEmpleado.Show();
        }

        private void botonDeVerHorasExtra_Click(object sender, EventArgs e)
        {
            EmpleadoVerHorasExtra empleadoVerHorasExtra = new EmpleadoVerHorasExtra();
            this.Hide();
            empleadoVerHorasExtra.Show();
        }

        private void botonDeSolicitudes_Click(object sender, EventArgs e)
        {
            SolicitudesEmpleados solicitudesEmpleados = new SolicitudesEmpleados();
            this.Hide();
            solicitudesEmpleados.Show();
        }

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            EmpleadoInicioDeSesion empleadoInicioDeSesion = new EmpleadoInicioDeSesion();
            this.Hide();
            empleadoInicioDeSesion.Show();
        }
    }
}
