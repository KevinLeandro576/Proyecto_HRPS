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
    public partial class EmpleadoVerPerfil : Form
    {
        public EmpleadoVerPerfil()
        {
            InitializeComponent();
        }

        static string infoCedula = "";
        static string infoNombre = "";
        static DateTime infoNacimiento;
        static string infoCorreo = "";
        static string infoContraseña = "";
        static string infoPuesto = "";

        private void EmpleadoVerPerfil_Load(object sender, EventArgs e)
        {
            //info_cedula = login.valor_de_cedula;
            //infoCedula = "123465789";
            var conexion = AbrirBaseDeDatos();
            var comando = conexion.GetStoredProcCommand("EMPLEADO_VER_PERFIL", infoCedula);
            using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
            {
                infoNombre = informacionEncontrada["NOMBRE"].ToString();
                infoNacimiento = DateTime.Parse(informacionEncontrada["FECHA_NAC"].ToString());
                infoCorreo = informacionEncontrada["CORREO"].ToString();
                infoContraseña = informacionEncontrada["CONTRASENNA"].ToString();
                infoPuesto = informacionEncontrada["PUESTO"].ToString();
            }
            textBoxDeCedula.Text = infoCedula;
            textBoxDeNombre.Text = infoNombre;
            dateTimePickerDeFechaDeNacimiento.Value = infoNacimiento;
            textBoxDeCorreoElectronico.Text = infoCorreo;
            textBoxDeContraseña.Text = infoContraseña;
            textBoxDePuesto.Text = infoPuesto;
        }

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            MenuPerfilesEmpleado menuPerfilesEmpleado = new MenuPerfilesEmpleado();
            this.Hide();
            menuPerfilesEmpleado.Show();
        }

        private void botonDeGuardar_Click(object sender, EventArgs e)
        {
            Button botonActual = (Button)sender;
            const string message = "¿Guadar cambios?";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNoCancel,
                                         MessageBoxIcon.Question);
            // Seleccionar no
            if (result == DialogResult.No)
            {
                MessageBox.Show("Cambios descartados");
            }
            else if (result == DialogResult.Yes)
            {
                MessageBox.Show("Cambios guardados");
                guardarCambios();
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Volver");
            }
        }

        private void guardarCambios()
        {
            infoCedula = textBoxDeCedula.Text;
            infoNombre = textBoxDeNombre.Text;
            infoNacimiento = dateTimePickerDeFechaDeNacimiento.Value;
            infoCorreo = textBoxDeCorreoElectronico.Text;
            infoContraseña = textBoxDeContraseña.Text;
            var conexion = AbrirBaseDeDatos();
            var comando = conexion.GetStoredProcCommand("EMPLEADO_ACTUALIZAR_DATOS",
                                                            infoCedula,
                                                            infoNombre,
                                                            infoNacimiento,
                                                            infoCorreo,
                                                            infoContraseña);
            conexion.ExecuteNonQuery(comando);
        }

        public Database AbrirBaseDeDatos()
        {
            var connectionString = @"Server=tcp:servidor-de-hr-payroll-system.database.windows.net,1433;Initial Catalog=HR_PAYROLL_SYSTEM;Persist Security Info=False;User ID=Kevin;Password=Leandro123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            return new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(connectionString);
        }

        private void EmpleadoVerPerfil_Load_1(object sender, EventArgs e)
        {
            infoCedula = EmpleadoInicioDeSesion.infoCedula;
            var conexion = AbrirBaseDeDatos();
            var comando = conexion.GetStoredProcCommand("EMPLEADO_VER_PERFIL", infoCedula);
            using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
            {
                while (informacionEncontrada.Read()) { 
                    infoNombre = informacionEncontrada["NOMBRE"].ToString();
                    infoNacimiento = DateTime.Parse(informacionEncontrada["FECHA_NAC"].ToString());
                    infoCorreo = informacionEncontrada["CORREO"].ToString();
                    infoContraseña = informacionEncontrada["CONTRASENNA"].ToString();
                    infoPuesto = informacionEncontrada["PUESTO"].ToString();
                }

            }
            textBoxDeCedula.Text = infoCedula;
            textBoxDeNombre.Text = infoNombre;
            dateTimePickerDeFechaDeNacimiento.Value = infoNacimiento;
            textBoxDeCorreoElectronico.Text = infoCorreo;
            textBoxDeContraseña.Text = infoContraseña;
            textBoxDePuesto.Text = infoPuesto;
        }
    }
}
