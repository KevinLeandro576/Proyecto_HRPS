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
    public partial class ModificarSalario : Form
    {
        public ModificarSalario()
        {
            InitializeComponent();
        }

        public static string infoCedula = "";
        public static int infoSalario = 0;

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            PerfilesDeUsuario perfilesDeUsuario = new PerfilesDeUsuario();
            this.Hide();
            perfilesDeUsuario.Show();
        }

        private void ModificarSalario_Load(object sender, EventArgs e)
        {
            int startposition = 100;
            int endposition = 10;
            var conexion = AbrirBaseDeDatos();
            var comando = conexion.GetStoredProcCommand("ADMINISTRADOR_VER_EMPLEADDOS_PARA_SALARIOS");

            using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
            {
                while (informacionEncontrada.Read())
                {
                    int i = 0;
                    string cedula = informacionEncontrada["PK_CEDULA"].ToString();
                    string nombre = informacionEncontrada["NOMBRE"].ToString();
                    int salario = int.Parse(informacionEncontrada["SALARIO"].ToString());
                    Button boton = agregarBoton(i, startposition, endposition, cedula, nombre, salario);
                    boton.Click += delegate (object sender1, EventArgs e1) { clickAboton(sender1, e1, cedula, salario); };
                    endposition += 100;
                }
            }
        }

        Button agregarBoton(int i, int start, int end, string cedula, string nombre, int salario)
        {
            Button botonConSalario = new Button();
            botonConSalario.Name = "Empleado " + i.ToString();
            botonConSalario.Text = "" + cedula + "\n" + nombre + "\n" + salario.ToString();
            botonConSalario.Width = 200;
            botonConSalario.Height = 60;
            botonConSalario.Location = new Point(start, end);
            botonConSalario.TextAlign = ContentAlignment.MiddleCenter;
            botonConSalario.Margin = new Padding(5);
            return botonConSalario;
        }

        private void clickAboton(object sender, EventArgs e, string cedula, int salario)
        {
            infoCedula = cedula;
            infoSalario = salario;
            ModificarSalario02 modificarSalario02 = new ModificarSalario02();
            this.Hide();
            modificarSalario02.Show();
        }



        public Database AbrirBaseDeDatos()
        {
            var connectionString = @"Server=tcp:servidor-de-hr-payroll-system.database.windows.net,1433;Initial Catalog=HR_PAYROLL_SYSTEM;Persist Security Info=False;User ID=Kevin;Password=Leandro123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            return new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(connectionString);
        }
    }
}
