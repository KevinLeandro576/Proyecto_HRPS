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
    public partial class MenuInicial : Form
    {
        public MenuInicial()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmpleadoInicioDeSesion empleadoInicioDeSesion = new EmpleadoInicioDeSesion();
            this.Hide();
            empleadoInicioDeSesion.Show();
        }

        private void botonDeAdministrador_Click(object sender, EventArgs e)
        {
            AdministradorInicioDeSesion administradorInicioDeSesion = new AdministradorInicioDeSesion();
            administradorInicioDeSesion.Show();
            this.Hide(); //Ocultar pantalla actual (menu inicial)            
        }
    }
}
