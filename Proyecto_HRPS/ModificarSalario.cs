using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_HRPS
{
    public partial class ModificarSalario : Form
    {
        public ModificarSalario()
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

        public static string infoCedula = "";
        public static string infoNombre = "";
        public static decimal infoSalario = 0;

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            try
            {
                PerfilesDeUsuario perfilesDeUsuario = new PerfilesDeUsuario();
                this.Hide();
                perfilesDeUsuario.Show();
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
                //var connectionString = @"Server=localhost\SQLEXPRESS;Initial Catalog=HR_PAYROLL_SYSTEM;Integrated Security=True;MultipleActiveResultSets=True;";
                //var connectionString = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=C:\Users\joseg\Source\Repos\Proyecto_HRPS\Proyecto_HRPS\PLANILLAS.mdf;Integrated Security=True;MultipleActiveResultSets=True;";
                var connectionString = @"Data Source=(localdb)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\PLANILLAS.mdf; Initial Catalog=HR_PAYROLL_SYSTEM;Connect Timeout=15;MultipleActiveResultSets=True;Integrated Security=True;";
                return new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(connectionString);
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
                return null;
            }
        }

        private void ModificarSalario_Load_1(object sender, EventArgs e)
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

        private void cargarDataGridView()
        {
            try
            {
                var conexion = AbrirBaseDeDatos();
                var comando = conexion.GetStoredProcCommand("[VER_EMPLEADOS]");
                using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
                {
                    while (informacionEncontrada.Read())
                    {
                        string cedula = informacionEncontrada["PK_CEDULA"].ToString();
                        string nombre = informacionEncontrada["NOMBRE"].ToString();
                        string horario = informacionEncontrada["HORARIO"].ToString();
                        string tiempo = informacionEncontrada["TIEMPO"].ToString();
                        DateTime fechaDeNacimiento = DateTime.Parse(informacionEncontrada["FECHA_NAC"].ToString());
                        decimal salario = decimal.Parse(informacionEncontrada["SALARIO"].ToString());
                        string puesto = informacionEncontrada["PUESTO"].ToString();
                        int cantidadDeDiasDisponibles = int.Parse(informacionEncontrada["DIAS_LIBRES"].ToString());
                        empleadoEnObjetoBindingSource1.Add(new EmpleadoEnObjeto()
                        {
                            Cedula = cedula,
                            Nombre = nombre,
                            Horario = horario,
                            Tiempo = tiempo,
                            FechaDeNacimiento = fechaDeNacimiento,
                            Salario = salario,
                            Puesto = puesto,
                            CantidadDeDiasDisponibles = cantidadDeDiasDisponibles
                        });
                    }
                }
                DataGridViewButtonColumn boton = (DataGridViewButtonColumn)dataGridViewDeEmpleados.Columns["botonDeModificar"];//ERROR AQUI, BOTON ESTARIA LO QUE SERIA NULO
                boton.FlatStyle = FlatStyle.Popup;
                boton.DefaultCellStyle.ForeColor = Color.White;
                boton.DefaultCellStyle.BackColor = Color.FromArgb(36, 75, 128);

                cargarAltura();
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }
        private void dataGridViewDeEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewDeEmpleados.Columns[e.ColumnIndex].Name == "botonDeModificar")
                {
                    DataGridViewRow fila = this.dataGridViewDeEmpleados.Rows[e.RowIndex];
                    infoCedula = fila.Cells["dataGridViewTextBoxColumnCedula"].Value.ToString();
                    infoNombre = fila.Cells["dataGridViewTextBoxColumnNombre"].Value.ToString();
                    infoSalario = decimal.Parse(fila.Cells["dataGridViewTextBoxColumnSalario"].Value.ToString());
                    ModificarSalario02 modificarSalario02 = new ModificarSalario02();
                    this.Hide();
                    modificarSalario02.Show();
                }
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }
        private void textBoxDeCedula_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var conexion = AbrirBaseDeDatos();
                var comando = conexion.GetStoredProcCommand("[SACAR_EMPLEADO_POR_CEDULA]", textBoxDeCedula.Text);
                using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
                {
                    if (informacionEncontrada.Read())
                    {
                        empleadoEnObjetoBindingSource1.Clear();
                        do
                        {
                            string cedula = informacionEncontrada["PK_CEDULA"].ToString();
                            string nombre = informacionEncontrada["NOMBRE"].ToString(); ;
                            string horario = informacionEncontrada["HORARIO"].ToString();
                            string tiempo = informacionEncontrada["TIEMPO"].ToString();
                            DateTime fechaDeNacimiento = DateTime.Parse(informacionEncontrada["FECHA_NAC"].ToString());
                            decimal salario = decimal.Parse(informacionEncontrada["SALARIO"].ToString());
                            string puesto = informacionEncontrada["PUESTO"].ToString();
                            int cantidadDeDiasDisponibles = int.Parse(informacionEncontrada["DIAS_LIBRES"].ToString());

                            empleadoEnObjetoBindingSource1.Add(new EmpleadoEnObjeto()
                            {
                                Cedula = cedula,
                                Nombre = nombre,
                                Horario = horario,
                                Tiempo = tiempo,
                                FechaDeNacimiento = fechaDeNacimiento,
                                Salario = salario,
                                Puesto = puesto,
                                CantidadDeDiasDisponibles = cantidadDeDiasDisponibles
                            });
                        } while (informacionEncontrada.Read());
                    }
                    else
                    {
                        empleadoEnObjetoBindingSource1.Clear();
                        cargarDataGridView();
                    }
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
                var height = 40;
                foreach (DataGridViewRow dr in dataGridViewDeEmpleados.Rows)
                {
                    height += dr.Height;
                }
                dataGridViewDeEmpleados.Height = height;
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }

        private void ModificarSalario_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
