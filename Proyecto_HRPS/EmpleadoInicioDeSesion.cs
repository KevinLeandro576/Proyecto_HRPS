using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_HRPS
{
    public partial class EmpleadoInicioDeSesion : Form
    {

        int numeroDeIntentos = 0;
        public EmpleadoInicioDeSesion()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            try
            {
                AdministradorInicioDeSesion02 menuInicial02 = new AdministradorInicioDeSesion02();
                this.Hide();
                menuInicial02.Show();
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }

        private void botonDeIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                comprobarContrasenna();
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
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
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
                return null;
            }
        }

        private void EmpleadoInicioDeSesion_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                const string message = "¿Desea cerrar la aplicación?";
                const string caption = "Opciones de Sesión";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNoCancel,
                                             MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Cerrando la aplicación", "Opciones de Sesión"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Environment.Exit(1);
                }
                else
                {
                    MessageBox.Show("Regresando", "Opciones de Sesión"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }

        private void linkLabelDeRecuperarPW_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                AdministradorRecuperarContrasenna recuperar = new AdministradorRecuperarContrasenna();
                this.Hide();
                recuperar.Show();
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
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
                        Empleado.CantidadDeDiasDisponibles = int.Parse(informacionEncontrada["DIAS_LIBRES"].ToString());

                        string evento = "El empleado: " + Empleado.Nombre + "; ha iniciado sesión";
                        registrarEvento(evento,
                            this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name);

                        MenuDeEmpleado menuDeEmpleado = new MenuDeEmpleado();
                        this.Hide();
                        menuDeEmpleado.Show();
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron datos al iniciar sesión."
                            , "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        EmpleadoInicioDeSesion empleadoInicioDeSesion = new EmpleadoInicioDeSesion();
                        this.Hide();
                        empleadoInicioDeSesion.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
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
                if (numeroDeIntentos != 2)
                {
                    if (validarTextBox())
                    {
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
                                MessageBox.Show("Cédula o contraseña incorrectas, por favor revisar credenciales."
                                    , "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                numeroDeIntentos = numeroDeIntentos + 1;
                            }
                        }
                    }
                }
                else
                {
                    numeroDeIntentos = 0;
                    MessageBox.Show("Ha fallado tres veces el inicio de sesión, por favor revise cédula o restablezca contraseña"
                        , "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
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
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
                return null;
            }
        }

        private void registrarError(Exception ex, string metodoYclase)
        {
            string texto = "Error: " + ex.ToString();
            var conexion = AbrirBaseDeDatos();
            var comando = conexion.GetStoredProcCommand("[INSERTAR_EVENTO]", texto,
                                                                             metodoYclase);
            conexion.ExecuteNonQuery(comando);
        }

        private void registrarEvento(string texto, string metodoYclase)
        {
            var conexion = AbrirBaseDeDatos();
            var comando = conexion.GetStoredProcCommand("[INSERTAR_EVENTO]", texto,
                                                                             metodoYclase);
            conexion.ExecuteNonQuery(comando);
        }

        private void checkBoxDeContrasena_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxDeContrasena.Checked)
                {
                    textBoxDeContrasena.PasswordChar = '\0';
                }
                else
                {
                    textBoxDeContrasena.PasswordChar = '*';
                }
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }

        private bool validarTextBox()
        {
            try
            {
                bool estaBien = false;
                if (string.IsNullOrEmpty(textBoxDeCedula.Text) || textBoxDeCedula.Text.Length != 9)
                {
                    numeroDeIntentos = numeroDeIntentos + 1;
                    textBoxDeCedula.Focus();
                    estaBien = false;
                    MessageBox.Show("Revise cédula", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!soloTieneNumeros(textBoxDeCedula.Text))
                {
                    numeroDeIntentos = numeroDeIntentos + 1;
                    textBoxDeCedula.Focus();
                    estaBien = false;
                    MessageBox.Show("Revise cédula", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(textBoxDeContrasena.Text) || textBoxDeContrasena.Text.Length < 5 || textBoxDeContrasena.Text.Length > 16)
                {
                    numeroDeIntentos = numeroDeIntentos + 1;
                    textBoxDeCedula.Focus();
                    estaBien = false;
                    MessageBox.Show("Revise contraseña", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    estaBien = true;
                }
                return estaBien;
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
                return false;
            }
        }

        bool soloTieneNumeros(string str)
        {
            try
            {
                foreach (char c in str)
                {
                    if (c < '0' || c > '9')
                        return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
                return false;
            }
        }

        private void EmpleadoInicioDeSesion_Load(object sender, EventArgs e)
        {

        }

        private void textBoxDeContrasena_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    comprobarContrasenna();
                }
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }
    }
}
