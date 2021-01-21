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

        private void enlaceDeVerHorario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EmpleadoVerHorario empleadoVerHorario = new EmpleadoVerHorario();
            this.Hide();
            empleadoVerHorario.Show();
        }

        private void enlaceDeVerSalario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EmpleadoVerSalario empleadoVerSalario = new EmpleadoVerSalario();
            this.Hide();
            empleadoVerSalario.Show();
        }

        private void enlaceDeVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MenuDeEmpleado menuDeEmpleado = new MenuDeEmpleado();
            this.Hide();
            menuDeEmpleado.Show();
        }

        private void enlaceDeVerPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EmpleadoVerPerfil empleadoVerPerfil = new EmpleadoVerPerfil();
            this.Hide();
            empleadoVerPerfil.Show();
        }
    }
}
