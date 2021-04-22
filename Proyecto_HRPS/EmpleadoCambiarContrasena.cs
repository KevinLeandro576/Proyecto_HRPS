using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Proyecto_HRPS
{
    public partial class EmpleadoCambiarContrasena : Form
    {

        public EmpleadoCambiarContrasena()
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

        private void EmpleadoCambiarContrasena_FormClosing(object sender, FormClosingEventArgs e)
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
                    this.Dispose();
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

        private void botonDeGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string contrasenaAnterior = "";
                var conexion = AbrirBaseDeDatos();
                var comando = conexion.GetStoredProcCommand("[EMPLEADO_SACAR_CONTRASENA]", Empleado.Cedula);
                conexion.ExecuteNonQuery(comando);
                using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
                {
                    if (informacionEncontrada.Read())
                    {
                        contrasenaAnterior = informacionEncontrada.GetString(0);
                    }
                }
                EmpleadoVerPerfil empleadoVerPerfil = new EmpleadoVerPerfil();
                string contrasena = textBoxDeContrasena.Text;
                string contrasenaEnHash = encriptarClaveAsha256(contrasena);
                contrasenaEnHash = contrasenaEnHash.Substring(0, 24);
                if (string.IsNullOrEmpty(contrasena))
                {
                    MessageBox.Show("Escriba contraseña", "Opciones de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!ValidarContrasena(contrasena))
                {
                    MessageBox.Show("Revise contraseña", "Opciones de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (contrasenaEnHash.Equals(contrasenaAnterior))
                {
                    MessageBox.Show("Contraseña igual a la anterior, por favor usar otra.", "Opciones de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    const string message = "Desea guardar la contraseña escrita?";
                    const string caption = "Opciones de Contraseña";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.YesNoCancel,
                                                 MessageBoxIcon.Question);
                    // Seleccionar no
                    if (result == DialogResult.No)
                    {
                        MessageBox.Show("Regresando", "Opciones de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (result == DialogResult.Yes)
                    {


                        var comando02 = conexion.GetStoredProcCommand("[EMPLEADO_CAMBIAR_CONTRASENA]", Empleado.Cedula, contrasenaEnHash);
                        conexion.ExecuteNonQuery(comando02);
                        AdministradorDeCorreo administradorDeCorreo = new AdministradorDeCorreo("mail.electronicaureba.com", "planilla@electronicaureba.com", "Qwertz987.,!", 8889);
                        StringBuilder builder = new StringBuilder();

                        builder.Append("<table class=table table-bordered align=center border=1 cellpadding= 3 cellspacing= 0 width= 100%'>");
                        builder.Append("<tr>");
                        builder.Append("<th>CONTRASEÑA NUEVA</th>");
                        builder.Append("</tr>");
                        builder.Append("<tr>");
                        builder.Append("<td align=center>" + contrasena + "</td>");
                        builder.Append("</tr>");
                        builder.Append("</table>");


                        List<string> listaDeCorreos = new List<string>();

                        string evento = "El empleado con cédula: " + Empleado.Cedula + "; ha actualizado su contraseña.";
                        string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                        registrarEvento(evento, metodoYclase);
                        administradorDeCorreo.EnviarCorreo("<img src=https://i.ibb.co/jv7wTtq/LOGO-UREBA.png height=80vh width=100%> <br> <br> <h1>Ha hecho un cambio de contraseña, a continuación se muestra su nueva contraseña:</h1> <br/> " + builder.ToString(), "Cambio de Contraseña", "planilla@electronicaureba.com", "Electrónica UREBA S.A.", new List<string> { Empleado.Correo });
                        MessageBox.Show("Cambios realizados, su nueva contraseña se ha enviado a su correo", "Opciones de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        empleadoVerPerfil.Show();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        MessageBox.Show("Regresando", "Opciones de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
        private Boolean ValidarContrasena(string contrasena)
        {
            try
            {
                bool estaBien = false;
                var tieneNumero = new Regex(@"[0-9]+");
                var tieneMayuscula = new Regex(@"[A-Z]+");
                var tieneMinuscula = new Regex(@"[a-z]+");
                var tieneMinimoOcho = new Regex(@".{8,}");
                if (tieneNumero.IsMatch(contrasena) && tieneMayuscula.IsMatch(contrasena) && tieneMinuscula.IsMatch(contrasena) && tieneMinimoOcho.IsMatch(contrasena) && contrasena.Length <= 16)
                {
                    estaBien = true;
                }
                else
                {
                    estaBien = false;
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

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            try
            {
                EmpleadoVerPerfil empleado = new EmpleadoVerPerfil();
                this.Hide();
                empleado.Show();
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }

        private void EmpleadoCambiarContrasena_Load(object sender, EventArgs e)
        {

        }
    }
}
