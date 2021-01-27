﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Proyecto_HRPS
{
    public partial class VerSalarioEmpleados : Form
    {
        public VerSalarioEmpleados()
        {
            InitializeComponent();
        }

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            this.Hide();
            reportes.Show();
        }

        private void botonDeGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                var conexion = AbrirBaseDeDatos();
                var comando = conexion.GetStoredProcCommand("REPORTE_DE_SALARIO");

                using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
                {
                    int numeroColumnas = informacionEncontrada.FieldCount;
                    if (informacionEncontrada.Read() != true)
                    {
                        MessageBox.Show("No hay horas extras registradas.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        PdfPTable tabla = CrearTablaPDFSalarios();
                        CrearReportePDFSalarios(tabla);
                        Reportes reportes = new Reportes();
                        this.Hide();
                        reportes.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cierra el reporte de salarios", ex.Message);
            }
        }

        private PdfPTable CrearTablaPDFSalarios()
        {
            PdfPTable tabla;
            try
            {
                var conexion = AbrirBaseDeDatos();
                var comando = conexion.GetStoredProcCommand("REPORTE_DE_SALARIO");

                using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
                {
                    int numeroColumnas = informacionEncontrada.FieldCount;
                    tabla = new PdfPTable(numeroColumnas);
                    tabla.WidthPercentage = 80;

                    Paragraph encabezadoDeCedula = new Paragraph("CÉDULA", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16));
                    Paragraph encabezadoDeNombre = new Paragraph("NOMBRE", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16));
                    Paragraph encabezadoDeSalario = new Paragraph("SALARIO BASE", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16));
                    Paragraph encabezadoDeTiempo = new Paragraph("TIEMPO", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16));
                    Paragraph encabezadoDeHorario = new Paragraph("HORARIO", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16));

                    tabla.AddCell(encabezadoDeCedula);
                    tabla.AddCell(encabezadoDeNombre);
                    tabla.AddCell(encabezadoDeSalario);
                    tabla.AddCell(encabezadoDeTiempo);
                    tabla.AddCell(encabezadoDeHorario);

                    while (informacionEncontrada.Read())
                    {
                        string cedula = informacionEncontrada.GetString(0);
                        string nombre = informacionEncontrada.GetString(1);
                        string salario = informacionEncontrada.GetInt32(2).ToString();
                        string tiempo = informacionEncontrada.GetString(3);
                        string horario = informacionEncontrada.GetString(4);

                        tabla.AddCell(cedula);
                        tabla.AddCell(nombre);
                        tabla.AddCell(salario);
                        tabla.AddCell(tiempo);
                        tabla.AddCell(horario);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return tabla;
        }

        private bool CrearReportePDFSalarios(PdfPTable tabla)
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/REPORTE_SALARIO" + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss").Replace(':', '_') + ".pdf";

                Document DC = new Document(PageSize.A4, 25, 25, 30, 30);

                using (FileStream FS = File.Create(path))
                {
                    PdfWriter.GetInstance(DC, FS);
                    DC.Open();

                    iTextSharp.text.Image jpeg01 = iTextSharp.text.Image.GetInstance(Properties.Resources.iconoDeUREBA, System.Drawing.Imaging.ImageFormat.Jpeg);

                    jpeg01.ScaleToFit(500f, 500f);
                    jpeg01.SpacingBefore = 10f;
                    jpeg01.SpacingAfter = 1f;
                    jpeg01.Alignment = Element.ALIGN_CENTER;
                    DC.Add(jpeg01);

                    Paragraph para = new Paragraph("REPORTE DE SALARIOS" + "\n", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 24));
                    para.Alignment = Element.ALIGN_CENTER;
                    para.SpacingAfter = 18f;
                    DC.Add(para);

                    DC.Add(tabla);
                    tabla.SpacingAfter = 14f;

                    string fechaYhora = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
                    Paragraph fechaYhoraDeGeneracion = new Paragraph("Fecha y hora de generación de reporte: " + fechaYhora, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10));
                    fechaYhoraDeGeneracion.SpacingBefore = 20f;
                    fechaYhoraDeGeneracion.Alignment = Element.ALIGN_CENTER;
                    DC.Add(fechaYhoraDeGeneracion);
                    DC.Close();
                    FS.Close();
                    FS.Dispose();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return true;
        }

        public Database AbrirBaseDeDatos()
        {
            var connectionString = @"Server=tcp:servidor-de-hr-payroll-system.database.windows.net,1433;Initial Catalog=HR_PAYROLL_SYSTEM;Persist Security Info=False;User ID=Kevin;Password=Leandro123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            return new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(connectionString);
        }
    }
}
