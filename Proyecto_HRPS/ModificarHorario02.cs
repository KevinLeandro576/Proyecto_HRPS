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

        static string info_cedula = "";
        static string info_horario = "";
        static string horario_nuevo = "";

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ModificarHorario02_Load(object sender, EventArgs e)
        {
            info_cedula = ModificarHorario.info_cedula;
            info_horario = ModificarHorario.info_horario;
            Label label = agregarLabel(info_cedula, info_horario);
        }

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            ModificarHorario modificarHorario = new ModificarHorario();
            this.Hide();
            modificarHorario.Show();
        }

        Label agregarLabel(string cedula, string horario)
        {
            Label labelConHorario = new Label();
            labelConHorario.Name = "Empleado " + cedula;
            labelConHorario.Text = horario;
            labelConHorario.ForeColor = Color.Black;
            labelConHorario.BackColor = Color.White;
            labelConHorario.Font = new Font("Arial", 10, FontStyle.Regular);
            labelConHorario.Width = 176;
            labelConHorario.Height = 20;
            labelConHorario.Location = new Point(255, 62);
            return labelConHorario;
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
                var comando = conexion.GetStoredProcCommand("ADMINISTRADOR_CAMBIAR_HORARIO", info_cedula, horario_nuevo);
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Volver");
            }
        }
    }
}
