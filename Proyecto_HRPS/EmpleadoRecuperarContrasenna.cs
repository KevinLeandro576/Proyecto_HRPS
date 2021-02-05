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
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Proyecto_HRPS
{
    public partial class EmpleadoRecuperarContrasenna : Form
    {
        public EmpleadoRecuperarContrasenna()
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

        private void RecuperarContrasenna_Load(object sender, EventArgs e)
        {

        }

        private void RecuperarContrasenna_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Application.Exit();
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

        private void volverAInicio()
        {
            try
            {
                EmpleadoInicioDeSesion empleado = new EmpleadoInicioDeSesion();
                this.Hide();
                empleado.Show();
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
                if (validarTextBox() == true)
                {
                    string cedula = textBoxDeCedula.Text;
                    string correo = "";
                    var conexion = AbrirBaseDeDatos();
                    var comando = conexion.GetStoredProcCommand("SACAR_CORREO_DE_EMPLEADO_CON_CEDULA", cedula);

                    using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
                    {
                        if (informacionEncontrada.Read())
                        {
                            correo = informacionEncontrada.GetString(0);
                            const string message = "¿Restablecer contraseña?";
                            const string caption = "Form Closing";
                            var result = MessageBox.Show(message, caption,
                                                         MessageBoxButtons.YesNoCancel,
                                                         MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                enviarCorreoConContraseña(cedula, correo);

                            }
                            else
                            {
                                MessageBox.Show("La contraseña no se restablecerá.", "",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Cédula inexistente.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void enviarCorreoConContraseña(string cedula, string correoDeEmpleado)
        {
            try
            {
                AdministradorDeCorreo administradorDeCorreo = new AdministradorDeCorreo("smtp.gmail.com", "1037joseg@gmail.com", "Qwertz987.,!", 587);

                StringBuilder builder = new StringBuilder();
                List<string> listaDeCorreos = new List<string>();
                var conexion = AbrirBaseDeDatos();
                string claveTemporal = RandomString(8);
                string claveTemporalEncriptada = encriptarClaveAsha256(claveTemporal);

                builder.Append("<table class=table table-bordered align= center border= 1 cellpadding= 3 cellspacing= 0 width= 100%'>");
                builder.Append("<tr>");
                builder.Append("<th>CONTRASEÑA TEMPORAL<th>");
                builder.Append("</tr>");

                builder.Append("<tr align= center>");
                builder.Append("<td>" + claveTemporal + "</td>");
                builder.Append("</tr>");
                builder.Append("</table>");

                var comando = conexion.GetStoredProcCommand("EMPLEADO_CAMBIAR_CONTRASENA", cedula, claveTemporalEncriptada);
                conexion.ExecuteNonQuery(comando);

                administradorDeCorreo.EnviarCorreo("<h1>Ha restablecido la contraseña</h1> <br/> " + builder.ToString(), "Restablecimiento de contraseña", "1037joseg@gmail.com", "Electrónica UREBA S.A.", new List<string> { correoDeEmpleado });

                string evento = "El empleado con cédula: " + cedula + "; ha restablecido su contraseña";
                registrarEvento(evento,
                    this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name);

                MessageBox.Show("Se ha enviado una contraseña temporal a su correo", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                volverAInicio();
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

        private void registrarEvento(string evento, string metodoYclase)
        {
            var conexion = AbrirBaseDeDatos();
            var comando = conexion.GetStoredProcCommand("[INSERTAR_EVENTO]", evento,
                                                                             metodoYclase);
            conexion.ExecuteNonQuery(comando);
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
                    MessageBox.Show("Revisa cédula", "Recuperación de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!soloTieneNumeros(textBoxDeCedula.Text))
                {
                    textBoxDeCedula.Focus();
                    estaBien = false;
                    MessageBox.Show("Revisa cédula", "Recuperación de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


    }
}
