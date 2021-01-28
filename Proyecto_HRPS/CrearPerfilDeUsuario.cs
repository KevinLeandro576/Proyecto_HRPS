using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_HRPS
{
    public partial class CrearPerfilDeUsuario : Form
    {
        public CrearPerfilDeUsuario()
        {
            InitializeComponent();
        }

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            PerfilesDeUsuario perfilesDeUsuario = new PerfilesDeUsuario();
            this.Hide();
            perfilesDeUsuario.Show();
        }
        //POR CADA FORMULARIO CON CRUD
        public Database AbrirBaseDeDatos()
        {
            var connectionString = @"Server=tcp:servidor-de-hr-payroll-system.database.windows.net,1433;Initial Catalog=HR_PAYROLL_SYSTEM;Persist Security Info=False;User ID=Kevin;Password=Leandro123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            return new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(connectionString);
        }
        //POR CADA INSERT   
        private void botonDeRegistrarUsuario_Click(object sender, EventArgs e)
        {
            /*var conexion = AbrirBaseDeDatos();
            var comando = conexion.GetStoredProcCommand("ADMINISTRADOR_INSERTAR_EMPLEADO", textBoxDeCedula.Text,
                                                                                            textBoxDeNombre.Text,
                                                                                            textBoxDeHorario.Text,
                                                                                            dateTimePickerDeFechaDeNacimiento.Value,
                                                                                            int.Parse(textBoxDeSalario.Text),
                                                                                            textBoxDePuesto.Text,
                                                                                            decimal.Parse(textBoxDeSalarioPorHora.Text),
                                                                                            textBoxDeTiempo.Text,
                                                                                            textBoxDeContrasena.Text,
                                                                                            int.Parse(textBoxDeIdDeRol.Text),
                                                                                             textBoxDeCorreoElectronico.Text);
            conexion.ExecuteNonQuery(comando);*/

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
