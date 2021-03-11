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

namespace Proyecto_HRPS
{
    public partial class MenuInicial : Form
    {
        public MenuInicial()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            aumentarDias();
            generarCorreoNotificacionDias();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                EmpleadoInicioDeSesion empleadoInicioDeSesion = new EmpleadoInicioDeSesion();
                this.Hide();
                empleadoInicioDeSesion.Show();
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }

        private void botonDeAdministrador_Click(object sender, EventArgs e)
        {
            try
            {
                AdministradorInicioDeSesion administradorInicioDeSesion = new AdministradorInicioDeSesion();
                administradorInicioDeSesion.Show();
                this.Hide(); //Ocultar pantalla actual (menu inicial)    
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }

        private void MenuInicial_FormClosing(object sender, FormClosingEventArgs e)
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
                    FormCollection fc = Application.OpenForms;
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


        private void registrarError(Exception ex, string metodoYclase)
        {
            string texto = "Error: " + ex.ToString();
            var conexion = AbrirBaseDeDatos();
            var comando = conexion.GetStoredProcCommand("[INSERTAR_EVENTO]", texto,
                                                                             metodoYclase);
            conexion.ExecuteNonQuery(comando);
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

        private void generarCorreoNotificacionDias()
        {
            try
            {
                var conexion = AbrirBaseDeDatos();
                var comando = conexion.GetStoredProcCommand("MOSTRAR_EMPLEADOS_CON_DIAS_LIBRES");

                using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
                {
                    if (informacionEncontrada.FieldCount != 0)
                    {
                        if (informacionEncontrada.Read() == true)
                        {
                            //ENVIA UN CORREO
                            AdministradorDeCorreo administradorDeCorreo = new AdministradorDeCorreo("smtp.gmail.com", "1037joseg@gmail.com", "Qwertz987.,!", 25);

                            StringBuilder builder = new StringBuilder();

                            builder.Append("<table class=table table-bordered align= center border= 1 cellpadding= 3 cellspacing= 0 width= 100%'>");
                            builder.Append("<tr>");
                            builder.Append("<th>CÉDULA</th>");
                            builder.Append("<th>NOMBRE</th>");
                            builder.Append("<th>CANTIDAD DE DÍAS DISPONIBLES</th>");
                            builder.Append("</tr>");

                            builder.Append("<tr align= center>");
                            builder.Append("<td>" + informacionEncontrada.GetString(0) + "</td>");
                            builder.Append("<td>" + informacionEncontrada.GetString(1) + "</td>");
                            builder.Append("<td>" + informacionEncontrada.GetInt32(2).ToString() + "</td>");
                            builder.Append("</tr>");
                            builder.Append("</table>");

                            var comando02 = conexion.GetStoredProcCommand("SACAR_CORREOS_DE_ADMINISTRADORES");
                            string correoDeAdministrador = "";
                            List<string> listaDeCorreos = new List<string>();
                            listaDeCorreos.Add("leandrokevin576@gmail.com");
                            using (IDataReader informacionEncontrada01 = conexion.ExecuteReader(comando02))
                            {
                                while (informacionEncontrada.Read())
                                {
                                    correoDeAdministrador = informacionEncontrada01.GetString(0);
                                    listaDeCorreos.Add(correoDeAdministrador);
                                }
                            }
                            administradorDeCorreo.EnviarCorreo("<img src=https://i.ibb.co/jv7wTtq/LOGO-UREBA.png height=80vh width=100%> <br> <br> <h2>Los siguientes empleados poseen 10 o más días libres</h2> <br/> " + builder.ToString(), "Notificación de 10 días libres", "1037joseg@gmail.com", "Electrónica UREBA S.A.", listaDeCorreos);
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

        private void aumentarDias()
        {
            try
            {
                var conexion = AbrirBaseDeDatos();
                var comando = conexion.GetStoredProcCommand("AUMENTAR_DIAS_LIBRES");
                conexion.ExecuteNonQuery(comando);
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }
    }
}
