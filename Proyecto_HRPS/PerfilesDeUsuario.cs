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
    public partial class PerfilesDeUsuario : Form
    {
        public PerfilesDeUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void enlaceDePerfilesDeUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CrearPerfilDeUsuario crearPerfilDeUsuario = new CrearPerfilDeUsuario();
            this.Hide();
            crearPerfilDeUsuario.Show();
        }

        private void enlaceDeVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MenuDeAdministrador menuDeAdministrador = new MenuDeAdministrador();
            this.Hide();
            menuDeAdministrador.Show();
        }

        private void enlaceDeVerSalario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VerSalario verSalario = new VerSalario();
            this.Hide();
            verSalario.Show();
        }

        private void enlaceDeVerEmpleados_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VerEmpleados verEmpleados = new VerEmpleados();
            this.Hide();
            verEmpleados.Show();
        }

        private void enlaceDeModificarHorario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ModificarHorario modificarHorario = new ModificarHorario();
            this.Hide();
            modificarHorario.Show();
        }

        private void enlaceDeModificarSalario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ModificarSalario modificarSalario = new ModificarSalario();
            this.Hide();
            modificarSalario.Show();
        }

        private void enlaceDeEliminarEmpleados_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EliminarEmpleados eliminarEmpleados = new EliminarEmpleados();
            this.Hide();
            eliminarEmpleados.Show();
        }
    }
}
