using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Proyecto_HRPS
{
    public partial class PerfilesDeUsuario : Form
    {
        public PerfilesDeUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void enlaceDePerfilesDeUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CrearPerfilDeUsuario crearPerfilDeUsuario = new CrearPerfilDeUsuario();
            this.Hide();
            crearPerfilDeUsuario.Show();
        }

        private void enlaceDeVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MenuDeAdministrador menuDeAdministrador = new MenuDeAdministrador();
            this.Hide();
            menuDeAdministrador.Show();
        }

        private void enlaceDeVerSalario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EmpleadoVerSalario empleadoVerSalario = new EmpleadoVerSalario();
            this.Hide();
            empleadoVerSalario.Show();
        }

        private void enlaceDeVerEmpleados_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var conexion = AbrirBaseDeDatos();
            var comando = conexion.GetStoredProcCommand("ADMINISTRADOR_VER_EMPLEADOS_ACTIVOS");
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/REPORTE.pdf";
            Document DC = new Document(PageSize.A4, 25, 25, 30, 30);
            FileStream FS = File.Create(path);
            PdfWriter.GetInstance(DC, FS);
            DC.Open();
            int x = 0;
            using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
            {
                while (informacionEncontrada.Read())
                {
                    string cedula = informacionEncontrada["PK_CEDULA"].ToString();
                    string nombre = informacionEncontrada["NOMBRE"].ToString();
                    string puesto = informacionEncontrada["PUESTO"].ToString();

                    string todo = cedula + " " + nombre + " " + puesto;

                    //DC.Add(new Paragraph(todo));
                    x = x + 1;
                }
            }
            string imageURL01 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/icono01.jpeg";
            iTextSharp.text.Image jpeg01 = iTextSharp.text.Image.GetInstance(imageURL01);
            jpeg01.ScaleToFit(500f, 500f);
            jpeg01.SpacingBefore = 10f;
            jpeg01.SpacingAfter = 1f;
            jpeg01.Alignment = Element.ALIGN_CENTER;
            DC.Add(jpeg01);
            PdfPTable tabla = new PdfPTable(x);
            Paragraph para = new Paragraph("EMPLEADOS ACTIVOS" + "\n", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 24));
            para.Alignment = Element.ALIGN_CENTER;
            para.SpacingAfter = 14f;
            DC.Add(para);
            Paragraph encabezadoDeCedula = new Paragraph("CÉDULA", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18));
            Paragraph encabezadoDeNombre = new Paragraph("NOMBRE", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18));
            Paragraph encabezadoDePuesto = new Paragraph("PUESTO", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18));
            tabla.AddCell(encabezadoDeCedula);
            tabla.AddCell(encabezadoDeNombre);
            tabla.AddCell(encabezadoDePuesto);
            using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
            {
                while (informacionEncontrada.Read())
                {
                    string cedula = informacionEncontrada["PK_CEDULA"].ToString();
                    string nombre = informacionEncontrada["NOMBRE"].ToString();
                    string puesto = informacionEncontrada["PUESTO"].ToString();

                    tabla.AddCell(cedula);
                    tabla.AddCell(nombre);
                    tabla.AddCell(puesto);
                }
            }
            DC.Add(tabla);
            DC.Close();
            /*VerEmpleados verEmpleados = new VerEmpleados();
            this.Hide();
            verEmpleados.Show();*/
        }

        private void enlaceDeModificarHorario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ModificarHorario modificarHorario = new ModificarHorario();
            this.Hide();
            modificarHorario.Show();
        }

        private void enlaceDeModificarSalario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ModificarSalario modificarSalario = new ModificarSalario();
            this.Hide();
            modificarSalario.Show();
        }

        private void enlaceDeEliminarEmpleados_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EliminarEmpleados eliminarEmpleados = new EliminarEmpleados();
            this.Hide();
            eliminarEmpleados.Show();
        }
        public Database AbrirBaseDeDatos()
        {
            var connectionString = @"Server=tcp:servidor-de-hr-payroll-system.database.windows.net,1433;Initial Catalog=HR_PAYROLL_SYSTEM;Persist Security Info=False;User ID=Kevin;Password=Leandro123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            return new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(connectionString);
        }
    }
}
