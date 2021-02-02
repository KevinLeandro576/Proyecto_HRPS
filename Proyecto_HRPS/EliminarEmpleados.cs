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
    public partial class EliminarEmpleados : Form
    {
        public EliminarEmpleados()
        {
            InitializeComponent();
        }

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            PerfilesDeUsuario perfilesDeUsuario = new PerfilesDeUsuario();
            this.Hide();
            perfilesDeUsuario.Show();
        }

        private void EliminarEmpleados_Load(object sender, EventArgs e)
        {
            cargarDataGridView();
        }
        private void cargarDataGridView()
        {
            var conexion = AbrirBaseDeDatos();
            var comando = conexion.GetStoredProcCommand("[VER_EMPLEADOS]");
            using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
            {
                while (informacionEncontrada.Read())
                {
                    string cedula = informacionEncontrada["PK_CEDULA"].ToString();
                    string nombre = informacionEncontrada["NOMBRE"].ToString(); ;
                    string horario = informacionEncontrada["HORARIO"].ToString();
                    string tiempo = informacionEncontrada["TIEMPO"].ToString();
                    DateTime fechaDeNacimiento = DateTime.Parse(informacionEncontrada["FECHA_NAC"].ToString());
                    decimal salario = decimal.Parse(informacionEncontrada["SALARIO"].ToString());
                    string puesto = informacionEncontrada["PUESTO"].ToString();
                    int cantidadDeDiasDisponibles = int.Parse(informacionEncontrada["DIAS_LIBRES"].ToString());
                    empleadoEnObjetoBindingSource.Add(new EmpleadoEnObjeto()
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
        private void textBoxDeCedula_TextChanged(object sender, EventArgs e)
        {
            var conexion = AbrirBaseDeDatos();
            var comando = conexion.GetStoredProcCommand("[SACAR_EMPLEADO_POR_CEDULA]", textBoxDeCedula.Text);
            using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
            {
                if (informacionEncontrada.Read())
                {
                    string cedula = informacionEncontrada["PK_CEDULA"].ToString();
                    string nombre = informacionEncontrada["NOMBRE"].ToString(); ;
                    string horario = informacionEncontrada["HORARIO"].ToString();
                    string tiempo = informacionEncontrada["TIEMPO"].ToString();
                    DateTime fechaDeNacimiento = DateTime.Parse(informacionEncontrada["FECHA_NAC"].ToString());
                    decimal salario = decimal.Parse(informacionEncontrada["SALARIO"].ToString());
                    string puesto = informacionEncontrada["PUESTO"].ToString();
                    int cantidadDeDiasDisponibles = int.Parse(informacionEncontrada["DIAS_LIBRES"].ToString());
                    empleadoEnObjetoBindingSource.Clear();
                    empleadoEnObjetoBindingSource.Add(new EmpleadoEnObjeto()
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
                else
                {
                    empleadoEnObjetoBindingSource.Clear();
                    cargarDataGridView();
                }
            }
        }
        private void cargarAltura()
        {
            var height = 40;
            foreach (DataGridViewRow dr in dataGridViewDeEmpleados.Rows)
            {
                height += dr.Height;
            }
            dataGridViewDeEmpleados.Height = height;
        }
        public Database AbrirBaseDeDatos()
        {
            var connectionString = @"Server=tcp:servidor-de-hr-payroll-system.database.windows.net,1433;Initial Catalog=HR_PAYROLL_SYSTEM;Persist Security Info=False;User ID=Kevin;Password=Leandro123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            return new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(connectionString);
        }
        private void dataGridViewDeEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDeEmpleados.Columns[e.ColumnIndex].Name == "botonDeModificar")
            {
                DataGridViewRow fila = this.dataGridViewDeEmpleados.Rows[e.RowIndex];
                String infoCedula = fila.Cells["dataGridViewTextBoxColumnCedula"].Value.ToString();
                //Borrar empleado (ponerlo inactivo)
                if (infoCedula.Equals(Empleado.Cedula))
                {
                    MessageBox.Show("No puede eliminarse a sí mismo", "Eliminación de Empleado");
                }
                else
                {
                    const string message = "Desea borrar el empleado seleccionado?";
                    const string caption = "Eliminación de Empleado";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.YesNoCancel,
                                                 MessageBoxIcon.Question);
                    // Seleccionar no
                    if (result == DialogResult.No)
                    {
                        MessageBox.Show("Empleado no borrado", "Eliminación de Empleado");
                    }
                    else if (result == DialogResult.Yes)
                    {
                        var conexion = AbrirBaseDeDatos();
                        var comando = conexion.GetStoredProcCommand("ADMINISTRADOR_BORRAR_EMPLEADO", infoCedula);
                        conexion.ExecuteNonQuery(comando);
                        MessageBox.Show("Empleado borrado", "Eliminación de Empleado");
                        reiniciarPagina();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        MessageBox.Show("Regresando", "Eliminación de Empleado");
                    }
                }
            }
        }
        public void reiniciarPagina()
        {
            EliminarEmpleados eliminar = new EliminarEmpleados();
            this.Hide();
            eliminar.Show();
        }

        private void EliminarEmpleados_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
