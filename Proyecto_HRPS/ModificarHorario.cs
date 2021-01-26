using System;
using Microsoft.Practices.EnterpriseLibrary.Data;
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
    public partial class ModificarHorario : Form
    {
        public ModificarHorario()
        {
            InitializeComponent();
        }

        public static string infoCedula = "";
        public static string infoHorario = "";
        public static string infoNombre = "";

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            PerfilesDeUsuario perfilesDeUsuario = new PerfilesDeUsuario();
            this.Hide();
            perfilesDeUsuario.Show();
        }

        private void clickAboton(object sender, EventArgs e, string cedula, string nombre, string horario)
        {
            Button botonActual = (Button)sender;
            infoCedula = cedula;
            infoNombre = nombre;
            infoHorario = horario;
            ModificarHorario02 modificarHorario02 = new ModificarHorario02();
            this.Hide();
            modificarHorario02.Show();
        }

        Button agregarBoton(int i, int start, int end, string cedula, string nombre, string horario)
        {
            Button botonConEmpleado = new Button();
            botonConEmpleado.Name = "Empleado " + i.ToString();
            botonConEmpleado.Text = "" + cedula + "\n" + nombre + "\n" + horario;
            botonConEmpleado.ForeColor = Color.Black;
            botonConEmpleado.BackColor = Color.White;
            botonConEmpleado.Font = new Font("Arial", 10, FontStyle.Regular);
            botonConEmpleado.Width = 200;
            botonConEmpleado.Height = 60;
            botonConEmpleado.Location = new Point(start, end);
            botonConEmpleado.TextAlign = ContentAlignment.MiddleCenter;
            botonConEmpleado.Margin = new Padding(5);
            return botonConEmpleado;
        }


        public Database AbrirBaseDeDatos()
        {
            var connectionString = @"Server=tcp:servidor-de-hr-payroll-system.database.windows.net,1433;Initial Catalog=HR_PAYROLL_SYSTEM;Persist Security Info=False;User ID=Kevin;Password=Leandro123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            return new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(connectionString);
        }

        private void ModificarHorario_Load_1(object sender, EventArgs e)
        {
            int startposition = 100;
            int endposition = 10;
            var conexion = AbrirBaseDeDatos();
            var comando = conexion.GetStoredProcCommand("ADMINISTRADOR_VER_EMPLEADOS_PARA_HORARIOS");

            using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
            {
                while (informacionEncontrada.Read())
                {
                    int i = 0;
                    MessageBox.Show("Intento: " + i.ToString());
                    //string cedula = informacionEncontrada.GetString(0);
                    string cedula = informacionEncontrada["PK_CEDULA"].ToString();
                    string nombre = informacionEncontrada.GetString(1);
                    string horario = informacionEncontrada.GetString(2);
                    Button boton = agregarBoton(i, startposition, endposition, cedula, nombre, horario);
                    panelDeFlujoDeHorarios.Controls.Add(boton);
                    boton.Click += delegate (object sender1, EventArgs e1) { clickAboton(sender1, e1, cedula, nombre, horario); };
                    endposition += 100;
                    i++;
                }
            }
        }
    }
}
