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
    public partial class SolicitudesHorasExtra : Form
    {
        public SolicitudesHorasExtra()
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
            var comando = conexion.GetStoredProcCommand("EMPLEADO_INSERTAR_SOLICITUD_HORAS_EXTRAS", textBoxDeNombre.Text,
                                                                                                   dateTimePickerDeDiaTrabajado.Value,
                                                                                                   numericDeCantidadDeHorasExtra.Value);
            conexion.ExecuteNonQuery(comando);
            //ENVIA UN CORREO
            AdministradorDeCorreo administradorDeCorreo = new AdministradorDeCorreo("smtp.gmail.com", "1037joseg@gmail.com", "Qwertz987.,!", 587);

            StringBuilder builder = new StringBuilder();

            builder.Append("<table class=table table-bordered align= center border= 1 cellpadding= 3 cellspacing= 0 width= 100%'>");
            builder.Append("<tr>");
            builder.Append("<th>NOMBRE</th>");
            builder.Append("<th>FECHA DE SOLICITUD</th>");
            builder.Append("<th>CANTIDAD DE HORAS</th>");
            builder.Append("<th>ESTADO DE SOLICITUD</th>");
            builder.Append("</tr>");

            builder.Append("<tr>");
            builder.Append("<td>" + textBoxDeNombre.Text + "</td>");
            builder.Append("<td>" + dateTimePickerDeDiaTrabajado.Value.ToString() + "</td>");
            builder.Append("<td>" + numericDeCantidadDeHorasExtra.Value.ToString() + "</td>");
            builder.Append("<td>" + "PENDIENTE" + "</td>");
            builder.Append("</tr>");
            builder.Append("</table>");


            var comando02 = conexion.GetStoredProcCommand("[SACAR_CORREO_DE_EMPLEADO_CON_NOMBRE]", textBoxDeNombre.Text);
            string correoDeEmpleado = "";
            string correoDeAdministrador;
            List<string> listaDeCorreos = new List<string>();
            listaDeCorreos.Add("1037joseg@gmail.com");
            listaDeCorreos.Add("leandrokevin576@gmail.com");
            using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando02))
            {
                if (informacionEncontrada.Read())
                {
                    correoDeEmpleado = informacionEncontrada.GetString(0);
                }
            }
            var comando03 = conexion.GetStoredProcCommand("[SACAR_CORREOS_DE_ADMINISTRADORES]");

            using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando03))
            {
                while (informacionEncontrada.Read())
                {
                    correoDeAdministrador = informacionEncontrada["CORREO"].ToString();
                    listaDeCorreos.Add(correoDeAdministrador);
                }
            }
            administradorDeCorreo.EnviarCorreo("<h1>Ha enviado una solicitud de horas extra</h1> <br/> " + builder.ToString(), "Solicitud de horas extra", "1037joseg@gmail.com", "Electrónica UREBA S.A.", new List<string> { correoDeEmpleado });
            administradorDeCorreo.EnviarCorreo("<h1>Ha recibido una solicitud de horas extra</h1> <br/> " + builder.ToString(), "Solicitud de horas extra", "1037joseg@gmail.com", "Electrónica UREBA S.A.", listaDeCorreos);
        }
        public Database AbrirBaseDeDatos()
        {
            var connectionString = @"Server=tcp:servidor-de-hr-payroll-system.database.windows.net,1433;Initial Catalog=HR_PAYROLL_SYSTEM;Persist Security Info=False;User ID=Kevin;Password=Leandro123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            return new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(connectionString);
        }
    }
}
