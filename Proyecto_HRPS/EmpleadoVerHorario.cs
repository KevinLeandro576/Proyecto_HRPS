using Microsoft.Practices.EnterpriseLibrary.Data;
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
    public partial class EmpleadoVerHorario : Form
    {
        public EmpleadoVerHorario()
        {
            InitializeComponent();
            textBoxDeHorario.Enabled = false;
        }

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            MenuPerfilesEmpleado menuPerfilesEmpleado = new MenuPerfilesEmpleado();
            this.Hide();
            menuPerfilesEmpleado.Show();
        }

        private void botonDeBuscar_Click(object sender, EventArgs e)
        {

        }

        public Database AbrirBaseDeDatos()
        {
            var connectionString = @"Server=tcp:servidor-de-hr-payroll-system.database.windows.net,1433;Initial Catalog=HR_PAYROLL_SYSTEM;Persist Security Info=False;User ID=Kevin;Password=Leandro123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            return new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(connectionString);
        }

        private void EmpleadoVerHorario_Load(object sender, EventArgs e)
        {
            textBoxDeCedula.Text = Empleado.Cedula;
            textBoxDeHorario.Text = Empleado.Horario;
        }

        private void EmpleadoVerHorario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
