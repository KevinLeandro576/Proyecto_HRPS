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
    public partial class EmpleadoInicioDeSesion : Form
    {
        public EmpleadoInicioDeSesion()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            MenuInicial menuInicial = new MenuInicial();
            this.Hide();
            menuInicial.Show();
        }

        private void botonDeIniciarSesion_Click(object sender, EventArgs e)
        {
            string cedula = textBoxDeCedula.Text;
            var conexion = AbrirBaseDeDatos();
            var comando = conexion.GetStoredProcCommand("SACAR_INFORMACION_DE_EMPLEADO", cedula);
            using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
            {
                if (informacionEncontrada.Read())
                {
                    Empleado.Cedula = cedula;
                    Empleado.Nombre = informacionEncontrada["NOMBRE"].ToString();
                    Empleado.Horario = informacionEncontrada["HORARIO"].ToString();
                    Empleado.Tiempo = informacionEncontrada["TIEMPO"].ToString();
                    Empleado.FechaDeNacimiento = DateTime.Parse(informacionEncontrada["FECHA_NAC"].ToString());
                    Empleado.Salario = decimal.Parse(informacionEncontrada["SALARIO"].ToString());
                    Empleado.Puesto = informacionEncontrada["PUESTO"].ToString();
                    Empleado.Correo = informacionEncontrada["CORREO"].ToString();
                    Empleado.Contrasena = informacionEncontrada["CONTRASENNA"].ToString();
                    MenuDeEmpleado menuDeEmpleado = new MenuDeEmpleado();
                    this.Hide();
                    menuDeEmpleado.Show();
                }
                else
                {
                    EmpleadoInicioDeSesion empleadoInicioDeSesion = new EmpleadoInicioDeSesion();
                    this.Hide();
                    empleadoInicioDeSesion.Show();
                }
            }
        }
        public Database AbrirBaseDeDatos()
        {
            var connectionString = @"Server=tcp:servidor-de-hr-payroll-system.database.windows.net,1433;Initial Catalog=HR_PAYROLL_SYSTEM;Persist Security Info=False;User ID=Kevin;Password=Leandro123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            return new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(connectionString);
        }

        private void EmpleadoInicioDeSesion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
