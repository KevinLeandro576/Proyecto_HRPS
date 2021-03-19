using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_HRPS
{
    public partial class AdministradorRecuperarContrasenna : Form
    {
        static string claveTemporal = "";

        public AdministradorRecuperarContrasenna()
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

        private void AdministradorRecuperarContrasenna_FormClosing(object sender, FormClosingEventArgs e)
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


        private void volverAInicio()
        {
            try
            {
                AdministradorInicioDeSesion administrador = new AdministradorInicioDeSesion();
                this.Hide();
                administrador.Show();
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

        private void renovarContrasenna()
        {
            try
            {
                if (validarTextBox())
                {
                    string cedula = textBoxDeCedula.Text;
                    string correo = "";
                    var conexion = AbrirBaseDeDatos();
                    var comando = conexion.GetStoredProcCommand("SACAR_CORREO_DE_ADMINISTRADOR_CON_CEDULA", cedula);

                    using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
                    {
                        if (informacionEncontrada.Read())
                        {
                            const string message = "¿Restablecer contraseña?";
                            const string caption = "Opciones de Recuperar Contraseña";
                            var result = MessageBox.Show(message, caption,
                                MessageBoxButtons.YesNoCancel,
                                MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                cambiarContrasenna(cedula);
                                correo = informacionEncontrada.GetString(0);
                                enviarCorreoConContrasenna(cedula, correo);
                                volverAInicio();
                            }
                            else
                            {
                                MessageBox.Show("Regresando", "Opciones de Recuperar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Cédula inexistente", "Opciones de Recuperar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }

        private void enviarCorreoConContrasenna(string cedula, string correo)
        {
            try
            {
                AdministradorDeCorreo administradorDeCorreo = new AdministradorDeCorreo("mail.electronicaureba.com", "planilla@electronicaureba.com", "Qwertz987.,!", 8889); 
                StringBuilder builder = new StringBuilder();

                builder.Append("<table class=table table-bordered align=center border=1 cellpadding= 3 cellspacing= 0 width= 100%'>");
                builder.Append("<tr>");
                builder.Append("<th>CONTRASEÑA TEMPORAL</th>");
                builder.Append("</tr>");

                builder.Append("<tr align=center>");
                builder.Append("<td>" + claveTemporal + "</td>");
                builder.Append("</tr>");
                builder.Append("</table>");



                List<string> listaDeCorreos = new List<string>();

                string evento = "El empleado con cédula: " + textBoxDeCedula.Text + "; ha restablecido su contraseña.";
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarEvento(evento, metodoYclase);

                administradorDeCorreo.EnviarCorreo("<img src=https://i.ibb.co/jv7wTtq/LOGO-UREBA.png height=80vh width=100%> <br> <br> <h1>Atención, se ha establecido una contraseña temporal para su inicio de sesión:</h1> <br/> " + builder.ToString(), "Restablecimiento de Contraseña", "planilla@electronicaureba.com", "Electrónica UREBA S.A.", new List<string> { correo });

                MessageBox.Show("Se ha enviado una contraseña temporal a su correo", "Opciones de Recuperar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }

        private string RandomString(int length)
        {
            try
            {
                const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890.,!:;";
                StringBuilder claveTemporal = new StringBuilder();
                using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
                {
                    byte[] uintBuffer = new byte[sizeof(uint)];

                    while (length-- > 0)
                    {
                        rng.GetBytes(uintBuffer);
                        uint num = BitConverter.ToUInt32(uintBuffer, 0);
                        claveTemporal.Append(valid[(int)(num % (uint)valid.Length)]);
                    }
                }

                return claveTemporal.ToString();
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
                return null;
            }
        }

        private string encriptarClaveAsha256(string clave)
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

        private void cambiarContrasenna(string cedula)
        {
            try
            {
                claveTemporal = RandomString(8);
                string claveEncriptada = encriptarClaveAsha256(claveTemporal);
                var conexion = AbrirBaseDeDatos();
                var comando = conexion.GetStoredProcCommand("EMPLEADO_CAMBIAR_CONTRASENA", cedula, claveEncriptada);
                conexion.ExecuteNonQuery(comando);
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            try
            {
                volverAInicio();
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }

        private void botonDeEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                renovarContrasenna();
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
                    textBoxDeCedula.Focus();
                    estaBien = false;
                    MessageBox.Show("Revise cédula", "Opciones de Recuperar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!soloTieneNumeros(textBoxDeCedula.Text))
                {
                    textBoxDeCedula.Focus();
                    estaBien = false;
                    MessageBox.Show("Revise cédula", "Opciones de Recuperar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            var conexion = AbrirBaseDeDatos();
            var comando = conexion.GetStoredProcCommand("[INSERTAR_EVENTO]", evento,
                                                                             metodoYclase);
            conexion.ExecuteNonQuery(comando);
        }

        private void AdministradorRecuperarContrasenna_Load(object sender, EventArgs e)
        {

        }
    }
}
