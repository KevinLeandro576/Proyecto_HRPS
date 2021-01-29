﻿using Microsoft.Practices.EnterpriseLibrary.Data;
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
    public partial class AdministradorSolicitudesDeVacaciones : Form
    {
        public AdministradorSolicitudesDeVacaciones()
        {
            InitializeComponent();
        }

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            AdminstradorEscogerSolicitud adminstradorEscogerSolicitud = new AdminstradorEscogerSolicitud();
            this.Hide();
            adminstradorEscogerSolicitud.Show();
        }
        public Database AbrirBaseDeDatos()
        {
            var connectionString = @"Server=tcp:servidor-de-hr-payroll-system.database.windows.net,1433;Initial Catalog=HR_PAYROLL_SYSTEM;Persist Security Info=False;User ID=Kevin;Password=Leandro123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            return new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(connectionString);
        }

        private void AdministradorSolicitudesDeVacaciones_Load(object sender, EventArgs e)
        {
            cargarDataGridViewDeVacaciones();
        }
        private void cargarDataGridViewDeVacaciones()
        {
            var conexion = AbrirBaseDeDatos();
            var comando = conexion.GetStoredProcCommand("[ADMINISTRADOR_VER_SOLICITUDES_DE_VACACIONES]");
            using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
            {
                while (informacionEncontrada.Read())
                {
                    int identificador = int.Parse(informacionEncontrada["PK_ID_SOLICITUD"].ToString());
                    DateTime diaDeInicio = DateTime.Parse(informacionEncontrada["FECHA_INICIO"].ToString());
                    DateTime diaDeFin = DateTime.Parse(informacionEncontrada["FECHA_FIN"].ToString());
                    int cantidadDeDias = int.Parse(informacionEncontrada["CANT_DIAS"].ToString());
                    string cedulaDeEmpleado = informacionEncontrada["FK_CEDULA"].ToString();
                    solicitudDeVacacionesBindingSource.Add(new SolicitudDeVacaciones()
                    {
                        Identificador = identificador,
                        DiaDeInicio = diaDeInicio,
                        DiaDeFin = diaDeFin,
                        CantidadDeDias = cantidadDeDias,
                        CedulaDeEmpleado = cedulaDeEmpleado
                    });
                }
            }
            DataGridViewButtonColumn botonAceptar = (DataGridViewButtonColumn)dataGridViewDeSolicitudesDeVacaciones.Columns["botonAceptar"];
            botonAceptar.FlatStyle = FlatStyle.Popup;
            botonAceptar.DefaultCellStyle.ForeColor = Color.White;
            botonAceptar.DefaultCellStyle.BackColor = Color.FromArgb(36, 75, 128);
            DataGridViewButtonColumn botonNegar = (DataGridViewButtonColumn)dataGridViewDeSolicitudesDeVacaciones.Columns["botonNegar"];
            botonNegar.FlatStyle = FlatStyle.Popup;
            botonNegar.DefaultCellStyle.ForeColor = Color.White;
            botonNegar.DefaultCellStyle.BackColor = Color.FromArgb(36, 75, 128);
            if (dataGridViewDeSolicitudesDeVacaciones == null || dataGridViewDeSolicitudesDeVacaciones.Rows.Count == 0)
            {
                labelVacaciones.Text = "Sin solicitudes de vacaciones";
                dataGridViewDeSolicitudesDeVacaciones.Visible = false;
            }
            else
            {
                labelVacaciones.Text = "Solicitudes de Vacaciones";
                dataGridViewDeSolicitudesDeVacaciones.Visible = true;
            }
            cargarAltura();
        }

        private void cargarAltura()
        {
            var height = 46;
            foreach (DataGridViewRow dr in dataGridViewDeSolicitudesDeVacaciones.Rows)
            {
                height += dr.Height;
            }
            dataGridViewDeSolicitudesDeVacaciones.Height = height;
        }

        private void textBoxDeCedula_TextChanged(object sender, EventArgs e)
        {
            bool hayFilas = false;
            var conexion = AbrirBaseDeDatos();
            var comando = conexion.GetStoredProcCommand("[SACAR_VACACIONES_POR_FECHAS_O_CEDULA]", dateTimePickerInicio.Value, dateTimePickerFin.Value, textBoxDeCedula.Text);
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
                    solicitudDeVacacionesBindingSource.Clear();
                    while (informacionEncontrada.Read())
                    {
                        int identificador = informacionEncontrada.GetInt32(0);
                        DateTime fechaDeInicio = informacionEncontrada.GetDateTime(1);
                        DateTime fechaDeFin = informacionEncontrada.GetDateTime(2);
                        int cantidadDeDias = informacionEncontrada.GetInt32(3);
                        string cedulaDeEmpleado = informacionEncontrada.GetString(4);
                        solicitudDeVacacionesBindingSource.Add(new SolicitudDeVacaciones()
                        {
                            Identificador = identificador,
                            DiaDeInicio = fechaDeInicio,
                            DiaDeFin = fechaDeFin,
                            CantidadDeDias = cantidadDeDias,
                            CedulaDeEmpleado = cedulaDeEmpleado
                        });
                    }
                }
                else
                {
                    solicitudDeVacacionesBindingSource.Clear();
                    cargarDataGridViewDeVacaciones();
                }
            }
        }
        private void dataGridViewDeSolicitudesDeVacaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String estado = "";
            if (dataGridViewDeSolicitudesDeVacaciones.Columns[e.ColumnIndex].Name == "botonAceptar")
            {
                DataGridViewRow fila = this.dataGridViewDeSolicitudesDeVacaciones.Rows[e.RowIndex];
                int identificador = int.Parse(fila.Cells["identificadorDataGridViewTextBoxColumn"].Value.ToString());
                DateTime diaDeInicio = DateTime.Parse(fila.Cells["diaDeInicioDataGridViewTextBoxColumn"].Value.ToString());                
                int cantidadDeDias = int.Parse(fila.Cells["cantidadDeDiasDataGridViewTextBoxColumn"].Value.ToString());
                String infoCedula = fila.Cells["cedulaDeEmpleadoDataGridViewTextBoxColumn"].Value.ToString();

                const string message = "Desea aceptar la solicitud de vacaciones seleccionada?";
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
                builder.Append("<th>FECHA DE INICIO</th>");
                builder.Append("<th>CANTIDAD DE DÍAS</th>");
                builder.Append("<th>ESTADO DE SOLICITUD</th>");
                builder.Append("</tr>");

                builder.Append("<tr align= center>");
                builder.Append("<td>" + nombreDeEmpleado + "</td>");
                builder.Append("<td>" + diaDeInicio + "</td>");
                builder.Append("<td>" + cantidadDeDias + "</td>");
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
                    var comando05 = conexion.GetStoredProcCommand("ADMINISTRADOR_ACEPTAR_O_NEGAR_SOLICITUD", identificador, estado);
                    conexion.ExecuteNonQuery(comando05);
                    MessageBox.Show("Solicitud aceptada", "Opciones de Solicitud");
                    administradorDeCorreo.EnviarCorreo("<h1>Ha aceptado una solicitud de vacaciones</h1> <br/> " + builder.ToString(), "Solicitud de vacaciones", "1037joseg@gmail.com", "Electrónica UREBA S.A.", listaDeCorreos);
                    administradorDeCorreo.EnviarCorreo("<h1>Solicitud de vacaciones aceptada</h1> <br/> " + builder.ToString(), "Solicitud de vacaciones", "1037joseg@gmail.com", "Electrónica UREBA S.A.", new List<string> { correoDeEmpleado });
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



            if (dataGridViewDeSolicitudesDeVacaciones.Columns[e.ColumnIndex].Name == "botonNegar")
            {
                DataGridViewRow fila = this.dataGridViewDeSolicitudesDeVacaciones.Rows[e.RowIndex];
                int identificador = int.Parse(fila.Cells["identificadorDataGridViewTextBoxColumn"].Value.ToString());
                DateTime diaDeInicio = DateTime.Parse(fila.Cells["diaDeInicioDataGridViewTextBoxColumn"].Value.ToString());                
                int cantidadDeDias = int.Parse(fila.Cells["cantidadDeDiasDataGridViewTextBoxColumn"].Value.ToString());
                String infoCedula = fila.Cells["cedulaDeEmpleadoDataGridViewTextBoxColumn"].Value.ToString();

                const string message = "Desea negar la solicitud de vacaciones seleccionada?";
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
                builder.Append("<th>FECHA DE INICIO</th>");
                builder.Append("<th>CANTIDAD DE DÍAS</th>");
                builder.Append("<th>ESTADO DE SOLICITUD</th>");
                builder.Append("</tr>");

                builder.Append("<tr align= center>");
                builder.Append("<td>" + nombreDeEmpleado + "</td>");
                builder.Append("<td>" + diaDeInicio + "</td>");
                builder.Append("<td>" + cantidadDeDias + "</td>");
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
                    var comando05 = conexion.GetStoredProcCommand("ADMINISTRADOR_ACEPTAR_O_NEGAR_SOLICITUD", identificador, estado);
                    conexion.ExecuteNonQuery(comando05);
                    MessageBox.Show("Solicitud negada", "Opciones de Solicitud");
                    administradorDeCorreo.EnviarCorreo("<h1>Ha negado una solicitud de vacaciones</h1> <br/> " + builder.ToString(), "Solicitud de vacaciones", "1037joseg@gmail.com", "Electrónica UREBA S.A.", listaDeCorreos);
                    administradorDeCorreo.EnviarCorreo("<h1>Solicitud de vacaciones negada</h1> <br/> " + builder.ToString(), "Solicitud de vacaciones", "1037joseg@gmail.com", "Electrónica UREBA S.A.", new List<string> { correoDeEmpleado });
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

        private void reiniciarPagina()
        {
            AdministradorSolicitudesDeVacaciones administradorSolicitudesDeVacaciones = new AdministradorSolicitudesDeVacaciones();
            this.Hide();
            administradorSolicitudesDeVacaciones.Show();
        }
        private void dateTimePickerInicio_ValueChanged(object sender, EventArgs e)
        {
            textBoxDeCedula_TextChanged(sender, e);
        }

        private void dateTimePickerFin_ValueChanged(object sender, EventArgs e)
        {
            textBoxDeCedula_TextChanged(sender, e);
        }
    }
}
