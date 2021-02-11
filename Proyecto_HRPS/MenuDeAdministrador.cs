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
    public partial class MenuDeAdministrador : Form
    {
        public MenuDeAdministrador()
        {
            InitializeComponent();
        }

        private void MenuDeAdministrador_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void botonDePerfilesDeUsuario_Click(object sender, EventArgs e)
        {
            PerfilesDeUsuario perfilesDeUsuario = new PerfilesDeUsuario();
            this.Hide();
            perfilesDeUsuario.Show();
        }

        private void botonDeControlDeEmpleados_Click(object sender, EventArgs e)
        {
            ControlDeEmpleados controlDeEmpleados = new ControlDeEmpleados();
            this.Hide();
            controlDeEmpleados.Show();
        }

        private void botonDeSolicitudes_Click(object sender, EventArgs e)
        {
            AdminstradorEscogerSolicitud adminstradorEscogerSolicitud = new AdminstradorEscogerSolicitud();
            this.Hide();
            adminstradorEscogerSolicitud.Show();
        }

        private void botonDeReportes_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            this.Hide();
            reportes.Show();
        }

        private void registrarError(Exception ex, string metodoYclase)
        {
            string texto = "Error: " + ex.ToString();
            var conexion = AbrirBaseDeDatos();
            var comando = conexion.GetStoredProcCommand("[INSERTAR_EVENTO]", texto,
                                                                             metodoYclase);
            conexion.ExecuteNonQuery(comando);
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

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            try
            {
                const string message = "¿Desea cerrar sesión?";
                string caption = "Opciones de Sesión";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNoCancel,
                                             MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    MessageBox.Show("No se ha cerrado sesión", caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == DialogResult.Yes)//ERROR AQUI PORQUE NO SE SALDRIA DE IF
                {
                    MessageBox.Show("Ha cerrado sesión", caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdministradorInicioDeSesion administradorInicioDeSesion = new AdministradorInicioDeSesion();
                    this.Hide();
                    administradorInicioDeSesion.Show();
                }
                else if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Regresando", caption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
