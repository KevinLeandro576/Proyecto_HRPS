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
using System.Text.RegularExpressions;

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
            if (HorarioEstaBienEscrito())
            {
                var conexion = AbrirBaseDeDatos();
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
                    AdministradorDeCorreo administradorDeCorreo = new AdministradorDeCorreo("smtp.gmail.com", "1037joseg@gmail.com", "Qwertz987.,!", 587);
                    StringBuilder builder = new StringBuilder();

                    builder.Append("<table class=table table-bordered align=center border=1 cellpadding= 3 cellspacing= 0 width= 100%'>");
                    builder.Append("<tr>");
                    builder.Append("<th>HORARIO NUEVO</th>");
                    builder.Append("</tr>");
                    builder.Append("<tr>");
                    builder.Append("<td align=center>" + horarioNuevo + "</td>");
                    builder.Append("</tr>");
                    builder.Append("</table>");


                    var comando = conexion.GetStoredProcCommand("[SACAR_CORREO_DE_EMPLEADO_CON_NOMBRE]", infoNombre);
                    string correoDeEmpleado = "";
                    List<string> listaDeCorreos = new List<string>();
                    listaDeCorreos.Add("1037joseg@gmail.com");
                    listaDeCorreos.Add("leandrokevin576@gmail.com");
                    using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
                    {
                        if (informacionEncontrada.Read())
                        {
                            correoDeEmpleado = informacionEncontrada.GetString(0);
                        }
                    }
                    administradorDeCorreo.EnviarCorreo("<h1>Su horario ha sido modificado</h1> <br/> " + builder.ToString(), "Modificación de horario", "1037joseg@gmail.com", "Electrónica UREBA S.A.", new List<string> { correoDeEmpleado });
                    MessageBox.Show("Cambios guardados");
                    var comando02 = conexion.GetStoredProcCommand("ADMINISTRADOR_CAMBIAR_HORARIO", infoCedula, horarioNuevo);
                    conexion.ExecuteNonQuery(comando02);
                    //volverVistaDeHorarios();
                }
                else if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Regresando");
                }
            }
        }

        private void ModificarHorario02_Load_1(object sender, EventArgs e)
        {
            infoCedula = ModificarHorario.infoCedula;
            infoNombre = ModificarHorario.infoNombre;
            infoHorario = ModificarHorario.infoHorario;
            textBoxDeNombre.Enabled = false;
            textBoxDeHorarioActual.Enabled = false;
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

        private void ModificarHorario02_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public Boolean HorarioEstaBienEscrito()
        {
            bool estaBien = false;
            if (string.IsNullOrEmpty(textBoxDeHorarioNuevo.Text))
            {
                textBoxDeHorarioNuevo.Focus();
                estaBien = false;
                MessageBox.Show("Revisa horario", "Opciones de Perfil");
            }
            else if (!horarioEstaBien(textBoxDeHorarioNuevo.Text))
            {
                textBoxDeHorarioNuevo.Focus();
                estaBien = false;
                MessageBox.Show("Revisa horario", "Opciones de Perfil");
            }
            else
            {
                estaBien = true;
            }
            return estaBien;
        }
        bool horarioEstaBien(String horario)
        {
            Regex objAlphaPattern = new Regex("^[a-zA-Z0-9][a-zA-Z0-9 -]*$");
            return objAlphaPattern.IsMatch(horario);
        }

    }
}
