﻿using System;
using System.Data;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Proyecto_HRPS
{
    public partial class VerEmpleados : Form
    {
        public VerEmpleados()
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

        private void botonDeVerEmpleadosInactivos_Click(object sender, EventArgs e)
        {
            try
            {
                var conexion = AbrirBaseDeDatos();
                var comando = conexion.GetStoredProcCommand("[ADMINISTRADOR_VER_EMPLEADOS_INACTIVOS]");

                using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
                {
                    int numeroColumas = informacionEncontrada.FieldCount;
                    if (informacionEncontrada.Read() != true)
                    {
                        MessageBox.Show("No hay empleados inactivos", "Opciones de Ver Empleados",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        PdfPTable tabla = CrearTablaPDFEmpleadosInactivos();
                        CrearReportePDFEmpleadosInactivos(tabla);
                        VerEmpleados verEmpleados = new VerEmpleados();
                        this.Hide();
                        verEmpleados.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cierra el reporte de empleados inactivos" + ex.Message, "Opciones de Ver Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private PdfPTable CrearTablaPDFEmpleadosInactivos()
        {
            PdfPTable tabla;
            try
            {
                var conexion = AbrirBaseDeDatos();
                var comando = conexion.GetStoredProcCommand("[ADMINISTRADOR_VER_EMPLEADOS_INACTIVOS]");

                using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
                {
                    int numeroColumas = informacionEncontrada.FieldCount;
                    tabla = new PdfPTable(numeroColumas);
                    tabla.WidthPercentage = 80;

                    Paragraph encabezadoDeCedula = new Paragraph("CÉDULA", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16));
                    Paragraph encabezadoDeNombre = new Paragraph("NOMBRE", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16));
                    Paragraph encabezadoDePuesto = new Paragraph("PUESTO", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16));

                    tabla.AddCell(encabezadoDeCedula);
                    tabla.AddCell(encabezadoDeNombre);
                    tabla.AddCell(encabezadoDePuesto);

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
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
                throw;
            }

            return tabla;

        }
        private bool CrearReportePDFEmpleadosInactivos(PdfPTable tabla)
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/REPORTE_" + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss").Replace(':', '_') + ".pdf";

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

                    Paragraph para = new Paragraph("EMPLEADOS INACTIVOS" + "\n", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 24));
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

                    MessageBox.Show("Reporte de empleados inactivos creado", "Opciones de Ver Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
                throw;
            }

            return true;
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

        private void registrarError(Exception ex, string metodoYclase)
        {
            string texto = "Error: " + ex.ToString();
            var conexion = AbrirBaseDeDatos();
            var comando = conexion.GetStoredProcCommand("[INSERTAR_EVENTO]", texto,
                                                                             metodoYclase);
            conexion.ExecuteNonQuery(comando);
        }

        private void VerEmpleados_FormClosing(object sender, FormClosingEventArgs e)
        {
            private void registrarError(Exception ex, string metodoYclase)
            {
                string texto = "Error: " + ex.ToString();
                var conexion = AbrirBaseDeDatos();
                var comando = conexion.GetStoredProcCommand("[INSERTAR_EVENTO]", texto,
                                                                                 metodoYclase);
                conexion.ExecuteNonQuery(comando);
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
        }

    }
}
