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
        private void botonDeSolicitarVacaciones_Click(object sender, EventArgs e)
        {
            SolicitudesVacaciones solicitudesVacaciones = new SolicitudesVacaciones();
            this.Hide();
            solicitudesVacaciones.Show();
        }

        private void botonDeRegistrarHorasExtra_Click(object sender, EventArgs e)
        {
            SolicitudesHorasExtra solicitudesHorasExtra = new SolicitudesHorasExtra();
            this.Hide();
            solicitudesHorasExtra.Show();
        }

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            MenuDeEmpleado menuDeEmpleado = new MenuDeEmpleado();
            this.Hide();
            menuDeEmpleado.Show();
        }
    }
}
