using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_HRPS
{
    public partial class CrearPerfilDeUsuario : Form
    {
        int rol = 0;
        string tiempo = "";
        public CrearPerfilDeUsuario()
        {
            InitializeComponent();
        }

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            PerfilesDeUsuario perfilesDeUsuario = new PerfilesDeUsuario();
            this.Hide();
            perfilesDeUsuario.Show();
        }
        //POR CADA FORMULARIO CON CRUD
        public Database AbrirBaseDeDatos()
        {
            var connectionString = @"Server=tcp:servidor-de-hr-payroll-system.database.windows.net,1433;Initial Catalog=HR_PAYROLL_SYSTEM;Persist Security Info=False;User ID=Kevin;Password=Leandro123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            return new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(connectionString);
        }
        //POR CADA INSERT   
        private void botonDeRegistrarUsuario_Click(object sender, EventArgs e)
        {
            string claveTemporal = RandomString(5);
            string claveTemporalEncriptada = encriptarClaveAsha256(claveTemporal);
            var conexion = AbrirBaseDeDatos();
            const string message = "Desea agregar un nuevo empleado?";
            const string caption = "Opciones de Perfil";

            //VALIDAR AQUI
            if (validarTodo() == true)
            {
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNoCancel,
                                             MessageBoxIcon.Question);
                string correoDeEmpleado = textBoxDeCorreoElectronico.Text;
                List<string> listaDeCorreos = new List<string>();
                listaDeCorreos.Add("leandrokevin576@gmail.com");
                AdministradorDeCorreo administradorDeCorreo = new AdministradorDeCorreo("smtp.gmail.com", "1037joseg@gmail.com", "Qwertz987.,!", 587);
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
                builder.Append("<td>" + dateTimePickerDeFechaDeNacimiento.Value + "</td>");
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
                    MessageBox.Show("Empleado agregado exitosamente", "Opciones de Perfil");
                    administradorDeCorreo.EnviarCorreo("<h1>Ha sido registrado en el sistema!</h1><br/><h3>Información de Perfil</h3> " + builder.ToString(), "Creación de Perfil", "1037joseg@gmail.com", "Electrónica UREBA S.A.", new List<string> { correoDeEmpleado });
                    reiniciarPagina();
                }
                else if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Regresando", "Opciones de Perfil");
                }
                // Seleccionar no
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("Regresando", "Opciones de Perfil");
                }
            }
        }

        static string RandomString(int length)
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
        public static string encriptarClaveAsha256(string clave)
        {
            using (var sha256 = new SHA256Managed())
            {
                return BitConverter.ToString(sha256.ComputeHash(Encoding.UTF8.GetBytes(clave))).Replace("-", "");
            }
        }
        private void reiniciarPagina()
        {
            CrearPerfilDeUsuario crearPerfilDeUsuario = new CrearPerfilDeUsuario();
            this.Hide();
            crearPerfilDeUsuario.Show();
        }

        private void comboBoxDeRol_SelectedIndexChanged(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
        private Boolean validarTodo()
        {
            bool estaBien = false;
            if (string.IsNullOrEmpty(textBoxDeCedula.Text) || textBoxDeCedula.Text.Length != 9)
            {
                textBoxDeCedula.Focus();
                estaBien = false;
                MessageBox.Show("Revisa cédula", "Opciones de Perfil");
            }
            else if (!soloTieneNumeros(textBoxDeCedula.Text))
            {
                textBoxDeCedula.Focus();
                estaBien = false;
                MessageBox.Show("Revisa cédula", "Opciones de Perfil");
            }
            else if (string.IsNullOrEmpty(textBoxDeNombre.Text))
            {
                textBoxDeNombre.Focus();
                estaBien = false;
                MessageBox.Show("Revisa nombre", "Opciones de Perfil");
            }
            else if (!soloTieneLetras(textBoxDeNombre.Text))
            {
                textBoxDeNombre.Focus();
                estaBien = false;
                MessageBox.Show("Revisa nombre", "Opciones de Perfil");
            }
            else if (string.IsNullOrEmpty(textBoxDeHorario.Text))
            {
                textBoxDeHorario.Focus();
                estaBien = false;
                MessageBox.Show("Revisa horario", "Opciones de Perfil");
            }
            else if (!horarioEstaBien(textBoxDeHorario.Text))
            {
                textBoxDeHorario.Focus();
                estaBien = false;
                MessageBox.Show("Revisa horario", "Opciones de Perfil");
            }
            else if (!dateTimePickerDeFechaDeNacimiento.Checked)
            {
                dateTimePickerDeFechaDeNacimiento.Focus();
                estaBien = false;
                MessageBox.Show("Revisa fecha de nacimiento", "Opciones de Perfil");
            }
            else if (comboBoxDeRol.SelectedIndex == -1)
            {
                comboBoxDeRol.Focus();
                estaBien = false;
                MessageBox.Show("Revisa rol", "Opciones de Perfil");
            }
            else if (numericUpDownDeSalario.Value < numericUpDownDeSalario.Minimum || numericUpDownDeSalario.Value > numericUpDownDeSalario.Maximum)
            {
                numericUpDownDeSalario.Focus();
                estaBien = false;
                MessageBox.Show("Revisa salario", "Opciones de Perfil");
            }
            else if (numericUpDownDeSalarioPorHora.Value < numericUpDownDeSalarioPorHora.Minimum || numericUpDownDeSalarioPorHora.Value > numericUpDownDeSalarioPorHora.Maximum)
            {
                numericUpDownDeSalarioPorHora.Focus();
                estaBien = false;
                MessageBox.Show("Revisa salario por hora", "Opciones de Perfil");
            }
            else if (string.IsNullOrEmpty(textBoxDePuesto.Text))
            {
                textBoxDePuesto.Focus();
                estaBien = false;
                MessageBox.Show("Revisa puesto", "Opciones de Perfil");
            }
            else if (!puestoEstaBienEscrito(textBoxDePuesto.Text))
            {
                textBoxDePuesto.Focus();
                estaBien = false;
                MessageBox.Show("Revisa puesto", "Opciones de Perfil");
            }
            else if (comboBoxDeTiempo.SelectedIndex == -1)
            {
                comboBoxDeTiempo.Focus();
                estaBien = false;
                MessageBox.Show("Revisa tiempo", "Opciones de Perfil");
            }
            else if (string.IsNullOrEmpty(textBoxDeCorreoElectronico.Text))
            {
                textBoxDeCorreoElectronico.Focus();
                estaBien = false;
                MessageBox.Show("Revisa correo electrónico", "Opciones de Perfil");
            }

            else if (!esCorreo(textBoxDeCorreoElectronico.Text) || !textBoxDeCorreoElectronico.Text.EndsWith(".com"))
            {
                textBoxDeCorreoElectronico.Focus();
                estaBien = false;
                MessageBox.Show("Revisa correo electrónico", "Opciones de Perfil");
            }
            else
            {
                estaBien = true;
            }
            return estaBien;
        }

        bool soloTieneNumeros(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }
        bool soloTieneLetras(String strToCheck)//LETRAS ESPACIO Y TILDES
        {
            Regex objAlphaPattern = new Regex("^[a-z A-Z\u00C0-\u00FF]*$");
            return objAlphaPattern.IsMatch(strToCheck);
        }
        bool esCorreo(string correo)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(correo);
                return true;
            }
            catch
            {
                return false;
            }
        }
        bool horarioEstaBien(String horario)
        {
            Regex objAlphaPattern = new Regex("^[a-zA-Z0-9][a-zA-Z0-9 -]*$");
            return objAlphaPattern.IsMatch(horario);
        }
        private bool puestoEstaBienEscrito(string puesto)
        {
            bool bienEscrito = puesto.All(c => char.IsWhiteSpace(c) || char.IsLetter(c));
            return bienEscrito;
        }

        private void CrearPerfilDeUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

