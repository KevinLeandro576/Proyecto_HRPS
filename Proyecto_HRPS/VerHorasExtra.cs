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
    public partial class VerHorasExtra : Form
    {
        public VerHorasExtra()
        {
            InitializeComponent();
        }

        private void VerHorasExtra_Load(object sender, EventArgs e)
        {

        }

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            ControlDeEmpleados controlDeEmpleados = new ControlDeEmpleados();
            this.Hide();
            controlDeEmpleados.Show();
        }

        private void textBoxDeCedula_Enter(object sender, EventArgs e)
        {

        }
    }
}
