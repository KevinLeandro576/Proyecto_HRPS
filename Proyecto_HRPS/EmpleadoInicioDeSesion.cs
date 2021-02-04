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
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                registrarError(ex);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            try
            {
                MenuInicial menuInicial = new MenuInicial();
                this.Hide();
                menuInicial.Show();
            }
            catch (Exception ex)
            {
                registrarError(ex);
            }
        }

        private void botonDeIniciarSesion_Click(object sender, EventArgs e)
        {
            comprobarContrasenna();
        }
        public Database AbrirBaseDeDatos()
        {
            try
            {
                var connectionString = @"Server=tcp:servidor-de-hr-payroll-system.database.windows.net,1433;Initial Catalog=HR_PAYROLL_SYSTEM;Persist Security Info=False;User ID=Kevin;Password=Leandro123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
                return new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(connectionString);
            }
            catch (Exception ex)
            {
                registrarError(ex);
                return null;
            }
        }

        private void EmpleadoInicioDeSesion_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                registrarError(ex);
            }
        }

        private void linkLabelDeRecuperarPW_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                EmpleadoRecuperarContrasenna recuperar = new EmpleadoRecuperarContrasenna();
                this.Hide();
                recuperar.Show();
            }
            catch (Exception ex)
            {
                registrarError(ex);
            }
        }

        private void iniciarSesion()
        {
            try
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
                        Empleado.SalarioPorHora = decimal.Parse(informacionEncontrada["SALARIO_HORA"].ToString());
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
            catch (Exception ex)
            {
                registrarError(ex);
            }
        }

        private void comprobarContrasenna()
        {
            try
            {
                string cedula = textBoxDeCedula.Text;
                string contrasenna = textBoxDeContrasena.Text;
                string contrasennaEncriptada = encriptarClaveAsha256(contrasenna);
                contrasennaEncriptada = contrasennaEncriptada.Substring(0, 24);
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
            catch (Exception ex)
            {
                registrarError(ex);
            }
        }

        public string encriptarClaveAsha256(string clave)
        {
            try
            {
                using (var sha256 = new SHA256Managed())
                {
                    return BitConverter.ToString(sha256.ComputeHash(Encoding.UTF8.GetBytes(clave))).Replace("-", "");
                }
            }
            catch (Exception ex)
            {
                registrarError(ex);
                return null;
            }
        }

        private void registrarError(Exception ex)
        {
            string texto = "Error: " + ex.ToString();
            string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
            var conexion = AbrirBaseDeDatos();
            var comando = conexion.GetStoredProcCommand("[INSERTAR_EVENTO]", texto,
                                                                             metodoYclase);
            conexion.ExecuteNonQuery(comando);
        }
    }
}
