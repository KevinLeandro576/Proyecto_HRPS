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
    public partial class EmpleadoVerSalario : Form
    {
        public EmpleadoVerSalario()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            MenuPerfilesEmpleado menuPerfilesEmpleado = new MenuPerfilesEmpleado();
            this.Hide();
            menuPerfilesEmpleado.Show();
        }

        private void botonDeBuscar_Click(object sender, EventArgs e)
        {
            string cedula = textBoxDeCedula.Text;
            var conexion = AbrirBaseDeDatos();
            var comando = conexion.GetStoredProcCommand("EMPLEADO_VER_SALARIO", cedula);
            using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
            {
                if (informacionEncontrada.Read())
                {
                    int salario = int.Parse(informacionEncontrada["SALARIO"].ToString());
                    textBoxDeSalarioBruto.Text = salario.ToString();
                    decimal deducciones = salario * 0.13M;
                    textBoxDeDeducciones.Text = deducciones.ToString();
                    decimal salarioNeto = salario - (salario * 0.13M);
                    textBoxDeSalarioNeto.Text = salarioNeto.ToString();
                }
            }
        }
        public Database AbrirBaseDeDatos()
        {
            var connectionString = @"Server=tcp:servidor-de-hr-payroll-system.database.windows.net,1433;Initial Catalog=HR_PAYROLL_SYSTEM;Persist Security Info=False;User ID=Kevin;Password=Leandro123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            return new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(connectionString);
        }

        private void EmpleadoVerSalario_Load(object sender, EventArgs e)
        {
            textBoxDeSalarioBruto.Enabled = false;
            textBoxDeDeducciones.Enabled = false;
            textBoxDeSalarioNeto.Enabled = false;
        }
    }
}
