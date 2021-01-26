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
    public partial class ModificarHorario02 : Form
    {
        public ModificarHorario02()
        {
            InitializeComponent();
        }

        static string infoCedula = "";
        static string infoHorario = "";
        static string infoNombre = "";
        static string horarioNuevo = "";

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            volverVistaDeHorarios();
        }

        public Database AbrirBaseDeDatos()
        {
            var connectionString = @"Server=tcp:servidor-de-hr-payroll-system.database.windows.net,1433;Initial Catalog=HR_PAYROLL_SYSTEM;Persist Security Info=False;User ID=Kevin;Password=Leandro123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            return new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(connectionString);
        }

        private void botonDeGuardarCambios_Click(object sender, EventArgs e)
        {
            guardarCambios();
        }

        private void guardarCambios()
        {
            const string message = "¿Guardar cambios?";
            const string caption = "Form Closing";
            horarioNuevo = textBoxDeHorarioNuevo.Text;
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
                var conexion = AbrirBaseDeDatos();
                var comando = conexion.GetStoredProcCommand("ADMINISTRADOR_CAMBIAR_HORARIO", infoCedula, horarioNuevo);
                conexion.ExecuteNonQuery(comando); 
                //volverVistaDeHorarios();
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Volver");
            }
        }

        private void ModificarHorario02_Load_1(object sender, EventArgs e)
        {
            infoCedula = ModificarHorario.infoCedula;
            infoNombre = ModificarHorario.infoNombre;
            infoHorario = ModificarHorario.infoHorario;
            mostrarInfo(infoNombre, infoHorario);
        }

        private void volverVistaDeHorarios()
        {
            ModificarHorario modificarHorario = new ModificarHorario();
            this.Hide();
            modificarHorario.Show();
        }

        private void mostrarInfo(string nombre, string horario)
        {
            textBoxDeNombre.Text = nombre;
            textBoxDeHorarioActual.Text = horario;
        }
    }
}
