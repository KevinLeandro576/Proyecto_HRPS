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
            //Hace botones de manera dinamica, hacer que se hagan por cada empleado registrado
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
                    string cedula = informacionEncontrada["FK_CEDULA"].ToString();
                    Button boton = agregarBotonDeHorasExtra(i, startposition, endposition, identificador, dia, cantidadDeHoras, cedula);
                    panelDeFlujoDeSolicitudesDeHorasExtra.Controls.Add(boton);
                    boton.Click += delegate (object sender1, EventArgs e1) { clickAboton1(sender1, e1, identificador); };
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

                    string cedula = informacionEncontrada["FK_CEDULA"].ToString();

                    Button boton = agregarBotonDeVacaciones(i, startposition, endposition, identificador, diaDeInicio, diaDeFin, cantidadDeDias, cedula);
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
        //Solicitud de horas exta
        private void clickAboton1(object sender, EventArgs e, int identificador)
        {
            Button botonActual = (Button)sender;
            string estado = "";
            //Borrar empleado (ponerlo inactivo)
            const string message = "Aceptar o negar?";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNoCancel,
                                         MessageBoxIcon.Question);
            // Seleccionar no
            if (result == DialogResult.No)
            {
                MessageBox.Show("Solicitud negada");
                estado = "NEGADO";
                var conexion = AbrirBaseDeDatos();
                var comando = conexion.GetStoredProcCommand("ADMINISTRADOR_ACEPTAR_NEGAR_SOLICITUD_HORAS_EXTRAS", identificador, estado);
                conexion.ExecuteNonQuery(comando);
            }
            else if (result == DialogResult.Yes)
            {
                MessageBox.Show("Solicitud aceptada");
                estado = "ACEPTADO";
                var conexion = AbrirBaseDeDatos();
                var comando = conexion.GetStoredProcCommand("ADMINISTRADOR_ACEPTAR_NEGAR_SOLICITUD_HORAS_EXTRAS", identificador, estado);
                conexion.ExecuteNonQuery(comando);
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Volver");
            }
        }
        //Solicitud de vacaciones
        private void clickAboton2(object sender, EventArgs e, int identificador)
        {
            Button botonActual = (Button)sender;
            string estado = "";
            //Borrar empleado (ponerlo inactivo)
            const string message = "Aceptar o negar?";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNoCancel,
                                         MessageBoxIcon.Question);
            // Seleccionar no
            if (result == DialogResult.No)
            {
                MessageBox.Show("Solicitud negada");
                estado = "NEGADO";
                var conexion = AbrirBaseDeDatos();
                var comando = conexion.GetStoredProcCommand("ADMINISTRADOR_ACEPTAR_O_NEGAR_SOLICITUD", identificador, estado);
                conexion.ExecuteNonQuery(comando);
            }
            else if (result == DialogResult.Yes)
            {
                MessageBox.Show("Solicitud aceptada");
                estado = "ACEPTADO";
                var conexion = AbrirBaseDeDatos();
                var comando = conexion.GetStoredProcCommand("ADMINISTRADOR_ACEPTAR_O_NEGAR_SOLICITUD", identificador, estado);
                conexion.ExecuteNonQuery(comando);
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Volver");
            }
        }

    }
}
