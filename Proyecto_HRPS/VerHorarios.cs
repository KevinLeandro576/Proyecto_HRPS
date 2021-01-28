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
    public partial class VerHorarios : Form
    {
        public VerHorarios()
        {
            InitializeComponent();
        }

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            ControlDeEmpleados controlDeEmpleados = new ControlDeEmpleados();
            controlDeEmpleados.Show();
            this.Hide();
        }

        private void VerHorarios_Load(object sender, EventArgs e)
        {
            var conexion = AbrirBaseDeDatos();
            var comando = conexion.GetStoredProcCommand("[ADMINISTRADOR_VER_HORARIOS]");
            DataSet ds = new DataSet();            

            using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
            {
                while (informacionEncontrada.Read())
                {
                    
                }
            }
        }
        public Database AbrirBaseDeDatos()
        {
            var connectionString = @"Server=tcp:servidor-de-hr-payroll-system.database.windows.net,1433;Initial Catalog=HR_PAYROLL_SYSTEM;Persist Security Info=False;User ID=Kevin;Password=Leandro123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            return new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(connectionString);
        }
    }
}
