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
    public partial class ModificarSalario : Form
    {
        public ModificarSalario()
        {
            InitializeComponent();
        }

        public static string infoCedula = "";
        public static string infoNombre = "";
        public static int infoSalario = 0;

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            PerfilesDeUsuario perfilesDeUsuario = new PerfilesDeUsuario();
            this.Hide();
            perfilesDeUsuario.Show();
        }

        /*Button agregarBoton(int i, int start, int end, string cedula, string nombre, int salario)
        {
            Button botonConSalario = new Button();
            botonConSalario.Name = "Empleado " + i.ToString();
            botonConSalario.Text = "" + cedula + "\n" + nombre + "\n" + salario.ToString();
            botonConSalario.ForeColor = Color.Black;
            botonConSalario.BackColor = Color.White;
            botonConSalario.Font = new Font("Arial", 10, FontStyle.Regular);
            botonConSalario.Width = 200;
            botonConSalario.Height = 60;
            botonConSalario.Location = new Point(start, end);
            botonConSalario.TextAlign = ContentAlignment.MiddleCenter;
            botonConSalario.Margin = new Padding(5);
            return botonConSalario;
        }

        private void clickAboton(object sender, EventArgs e, string cedula, string nombre, int salario)
        {
            infoCedula = cedula;
            infoNombre = nombre;
            infoSalario = salario;
            ModificarSalario02 modificarSalario02 = new ModificarSalario02();
            this.Hide();
            modificarSalario02.Show();
        }*/



        public Database AbrirBaseDeDatos()
        {
            var connectionString = @"Server=tcp:servidor-de-hr-payroll-system.database.windows.net,1433;Initial Catalog=HR_PAYROLL_SYSTEM;Persist Security Info=False;User ID=Kevin;Password=Leandro123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            return new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(connectionString);
        }

        private void ModificarSalario_Load_1(object sender, EventArgs e)
        {
            cargarDataGridView();
            /*int startposition = 100;
            int endposition = 10;
            var conexion = AbrirBaseDeDatos();
            var comando = conexion.GetStoredProcCommand("ADMINISTRADOR_VER_EMPLEADOS_PARA_SALARIOS");

            using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
            {
                while (informacionEncontrada.Read())
                {
                    int i = 0;
                    //string cedula = informacionEncontrada["PK_CEDULA"].ToString();
                    //string nombre = informacionEncontrada["NOMBRE"].ToString();
                    //int salario = int.Parse(informacionEncontrada["SALARIO"].ToString());
                    string cedula = informacionEncontrada.GetString(0);
                    string nombre = informacionEncontrada.GetString(1);
                    int salario = informacionEncontrada.GetInt32(2);
                    Button boton = agregarBoton(i, startposition, endposition, cedula, nombre, salario);
                    panelDeFlujoDeSalarios.Controls.Add(boton);
                    boton.Click += delegate (object sender1, EventArgs e1) { clickAboton(sender1, e1, cedula, nombre, salario); };
                    endposition += 100;
                }
            }*/
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
                    int salario = int.Parse(informacionEncontrada["SALARIO"].ToString());
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
        private void dataGridViewDeEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDeEmpleados.Columns[e.ColumnIndex].Name == "botonDeModificar")
            {
                DataGridViewRow fila = this.dataGridViewDeEmpleados.Rows[e.RowIndex];
                infoCedula = fila.Cells["dataGridViewTextBoxColumnCedula"].Value.ToString();
                infoNombre = fila.Cells["dataGridViewTextBoxColumnNombre"].Value.ToString();
                infoSalario = int.Parse(fila.Cells["dataGridViewTextBoxColumnSalario"].Value.ToString());
                ModificarSalario02 modificarSalario02 = new ModificarSalario02();
                this.Hide();
                modificarSalario02.Show();
            }
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
                    int salario = int.Parse(informacionEncontrada["SALARIO"].ToString());
                    string puesto = informacionEncontrada["PUESTO"].ToString();
                    int cantidadDeDiasDisponibles = int.Parse(informacionEncontrada["DIAS_LIBRES"].ToString());
                    empleadoEnObjetoBindingSource1.Clear();
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
                else
                {
                    empleadoEnObjetoBindingSource1.Clear();
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
    }
}
