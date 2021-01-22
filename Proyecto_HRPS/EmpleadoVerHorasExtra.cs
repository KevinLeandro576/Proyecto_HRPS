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

        private void botonDeBuscar_Click(object sender, EventArgs e)
        {
            string cedula = textBoxDeCedula.Text;
            var conexion = AbrirBaseDeDatos();
            var comando = conexion.GetStoredProcCommand("EMPLEADO_VER_HORAS_EXTRAS", cedula);
            using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
            {
                if (informacionEncontrada.Read())
                {
                    decimal cantidadDeHoras = decimal.Parse(informacionEncontrada.GetDecimal(0).ToString());
                    textBoxDeHorasExtra.Text = cantidadDeHoras.ToString();
                }
            }
        }
        public Database AbrirBaseDeDatos()
        {
            var connectionString = @"Server=tcp:servidor-de-hr-payroll-system.database.windows.net,1433;Initial Catalog=HR_PAYROLL_SYSTEM;Persist Security Info=False;User ID=Kevin;Password=Leandro123;MultipleActiveResultSets=True;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            return new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(connectionString);
        }

        private void EmpleadoVerHorasExtra_Load(object sender, EventArgs e)
        {
            textBoxDeHorasExtra.Enabled = false;
        }
    }
}
