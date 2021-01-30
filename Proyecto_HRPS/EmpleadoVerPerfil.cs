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
using System.Text.RegularExpressions;

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
            const string caption = "Opciones de Perfil";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNoCancel,
                                         MessageBoxIcon.Question);
            // Seleccionar no
            if (result == DialogResult.No)
            {
                MessageBox.Show("Cambios descartados", "Opciones de Perfil");
            }
            else if (result == DialogResult.Yes)
            {
                if (ValidarTodo() == true)
                {
                    guardarCambios();
                    MessageBox.Show("Cambios guardados", "Opciones de Perfil");
                    this.Hide();
                    ReiniciarPantalla();
                }
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Regresando", "Opciones de Perfil");
            }
        }

        private void guardarCambios()
        {
            infoCedula = textBoxDeCedula.Text;
            infoNombre = textBoxDeNombre.Text;
            infoNacimiento = dateTimePickerDeFechaDeNacimiento.Value;
            infoCorreo = textBoxDeCorreoElectronico.Text;
            var conexion = AbrirBaseDeDatos();
            var comando = conexion.GetStoredProcCommand("EMPLEADO_ACTUALIZAR_DATOS",
                                                            infoCedula,
                                                            infoNombre,
                                                            infoNacimiento,
                                                            infoCorreo);
            conexion.ExecuteNonQuery(comando);
            Empleado.Nombre = infoNombre;
            Empleado.FechaDeNacimiento = infoNacimiento;
            Empleado.Correo = infoCorreo;
        }

        public Database AbrirBaseDeDatos()
        {
            var connectionString = @"Server=tcp:servidor-de-hr-payroll-system.database.windows.net,1433;Initial Catalog=HR_PAYROLL_SYSTEM;Persist Security Info=False;User ID=Kevin;Password=Leandro123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            return new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(connectionString);
        }

        private void EmpleadoVerPerfil_Load_1(object sender, EventArgs e)
        {
            textBoxDeCedula.Text = Empleado.Cedula;
            textBoxDeCedula.Enabled = false;
            textBoxDeNombre.Text = Empleado.Nombre;
            dateTimePickerDeFechaDeNacimiento.Value = Empleado.FechaDeNacimiento;
            textBoxDeCorreoElectronico.Text = Empleado.Correo;
            textBoxDePuesto.Text = Empleado.Puesto;
        }
        private void EmpleadoVerPerfil_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabelDeCambiarContrasena_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            const string message = "Al continuar deberá cambiar la contraseña, desea continuar?";
            const string caption = "Opciones de Perfil";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNoCancel,
                                         MessageBoxIcon.Question);
            // Seleccionar no
            if (result == DialogResult.No)
            {
                MessageBox.Show("Regresando", "Opciones de Perfil");
            }
            else if (result == DialogResult.Yes)
            {
                EmpleadoCambiarContrasena empleadoCambiarContrasena = new EmpleadoCambiarContrasena();
                this.Hide();
                empleadoCambiarContrasena.Show();
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Regresando", "Opciones de Perfil");
            }
        }
        private void ReiniciarPantalla()
        {
            EmpleadoVerPerfil empleadoVerPerfil = new EmpleadoVerPerfil();
            this.Hide();
            empleadoVerPerfil.Show();
        }
        private Boolean ValidarTodo()
        {
            bool estaBien = false;
            if (string.IsNullOrEmpty(textBoxDeNombre.Text))
            {
                textBoxDeNombre.Focus();
                estaBien = false;
                MessageBox.Show("Revisa nombre", "Opciones de Perfil");
            }
            else if (!soloTieneLetras(textBoxDeNombre.Text))
            {
                textBoxDeNombre.Focus();
                estaBien = false;
                MessageBox.Show("Revisa nombre", "Opciones de Perfil");
            }
            else if (!dateTimePickerDeFechaDeNacimiento.Checked)
            {
                dateTimePickerDeFechaDeNacimiento.Focus();
                estaBien = false;
                MessageBox.Show("Revisa fecha de nacimiento", "Opciones de Perfil");
            }
            else if (string.IsNullOrEmpty(textBoxDePuesto.Text))
            {
                textBoxDePuesto.Focus();
                estaBien = false;
                MessageBox.Show("Revisa puesto", "Opciones de Perfil");
            }
            else if (string.IsNullOrEmpty(textBoxDeCorreoElectronico.Text))
            {
                textBoxDeCorreoElectronico.Focus();
                estaBien = false;
                MessageBox.Show("Revisa correo electrónico", "Opciones de Perfil");
            }

            else if (!esCorreo(textBoxDeCorreoElectronico.Text) || !textBoxDeCorreoElectronico.Text.EndsWith(".com"))
            {
                textBoxDeCorreoElectronico.Focus();
                estaBien = false;
                MessageBox.Show("Revisa correo electrónico", "Opciones de Perfil");
            }
            else
            {
                estaBien = true;
            }
            return estaBien;
        }
        bool soloTieneLetras(String strToCheck)//LETRAS ESPACIO Y TILDES
        {
            Regex objAlphaPattern = new Regex("^[a-z A-Z\u00C0-\u00FF]*$");
            return objAlphaPattern.IsMatch(strToCheck);
        }
        bool esCorreo(string correo)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(correo);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
