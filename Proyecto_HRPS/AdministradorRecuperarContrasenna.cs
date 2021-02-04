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
            InitializeComponent();
        }

        private void AdministradorRecuperarContrasenna_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void volverAInicio()
        {
            AdministradorInicioDeSesion administrador = new AdministradorInicioDeSesion();
            this.Hide();
            administrador.Show();
        }

        public Database AbrirBaseDeDatos()
        {
            var connectionString = @"Server=tcp:servidor-de-hr-payroll-system.database.windows.net,1433;Initial Catalog=HR_PAYROLL_SYSTEM;Persist Security Info=False;User ID=Kevin;Password=Leandro123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            return new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(connectionString);
        }

        private void renovarContrasenna()
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
                    const string caption = "Form Closing";
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
                        MessageBox.Show("La contraseña no se restablecerá.");
                    }
                }
                else
                {
                    MessageBox.Show("Información incorrecta");
                }
            }
        }

        private void enviarCorreoConContrasenna(string cedula, string correo)
        {
            AdministradorDeCorreo administradorDeCorreo = new AdministradorDeCorreo("smtp.gmail.com", "1037joseg@gmail.com", "Qwertz987.,!", 587);
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
            listaDeCorreos.Add("1037joseg@gmail.com");
            listaDeCorreos.Add("leandrokevin576@gmail.com");

            string evento = "El empleado: " + Empleado.Nombre + "; ha actualizado su contraseña.";
            //registrarEvento(evento);

            administradorDeCorreo.EnviarCorreo("<h1>Ha hecho un cambio de contraseña</h1> <br/> " + builder.ToString(), "Reestablecimiento de contraseña", "1037joseg@gmail.com", "Electrónica UREBA S.A.", new List<string> { correo });

            MessageBox.Show("Se ha enviado una contraseña temporal a su correo");
        }

        private string RandomString(int length)
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

        private string encriptarClaveAsha256(string clave)
        {
            using (var sha256 = new SHA256Managed())
            {
                return BitConverter.ToString(sha256.ComputeHash(Encoding.UTF8.GetBytes(clave))).Replace("-", "");
            }
        }

        private void cambiarContrasenna(string cedula)
        {
            claveTemporal = RandomString(8);
            string claveEncriptada = encriptarClaveAsha256(claveTemporal);
            var conexion = AbrirBaseDeDatos();
            var comando = conexion.GetStoredProcCommand("EMPLEADO_CAMBIAR_CONTRASENA", cedula, claveEncriptada);
            conexion.ExecuteNonQuery(comando);
        }

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            volverAInicio();
        }

        private void botonDeEnviar_Click(object sender, EventArgs e)
        {
            renovarContrasenna();
        }
    }
}
