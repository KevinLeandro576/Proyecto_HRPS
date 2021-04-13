using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_HRPS
{
    public partial class VerHorasExtra : Form
    {
        List<string> nombresConLetras = new List<string>();
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
                PonerNombresAcomboBox();
                textBoxDeCedula.Enabled = false;
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

        private void PonerNombresAcomboBox()
        {
            try
            {
                comboBoxDeNombres.SelectedItem = null;
                comboBoxDeNombres.SelectedText = "Seleccione el nombre de un empleado";
                comboBoxDeNombres.ForeColor = Color.Gray;
                var conexion = AbrirBaseDeDatos();
                var comando = conexion.GetStoredProcCommand("[SACAR_NOMBRES_DE_EMPLEADOS]");
                using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
                {
                    while (informacionEncontrada.Read())
                    {
                        comboBoxDeNombres.Items.Add(informacionEncontrada["NOMBRE"].ToString());
                        nombresConLetras.Add(informacionEncontrada["NOMBRE"].ToString());
                    }
                    comboBoxDeNombres.ValueMember = "NOMBRE";
                    comboBoxDeNombres.DisplayMember = "NOMBRE";
                }
            }
            catch (Exception ex)
            {
                string metodoYclase02 = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase02);
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
                Buscar();
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
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

        private void Buscar()
        {
            try
            {
                string nombre = comboBoxDeNombres.GetItemText(comboBoxDeNombres.SelectedItem);
                if (comboBoxDeNombres.SelectedIndex != -1)
                {
                    var conexion = AbrirBaseDeDatos();
                    var comando = conexion.GetStoredProcCommand("[ADMINISTRADOR_VER_HORAS_EXTRAS]", nombre);
                    using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
                    {
                        if (informacionEncontrada.Read())
                        {
                            textBoxDeCedula.Text = informacionEncontrada.GetString(0);
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
                            var comando02 = conexion.GetStoredProcCommand("[SACAR_INFORMACION_DE_EMPLEADO_PARA_HORAS_EXTRA]", nombre);
                            using (IDataReader informacionEncontrada02 = conexion.ExecuteReader(comando02))
                            {
                                if (informacionEncontrada02.Read())
                                {
                                    decimal salarioBruto = decimal.Parse(informacionEncontrada02["SALARIO"].ToString());
                                    textBoxDeCedula.Text = informacionEncontrada02["PK_CEDULA"].ToString(); ;
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
                                    comboBoxDeNombres.Focus();
                                    MessageBox.Show("Revisa nombre", "Opciones de Horas Extra", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void comboBoxDeNombres_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Buscar();
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }


        private void comboBoxDeNombres_DropDown(object sender, EventArgs e)
        {
            try
            {
                comboBoxDeNombres.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }
        private void comboBoxDeNombres_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                string letra = comboBoxDeNombres.Text;
                var conexion = AbrirBaseDeDatos();
                var comando = conexion.GetStoredProcCommand("[SACAR_NOMBRES_DE_EMPLEADOS_CON_LETRAS]", letra);
                using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
                {
                    if (informacionEncontrada.Read())
                    {
                        comboBoxDeNombres.Items.Clear();
                        comboBoxDeNombres.SelectionStart = comboBoxDeNombres.Text.Length;
                        do
                        {
                            comboBoxDeNombres.Items.Add(informacionEncontrada["NOMBRE"].ToString());
                        } while (informacionEncontrada.Read());
                        comboBoxDeNombres.ValueMember = "NOMBRE";
                        comboBoxDeNombres.DisplayMember = "NOMBRE";
                    }
                    else
                    {
                        comboBoxDeNombres.Items.Clear();
                        comboBoxDeNombres.SelectionStart = comboBoxDeNombres.Text.Length;
                        var comando02 = conexion.GetStoredProcCommand("[SACAR_NOMBRES_DE_EMPLEADOS]");
                        using (IDataReader informacionEncontrada02 = conexion.ExecuteReader(comando02))
                        {
                            while (informacionEncontrada02.Read())
                            {
                                comboBoxDeNombres.Items.Add(informacionEncontrada02["NOMBRE"].ToString());
                                nombresConLetras.Add(informacionEncontrada02["NOMBRE"].ToString());
                            }
                            comboBoxDeNombres.ValueMember = "NOMBRE";
                            comboBoxDeNombres.DisplayMember = "NOMBRE";
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
    }
}
