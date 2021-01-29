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
    public partial class AdministradorInicioDeSesion : Form
    {
        public AdministradorInicioDeSesion()
        {
            InitializeComponent();
        }

        private void botonDeIniciarSesion_Click(object sender, EventArgs e)
        {
            generarCorreo();
            MenuDeAdministrador menuDeAdministrador = new MenuDeAdministrador();
            Empleado.Cedula = textBoxDeCedula.Text;
            this.Hide();
            menuDeAdministrador.Show();
        }

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            MenuInicial menuInicial = new MenuInicial();
            this.Hide();
            menuInicial.Show();
        }

        public Database AbrirBaseDeDatos()
        {
            var connectionString = @"Server=tcp:servidor-de-hr-payroll-system.database.windows.net,1433;Initial Catalog=HR_PAYROLL_SYSTEM;Persist Security Info=False;User ID=Kevin;Password=Leandro123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            return new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(connectionString);
        }

        private void generarCorreo()
        {
            var conexion = AbrirBaseDeDatos();
            var comando = conexion.GetStoredProcCommand("MOSTRAR_EMPLEADOS_CON_DIAS_LIBRES");

            using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
            {
                if (informacionEncontrada.FieldCount != 0)
                {
                    if (informacionEncontrada.Read() == true)
                    {
                        //ENVIA UN CORREO
                        AdministradorDeCorreo administradorDeCorreo = new AdministradorDeCorreo("smtp.gmail.com", "1037joseg@gmail.com", "Qwertz987.,!", 25);

                        StringBuilder builder = new StringBuilder();

                        builder.Append("<table class=table table-bordered align= center border= 1 cellpadding= 3 cellspacing= 0 width= 100%'>");
                        builder.Append("<tr>");
                        builder.Append("<th>CÉDULA</th>");
                        builder.Append("<th>NOMBRE</th>");
                        builder.Append("<th>CANTIDAD DE DÍAS DISPONIBLES</th>");
                        builder.Append("</tr>");

                        builder.Append("<tr align= center>");
                        builder.Append("<td>" + informacionEncontrada.GetString(0) + "</td>");
                        builder.Append("<td>" + informacionEncontrada.GetString(1) + "</td>");
                        builder.Append("<td>" + informacionEncontrada.GetInt32(2).ToString() + "</td>");
                        builder.Append("</tr>");
                        builder.Append("</table>");

                        var comando02 = conexion.GetStoredProcCommand("SACAR_CORREOS_DE_ADMINISTRADORES");
                        string correoDeAdministrador = "";
                        List<string> listaDeCorreos = new List<string>();
                        listaDeCorreos.Add("leandrokevin576@gmail.com");
                        using (IDataReader informacionEncontrada01 = conexion.ExecuteReader(comando02))
                        {
                            while (informacionEncontrada.Read())
                            {
                                correoDeAdministrador = informacionEncontrada01.GetString(0);
                                listaDeCorreos.Add(correoDeAdministrador);
                            }
                        }
                        administradorDeCorreo.EnviarCorreo("<h1>Los siguientes empleados </h1> <br/> " + builder.ToString(), "Notificación de 10 días libres", "1037joseg@gmail.com", "Electrónica UREBA S.A.", listaDeCorreos);
                    }
                }
            }

        }
    }
}
