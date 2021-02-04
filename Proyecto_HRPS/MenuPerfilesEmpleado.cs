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
    public partial class MenuPerfilesEmpleado : Form
    {
        public MenuPerfilesEmpleado()
        {
            InitializeComponent();
        }

        private void MenuPerfilesEmpleado_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void botonDeVerHorario_Click(object sender, EventArgs e)
        {
            EmpleadoVerHorario empleadoVerHorario = new EmpleadoVerHorario();
            this.Hide();
            empleadoVerHorario.Show();
        }

        private void botonDeVerPerfil_Click(object sender, EventArgs e)
        {
            EmpleadoVerPerfil empleadoVerPerfil = new EmpleadoVerPerfil();
            this.Hide();
            empleadoVerPerfil.Show();
        }

        private void botonDeVerSalario_Click(object sender, EventArgs e)
        {
            EmpleadoVerSalario empleadoVerSalario = new EmpleadoVerSalario();
            this.Hide();
            empleadoVerSalario.Show();
        }

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            MenuDeEmpleado menuDeEmpleado = new MenuDeEmpleado();
            this.Hide();
            menuDeEmpleado.Show();
        }
    }
}
