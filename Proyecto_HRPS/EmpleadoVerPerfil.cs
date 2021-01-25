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

        static string info_cedula = "";
        static string info_nombre = "";
        static DateTime info_nacimiento;
        static string info_correo = "";
        static string info_contraseña = "";
        static string info_puesto = "";

        private void EmpleadoVerPerfil_Load(object sender, EventArgs e)
        {
            //info_cedula = valor de cedula;
            var conexion = AbrirBaseDeDatos();
            var comando = conexion.GetStoredProcCommand("EMPLEADO_VER_PERFIL", info_cedula);
            using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
            {
                info_nombre = informacionEncontrada["NOMBRE"].ToString();
                info_nacimiento = DateTime.Parse(informacionEncontrada["FECHA_NAC"].ToString());
                info_contraseña = informacionEncontrada["CORREO"].ToString();
                info_contraseña = informacionEncontrada["CONTRASENNA"].ToString();
                info_puesto = informacionEncontrada["PUESTO"].ToString();
            }
            Label label = agregarLabel(info_puesto);
            textBoxDeCedula.Text = info_cedula;
            textBoxDeNombre.Text = info_nombre;
            dateTimePickerDeFechaDeNacimiento.Value = info_nacimiento;
            textBoxDeCorreoElectronico.Text = info_correo;
            textBoxDeContraseña.Text = info_contraseña;
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
            info_cedula = textBoxDeCedula.Text;
            info_nombre = textBoxDeNombre.Text;
            info_nacimiento = dateTimePickerDeFechaDeNacimiento.Value;
            info_correo = textBoxDeCorreoElectronico.Text;
            info_contraseña = textBoxDeContraseña.Text;
            var conexion = AbrirBaseDeDatos();
            var comando = conexion.GetStoredProcCommand("EMPLEADO_ACTUALIZAR_DATOS",
                                                            info_cedula,
                                                            info_nombre,
                                                            info_nacimiento,
                                                            info_correo,
                                                            info_contraseña);
            conexion.ExecuteNonQuery(comando);
        }

        Label agregarLabel(string puesto)
        {
            Label labelPuesto = new Label();
            labelPuesto.Name = "Puesto";
            labelPuesto.Text = puesto;
            labelPuesto.ForeColor = Color.Black;
            labelPuesto.BackColor = Color.White;
            labelPuesto.Font = new Font("Arial", 10, FontStyle.Regular);
            labelPuesto.Width = 176;
            labelPuesto.Height = 20;
            labelPuesto.Location = new Point(265, 255);
            return labelPuesto;
        }

        public Database AbrirBaseDeDatos()
        {
            var connectionString = @"Server=tcp:servidor-de-hr-payroll-system.database.windows.net,1433;Initial Catalog=HR_PAYROLL_SYSTEM;Persist Security Info=False;User ID=Kevin;Password=Leandro123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            return new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(connectionString);
        }
    }
}
