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
    public partial class ControlDeEmpleados : Form
    {
        public ControlDeEmpleados()
        {
            InitializeComponent();
        }

        private void enlaceDeVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MenuDeAdministrador menuDeAdministrador = new MenuDeAdministrador();
            this.Hide();
            menuDeAdministrador.Show();
        }

        private void enlaceDeCrearPerfilDeUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VerHorasExtra verHorasExtra = new VerHorasExtra();
            this.Hide();
            verHorasExtra.Show();
        }

        private void enlaceDeVerHorarios_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
    }
}
