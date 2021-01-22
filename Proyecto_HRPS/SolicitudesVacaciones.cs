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
    public partial class SolicitudesVacaciones : Form
    {
        public SolicitudesVacaciones()
        {
            InitializeComponent();
        }

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            SolicitudesEmpleados solicitudesEmpleados = new SolicitudesEmpleados();
            this.Hide();
            solicitudesEmpleados.Show();
        }

        private void botonDeEnviar_Click(object sender, EventArgs e)
        {
            var conexion = AbrirBaseDeDatos();
            var comando = conexion.GetStoredProcCommand("EMPLEADO_INSERTAR_SOLICITUD_VACACIONES", textBoxDeNombre.Text,
                                                                                                   dateTimePickerDeFechaDeInicio.Value,
                                                                                                   dateTimePickerDeFechaDeFinalizacion.Value);
            conexion.ExecuteNonQuery(comando);
        }
        public Database AbrirBaseDeDatos()
        {
            var connectionString = @"Server=tcp:servidor-de-hr-payroll-system.database.windows.net,1433;Initial Catalog=HR_PAYROLL_SYSTEM;Persist Security Info=False;User ID=Kevin;Password=Leandro123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            return new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(connectionString);
        }
    }
}
