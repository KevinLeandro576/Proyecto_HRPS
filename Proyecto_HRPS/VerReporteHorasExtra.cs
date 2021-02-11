using System;
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
    public partial class VerReporteHorasExtra : Form
    {
        public VerReporteHorasExtra()
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

        private void botonDeVolver_Click(object sender, EventArgs e)
        {
            try
            {
                Reportes reportes = new Reportes();
                this.Hide();
                reportes.Show();
            }
            catch (Exception ex)
            {
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }

        private void botonDeGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaDeInicio = dateTimePickerDeFechaDeInicio.Value;
                DateTime fechaDeFinalizacion = dateTimePickerDeFechaDeFinalizacion.Value;

                var conexion = AbrirBaseDeDatos();
                var comando = conexion.GetStoredProcCommand("REPORTE_DE_HORAS_EXTRA", fechaDeInicio, fechaDeFinalizacion);

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
                        PdfPTable tabla = CrearTablaPDFHorasExtra();
                        CrearReportePDFHorasExtra(tabla);
                        Reportes reportes = new Reportes();
                        this.Hide();
                        reportes.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cierra el reporte de horas extra", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                string metodoYclase = this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                registrarError(ex, metodoYclase);
            }
        }

        private PdfPTable CrearTablaPDFHorasExtra()
        {
            PdfPTable tabla;
            try
            {
                var fechaDeInicio = dateTimePickerDeFechaDeInicio.Value;
                var fechaDeFinalizacion = dateTimePickerDeFechaDeFinalizacion.Value;

                var conexion = AbrirBaseDeDatos();
                var comando = conexion.GetStoredProcCommand("REPORTE_DE_HORAS_EXTRA", fechaDeInicio, fechaDeFinalizacion);

                using (IDataReader informacionEncontrada = conexion.ExecuteReader(comando))
                {
                    int numeroColumnas = informacionEncontrada.FieldCount;
                    tabla = new PdfPTable(numeroColumnas);
                    tabla.WidthPercentage = 80;

                    Paragraph encabezadoDeCedula = new Paragraph("CÉDULA", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16));
                    Paragraph encabezadoDeNombre = new Paragraph("NOMBRE", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16));
                    Paragraph encabezadoDeSumaDeHoras = new Paragraph("TOTAL DE HORAS EXTRA", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16));

                    tabla.AddCell(encabezadoDeCedula);
                    tabla.AddCell(encabezadoDeNombre);
                    tabla.AddCell(encabezadoDeSumaDeHoras);

                    while (informacionEncontrada.Read())
                    {
                        string cedula = informacionEncontrada.GetString(0);
                        string nombre = informacionEncontrada.GetString(1);
                        string horasExtra = informacionEncontrada.GetValue(2).ToString();

                        tabla.AddCell(cedula);
                        tabla.AddCell(nombre);
                        tabla.AddCell(horasExtra);
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

        private bool CrearReportePDFHorasExtra(PdfPTable tabla)
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/REPORTE_HORAS_EXTRA_" + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss").Replace(':', '_') + ".pdf";

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

                    Paragraph para = new Paragraph("REPORTE DE HORAS EXTRA" + "\n", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 24));
                    para.Alignment = Element.ALIGN_CENTER;
                    para.SpacingAfter = 18f;
                    DC.Add(para);

                    DC.Add(tabla);
                    tabla.SpacingAfter = 14f;

                    string fechaDeInicio = dateTimePickerDeFechaDeInicio.Value.ToString();
                    string fechaDeFinalizacion = dateTimePickerDeFechaDeFinalizacion.Value.ToString();
                    string rangoDeFechas = fechaDeInicio + " - " + fechaDeFinalizacion;
                    Paragraph rangoDeFechasDeGeneracion = new Paragraph("Rango de fechas de generarión de reporte: " + rangoDeFechas, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10));
                    rangoDeFechasDeGeneracion.SpacingBefore = 20f;
                    rangoDeFechasDeGeneracion.Alignment = Element.ALIGN_CENTER;
                    DC.Add(rangoDeFechasDeGeneracion);

                    string fechaYhora = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
                    Paragraph fechaYhoraDeGeneracion = new Paragraph("Fecha y hora de generación de reporte: " + fechaYhora, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10));
                    fechaYhoraDeGeneracion.SpacingBefore = 20f;
                    fechaYhoraDeGeneracion.Alignment = Element.ALIGN_CENTER;
                    DC.Add(fechaYhoraDeGeneracion);
                    DC.Close();
                    FS.Close();
                    FS.Dispose();
                    MessageBox.Show("Se ha creado un reporte de horas extra.", "Creación de reporte",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void VerReporteHorasExtra_Load(object sender, EventArgs e)
        {
            try
            {
                dateTimePickerDeFechaDeFinalizacion.MaxDate = DateTime.Now;
                dateTimePickerDeFechaDeInicio.MaxDate = DateTime.Now;
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
    }
}
