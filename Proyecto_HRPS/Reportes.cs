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

        private void botonDeVerSalariosDeEmpleados_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void botonDeVevReportesDiarios_Click(object sender, EventArgs e)
        {
            VerReporteHorasExtra verReporteHorasExtra = new VerReporteHorasExtra();
            this.Hide();
            verReporteHorasExtra.Show();
        }

        private void botonDeVerVacacionesDeEmpleados_Click(object sender, EventArgs e)
        {
            VerReporteVacaciones verReporteVacaciones = new VerReporteVacaciones();
            this.Hide();
            verReporteVacaciones.Show();
        }

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            MenuDeAdministrador menuDeAdministrador = new MenuDeAdministrador();
            this.Hide();
            menuDeAdministrador.Show();
        }
    }
}
