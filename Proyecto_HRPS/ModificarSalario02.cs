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

        static string infoCedula = "";
        static string infoNombre = "";
        static int infoSalario = 0;
        static int salarioNuevo = 0;

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            volverVistaDeSalarios();
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
            salarioNuevo = int.Parse(textBoxDeSalarioNuevo.Text);
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
                var comando = conexion.GetStoredProcCommand("ADMINISTRADOR_CAMBIAR_SALARIO", infoCedula, salarioNuevo);
                conexion.ExecuteNonQuery(comando);
                volverVistaDeSalarios();
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Volver");
            }
        }

        private void ModificarSalario02_Load_1(object sender, EventArgs e)
        {
            infoCedula = ModificarSalario.infoCedula;
            infoNombre = ModificarSalario.infoNombre;
            infoSalario = ModificarSalario.infoSalario;
            mostrarInfo(infoNombre, infoSalario);
        }

        private void mostrarInfo(string nombre, int salario)
        {
            textBoxDeNombre.Text = nombre;
            textBoxDeSalarioActual.Text = salario.ToString();
        }

        private void volverVistaDeSalarios()
        {
            ModificarSalario modificarSalario = new ModificarSalario();
            this.Hide();
            modificarSalario.Show();
        }
    }
}
