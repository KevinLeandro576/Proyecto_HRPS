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

        private void VerHorasExtra_Load(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            try
            {
                ControlDeEmpleados controlDeEmpleados = new ControlDeEmpleados();
                this.Hide();
                controlDeEmpleados.Show();
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
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

        private void botonDeBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string cedula = textBoxDeCedula.Text;
                if (cedulaEstaBienEscrita())
                {
                    var conexion = AbrirBaseDeDatos();
                    var comando = conexion.GetStoredProcCommand("[ADMINISTRADOR_VER_HORAS_EXTRAS]", cedula);
                    using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
                    {
                        if (informacionEncontrada.Read())
                        {
                            string nombre = informacionEncontrada.GetString(0);
                            textBoxDeNombre.Text = nombre;
                            string horario = informacionEncontrada.GetString(1);
                            textBoxDeHorario.Text = horario;
                            decimal salarioBruto = informacionEncontrada.GetDecimal(2);
                            salarioBruto = decimal.Round(salarioBruto, 2);
                            textBoxDeSalarioBruto.Text = salarioBruto.ToString();
                            decimal salarioPorHora = informacionEncontrada.GetDecimal(3);
                            salarioPorHora = decimal.Round(salarioPorHora, 2);
                            textBoxDeSalarioPorHora.Text = salarioPorHora.ToString();
                            decimal cantidadDeHorasExtra = informacionEncontrada.GetDecimal(4);
                            cantidadDeHorasExtra = decimal.Round(cantidadDeHorasExtra, 2);
                            textBoxDeCantidadDeHorasExtra.Text = cantidadDeHorasExtra.ToString();
                            decimal pagoPorHorasExtra = informacionEncontrada.GetDecimal(5);
                            pagoPorHorasExtra = decimal.Round(pagoPorHorasExtra, 2);
                            textBoxDePagoPorHorasExtra.Text = pagoPorHorasExtra.ToString();
                            decimal salarioBrutoConHorasExtra = informacionEncontrada.GetDecimal(6);
                            salarioBrutoConHorasExtra = decimal.Round(salarioBrutoConHorasExtra, 2);
                            textBoxDeSalarioBrutoConHorasExtra.Text = salarioBrutoConHorasExtra.ToString();
                            decimal deducciones = informacionEncontrada.GetDecimal(7);
                            deducciones = decimal.Round(deducciones, 2);
                            textBoxDeDeducciones.Text = deducciones.ToString();
                            decimal salarioNeto = informacionEncontrada.GetDecimal(8);
                            salarioNeto = decimal.Round(salarioNeto, 2);
                            textBoxDeSalarioNeto.Text = salarioNeto.ToString();
                        }
                        else
                        {
                            var comando02 = conexion.GetStoredProcCommand("[SACAR_INFORMACION_DE_EMPLEADO]", cedula);
                            using (IDataReader informacionEncontrada02 = conexion.ExecuteReader(comando02))
                            {
                                if (informacionEncontrada02.Read())
                                {
                                    decimal salarioBruto = decimal.Parse(informacionEncontrada02["SALARIO"].ToString());
                                    textBoxDeNombre.Text = informacionEncontrada02["NOMBRE"].ToString(); ;
                                    textBoxDeHorario.Text = informacionEncontrada02["HORARIO"].ToString();
                                    textBoxDeSalarioBruto.Text = salarioBruto.ToString();
                                    decimal salarioPorHora = decimal.Parse(informacionEncontrada02["SALARIO_HORA"].ToString());
                                    salarioPorHora = decimal.Round(salarioPorHora, 2);
                                    textBoxDeSalarioPorHora.Text = salarioPorHora.ToString();
                                    textBoxDeCantidadDeHorasExtra.Text = "0";
                                    textBoxDePagoPorHorasExtra.Text = "0.00";
                                    salarioBruto = decimal.Round(salarioBruto, 2);
                                    textBoxDeSalarioBrutoConHorasExtra.Text = salarioBruto.ToString();
                                    decimal deducciones = salarioBruto * 0.13M;
                                    deducciones = decimal.Round(deducciones, 2);
                                    textBoxDeDeducciones.Text = deducciones.ToString();
                                    decimal salarioNeto = salarioBruto - deducciones;
                                    salarioNeto = decimal.Round(salarioNeto, 2);
                                    textBoxDeSalarioNeto.Text = salarioNeto.ToString();
                                }
                                else
                                {
                                    textBoxDeCedula.Focus();
                                    MessageBox.Show("Cédula no registrada o inactiva", "Opciones de Horas Extra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    reiniciarPagina();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }
        private bool cedulaEstaBienEscrita()
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxDeCedula.Text) || textBoxDeCedula.Text.Length != 9 || !soloTieneNumeros(textBoxDeCedula.Text))
                {
                    textBoxDeCedula.Focus();
                    MessageBox.Show("Revise cédula", "Opciones de Horas Extra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
                return false;
            }
        }
        bool soloTieneNumeros(string str)
        {
            try
            {
                foreach (char c in str)
                {
                    if (c < '0' || c > '9')
                        return false;
                }
                return true;
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
        private void reiniciarPagina()
        {
            try
            {
                VerHorasExtra verHorasExtra = new VerHorasExtra();
                this.Hide();
                verHorasExtra.Show();
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }

        private void VerHorasExtra_FormClosing(object sender, FormClosingEventArgs e)
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
                    Application.Exit();
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

    }
}
