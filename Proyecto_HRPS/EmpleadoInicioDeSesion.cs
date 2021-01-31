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
using System.Security.Cryptography;

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
            comprobarContrasenna();
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

        private void linkLabelDeRecuperarPW_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EmpleadoRecuperarContrasenna recuperar = new EmpleadoRecuperarContrasenna();
            this.Hide();
            recuperar.Show();
        }

        private void iniciarSesion()
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

        private void comprobarContrasenna()
        {
            string cedula = textBoxDeCedula.Text;
            string contrasenna = textBoxDeContrasena.Text;
            string contrasennaEncriptada = encriptarClaveAsha256(contrasenna);
            var conexion = AbrirBaseDeDatos();
            var comando = conexion.GetStoredProcCommand("EMPLEADO_INICIO_SESION", cedula, contrasennaEncriptada);
            using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
            {
                if (informacionEncontrada.Read())
                {
                    iniciarSesion();
                }
                else
                {
                    MessageBox.Show("Cédula o contraseña incorrectas, favor volver a intentar");
                }
            }
        }

        public static string encriptarClaveAsha256(string clave)
        {
            using (var sha256 = new SHA256Managed())
            {
                return BitConverter.ToString(sha256.ComputeHash(Encoding.UTF8.GetBytes(clave))).Replace("-", "");
            }
        }
    }
}
