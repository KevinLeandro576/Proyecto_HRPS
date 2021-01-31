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

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            MenuPerfilesEmpleado menuPerfilesEmpleado = new MenuPerfilesEmpleado();
            this.Hide();
            menuPerfilesEmpleado.Show();
        }

        private void VerSalario()
        {
            string cedula = Empleado.Cedula;
            textBoxDeCedula.Text = cedula;

            decimal salario = Empleado.Salario;
            decimal salarioPorHora = Empleado.SalarioPorHora;
            decimal horasExtraDelMes = 0.00M;
            decimal pagoDeHorasExtra = 0.00M;
            decimal deducciones = 0.00M;
            decimal salarioNeto = 0.00M;
            var conexion = AbrirBaseDeDatos();
            var comando = conexion.GetStoredProcCommand("EMPLEADO_VER_SALARIO", cedula);
            using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
            {
                if (informacionEncontrada.Read())
                {
                    salario = informacionEncontrada.GetDecimal(0);
                    textBoxDeSalarioBruto.Text = salario.ToString();
                    horasExtraDelMes = informacionEncontrada.GetDecimal(1);
                    pagoDeHorasExtra = horasExtraDelMes * (salarioPorHora * 1.5M);
                    textBoxDePagoDeHorasExtra.Text = pagoDeHorasExtra.ToString("F2");
                    deducciones = (salario + pagoDeHorasExtra) * 0.13M;
                    textBoxDeDeducciones.Text = deducciones.ToString("F2");
                    salarioNeto = salario + pagoDeHorasExtra - (deducciones);
                    textBoxDeSalarioNeto.Text = salarioNeto.ToString("F2");
                }
                else
                {
                    textBoxDeSalarioBruto.Text = salario.ToString();
                    horasExtraDelMes = 0;
                    pagoDeHorasExtra = horasExtraDelMes * (salarioPorHora * 1.5M);
                    textBoxDePagoDeHorasExtra.Text = pagoDeHorasExtra.ToString("F2");
                    deducciones = salario * 0.13M;
                    textBoxDeDeducciones.Text = deducciones.ToString("F2");
                    salarioNeto = salario + pagoDeHorasExtra - (deducciones);
                    textBoxDeSalarioNeto.Text = salarioNeto.ToString("F2");
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
            textBoxDeCedula.Enabled = false;
            textBoxDeSalarioBruto.Enabled = false;
            textBoxDePagoDeHorasExtra.Enabled = false;
            textBoxDeDeducciones.Enabled = false;
            textBoxDeSalarioNeto.Enabled = false;
            VerSalario();
        }

        private void EmpleadoVerSalario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
