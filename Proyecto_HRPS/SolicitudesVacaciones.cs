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
    public partial class SolicitudesVacaciones : Form
    {
        public SolicitudesVacaciones()
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

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            try
            {
                SolicitudesEmpleados solicitudesEmpleados = new SolicitudesEmpleados();
                this.Hide();
                solicitudesEmpleados.Show();
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
                if (dateTimePickerDeFechaDeInicio.Value >= dateTimePickerDeFechaDeFinalizacion.Value)
                {
                    MessageBox.Show("Revise fechas escogidas", "Opciones de Solicitudes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var conexion = AbrirBaseDeDatos();
                    var comando = conexion.GetStoredProcCommand("EMPLEADO_INSERTAR_SOLICITUD_VACACIONES", textBoxDeNombre.Text,
                                                                                                   dateTimePickerDeFechaDeInicio.Value,
                                                                                                   dateTimePickerDeFechaDeFinalizacion.Value);
                    int respuesta = conexion.ExecuteNonQuery(comando);
                    if (respuesta > 0)
                    {
                        enviarCorreoNotificacion();
                    }
                    else
                    {
                        MessageBox.Show("Revise fechas de solicitud de vacaciones o cantidad de días disponibles", "Opciones de Solicitudes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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

        private void enviarCorreoNotificacion()
        {
            try
            {
                TimeSpan tiempoEnMedio = dateTimePickerDeFechaDeFinalizacion.Value - dateTimePickerDeFechaDeInicio.Value;
                int cantidadDeDiasEnMedio = tiempoEnMedio.Days;
                if (Empleado.CantidadDeDiasDisponibles < cantidadDeDiasEnMedio)
                {
                    MessageBox.Show("Revise cantidad de días disponibles de vacaciones", "Opciones de Solicitudes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var conexion = AbrirBaseDeDatos();
                    var comando = conexion.GetStoredProcCommand("EMPLEADO_INSERTAR_SOLICITUD_VACACIONES", textBoxDeNombre.Text,
                                                                                                       dateTimePickerDeFechaDeInicio.Value,
                                                                                                       dateTimePickerDeFechaDeFinalizacion.Value);
                    conexion.ExecuteNonQuery(comando);
                    //ENVIA UN CORREO
                    AdministradorDeCorreo administradorDeCorreo = new AdministradorDeCorreo("smtp.gmail.com", "1037joseg@gmail.com", "Qwertz987.,!", 587);

                    StringBuilder builder = new StringBuilder();

                    builder.Append("<table class=table table-bordered align= center border= 1 cellpadding= 3 cellspacing= 0 width= 100%'>");
                    builder.Append("<tr>");
                    builder.Append("<th>NOMBRE</th>");
                    builder.Append("<th>FECHA DE INICIO</th>");
                    builder.Append("<th>FECHA DE FINALIZACIÓN</th>");
                    builder.Append("<th>ESTADO</th>");
                    builder.Append("</tr>");

                    builder.Append("<tr align= center>");
                    builder.Append("<td>" + textBoxDeNombre.Text + "</td>");
                    builder.Append("<td>" + dateTimePickerDeFechaDeInicio.Value.ToString() + "</td>");
                    builder.Append("<td>" + dateTimePickerDeFechaDeFinalizacion.Value.ToString() + "</td>");
                    builder.Append("<td>" + "PENDIENTE" + "</td>");
                    builder.Append("</tr>");
                    builder.Append("</table>");


                    var comando02 = conexion.GetStoredProcCommand("[SACAR_CORREO_DE_EMPLEADO_CON_NOMBRE]", textBoxDeNombre.Text);
                    string correoDeEmpleado = "";
                    string correoDeAdministrador;
                    List<string> listaDeCorreos = new List<string>();
                    listaDeCorreos.Add("leandrokevin576@gmail.com");
                    using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando02))
                    {
                        if (informacionEncontrada.Read())
                        {
                            correoDeEmpleado = informacionEncontrada.GetString(0);
                        }
                    }
                    var comando03 = conexion.GetStoredProcCommand("[SACAR_CORREOS_DE_ADMINISTRADORES]");

                    using (IDataReader informacionEncontrada02 = conexion.ExecuteReader(comando03))
                    {
                        while (informacionEncontrada02.Read())
                        {
                            correoDeAdministrador = informacionEncontrada02["CORREO"].ToString();
                            listaDeCorreos.Add(correoDeAdministrador);
                        }
                    }
                    administradorDeCorreo.EnviarCorreo("<h1>Ha enviado una solicitud de vacaciones</h1> <br/> " + builder.ToString(), "Solicitud de vacaciones", "1037joseg@gmail.com", "Electrónica UREBA S.A.", new List<string> { correoDeEmpleado });
                    administradorDeCorreo.EnviarCorreo("<h1>Ha recibido una solicitud de vacaciones</h1> <br/> " + builder.ToString(), "Solicitud de vacaciones", "1037joseg@gmail.com", "Electrónica UREBA S.A.", listaDeCorreos);
                    MessageBox.Show("Ha registrado una solicitud de vacaciones", "Opciones de Solicitudes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SolicitudesVacaciones solicitudesVacaciones = new SolicitudesVacaciones();
                    this.Hide();
                    solicitudesVacaciones.Show();
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

        private void SolicitudesVacaciones_FormClosing(object sender, FormClosingEventArgs e)
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

        private void SolicitudesVacaciones_Load(object sender, EventArgs e)
        {
            var conexion = AbrirBaseDeDatos();
            var comando = conexion.GetStoredProcCommand("SACAR_PRIMER_DIA_DISPONIBLE");
            conexion.ExecuteNonQuery(comando);
            using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
            {
                if (informacionEncontrada.Read())
                {
                    dateTimePickerDeFechaDeInicio.MinDate = informacionEncontrada.GetDateTime(0);
                }
            }
            textBoxDeNombre.Enabled = false;
            textBoxDeNombre.Text = Empleado.Nombre;
            dateTimePickerDeFechaDeFinalizacion.MinDate = dateTimePickerDeFechaDeInicio.MinDate.AddDays(1);
        }
    }
}
