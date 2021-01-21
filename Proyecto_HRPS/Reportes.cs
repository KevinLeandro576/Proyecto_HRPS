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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void enlaceDeVerSalariosDeEmpleados_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VerSalarioEmpleados verSalarioEmpleados = new VerSalarioEmpleados();
            this.Hide();
            verSalarioEmpleados.Show();
        }

        private void enlaceDeVerReportesDiarios_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void enlaceDeVerVacacionesDeEmpleados_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void enlaceDeVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MenuDeAdministrador menuDeAdministrador = new MenuDeAdministrador();
            this.Hide();
            menuDeAdministrador.Show();
        }
    }
}
