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
    public partial class EmpleadoVerHorasExtra : Form
    {
        public EmpleadoVerHorasExtra()
        {
            InitializeComponent();
        }

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            MenuDeEmpleado menuDeEmpleado = new MenuDeEmpleado();
            this.Hide();
            menuDeEmpleado.Show();
        }
    }
}
