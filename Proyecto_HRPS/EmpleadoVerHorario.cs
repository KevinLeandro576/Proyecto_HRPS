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
    public partial class EmpleadoVerHorario : Form
    {
        public EmpleadoVerHorario()
        {
            try
            {
                InitializeComponent();
                textBoxDeHorario.Enabled = false;
            }
            catch (Exception ex)
            {
                string texto = "Error: " + ex.ToString();
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                var conexion = AbrirBaseDeDatos();
                var comando = conexion.GetStoredProcCommand("[INSERTAR_EVENTO]", texto,
                                                                                 metodoYclase);
                conexion.ExecuteNonQuery(comando);
            }
        }

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            try
            {
                MenuPerfilesEmpleado menuPerfilesEmpleado = new MenuPerfilesEmpleado();
                this.Hide();
                menuPerfilesEmpleado.Show();
            }
            catch (Exception ex)
            {
                string texto = "Error: " + ex.ToString();
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                var conexion = AbrirBaseDeDatos();
                var comando = conexion.GetStoredProcCommand("[INSERTAR_EVENTO]", texto,
                                                                                 metodoYclase);
                conexion.ExecuteNonQuery(comando);
            }
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
                string texto = "Error: " + ex.ToString();
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                var conexion = AbrirBaseDeDatos();
                var comando = conexion.GetStoredProcCommand("[INSERTAR_EVENTO]", texto,
                                                                                 metodoYclase);
                conexion.ExecuteNonQuery(comando);
                return null;
            }
        }

        private void EmpleadoVerHorario_Load(object sender, EventArgs e)
        {
            try
            {
                textBoxDeCedula.Text = Empleado.Cedula;
                textBoxDeHorario.Text = Empleado.Horario;
            }
            catch (Exception ex)
            {
                string texto = "Error: " + ex.ToString();
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                var conexion = AbrirBaseDeDatos();
                var comando = conexion.GetStoredProcCommand("[INSERTAR_EVENTO]", texto,
                                                                                 metodoYclase);
                conexion.ExecuteNonQuery(comando);
            }
        }

        private void EmpleadoVerHorario_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                string texto = "Error: " + ex.ToString();
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                var conexion = AbrirBaseDeDatos();
                var comando = conexion.GetStoredProcCommand("[INSERTAR_EVENTO]", texto,
                                                                                 metodoYclase);
                conexion.ExecuteNonQuery(comando);
            }
        }
    }
}
