﻿using System;
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
        static string infoNombre = "";
        static decimal infoSalario = 0;
        static decimal salarioNuevo = 0;

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            try
            {
                volverVistaDeSalarios();
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

        private void botonDeGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                if (salarioNoEsIgual())
                {
                    guardarCambios();
                }
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }

        private void guardarCambios()
        {
            try
            {
                string caption = "Opciones de Salario";
                if (numericUpDownDeSalario.Value < numericUpDownDeSalario.Minimum)
                {
                    MessageBox.Show("Salario menor a mínimo, por favor cambiar", caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (numericUpDownDeSalario.Value > numericUpDownDeSalario.Maximum)
                {
                    MessageBox.Show("Salario mayor al máximo, por favor cambiar", caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    const string message = "¿Guardar cambios?";
                    salarioNuevo = numericUpDownDeSalario.Value;
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.YesNoCancel,
                                                 MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        MessageBox.Show("Cambios descartados", caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (result == DialogResult.Yes)//ERROR AQUI PORQUE NO SE SALDRIA DE IF
                    {

                        var conexion = AbrirBaseDeDatos();
                        var comando = conexion.GetStoredProcCommand("ADMINISTRADOR_CAMBIAR_SALARIO", infoCedula, salarioNuevo);
                        conexion.ExecuteNonQuery(comando);
                        string evento = "El empleado " + Empleado.Nombre + " ha cambiado el salario del empleado " + infoNombre + ", del salario " + textBoxDeSalarioActual.Text + " al salario " + numericUpDownDeSalario.Value.ToString() + ".";
                        string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                        registrarEvento(evento, metodoYclase);
                        MessageBox.Show("Cambios guardados", caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        volverVistaDeSalarios();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        MessageBox.Show("Regresando", caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }

        private void ModificarSalario02_Load_1(object sender, EventArgs e)
        {
            try
            {
                infoCedula = ModificarSalario.infoCedula;
                infoNombre = ModificarSalario.infoNombre;
                infoSalario = ModificarSalario.infoSalario;
                textBoxDeNombre.Enabled = false;
                textBoxDeSalarioActual.Enabled = false;
                mostrarInfo(infoNombre, infoSalario);
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }

        private void mostrarInfo(string nombre, decimal salario)
        {
            try
            {
                textBoxDeNombre.Text = nombre;
                textBoxDeSalarioActual.Text = salario.ToString();
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }

        private void volverVistaDeSalarios()
        {
            try
            {
                ModificarSalario modificarSalario = new ModificarSalario();
                this.Hide();
                modificarSalario.Show();
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }

        private void ModificarSalario02_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }
        public Boolean SalarioEstaBien()
        {
            try
            {
                bool estaBien = false;
                if (numericUpDownDeSalario.Value < numericUpDownDeSalario.Minimum || numericUpDownDeSalario.Value > numericUpDownDeSalario.Maximum)
                {
                    numericUpDownDeSalario.Focus();
                    estaBien = false;
                    MessageBox.Show("Revisa salario", "Opciones de Salario");
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
        bool salarioNoEsIgual()
        {
            try
            {
                if (!(textBoxDeSalarioActual.Text.Equals(numericUpDownDeSalario.Value.ToString() + ",00")))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Salario igual al anterior, cambiar", "Opciones de Horario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
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

        /* private void numericUpDownDeSalario_KeyUp(object sender, KeyEventArgs e)
         {
             try
             {
                 string caption = "Opciones de Salario";
                 if (numericUpDownDeSalario.Value < numericUpDownDeSalario.Minimum)
                 {
                     MessageBox.Show("Salario menor a mínimo, por favor cambiar", caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
                 else if (numericUpDownDeSalario.Value > numericUpDownDeSalario.Maximum)
                 {
                     MessageBox.Show("Salario mayor al máximo, por favor cambiar", caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
             }
             catch (Exception ex)
             {
                 string metodoYclase02 = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                 registrarError(ex, metodoYclase02);
             }
         }*/
    }
}
