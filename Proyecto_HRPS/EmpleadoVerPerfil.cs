using System;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Proyecto_HRPS
{
    public partial class EmpleadoVerPerfil : Form
    {


        public EmpleadoVerPerfil()
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

        static string infoCedula = "";
        static string infoNombre = "";
        static DateTime infoNacimiento;
        static string infoCorreo = "";
        static string infoContraseña = "";
        static string infoPuesto = "";

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            try
            {
                MenuPerfilesEmpleado menuPerfilesEmpleado = new MenuPerfilesEmpleado();
                this.Hide();
                menuPerfilesEmpleado.Show();
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }

        private void botonDeGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarTodo() == true)
                {
                    Button botonActual = (Button)sender;
                    const string message = "¿Guardar cambios?";
                    const string caption = "Opciones de Perfil";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.YesNoCancel,
                                                 MessageBoxIcon.Question);
                    // Seleccionar no
                    if (result == DialogResult.No)
                    {
                        MessageBox.Show("Cambios descartados", "Opciones de Perfil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (result == DialogResult.Yes)
                    {

                        guardarCambios();
                        string texto = "El empleado: " + Empleado.Nombre + " ha cambiado datos.";
                        string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                        registrarEvento(texto, metodoYclase);
                        MessageBox.Show("Cambios guardados", "Opciones de Perfil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        ReiniciarPantalla();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        MessageBox.Show("Regresando", "Opciones de Perfil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }

        private void guardarCambios()
        {
            try
            {
                infoCedula = textBoxDeCedula.Text;
                infoNombre = textBoxDeNombre.Text;
                infoNacimiento = dateTimePickerDeFechaDeNacimiento.Value;
                infoCorreo = textBoxDeCorreoElectronico.Text;
                var conexion = AbrirBaseDeDatos();
                var comando = conexion.GetStoredProcCommand("EMPLEADO_ACTUALIZAR_DATOS",
                                                                infoCedula,
                                                                infoNombre,
                                                                infoNacimiento,
                                                                infoCorreo);
                conexion.ExecuteNonQuery(comando);
                Empleado.Nombre = infoNombre;
                Empleado.FechaDeNacimiento = infoNacimiento;
                Empleado.Correo = infoCorreo;
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

        private void EmpleadoVerPerfil_Load_1(object sender, EventArgs e)
        {
            try
            {
                textBoxDeCedula.Text = Empleado.Cedula;
                textBoxDeCedula.Enabled = false;
                textBoxDeNombre.Text = Empleado.Nombre;
                dateTimePickerDeFechaDeNacimiento.Value = Empleado.FechaDeNacimiento.Date;
                textBoxDeCorreoElectronico.Text = Empleado.Correo;
                textBoxDePuesto.Text = Empleado.Puesto;
                dateTimePickerDeFechaDeNacimiento.MaxDate = DateTime.Now.AddYears(-5);
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }
        private void EmpleadoVerPerfil_FormClosing(object sender, FormClosingEventArgs e)
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
                    Application.Exit();
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

        private void linkLabelDeCambiarContrasena_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                const string message = "Al continuar deberá cambiar la contraseña, desea continuar?";
                const string caption = "Opciones de Perfil";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNoCancel,
                                             MessageBoxIcon.Question);
                // Seleccionar no
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Regresando", "Opciones de Perfil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == DialogResult.Yes)
                {
                    EmpleadoCambiarContrasena empleadoCambiarContrasena = new EmpleadoCambiarContrasena();
                    this.Hide();
                    empleadoCambiarContrasena.Show();
                }
                else if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Regresando", "Opciones de Perfil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }
        private void ReiniciarPantalla()
        {
            try
            {
                EmpleadoVerPerfil empleadoVerPerfil = new EmpleadoVerPerfil();
                this.Hide();
                empleadoVerPerfil.Show();
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }
        private Boolean ValidarTodo()
        {
            bool estaBien = false;
            try
            {
                if (string.IsNullOrEmpty(textBoxDeNombre.Text))
                {
                    textBoxDeNombre.Focus();
                    estaBien = false;
                    MessageBox.Show("Revise nombre", "Opciones de Perfil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!soloTieneLetras(textBoxDeNombre.Text))
                {
                    textBoxDeNombre.Focus();
                    estaBien = false;
                    MessageBox.Show("Revise nombre", "Opciones de Perfil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!dateTimePickerDeFechaDeNacimiento.Checked)
                {
                    dateTimePickerDeFechaDeNacimiento.Focus();
                    estaBien = false;
                    MessageBox.Show("Revise fecha de nacimiento", "Opciones de Perfil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(textBoxDePuesto.Text))
                {
                    textBoxDePuesto.Focus();
                    estaBien = false;
                    MessageBox.Show("Revise puesto", "Opciones de Perfil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(textBoxDeCorreoElectronico.Text))
                {
                    textBoxDeCorreoElectronico.Focus();
                    estaBien = false;
                    MessageBox.Show("Revise correo electrónico", "Opciones de Perfil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (!esCorreo(textBoxDeCorreoElectronico.Text) || !textBoxDeCorreoElectronico.Text.EndsWith(".com"))
                {
                    textBoxDeCorreoElectronico.Focus();
                    estaBien = false;
                    MessageBox.Show("Revise correo electrónico", "Opciones de Perfil", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        bool soloTieneLetras(String strToCheck)//LETRAS ESPACIO Y TILDES
        {
            try
            {
                Regex objAlphaPattern = new Regex("^[a-z A-Z\u00C0-\u00FF]*$");
                return objAlphaPattern.IsMatch(strToCheck);
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
                return false;
            }
        }
        bool esCorreo(string correo)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(correo);
                return true;
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
                return false;
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
        private void registrarEvento(string evento, string metodoYclase)
        {
            try
            {
                var conexion = AbrirBaseDeDatos();
                var comando = conexion.GetStoredProcCommand("[INSERTAR_EVENTO]", evento,
                                                                                metodoYclase);
                conexion.ExecuteNonQuery(comando);
            }
            catch (Exception ex)
            {
                string metodoYclase02 = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase02);
            }
        }
    }
}
