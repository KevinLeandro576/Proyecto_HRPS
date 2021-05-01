using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_HRPS
{
    public partial class VerHorarios : Form
    {
        public VerHorarios()
        {
            try
            {
                InitializeComponent();
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
                ControlDeEmpleados controlDeEmpleados = new ControlDeEmpleados();
                controlDeEmpleados.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }

        private void VerHorarios_Load(object sender, EventArgs e)
        {
            try
            {
                cargarDataGridView();
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }

        public Database AbrirBaseDeDatos()
        {
            try
            {
                //var connectionString = @"Server=tcp:servidor-de-hr-payroll-system.database.windows.net,1433;Initial Catalog=HR_PAYROLL_SYSTEM;Persist Security Info=False;User ID=Kevin;Password=Leandro123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
                var connectionString = @"Server=localhost\SQLEXPRESS;Initial Catalog=HR_PAYROLL_SYSTEM;Integrated Security=True;MultipleActiveResultSets=True;";
                return new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(connectionString);
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
                return null;
            }
        }

        private void VerHorarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                const string message = "¿Desea cerrar la aplicación?";
                const string caption = "Opciones de Sesión";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNoCancel,
                                             MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Cerrando la aplicación", "Opciones de Sesión"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                    System.Environment.Exit(1);
                }
                else
                {
                    MessageBox.Show("Regresando", "Opciones de Sesión"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Cancel = true;
                }
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

        private void cargarDataGridView()
        {
            try
            {
                var conexion = AbrirBaseDeDatos();
                var comando = conexion.GetStoredProcCommand("[ADMINISTRADOR_VER_HORARIOS]");
                DataSet ds = new DataSet();

                using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
                {
                    while (informacionEncontrada.Read())
                    {
                        string cedula = informacionEncontrada["PK_CEDULA"].ToString();
                        string nombre = informacionEncontrada["NOMBRE"].ToString(); ;
                        string horario = informacionEncontrada["HORARIO"].ToString();

                        dataGridViewDeEmpleados.DefaultCellStyle.ForeColor = Color.Black;
                        empleadoEnObjetoBindingSource.Add(new EmpleadoEnObjeto
                        {
                            Cedula = cedula,
                            Nombre = nombre,
                            Horario = horario
                        });
                    }
                    cargarAltura();
                }
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }

        private void cargarAltura()
        {
            try
            {
                var heigth = 40;
                foreach (DataGridViewRow dr in dataGridViewDeEmpleados.Rows)
                {
                    heigth += dr.Height;
                }
                dataGridViewDeEmpleados.Height = heigth;
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }
    }
}
