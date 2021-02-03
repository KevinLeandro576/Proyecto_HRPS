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
        public AdministradorRecuperarContrasenna()
        {
            InitializeComponent();
        }

        private void botonDeEnviar_Click(object sender, EventArgs e)
        {
            renovarContrasenna();
        }

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            volverAInicio();
        }

        private void AdministradorRecuperarContrasenna_FormClosing(object sender, FormClosingEventArgs e)
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
                registrarError(ex);
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
                registrarError(ex);
                return null;
            }
        }

        private void renovarContrasenna()
        {
            try
            {
                string cedula = textBoxDeCedula.Text;
                string correo = "";
                var conexion = AbrirBaseDeDatos();
                var comando = conexion.GetStoredProcCommand("SACAR_CORREO_DE_ADMINISTRADOR_CON_CEDULA", cedula);

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
                            MessageBox.Show("La contraseña no ha sido restablecida.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Información incorrecta");
                    }
                }
            }
            catch (Exception ex)
            {
                registrarError(ex);
            }
        }

        private void enviarCorreoConContraseña(string cedula, string correoDeEmpleado)
        {
            try
            {
                AdministradorDeCorreo administradorDeCorreo = new AdministradorDeCorreo("smtp.gmail.com", "1037joseg@gmail.com", "Qwertz987.,!", 587);

                StringBuilder builder = new StringBuilder();
                var conexion = AbrirBaseDeDatos();
                string claveTemporal = RandomString(8);
                string claveTemporalEncriptada = encriptarClaveAsha256(claveTemporal);
                var comando = conexion.GetStoredProcCommand("ADMINISTRADOR_CAMBIAR_CONTRASENNA", cedula, claveTemporalEncriptada);
                conexion.ExecuteNonQuery(comando);

                builder.Append("<table class=table table-bordered align= center border= 1 cellpadding= 3 cellspacing= 0 width= 100%'>");
                builder.Append("<tr>");
                builder.Append("<th>CÉDULA</th>");
                builder.Append("<th>CONTRASEÑA TEMPORAL<th>");
                builder.Append("</tr>");

                builder.Append("<tr align= center>");
                builder.Append("<td>" + cedula + "</td>");
                builder.Append("<td>" + claveTemporal + "</td>");
                builder.Append("</tr>");
                builder.Append("</table>");

                administradorDeCorreo.EnviarCorreo("<h1>Ha cambiado la contraseña</h1> <br/> " + builder.ToString(), "Cambio de contraseña", "1037joseg@gmail.com", "Electrónica UREBA S.A.", new List<string> { correoDeEmpleado });

                string evento = "El administrador con cédula: " + cedula + "; ha restablecido su contraseña";
                registrarEvento(evento);

                MessageBox.Show("Se ha enviado una contraseña temporal su correo");
                volverAInicio();
            }
            catch (Exception ex)
            {
                registrarError(ex);
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
                registrarError(ex);
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

        private void registrarEvento(string evento)
        {
            string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
            var conexion = AbrirBaseDeDatos();
            var comando = conexion.GetStoredProcCommand("[INSERTAR_EVENTO]", evento,
                                                                             metodoYclase);
            conexion.ExecuteNonQuery(comando);
        }
    }
}
