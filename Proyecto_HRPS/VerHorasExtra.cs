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
    public partial class VerHorasExtra : Form
    {
        public VerHorasExtra()
        {
            InitializeComponent();
        }

        private void VerHorasExtra_Load(object sender, EventArgs e)
        {
            textBoxDeNombre.Enabled = false;
            textBoxDeHorario.Enabled = false;
            textBoxDeSalarioBruto.Enabled = false;
            textBoxDeSalarioPorHora.Enabled = false;
            textBoxDeCantidadDeHorasExtra.Enabled = false;
            textBoxDePagoPorHorasExtra.Enabled = false;
            textBoxDeSalarioBrutoConHorasExtra.Enabled = false;
            textBoxDeDeducciones.Enabled = false;
            textBoxDeSalarioNeto.Enabled = false;
        }

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            ControlDeEmpleados controlDeEmpleados = new ControlDeEmpleados();
            this.Hide();
            controlDeEmpleados.Show();
        }
        public Database AbrirBaseDeDatos()
        {
            var connectionString = @"Server=tcp:servidor-de-hr-payroll-system.database.windows.net,1433;Initial Catalog=HR_PAYROLL_SYSTEM;Persist Security Info=False;User ID=Kevin;Password=Leandro123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            return new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(connectionString);
        }

        private void botonDeBuscar_Click(object sender, EventArgs e)
        {
            string cedula = textBoxDeCedula.Text;
            var conexion = AbrirBaseDeDatos();
            var comando = conexion.GetStoredProcCommand("[ADMINISTRADOR_VER_HORAS_EXTRAS]", cedula);
            using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
            {
                if (informacionEncontrada.Read())
                {
                    textBoxDeNombre.Text = informacionEncontrada.GetString(0);
                    textBoxDeHorario.Text = informacionEncontrada.GetString(1);
                    textBoxDeSalarioBruto.Text = informacionEncontrada.GetInt32(2).ToString(); //
                    textBoxDeSalarioPorHora.Text = informacionEncontrada.GetDecimal(3).ToString();
                    textBoxDeCantidadDeHorasExtra.Text = informacionEncontrada.GetDecimal(4).ToString();
                    textBoxDePagoPorHorasExtra.Text = informacionEncontrada.GetDecimal(5).ToString();
                    textBoxDeSalarioBrutoConHorasExtra.Text = informacionEncontrada.GetDecimal(6).ToString();
                    textBoxDeDeducciones.Text = informacionEncontrada.GetDecimal(7).ToString();
                    textBoxDeSalarioNeto.Text = informacionEncontrada.GetDecimal(8).ToString();
                }
            }
        }
    }
}
