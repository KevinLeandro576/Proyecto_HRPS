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
    public partial class Solicitudes : Form
    {
        public Solicitudes()
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
                AdminstradorEscogerSolicitud adminstradorEscogerSolicitud = new AdminstradorEscogerSolicitud();
                this.Hide();
                adminstradorEscogerSolicitud.Show();
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

        private void Solicitudes_Load(object sender, EventArgs e)
        {
            cargarDataGridViewDeHorasExtra();
            //cargarDataGridViewDeVacaciones();
        }
        private void cargarDataGridViewDeHorasExtra()
        {
            try
            {
                var conexion = AbrirBaseDeDatos();
                var comando = conexion.GetStoredProcCommand("[ADMINISTRADOR_VER_SOLICITUDES_DE_HORAS_EXTRAS]");
                using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
                {
                    while (informacionEncontrada.Read())
                    {
                        int identificador = int.Parse(informacionEncontrada["PK_ID_SOLICITUD"].ToString());
                        DateTime dia = DateTime.Parse(informacionEncontrada["DIA_SOLICITUD"].ToString());
                        decimal cantidadDeHoras = decimal.Parse(informacionEncontrada["CANT_HORAS"].ToString());
                        string cedulaDeEmpleado = informacionEncontrada["FK_CEDULA"].ToString();
                        solicitudDeHorasExtraBindingSource.Add(new SolicitudDeHorasExtra()
                        {
                            Identificador = identificador,
                            Dia = dia,
                            CantidadDeHoras = cantidadDeHoras,
                            CedulaDeEmpleado = cedulaDeEmpleado
                        });
                    }
                }
                DataGridViewButtonColumn botonDeAceptar = (DataGridViewButtonColumn)dataGridViewDeSolicitudesDeHorasExtra.Columns["botonDeAceptar"];//ERROR AQUI, BOTON ESTARIA LO QUE SERIA NULO
                botonDeAceptar.FlatStyle = FlatStyle.Popup;
                botonDeAceptar.DefaultCellStyle.ForeColor = Color.White;
                botonDeAceptar.DefaultCellStyle.BackColor = Color.FromArgb(36, 75, 128);
                DataGridViewButtonColumn botonDeNegar = (DataGridViewButtonColumn)dataGridViewDeSolicitudesDeHorasExtra.Columns["botonDeNegar"];//ERROR AQUI, BOTON ESTARIA LO QUE SERIA NULO
                botonDeNegar.FlatStyle = FlatStyle.Popup;
                botonDeNegar.DefaultCellStyle.ForeColor = Color.White;
                botonDeNegar.DefaultCellStyle.BackColor = Color.FromArgb(36, 75, 128);
                if (dataGridViewDeSolicitudesDeHorasExtra == null || dataGridViewDeSolicitudesDeHorasExtra.Rows.Count == 0)
                {
                    labelHorasExtra.Text = "Sin solicitudes de horas extra";
                    dataGridViewDeSolicitudesDeHorasExtra.Visible = false;
                }
                else
                {
                    labelHorasExtra.Text = "Solicitudes de Horas Extra";
                    dataGridViewDeSolicitudesDeHorasExtra.Visible = true;
                }
                cargarAltura();
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }

        private void cargarAltura()
        {
            try
            {
                var height = 40;
                foreach (DataGridViewRow dr in dataGridViewDeSolicitudesDeHorasExtra.Rows)
                {
                    height += dr.Height;
                }
                dataGridViewDeSolicitudesDeHorasExtra.Height = height;
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }


        private void textBoxDeCedula_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bool hayFilas = false;
                var conexion = AbrirBaseDeDatos();
                var comando = conexion.GetStoredProcCommand("[SACAR_HORAS_EXTRA_POR_FECHA_O_CEDULA]", dateTimePickerDeFecha.Value, textBoxDeCedula.Text);
                using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
                {
                    if (informacionEncontrada.Read())
                    {
                        hayFilas = true;
                    }
                }
                using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
                {
                    if (hayFilas)
                    {
                        solicitudDeHorasExtraBindingSource.Clear();
                        while (informacionEncontrada.Read())
                        {
                            int identificador = informacionEncontrada.GetInt32(0);
                            DateTime dia = informacionEncontrada.GetDateTime(1);
                            decimal cantidadDeHoras = informacionEncontrada.GetDecimal(2);
                            string cedulaDeEmpleado = informacionEncontrada.GetString(3);
                            solicitudDeHorasExtraBindingSource.Add(new SolicitudDeHorasExtra()
                            {
                                Identificador = identificador,
                                Dia = dia,
                                CantidadDeHoras = cantidadDeHoras,
                                CedulaDeEmpleado = cedulaDeEmpleado
                            });
                        }
                    }
                    else
                    {
                        solicitudDeHorasExtraBindingSource.Clear();
                        cargarDataGridViewDeHorasExtra();
                    }
                }
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }


        private void dataGridViewDeEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String estado = "";
                if (dataGridViewDeSolicitudesDeHorasExtra.Columns[e.ColumnIndex].Name == "botonDeAceptar")
                {
                    DataGridViewRow fila = this.dataGridViewDeSolicitudesDeHorasExtra.Rows[e.RowIndex];
                    int identificador = int.Parse(fila.Cells["dataGridViewTextBoxColumnIdentificador"].Value.ToString());
                    String infoCedula = fila.Cells["dataGridViewTextBoxColumnCedula"].Value.ToString();
                    DateTime fechaDeSolicitud = DateTime.Parse(fila.Cells["dataGridViewTextBoxColumnDia"].Value.ToString());
                    int cantidadDeHoras = int.Parse(fila.Cells["dataGridViewTextBoxColumnCantidadDeHoras"].Value.ToString());


                    const string message = "Desea aceptar la solicitud de horas extra seleccionada?";
                    const string caption = "Opciones de Solicitud";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.YesNoCancel,
                                                 MessageBoxIcon.Question);
                    string correoDeEmpleado = "";
                    string correoDeAdministrador = "";
                    string nombreDeEmpleado = "";
                    List<string> listaDeCorreos = new List<string>();
                    listaDeCorreos.Add("leandrokevin576@gmail.com");
                    var conexion = AbrirBaseDeDatos();
                    var comando = conexion.GetStoredProcCommand("[SACAR_NOMBRE_DE_EMPLEADO_CON_CEDULA]", infoCedula);
                    using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
                    {
                        if (informacionEncontrada.Read())
                        {
                            nombreDeEmpleado = informacionEncontrada["NOMBRE"].ToString();
                        }
                    }
                    AdministradorDeCorreo administradorDeCorreo = new AdministradorDeCorreo("smtp.gmail.com", "1037joseg@gmail.com", "Qwertz987.,!", 587);
                    StringBuilder builder = new StringBuilder();

                    builder.Append("<table class=table table-bordered align= center border= 1 cellpadding= 3 cellspacing= 0 width= 100%'>");
                    builder.Append("<tr>");
                    builder.Append("<th>NOMBRE</th>");
                    builder.Append("<th>FECHA DE SOLICITUD</th>");
                    builder.Append("<th>CANTIDAD DE HORAS</th>");
                    builder.Append("<th>ESTADO DE SOLICITUD</th>");
                    builder.Append("</tr>");

                    builder.Append("<tr align= center>");
                    builder.Append("<td>" + nombreDeEmpleado + "</td>");
                    builder.Append("<td>" + fechaDeSolicitud + "</td>");
                    builder.Append("<td>" + cantidadDeHoras + "</td>");
                    builder.Append("<td>" + "REVISADA" + "</td>");
                    builder.Append("</tr>");
                    builder.Append("</table>");
                    var comando02 = conexion.GetStoredProcCommand("[SACAR_CORREO_DE_EMPLEADO_CON_CEDULA]", infoCedula);

                    using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando02))
                    {
                        if (informacionEncontrada.Read())
                        {
                            correoDeEmpleado = informacionEncontrada.GetString(0);
                        }
                    }
                    var comando03 = conexion.GetStoredProcCommand("[SACAR_CORREO_DE_EMPLEADO_CON_CEDULA]", Empleado.Cedula);
                    using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando03))
                    {
                        if (informacionEncontrada.Read())
                        {
                            correoDeAdministrador = informacionEncontrada["CORREO"].ToString();
                            listaDeCorreos.Add(correoDeAdministrador);
                        }
                    }
                    if (result == DialogResult.Yes)
                    {
                        estado = "ACEPTADO";
                        var comando05 = conexion.GetStoredProcCommand("ADMINISTRADOR_ACEPTAR_NEGAR_SOLICITUD_HORAS_EXTRAS", identificador, estado);
                        conexion.ExecuteNonQuery(comando05);
                        MessageBox.Show("Solicitud aceptada", "Opciones de Solicitud");
                        administradorDeCorreo.EnviarCorreo("<h1>Ha aceptado una solicitud de horas extra</h1> <br/> " + builder.ToString(), "Solicitud de horas extra", "1037joseg@gmail.com", "Electrónica UREBA S.A.", listaDeCorreos);
                        administradorDeCorreo.EnviarCorreo("<h1>Su solicitud ha sido aceptada</h1> <br/> " + builder.ToString(), "Solicitud de horas extra", "1037joseg@gmail.com", "Electrónica UREBA S.A.", new List<string> { correoDeEmpleado });

                        string texto = "El administrador: " + Empleado.Nombre + " ha aceptado la solicitud del empleado " + nombreDeEmpleado + ".";
                        string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                        registrarEvento(texto, metodoYclase);

                        reiniciarPagina();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        MessageBox.Show("Regresando", "Opciones de Solicitud");
                    }
                    // Seleccionar no
                    else if (result == DialogResult.No)
                    {
                        MessageBox.Show("Regresando", "Opciones de Solicitud");
                    }
                }
                if (dataGridViewDeSolicitudesDeHorasExtra.Columns[e.ColumnIndex].Name == "botonDeNegar")
                {
                    DataGridViewRow fila = this.dataGridViewDeSolicitudesDeHorasExtra.Rows[e.RowIndex];
                    int identificador = int.Parse(fila.Cells["dataGridViewTextBoxColumnIdentificador"].Value.ToString());
                    String infoCedula = fila.Cells["dataGridViewTextBoxColumnCedula"].Value.ToString();
                    DateTime fechaDeSolicitud = DateTime.Parse(fila.Cells["dataGridViewTextBoxColumnDia"].Value.ToString());
                    int cantidadDeHoras = int.Parse(fila.Cells["dataGridViewTextBoxColumnCantidadDeHoras"].Value.ToString());


                    const string message = "Desea negar la solicitud de horas extra seleccionada?";
                    const string caption = "Opciones de Solicitud";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.YesNoCancel,
                                                 MessageBoxIcon.Question);
                    string correoDeEmpleado = "";
                    string correoDeAdministrador = "";
                    string nombreDeEmpleado = "";
                    List<string> listaDeCorreos = new List<string>();
                    listaDeCorreos.Add("leandrokevin576@gmail.com");
                    var conexion = AbrirBaseDeDatos();
                    var comando = conexion.GetStoredProcCommand("[SACAR_NOMBRE_DE_EMPLEADO_CON_CEDULA]", infoCedula);
                    using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
                    {
                        if (informacionEncontrada.Read())
                        {
                            nombreDeEmpleado = informacionEncontrada["NOMBRE"].ToString();
                        }
                    }
                    AdministradorDeCorreo administradorDeCorreo = new AdministradorDeCorreo("smtp.gmail.com", "1037joseg@gmail.com", "Qwertz987.,!", 587);
                    StringBuilder builder = new StringBuilder();

                    builder.Append("<table class=table table-bordered align= center border= 1 cellpadding= 3 cellspacing= 0 width= 100%'>");
                    builder.Append("<tr>");
                    builder.Append("<th>NOMBRE</th>");
                    builder.Append("<th>FECHA DE SOLICITUD</th>");
                    builder.Append("<th>CANTIDAD DE HORAS</th>");
                    builder.Append("<th>ESTADO DE SOLICITUD</th>");
                    builder.Append("</tr>");

                    builder.Append("<tr align= center>");
                    builder.Append("<td>" + nombreDeEmpleado + "</td>");
                    builder.Append("<td>" + fechaDeSolicitud + "</td>");
                    builder.Append("<td>" + cantidadDeHoras + "</td>");
                    builder.Append("<td>" + "REVISADA" + "</td>");
                    builder.Append("</tr>");
                    builder.Append("</table>");
                    var comando02 = conexion.GetStoredProcCommand("[SACAR_CORREO_DE_EMPLEADO_CON_CEDULA]", infoCedula);

                    using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando02))
                    {
                        if (informacionEncontrada.Read())
                        {
                            correoDeEmpleado = informacionEncontrada.GetString(0);
                        }
                    }
                    var comando03 = conexion.GetStoredProcCommand("[SACAR_CORREO_DE_EMPLEADO_CON_CEDULA]", Empleado.Cedula);
                    using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando03))
                    {
                        if (informacionEncontrada.Read())
                        {
                            correoDeAdministrador = informacionEncontrada["CORREO"].ToString();
                            listaDeCorreos.Add(correoDeAdministrador);
                        }
                    }
                    if (result == DialogResult.Yes)
                    {
                        estado = "NEGADO";
                        var comando04 = conexion.GetStoredProcCommand("ADMINISTRADOR_ACEPTAR_NEGAR_SOLICITUD_HORAS_EXTRAS", identificador, estado);
                        conexion.ExecuteNonQuery(comando04);
                        MessageBox.Show("Solicitud negada", "Opciones de Solicitud");
                        administradorDeCorreo.EnviarCorreo("<h1>Ha negado una solicitud de horas extra</h1> <br/> " + builder.ToString(), "Solicitud de horas extra", "1037joseg@gmail.com", "Electrónica UREBA S.A.", listaDeCorreos);
                        administradorDeCorreo.EnviarCorreo("<h1>Su solicitud ha sido negada</h1> <br/> " + builder.ToString(), "Solicitud de horas extra", "1037joseg@gmail.com", "Electrónica UREBA S.A.", new List<string> { correoDeEmpleado });

                        string texto = "El administrador: " + Empleado.Nombre + " ha rechazado la solicitud del empleado " + nombreDeEmpleado + ".";
                        string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                        registrarEvento(texto, metodoYclase);

                        reiniciarPagina();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        MessageBox.Show("Regresando", "Opciones de Solicitud");
                    }
                    // Seleccionar no
                    else if (result == DialogResult.No)
                    {
                        MessageBox.Show("Regresando", "Opciones de Solicitud");
                    }
                }
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }
        private void reiniciarPagina()
        {
            try
            {
                Solicitudes solicitudes = new Solicitudes();
                this.Hide();
                solicitudes.Show();
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }

        private void dateTimePickerDeFecha_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxDeCedula_TextChanged(sender, e);
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

            private void Solicitudes_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
