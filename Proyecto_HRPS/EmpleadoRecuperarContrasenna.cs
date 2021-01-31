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
            InitializeComponent();
        }

        private void RecuperarContrasenna_Load(object sender, EventArgs e)
        {

        }

        private void RecuperarContrasenna_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            volverAInicio();
        }

        private void volverAInicio()
        {
            EmpleadoInicioDeSesion empleado = new EmpleadoInicioDeSesion();
            this.Hide();
            empleado.Show();
        }

        private void botonDeEnviar_Click(object sender, EventArgs e)
        {
            renovarContrasenna();
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
            var comando = conexion.GetStoredProcCommand("SACAR_CORREO_DE_EMPLEADO_CON_CEDULA", cedula);
            
            using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
            {
                if (informacionEncontrada.Read())
                {
                    correo = informacionEncontrada.GetString(0);
                    enviarCorreoConContraseña(cedula, correo);
                }
                else
                {
                    MessageBox.Show("Información incorrecta");
                }
            }
        }

        private void enviarCorreoConContraseña(string cedula, string correoDeEmpleado)
        {
            AdministradorDeCorreo administradorDeCorreo = new AdministradorDeCorreo("smtp.gmail.com", "1037joseg@gmail.com", "Qwertz987.,!", 587);

            StringBuilder builder = new StringBuilder();
            List<string> listaDeCorreos = new List<string>();
            var conexion = AbrirBaseDeDatos();
            var comando = conexion.GetStoredProcCommand("SACAR_CORREOS_DE_ADMINISTRADORES");
            string claveTemporal = RandomString(8);
            string claveTemporalEncriptada = encriptarClaveAsha256(claveTemporal);

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

            var comando01 = conexion.GetStoredProcCommand("EMPLEADO_CAMBIAR_CONTRASENA", cedula, claveTemporalEncriptada);
            conexion.ExecuteNonQuery(comando01);

            using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
            {
                string correoDeAdministrador = "";

                while (informacionEncontrada.Read())
                {
                    correoDeAdministrador = informacionEncontrada.GetString(0);
                    listaDeCorreos.Add(correoDeAdministrador);
                }
            }

            administradorDeCorreo.EnviarCorreo("<h1>Se ha cambiado una contraseña</h1> <br/> " + builder.ToString(), "Cambio de contraseña", "1037joseg@gmail.com", "Electrónica UREBA S.A.", listaDeCorreos);
            administradorDeCorreo.EnviarCorreo("<h1>Ha cambiado la contraseña</h1> <br/> " + builder.ToString(), "Cambio de contraseña", "1037joseg@gmail.com", "Electrónica UREBA S.A.", new List<string> { correoDeEmpleado });

            MessageBox.Show("Se ha enviado una contraseña temporal su correo");
            volverAInicio();
        }

        static string RandomString(int length)
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

        public static string encriptarClaveAsha256(string clave)
        {
            using (var sha256 = new SHA256Managed())
            {
                return BitConverter.ToString(sha256.ComputeHash(Encoding.UTF8.GetBytes(clave))).Replace("-", "");
            }
        }

    }
}
