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
    public partial class ModificarSalario02 : Form
    {
        public ModificarSalario02()
        {
            InitializeComponent();
        }

        static string info_cedula = "";
        static int info_salario = 0;
        static int salario_nuevo = 0;

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            ModificarSalario modificarSalario = new ModificarSalario();
            this.Hide();
            modificarSalario.Show();
        }

        private void ModificarSalario02_Load(object sender, EventArgs e)
        {
            info_cedula = ModificarSalario.info_cedula;
            info_salario = ModificarSalario.info_salario;
            Label label = agregarLabel(info_cedula, info_salario);
        }

        Label agregarLabel(string cedula, int salario)
        {
            Label labelConSalario = new Label();
            labelConSalario.Name = "Empleado " + cedula;
            labelConSalario.Text = salario.ToString();
            labelConSalario.ForeColor = Color.Black;
            labelConSalario.BackColor = Color.White;
            labelConSalario.Font = new Font("Arial", 10, FontStyle.Regular);
            labelConSalario.Width = 176;
            labelConSalario.Height = 20;
            labelConSalario.Location = new Point(248, 65);
            return labelConSalario;
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
                var comando = conexion.GetStoredProcCommand("ADMINISTRADOR_CAMBIAR_SALARIO", info_cedula, salario_nuevo);
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Volver");
            }
        }
    }
}
