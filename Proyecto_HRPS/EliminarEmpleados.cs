﻿using Microsoft.Practices.EnterpriseLibrary.Data;
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
    public partial class EliminarEmpleados : Form
    {
        public EliminarEmpleados()
        {
            InitializeComponent();
        }

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            PerfilesDeUsuario perfilesDeUsuario = new PerfilesDeUsuario();
            this.Hide();
            perfilesDeUsuario.Show();
        }

        private void EliminarEmpleados_Load(object sender, EventArgs e)
        {
            //Hace botones de manera dinamica, hacer que se hagan por cada empleado registrado
            int startposition = 100;
            int endposition = 10;
            var conexion = AbrirBaseDeDatos();
            var comando = conexion.GetStoredProcCommand("ADMINISTRADOR_VER_EMPLEADOS_A_BORRAR");

            using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
            {
                while (informacionEncontrada.Read())
                {
                    int i = 0;
                    string cedula = informacionEncontrada["PK_CEDULA"].ToString();
                    string nombre = informacionEncontrada["NOMBRE"].ToString();
                    Button boton = agregarBoton(i, startposition, endposition, cedula, nombre);
                    panelDeFlujoDeEmpleados.Controls.Add(boton);
                    boton.Click += new System.EventHandler(this.clickAboton);
                    endposition += 100;
                }
            }
        }
        private void clickAboton(object sender, EventArgs e)
        {
            Button botonActual = (Button)sender;
            MessageBox.Show("Hola");
            //Borrar empleado (ponerlo inactivo)
        }
        Button agregarBoton(int i, int start, int end, string cedula, string nombre)
        {
            //Hace un boton, poner texto de empleado segun historia de usuario    
            Button botonConEmpleado = new Button();
            botonConEmpleado.Name = "Empleado " + i.ToString();
            botonConEmpleado.Text = "" + cedula + "\n" + nombre;
            botonConEmpleado.ForeColor = Color.Black;
            botonConEmpleado.BackColor = Color.White;
            botonConEmpleado.Font = new Font("Arial", 10, FontStyle.Regular);
            botonConEmpleado.Width = 200;
            botonConEmpleado.Height = 60;
            botonConEmpleado.Location = new Point(start, end);
            botonConEmpleado.TextAlign = ContentAlignment.MiddleCenter;
            botonConEmpleado.Margin = new Padding(5);
            return botonConEmpleado;

        }

        //POR CADA FORMULARIO CON CRUD
        public Database AbrirBaseDeDatos()
        {
            var connectionString = @"Server=tcp:servidor-de-hr-payroll-system.database.windows.net,1433;Initial Catalog=HR_PAYROLL_SYSTEM;Persist Security Info=False;User ID=Kevin;Password=Leandro123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            return new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(connectionString);
        }
    }
}
