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
            InitializeComponent();
        }

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            MenuDeAdministrador menuDeAdministrador = new MenuDeAdministrador();
            this.Hide();
            menuDeAdministrador.Show();
        }
        public Database AbrirBaseDeDatos()
        {
            var connectionString = @"Server=tcp:servidor-de-hr-payroll-system.database.windows.net,1433;Initial Catalog=HR_PAYROLL_SYSTEM;Persist Security Info=False;User ID=Kevin;Password=Leandro123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            return new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(connectionString);
        }

        private void Solicitudes_Load(object sender, EventArgs e)
        {
            //Hace botones de manera dinamica
            int startposition = 100;
            int endposition = 10;
            var conexion = AbrirBaseDeDatos();
            var comando = conexion.GetStoredProcCommand("ADMINISTRADOR_VER_SOLICITUDES_DE_HORAS_EXTRAS");

            using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
            {
                while (informacionEncontrada.Read())
                {
                    int i = 0;
                    int identificador = int.Parse(informacionEncontrada["PK_ID_SOLICITUD"].ToString());
                    DateTime dia = DateTime.Parse(informacionEncontrada["DIA_SOLICITUD"].ToString());
                    decimal cantidadDeHoras = decimal.Parse(informacionEncontrada["CANT_HORAS"].ToString());
                    string cedulaDeEmpleado = informacionEncontrada["FK_CEDULA"].ToString();
                    Button boton = agregarBotonDeHorasExtra(i, startposition, endposition, identificador, dia, cantidadDeHoras, cedulaDeEmpleado);
                    panelDeFlujoDeSolicitudesDeHorasExtra.Controls.Add(boton);
                    boton.Click += delegate (object sender1, EventArgs e1) { clickAboton1(sender1, e1, identificador, cedulaDeEmpleado, dia, cantidadDeHoras); };
                    endposition += 100;
                }
            }

            var comando02 = conexion.GetStoredProcCommand("ADMINISTRADOR_VER_SOLICITUDES_DE_VACACIONES");
            using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando02))
            {
                while (informacionEncontrada.Read())
                {
                    int i = 0;
                    int identificador = int.Parse(informacionEncontrada["PK_ID_SOLICITUD"].ToString());
                    DateTime diaDeInicio = DateTime.Parse(informacionEncontrada["FECHA_INICIO"].ToString());
                    DateTime diaDeFin = DateTime.Parse(informacionEncontrada["FECHA_FIN"].ToString());
                    int cantidadDeDias = int.Parse(informacionEncontrada["CANT_DIAS"].ToString());
                    string cedulaDeEmpleado = informacionEncontrada["FK_CEDULA"].ToString();
                    Button boton = agregarBotonDeVacaciones(i, startposition, endposition, identificador, diaDeInicio, diaDeFin, cantidadDeDias, cedulaDeEmpleado);
                    panelDeFlujoDeSolicitudesDeVacaciones.Controls.Add(boton);
                    boton.Click += delegate (object sender2, EventArgs e2) { clickAboton2(sender2, e2, identificador); };
                    endposition += 100;
                }
            }
        }
        Button agregarBotonDeHorasExtra(int i, int start, int end, int identificador, DateTime dia, decimal cantidadDeHoras, string cedula)
        {
            string fechaConFormato = dia.ToString("dd-MM-yyyy");
            //Hace un boton, poner texto de empleado segun historia de usuario    
            Button botonConEmpleado = new Button();
            botonConEmpleado.Name = "Solicitud " + identificador.ToString();
            botonConEmpleado.Text = "Solicitud número: " + identificador.ToString() + "\n" + "Día de horas extra: " + fechaConFormato +
                                    "\n" + "Cantidad de horas: " + cantidadDeHoras + "\n" + "Cédula de empleado: " + cedula;
            botonConEmpleado.ForeColor = Color.Black;
            botonConEmpleado.BackColor = Color.White;
            botonConEmpleado.Font = new Font("Arial", 10, FontStyle.Regular);
            botonConEmpleado.Width = 400;
            botonConEmpleado.Height = 80;
            botonConEmpleado.Location = new Point(start, end);
            botonConEmpleado.TextAlign = ContentAlignment.MiddleCenter;
            botonConEmpleado.Margin = new Padding(5);
            return botonConEmpleado;
        }
        Button agregarBotonDeVacaciones(int i, int start, int end, int identificador, DateTime diaDeInicio, DateTime diaDeFin, int cantidadDeDias, string cedula)
        {
            string fechaInicialConFormato = diaDeInicio.ToString("dd-MM-yyyy");
            string fechaFinalConFormato = diaDeFin.ToString("dd-MM-yyyy");
            //Hace un boton, poner texto de empleado segun historia de usuario    
            Button botonConEmpleado = new Button();
            botonConEmpleado.Name = "Solicitud " + identificador.ToString();
            botonConEmpleado.Text = "Solicitud número: " + identificador.ToString() + "\n" + "Día de inicio: " + fechaInicialConFormato +
                                    "\n" + "Día de fin: " + fechaFinalConFormato + "\n" + "Cantidad de días: " + cantidadDeDias + "\n" + "Cédula de empleado: " + cedula;
            botonConEmpleado.ForeColor = Color.Black;
            botonConEmpleado.BackColor = Color.White;
            botonConEmpleado.Font = new Font("Arial", 10, FontStyle.Regular);
            botonConEmpleado.Width = 400;
            botonConEmpleado.Height = 80;
            botonConEmpleado.Location = new Point(start, end);
            botonConEmpleado.TextAlign = ContentAlignment.MiddleCenter;
            botonConEmpleado.Margin = new Padding(5);
            return botonConEmpleado;
        }
        //Solicitud de horas extra
        private void clickAboton1(object sender, EventArgs e, int identificador, string cedulaDeEmpleado, DateTime fechaDeSolicitud, decimal cantidadDeHoras)
        {
            Button botonActual = (Button)sender;
            string estado = "";
            //Borrar empleado (ponerlo inactivo)
            const string message = "Desea aceptar o negar la solicitud de horas extra seleccionada?";
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
            var comando = conexion.GetStoredProcCommand("[SACAR_NOMBRE_DE_EMPLEADO_CON_CEDULA]", cedulaDeEmpleado);
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
            var comando02 = conexion.GetStoredProcCommand("[SACAR_CORREO_DE_EMPLEADO_CON_CEDULA]", cedulaDeEmpleado);

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
            // Seleccionar no
            if (result == DialogResult.No)
            {
                estado = "NEGADO";
                var comando04 = conexion.GetStoredProcCommand("ADMINISTRADOR_ACEPTAR_NEGAR_SOLICITUD_HORAS_EXTRAS", identificador, estado);
                conexion.ExecuteNonQuery(comando04);
                MessageBox.Show("Solicitud negada", "Opciones de Solicitud");
                administradorDeCorreo.EnviarCorreo("<h1>Ha negado una solicitud de horas extra</h1> <br/> " + builder.ToString(), "Solicitud de horas extra", "1037joseg@gmail.com", "Electrónica UREBA S.A.", listaDeCorreos);
                administradorDeCorreo.EnviarCorreo("<h1>Solicitud de horas extra negada</h1> <br/> " + builder.ToString(), "Solicitud de horas extra", "1037joseg@gmail.com", "Electrónica UREBA S.A.", new List<string> { correoDeEmpleado });
                reiniciarPagina();
            }
            else if (result == DialogResult.Yes)
            {
                estado = "ACEPTADO";
                var comando05 = conexion.GetStoredProcCommand("ADMINISTRADOR_ACEPTAR_NEGAR_SOLICITUD_HORAS_EXTRAS", identificador, estado);
                conexion.ExecuteNonQuery(comando05);
                MessageBox.Show("Solicitud aceptada", "Opciones de Solicitud");
                administradorDeCorreo.EnviarCorreo("<h1>Ha aceptado una solicitud de horas extra</h1> <br/> " + builder.ToString(), "Solicitud de horas extra", "1037joseg@gmail.com", "Electrónica UREBA S.A.", listaDeCorreos);
                administradorDeCorreo.EnviarCorreo("<h1>Solicitud de horas extra aceptada</h1> <br/> " + builder.ToString(), "Solicitud de horas extra", "1037joseg@gmail.com", "Electrónica UREBA S.A.", new List<string> { correoDeEmpleado });
                reiniciarPagina();
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Regresando", "Opciones de Solicitud");
            }
        }
        //Solicitud de vacaciones
        private void clickAboton2(object sender, EventArgs e, int identificador)
        {
            Button botonActual = (Button)sender;
            string estado = "";
            //Borrar empleado (ponerlo inactivo)
            const string message = "Desea aceptar o negar la solicitud de vacaciones seleccionada?";
            const string caption = "Opciones de Solicitud";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNoCancel,
                                         MessageBoxIcon.Question);
            // Seleccionar no
            if (result == DialogResult.No)
            {
                MessageBox.Show("Solicitud negada", "Opciones de Solicitud");
                estado = "NEGADO";
                var conexion = AbrirBaseDeDatos();
                var comando = conexion.GetStoredProcCommand("ADMINISTRADOR_ACEPTAR_O_NEGAR_SOLICITUD", identificador, estado);
                conexion.ExecuteNonQuery(comando);
                reiniciarPagina();
            }
            else if (result == DialogResult.Yes)
            {
                MessageBox.Show("Solicitud aceptada", "Opciones de Solicitud");
                estado = "ACEPTADO";
                var conexion = AbrirBaseDeDatos();
                var comando = conexion.GetStoredProcCommand("ADMINISTRADOR_ACEPTAR_O_NEGAR_SOLICITUD", identificador, estado);
                conexion.ExecuteNonQuery(comando);
                reiniciarPagina();
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Regresando", "Opciones de Solicitud");
            }
        }

        private void reiniciarPagina()
        {
            Solicitudes solicitudes = new Solicitudes();
            this.Hide();
            solicitudes.Show();
        }

    }
}
