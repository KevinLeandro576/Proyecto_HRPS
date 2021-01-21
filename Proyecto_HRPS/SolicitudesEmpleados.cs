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
    public partial class SolicitudesEmpleados : Form
    {
        public SolicitudesEmpleados()
        {
            InitializeComponent();
        }

        private void enlaceDeVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MenuDeEmpleado menuDeEmpleado = new MenuDeEmpleado();
            this.Hide();
            menuDeEmpleado.Show();
        }

        private void enlaceDeSolicitarVacaciones_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SolicitudesVacaciones solicitudesVacaciones = new SolicitudesVacaciones();
            this.Hide();
            solicitudesVacaciones.Show();
        }

        private void enlaceDeRegistrarHorasExtras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SolicitudesHorasExtra solicitudesHorasExtra = new SolicitudesHorasExtra();
            this.Hide();
            solicitudesHorasExtra.Show();
        }
    }
}
