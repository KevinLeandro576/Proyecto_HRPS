﻿using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Proyecto_HRPS
{

    public partial class CrearPerfilDeUsuario : Form
    {
        int rol = 0;
        string tiempo = "";
        TextBox txt;
        TextBox txt01;
        public CrearPerfilDeUsuario()
        {
            try
            {
                InitializeComponent();
                dateTimePickerDeFechaDeNacimiento.MaxDate = DateTime.Today;
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
                PerfilesDeUsuario perfilesDeUsuario = new PerfilesDeUsuario();
                this.Hide();
                perfilesDeUsuario.Show();
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }
        //POR CADA FORMULARIO CON CRUD
        public Database AbrirBaseDeDatos()
        {
            try
            {
                //var connectionString = @"Server=tcp:servidor-de-hr-payroll-system.database.windows.net,1433;Initial Catalog=HR_PAYROLL_SYSTEM;Persist Security Info=False;User ID=Kevin;Password=Leandro123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
                //var connectionString = @"Server=localhost\SQLEXPRESS;Initial Catalog=HR_PAYROLL_SYSTEM;Integrated Security=True;MultipleActiveResultSets=True;";
                //var connectionString = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=C:\Users\joseg\Source\Repos\Proyecto_HRPS\Proyecto_HRPS\PLANILLAS.mdf;Integrated Security=True;MultipleActiveResultSets=True;";
                var connectionString = @"Data Source=(localdb)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\PLANILLAS.mdf; Initial Catalog=HR_PAYROLL_SYSTEM;Connect Timeout=15;MultipleActiveResultSets=True;Integrated Security=True;";
                return new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(connectionString);
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
                return null;
            }
        }
        //POR CADA INSERT   
        private void botonDeRegistrarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                string claveTemporal = RandomString(5);
                string claveTemporalEncriptada = encriptarClaveAsha256(claveTemporal);
                claveTemporalEncriptada = claveTemporalEncriptada.Substring(0, 24);
                var conexion = AbrirBaseDeDatos();
                const string message = "Desea agregar un nuevo empleado?";
                const string caption = "Opciones de Perfil";

                //VALIDAR AQUI
                if (validarTodo() == true && !empleadoExiste())
                {
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.YesNoCancel,
                                                 MessageBoxIcon.Question);
                    string correoDeEmpleado = textBoxDeCorreoElectronico.Text;
                    List<string> listaDeCorreos = new List<string>();
                    listaDeCorreos.Add("leandrokevin576@gmail.com");
                    AdministradorDeCorreo administradorDeCorreo = new AdministradorDeCorreo("mail.electronicaureba.com", "planilla@electronicaureba.com", "Qwertz987.,!", 8889);
                    StringBuilder builder = new StringBuilder();
                    builder.Append("<table class=table table-bordered align= center border= 1 cellpadding= 3 cellspacing= 0 width= 100%'>");
                    builder.Append("<tr>");
                    builder.Append("<th>CÉDULA</th>");
                    builder.Append("<th>NOMBRE</th>");
                    builder.Append("<th>HORARIO</th>");
                    builder.Append("<th>FECHA DE NACIMIENTO</th>");
                    builder.Append("<th>SALARIO BRUTO</th>");
                    builder.Append("<th>SALARIO POR HORA</th>");
                    builder.Append("<th>PUESTO</th>");
                    builder.Append("<th>TIEMPO</th>");
                    builder.Append("<th>CLAVE TEMPORAL</th>");
                    builder.Append("<th>DIRECCIÓN DE CORREO REGISTRADA</th>");
                    builder.Append("</tr>");

                    builder.Append("<tr align= center>");
                    builder.Append("<td>" + textBoxDeCedula.Text + "</td>");
                    builder.Append("<td>" + textBoxDeNombre.Text + "</td>");
                    builder.Append("<td>" + textBoxDeHorario.Text + "</td>");
                    builder.Append("<td>" + dateTimePickerDeFechaDeNacimiento.Value.ToString("dd/MM/yyyy") + "</td>");
                    builder.Append("<td>" + numericUpDownDeSalario.Value.ToString() + "</td>");
                    builder.Append("<td>" + numericUpDownDeSalarioPorHora.Value.ToString() + "</td>");
                    builder.Append("<td>" + textBoxDePuesto.Text + "</td>");
                    builder.Append("<td>" + tiempo + "</td>");
                    builder.Append("<td>" + claveTemporal + "</td>");
                    builder.Append("<td>" + textBoxDeCorreoElectronico.Text + "</td>");
                    builder.Append("</tr>");
                    builder.Append("</table>");
                    builder.Append("<br><br>");
                    builder.Append("<h3>*Por favor cambie su contraseña temporal cuando ingrese al sistema en la sección " + "'Perfil'" + " y seguidamente " + "'Ver Perfil'." + "</h3>");
                    if (result == DialogResult.Yes)
                    {
                        var comando = conexion.GetStoredProcCommand("ADMINISTRADOR_INSERTAR_EMPLEADO", textBoxDeCedula.Text,
                                                                                                    textBoxDeNombre.Text,
                                                                                                    textBoxDeHorario.Text,
                                                                                                    dateTimePickerDeFechaDeNacimiento.Value,
                                                                                                    numericUpDownDeSalario.Value,
                                                                                                    textBoxDePuesto.Text,
                                                                                                    numericUpDownDeSalarioPorHora.Value,
                                                                                                    tiempo,
                                                                                                    claveTemporalEncriptada,
                                                                                                    rol,
                                                                                                    textBoxDeCorreoElectronico.Text);
                        conexion.ExecuteNonQuery(comando);
                        administradorDeCorreo.EnviarCorreo("<img src=https://i.ibb.co/jv7wTtq/LOGO-UREBA.png height=80vh width=100%> <br> <br> <h1>Ha sido registrado en el sistema, bienvenido a Electrónica UREBA S.A.!</h1><br/><h3>Información de Perfil</h3> " + builder.ToString(), "Creación de Perfil", "planilla@electronicaureba.com", "Electrónica UREBA S.A.", new List<string> { correoDeEmpleado });
                        MessageBox.Show("Empleado agregado exitosamente, se ha enviado un correo al empleado con la información escrita y contraseña temporal.", "Opciones de Perfil", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        string texto = "El empleado: " + Empleado.Nombre + " ha agregado al empleado " + textBoxDeNombre.Text + ".";
                        string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                        registrarEvento(texto, metodoYclase);
                        reiniciarPagina();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        MessageBox.Show("Regresando", "Opciones de Perfil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    // Seleccionar no
                    else if (result == DialogResult.No)
                    {
                        MessageBox.Show("Regresando", "Opciones de Perfil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
                MessageBox.Show("Error", "Opciones de Perfil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reiniciarPagina();
            }

        }

        public string RandomString(int length)
        {
            try
            {
                const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890.,!:;";
                StringBuilder claveTemporal = new StringBuilder();
                using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
                {
                    byte[] uintBuffer = new byte[sizeof(uint)];

                    while (length-- > 0)
                    {
                        rng.GetBytes(uintBuffer);
                        uint num = BitConverter.ToUInt32(uintBuffer, 0);
                        claveTemporal.Append(valid[(int)(num % (uint)valid.Length)]);
                    }
                }

                return claveTemporal.ToString();
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
                return null;
            }
        }
        public string encriptarClaveAsha256(string clave)
        {
            try
            {
                using (var sha256 = new SHA256Managed())
                {
                    return BitConverter.ToString(sha256.ComputeHash(Encoding.UTF8.GetBytes(clave))).Replace("-", "");
                }
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
                return null;
            }
        }
        private void reiniciarPagina()
        {
            try
            {
                CrearPerfilDeUsuario crearPerfilDeUsuario = new CrearPerfilDeUsuario();
                this.Hide();
                crearPerfilDeUsuario.Show();
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }

        private void comboBoxDeRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int indice = comboBoxDeRol.SelectedIndex;
                if (indice == 0)//seria administrador
                {
                    rol = 1;
                }
                else if (indice == 1)//seria empleado
                {
                    rol = 2;
                }
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int indice = comboBoxDeTiempo.SelectedIndex;
                if (indice == 0)//seria medio tiempo
                {
                    tiempo = "MEDIO";
                }
                else if (indice == 1)//seria tiempo completo
                {
                    tiempo = "COMPLETO";
                }
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }
        private Boolean validarTodo()
        {
            try
            {
                bool estaBien = false;
                if (string.IsNullOrEmpty(textBoxDeCedula.Text) || textBoxDeCedula.Text.Length != 9)
                {
                    textBoxDeCedula.Focus();
                    estaBien = false;
                    MessageBox.Show("Revise cédula", "Opciones de Perfil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!soloTieneNumeros(textBoxDeCedula.Text))
                {
                    textBoxDeCedula.Focus();
                    estaBien = false;
                    MessageBox.Show("Revise cédula", "Opciones de Perfil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(textBoxDeNombre.Text))
                {
                    textBoxDeNombre.Focus();
                    estaBien = false;
                    MessageBox.Show("Revise nombre", "Opciones de Perfil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!soloTieneLetras(textBoxDeNombre.Text))
                {
                    textBoxDeNombre.Focus();
                    estaBien = false;
                    MessageBox.Show("Revise nombre", "Opciones de Perfil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(textBoxDeHorario.Text))
                {
                    textBoxDeHorario.Focus();
                    estaBien = false;
                    MessageBox.Show("Revise horario", "Opciones de Perfil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!horarioEstaBien(textBoxDeHorario.Text) || soloTieneNumeros(textBoxDeHorario.Text) || soloTieneLetras(textBoxDeHorario.Text))
                {
                    textBoxDeHorario.Focus();
                    estaBien = false;
                    MessageBox.Show("Revise horario", "Opciones de Perfil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!dateTimePickerDeFechaDeNacimiento.Checked)
                {
                    dateTimePickerDeFechaDeNacimiento.Focus();
                    estaBien = false;
                    MessageBox.Show("Revise fecha de nacimiento", "Opciones de Perfil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (comboBoxDeRol.SelectedIndex == -1)
                {
                    comboBoxDeRol.Focus();
                    estaBien = false;
                    MessageBox.Show("Revise rol", "Opciones de Perfil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (numericUpDownDeSalario.Value < numericUpDownDeSalario.Minimum || numericUpDownDeSalario.Value > numericUpDownDeSalario.Maximum)
                {
                    numericUpDownDeSalario.Focus();
                    estaBien = false;
                    MessageBox.Show("Revise salario", "Opciones de Perfil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (numericUpDownDeSalarioPorHora.Value < numericUpDownDeSalarioPorHora.Minimum || numericUpDownDeSalarioPorHora.Value > numericUpDownDeSalarioPorHora.Maximum)
                {
                    numericUpDownDeSalarioPorHora.Focus();
                    estaBien = false;
                    MessageBox.Show("Revise salario por hora", "Opciones de Perfil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(textBoxDePuesto.Text))
                {
                    textBoxDePuesto.Focus();
                    estaBien = false;
                    MessageBox.Show("Revise puesto", "Opciones de Perfil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!puestoEstaBienEscrito(textBoxDePuesto.Text))
                {
                    textBoxDePuesto.Focus();
                    estaBien = false;
                    MessageBox.Show("Revise puesto", "Opciones de Perfil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (comboBoxDeTiempo.SelectedIndex == -1)
                {
                    comboBoxDeTiempo.Focus();
                    estaBien = false;
                    MessageBox.Show("Revise tiempo", "Opciones de Perfil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(textBoxDeCorreoElectronico.Text))
                {
                    textBoxDeCorreoElectronico.Focus();
                    estaBien = false;
                    MessageBox.Show("Revise correo electrónico", "Opciones de Perfil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (!esCorreo(textBoxDeCorreoElectronico.Text))
                {
                    textBoxDeCorreoElectronico.Focus();
                    estaBien = false;
                    MessageBox.Show("Revise correo electrónico", "Opciones de Perfil", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        bool esCorreo(string correo)
        {
            try
            {
                //var mail = new System.Net.Mail.MailAddress(correo);
                //return true;
                Regex objAlphaPattern = new Regex("^[^@]+@[^@]+\\.[a-zA-Z]{2,}$");
                return objAlphaPattern.IsMatch(correo);
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
        private bool puestoEstaBienEscrito(string puesto)
        {
            try
            {
                bool bienEscrito = puesto.All(c => char.IsWhiteSpace(c) || char.IsLetter(c));
                return bienEscrito;
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
                return false;
            }
        }

        private void CrearPerfilDeUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (e.CloseReason==CloseReason.UserClosing)
            //{
            //    cerrarSesion();
            //}
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
                    this.Dispose();
                    System.Environment.Exit(1);
                }
                else
                {
                    MessageBox.Show("Regresando", "Opciones de Sesión"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }

        }

        private void cerrarSesion()
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
                }
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }

        private bool empleadoExiste()
        {
            try
            {
                bool yaExiste = true;
                var conexion = AbrirBaseDeDatos();
                var comando = conexion.GetStoredProcCommand("[SACAR_INFORMACION_PARA_VER_SI_EXISTE]", textBoxDeCedula.Text);
                using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
                {
                    if (informacionEncontrada.Read())
                    {
                        MessageBox.Show("Cédula ya registrada, empleado no se puede agregar", "Opciones de Perfil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        yaExiste = true;
                        return yaExiste;
                    }
                    else
                    {
                        return false;
                    }
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

        private void CrearPerfilDeUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                dateTimePickerDeFechaDeNacimiento.MinDate = DateTime.Now.AddYears(-70);
                dateTimePickerDeFechaDeNacimiento.MaxDate = DateTime.Now.AddYears(-5);
                txt = (TextBox)numericUpDownDeSalario.Controls[1];
                txt.Validating += new CancelEventHandler(txt_Validating);
                txt01 = (TextBox)numericUpDownDeSalarioPorHora.Controls[1];
                txt01.Validating += new CancelEventHandler(txt01_Validating);
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }
        private void txt_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                string caption = "Opciones de Salario";
                if (numericUpDownDeSalario.Value == numericUpDownDeSalario.Minimum)
                {
                    MessageBox.Show("Revise salario, es el mínimo posible", caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (numericUpDownDeSalario.Value == numericUpDownDeSalario.Maximum)
                {
                    MessageBox.Show("Revise salario, es el máximo posible", caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }
        private void txt01_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                string caption = "Opciones de Salario";
                if (numericUpDownDeSalarioPorHora.Value == numericUpDownDeSalarioPorHora.Minimum)
                {
                    MessageBox.Show("Revise salario por hora, es el mínimo posible", caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (numericUpDownDeSalarioPorHora.Value == numericUpDownDeSalarioPorHora.Maximum)
                {
                    MessageBox.Show("Revise salario por hora, es el máximo posible", caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

