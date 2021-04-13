using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Windows.Forms;

namespace Proyecto_HRPS
{
    public partial class PerfilDeAdministrador : Form
    {
        public PerfilDeAdministrador()
        {
            InitializeComponent();
        }

        private void botonDeVerPerfil_Click(object sender, EventArgs e)
        {
            try
            {
                EmpleadoVerPerfil empleadoVerPerfil = new EmpleadoVerPerfil();
                this.Hide();
                empleadoVerPerfil.Show();
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
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

        private void botonDeSolicitarVacaciones_Click(object sender, EventArgs e)
        {
            try
            {
                SolicitudesVacaciones solicitud = new SolicitudesVacaciones();
                this.Hide();
                solicitud.Show();
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            try
            {
                MenuDeAdministrador menu = new MenuDeAdministrador();
                this.Hide();
                menu.Show();
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }

        private void botonDeRegistrarSolicitudDeHorasExtra_Click(object sender, EventArgs e)
        {
            try
            {
                SolicitudesHorasExtra solicitud = new SolicitudesHorasExtra();
                this.Hide();
                solicitud.Show();
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }
    }
}
