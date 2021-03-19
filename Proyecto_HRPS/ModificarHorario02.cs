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
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }

        static string infoCedula = "";
        static string infoHorario = "";
        static string infoNombre = "";
        static string horarioNuevo = "";

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            volverVistaDeHorarios();
        }

        public Database AbrirBaseDeDatos()
        {
            try
            {
                var connectionString = @"Server=tcp:servidor-de-hr-payroll-system.database.windows.net,1433;Initial Catalog=HR_PAYROLL_SYSTEM;Persist Security Info=False;User ID=Kevin;Password=Leandro123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
                return new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(connectionString);
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
                return null;
            }
        }

        private void botonDeGuardarCambios_Click(object sender, EventArgs e)
        {
            if (HorarioEstaBienEscrito() && horarioNoEsIgual() && horariosSonIguales() == false && !soloTieneNumeros(textBoxDeHorarioNuevo.Text))
            {
                if (!soloTieneLetras(textBoxDeHorarioNuevo.Text))
                {
                    guardarCambios();
                }
                else
                {
                    textBoxDeHorarioNuevo.Focus();
                    MessageBox.Show("Revise horario", "Opciones de Horario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void guardarCambios()
        {
            try
            {

                var conexion = AbrirBaseDeDatos();
                const string message = "¿Guardar cambios?";
                const string caption = "Opciones de Horario";
                horarioNuevo = textBoxDeHorarioNuevo.Text;
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNoCancel,
                                             MessageBoxIcon.Question);
                // Seleccionar no
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Cambios descartados", caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == DialogResult.Yes)
                {
                    AdministradorDeCorreo administradorDeCorreo = new AdministradorDeCorreo("mail.electronicaureba.com", "planilla@electronicaureba.com", "Qwertz987.,!", 8889);
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
                    using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
                    {
                        if (informacionEncontrada.Read())
                        {
                            correoDeEmpleado = informacionEncontrada.GetString(0);
                        }
                    }
                    administradorDeCorreo.EnviarCorreo("<img src=https://i.ibb.co/jv7wTtq/LOGO-UREBA.png height=80vh width=100%> <br> <br> <h1>Atención, su horario ha sido modificado:</h1> <br/> " + builder.ToString(), "Modificación de Horario", "planilla@electronicaureba.com", "Electrónica UREBA S.A.", new List<string> { correoDeEmpleado });
                    MessageBox.Show("Cambios guardados", caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var comando02 = conexion.GetStoredProcCommand("ADMINISTRADOR_CAMBIAR_HORARIO", infoCedula, horarioNuevo);
                    conexion.ExecuteNonQuery(comando02);

                    string evento = "El empleado " + Empleado.Nombre + " ha cambiado el horario del empleado " + infoNombre + ", del horario " + textBoxDeHorarioActual.Text + " al horario " + horarioNuevo + "."; 
                    string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                    registrarEvento(evento, metodoYclase);

                    volverVistaDeHorarios();
                }
                else if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Regresando", caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }

        private void ModificarHorario02_Load_1(object sender, EventArgs e)
        {
            try
            {
                infoCedula = ModificarHorario.infoCedula;
                infoNombre = ModificarHorario.infoNombre;
                infoHorario = ModificarHorario.infoHorario;
                textBoxDeNombre.Enabled = false;
                textBoxDeHorarioActual.Enabled = false;
                mostrarInfo(infoNombre, infoHorario);
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }

        private void volverVistaDeHorarios()
        {
            try
            {
                ModificarHorario modificarHorario = new ModificarHorario();
                this.Hide();
                modificarHorario.Show();
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }

        private void mostrarInfo(string nombre, string horario)
        {
            try
            {
                textBoxDeNombre.Text = nombre;
                textBoxDeHorarioActual.Text = horario;
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }

        private void ModificarHorario02_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                const string message = "¿Desea cerrar la aplicación?";
                const string caption = "Opciones de Sesión";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNoCancel,
                                             MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Cerrando la aplicación", "Opciones de Sesión"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Environment.Exit(1);
                }
                else
                {
                    MessageBox.Show("Regresando", "Opciones de Sesión"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }


        public Boolean HorarioEstaBienEscrito()
        {
            try
            {
                bool estaBien = false;
                if (string.IsNullOrEmpty(textBoxDeHorarioNuevo.Text))
                {
                    textBoxDeHorarioNuevo.Focus();
                    estaBien = false;
                    MessageBox.Show("Revise horario", "Opciones de Horario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!horarioEstaBien(textBoxDeHorarioNuevo.Text))
                {
                    textBoxDeHorarioNuevo.Focus();
                    estaBien = false;
                    MessageBox.Show("Revise horario", "Opciones de Horario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    estaBien = true;
                }
                return estaBien;
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
                return false;
            }
        }
        bool horarioEstaBien(String horario)
        {
            try
            {
                Regex objAlphaPattern = new Regex("^[a-zA-Z0-9][a-zA-Z0-9 -]*$");
                return objAlphaPattern.IsMatch(horario);
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
                return false;
            }
        }
        bool horarioNoEsIgual()
        {
            bool estaBien = false;
            try
            {
                if (!(textBoxDeHorarioActual.Text.Equals(textBoxDeHorarioNuevo.Text)))
                {
                    estaBien = true;
                }
                else
                {
                    MessageBox.Show("Horario igual al anterior, cambiar", "Opciones de Horario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    estaBien = false;
                }
                return estaBien;
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
                return false;
            }
        }
        bool horariosSonIguales()
        {
            try
            {
                bool sonIguales = false;
                string horarioSinEspacios = textBoxDeHorarioActual.Text.Replace(" ", String.Empty);
                string horarioNuevoSinEspacios = textBoxDeHorarioNuevo.Text.Replace(" ", String.Empty);
                if (!horarioSinEspacios.Equals(horarioNuevoSinEspacios))
                {
                    sonIguales = false;
                }
                else
                {
                    sonIguales = true;
                    MessageBox.Show("Horario igual al anterior, cambiar", "Opciones de Horario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return sonIguales;
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
                return false;
            }
        }

        private void registrarError(Exception ex, string metodoYclase)
        {
            string texto = "Error: " + ex.ToString();
            var conexion = AbrirBaseDeDatos();
            var comando = conexion.GetStoredProcCommand("[INSERTAR_EVENTO]", texto,
                                                                             metodoYclase);
            conexion.ExecuteNonQuery(comando);
        }

        private void registrarEvento(string evento, string metodoYclase)
        {
            try
            {
                var conexion = AbrirBaseDeDatos();
                var comando = conexion.GetStoredProcCommand("[INSERTAR_EVENTO]", evento,
                                                                                metodoYclase);
                conexion.ExecuteNonQuery(comando);
            }
            catch (Exception ex)
            {
                string metodoYclase02 = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase02);
            }
        }
        bool soloTieneNumeros(string str)
        {
            try
            {
                foreach (char c in str)
                {
                    if (c < '0' || c > '9')
                    {
                        return false;
                    }
                }
                MessageBox.Show("Revise horario", "Opciones de Horario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
                return false;
            }
        }
        bool soloTieneLetras(String strToCheck)
        {
            try
            {
                Regex objAlphaPattern = new Regex("^[a-z A-Z\u00C0-\u00FF]*$");
                return objAlphaPattern.IsMatch(strToCheck);
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
                return false;
            }
        }
    }
}
