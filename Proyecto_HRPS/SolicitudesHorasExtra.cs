using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_HRPS
{
    public partial class SolicitudesHorasExtra : Form
    {
        public SolicitudesHorasExtra()
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
                if (Empleado.Rol == 2)
                {
                    SolicitudesEmpleados solicitudesEmpleados = new SolicitudesEmpleados();
                    this.Hide();
                    solicitudesEmpleados.Show();
                }
                else if (Empleado.Rol == 1)
                {
                    PerfilDeAdministrador perfil = new PerfilDeAdministrador();
                    this.Hide();
                    perfil.Show();
                }
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
                if (numericDeCantidadDeHorasExtra.Value != 0)
                {
                    var conexion = AbrirBaseDeDatos();
                    var comando = conexion.GetStoredProcCommand("EMPLEADO_INSERTAR_SOLICITUD_HORAS_EXTRAS", textBoxDeNombre.Text,
                                                                                                           dateTimePickerDeDiaTrabajado.Value,
                                                                                                           numericDeCantidadDeHorasExtra.Value);
                    conexion.ExecuteNonQuery(comando);
                    //ENVIA UN CORREO
                    AdministradorDeCorreo administradorDeCorreo = new AdministradorDeCorreo("mail.electronicaureba.com", "planilla@electronicaureba.com", "Qwertz987.,!", 8889);

                    StringBuilder builder = new StringBuilder();

                    builder.Append("<table class=table table-bordered align= center border= 1 cellpadding= 3 cellspacing= 0 width= 100%'>");
                    builder.Append("<tr>");
                    builder.Append("<th>NOMBRE</th>");
                    builder.Append("<th>FECHA DE SOLICITUD</th>");
                    builder.Append("<th>CANTIDAD DE HORAS</th>");
                    builder.Append("<th>ESTADO DE SOLICITUD</th>");
                    builder.Append("</tr>");

                    builder.Append("<tr align= center>");
                    builder.Append("<td>" + textBoxDeNombre.Text + "</td>");
                    builder.Append("<td>" + dateTimePickerDeDiaTrabajado.Value.ToString("dd/MM/yyyy") + "</td>");
                    builder.Append("<td>" + numericDeCantidadDeHorasExtra.Value.ToString() + "</td>");
                    builder.Append("<td>" + "PENDIENTE" + "</td>");
                    builder.Append("</tr>");
                    builder.Append("</table>");


                    var comando02 = conexion.GetStoredProcCommand("[SACAR_CORREO_DE_EMPLEADO_CON_NOMBRE]", textBoxDeNombre.Text);
                    string correoDeEmpleado = "";
                    string correoDeAdministrador;
                    List<string> listaDeCorreos = new List<string>();
                    using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando02))
                    {
                        if (informacionEncontrada.Read())
                        {
                            correoDeEmpleado = informacionEncontrada.GetString(0);
                        }
                    }
                    var comando03 = conexion.GetStoredProcCommand("[SACAR_CORREOS_DE_ADMINISTRADORES]");

                    using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando03))
                    {
                        while (informacionEncontrada.Read())
                        {
                            correoDeAdministrador = informacionEncontrada["CORREO"].ToString();
                            listaDeCorreos.Add(correoDeAdministrador);
                        }
                    }
                    administradorDeCorreo.EnviarCorreo("<img src=https://i.ibb.co/jv7wTtq/LOGO-UREBA.png height=80vh width=100%> <br> <br> <h1>Ha enviado una solicitud de horas extra</h1> <br/> " + builder.ToString(), "Solicitud de horas extra", "planilla@electronicaureba.com", "Electrónica UREBA S.A.", new List<string> { correoDeEmpleado });
                    administradorDeCorreo.EnviarCorreo("<img src=https://i.ibb.co/jv7wTtq/LOGO-UREBA.png height=80vh width=100%> <br> <br> <h1>Ha recibido una solicitud de horas extra</h1> <br/> " + builder.ToString(), "Solicitud de horas extra", "planilla@electronicaureba.com", "Electrónica UREBA S.A.", listaDeCorreos);

                    string texto = "El empleado: " + Empleado.Nombre + " ha enviado una solicitud de horas extra de " + numericDeCantidadDeHorasExtra.Value.ToString() + " horas para el día " + dateTimePickerDeDiaTrabajado.Value.ToString("dd/MM/yyyy") + ".";
                    string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                    registrarEvento(texto, metodoYclase);
                    MessageBox.Show("Ha registrado una solicitud de horas extra", "Opciones de Solicitudes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SolicitudesHorasExtra solicitudes = new SolicitudesHorasExtra();
                    this.Hide();
                    solicitudes.Show();
                }
                else
                {
                    MessageBox.Show("No puede registrar menos de una hora extra", "Opciones de Solicitudes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    numericDeCantidadDeHorasExtra.Focus();
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
        private void registrarError(Exception ex, string metodoYclase)
        {
            string texto = "Error: " + ex.ToString();
            var conexion = AbrirBaseDeDatos();
            var comando = conexion.GetStoredProcCommand("[INSERTAR_EVENTO]", texto,
                                                                             metodoYclase);
            conexion.ExecuteNonQuery(comando);
        }

        private void SolicitudesHorasExtra_FormClosing(object sender, FormClosingEventArgs e)
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

        private void SolicitudesHorasExtra_Load(object sender, EventArgs e)
        {
            textBoxDeNombre.Text = Empleado.Nombre;
            textBoxDeNombre.Enabled = false;
            //var conexion = AbrirBaseDeDatos();
            //var comando = conexion.GetStoredProcCommand("SACAR_PRIMER_DIA_DISPONIBLE_HORAS_EXTRA");
            //conexion.ExecuteNonQuery(comando);
            //using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
            //{
            //    if (informacionEncontrada.Read())
            //    {
            //        dateTimePickerDeDiaTrabajado.MinDate = informacionEncontrada.GetDateTime(0);
            //        if (informacionEncontrada.GetDateTime(0) < DateTime.Now)
            //        {
            //            dateTimePickerDeDiaTrabajado.MinDate = DateTime.Now;
            //        }
            //    }
            //    else
            //    {
            //        dateTimePickerDeDiaTrabajado.MinDate = DateTime.Now;
            //    }
            //}
            dateTimePickerDeDiaTrabajado.MinDate = DateTime.Now;
            dateTimePickerDeDiaTrabajado.MaxDate = DateTime.Now.AddYears(+1);
        }

    }
}
