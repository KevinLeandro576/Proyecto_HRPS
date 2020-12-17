namespace Proyecto_HRPS
{
    partial class Reportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.enlaceDeVerSalariosDeEmpleados = new System.Windows.Forms.LinkLabel();
            this.enlaceDeVerReportesDiarios = new System.Windows.Forms.LinkLabel();
            this.enlaceDeVerVacacionesDeEmpleados = new System.Windows.Forms.LinkLabel();
            this.enlaceDeVolver = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // enlaceDeVerSalariosDeEmpleados
            // 
            this.enlaceDeVerSalariosDeEmpleados.AutoSize = true;
            this.enlaceDeVerSalariosDeEmpleados.Font = new System.Drawing.Font("Arial", 8.25F);
            this.enlaceDeVerSalariosDeEmpleados.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.enlaceDeVerSalariosDeEmpleados.Location = new System.Drawing.Point(41, 38);
            this.enlaceDeVerSalariosDeEmpleados.Name = "enlaceDeVerSalariosDeEmpleados";
            this.enlaceDeVerSalariosDeEmpleados.Size = new System.Drawing.Size(165, 14);
            this.enlaceDeVerSalariosDeEmpleados.TabIndex = 0;
            this.enlaceDeVerSalariosDeEmpleados.TabStop = true;
            this.enlaceDeVerSalariosDeEmpleados.Text = "VER SALARIOS DE EMPLEADOS";
            // 
            // enlaceDeVerReportesDiarios
            // 
            this.enlaceDeVerReportesDiarios.AutoSize = true;
            this.enlaceDeVerReportesDiarios.Font = new System.Drawing.Font("Arial", 8.25F);
            this.enlaceDeVerReportesDiarios.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.enlaceDeVerReportesDiarios.Location = new System.Drawing.Point(244, 38);
            this.enlaceDeVerReportesDiarios.Name = "enlaceDeVerReportesDiarios";
            this.enlaceDeVerReportesDiarios.Size = new System.Drawing.Size(128, 14);
            this.enlaceDeVerReportesDiarios.TabIndex = 1;
            this.enlaceDeVerReportesDiarios.TabStop = true;
            this.enlaceDeVerReportesDiarios.Text = "VER REPORTES DIARIOS";
            // 
            // enlaceDeVerVacacionesDeEmpleados
            // 
            this.enlaceDeVerVacacionesDeEmpleados.AutoSize = true;
            this.enlaceDeVerVacacionesDeEmpleados.Font = new System.Drawing.Font("Arial", 8.25F);
            this.enlaceDeVerVacacionesDeEmpleados.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.enlaceDeVerVacacionesDeEmpleados.Location = new System.Drawing.Point(418, 38);
            this.enlaceDeVerVacacionesDeEmpleados.Name = "enlaceDeVerVacacionesDeEmpleados";
            this.enlaceDeVerVacacionesDeEmpleados.Size = new System.Drawing.Size(203, 14);
            this.enlaceDeVerVacacionesDeEmpleados.TabIndex = 2;
            this.enlaceDeVerVacacionesDeEmpleados.TabStop = true;
            this.enlaceDeVerVacacionesDeEmpleados.Text = "VER VACACIONES DE LOS EMPLEADOS";
            // 
            // enlaceDeVolver
            // 
            this.enlaceDeVolver.AutoSize = true;
            this.enlaceDeVolver.Font = new System.Drawing.Font("Arial", 8.25F);
            this.enlaceDeVolver.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.enlaceDeVolver.Location = new System.Drawing.Point(662, 38);
            this.enlaceDeVolver.Name = "enlaceDeVolver";
            this.enlaceDeVolver.Size = new System.Drawing.Size(49, 14);
            this.enlaceDeVolver.TabIndex = 3;
            this.enlaceDeVolver.TabStop = true;
            this.enlaceDeVolver.Text = "VOLVER";
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 281);
            this.Controls.Add(this.enlaceDeVolver);
            this.Controls.Add(this.enlaceDeVerVacacionesDeEmpleados);
            this.Controls.Add(this.enlaceDeVerReportesDiarios);
            this.Controls.Add(this.enlaceDeVerSalariosDeEmpleados);
            this.Name = "Reportes";
            this.Text = "Menú de reportes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel enlaceDeVerSalariosDeEmpleados;
        private System.Windows.Forms.LinkLabel enlaceDeVerReportesDiarios;
        private System.Windows.Forms.LinkLabel enlaceDeVerVacacionesDeEmpleados;
        private System.Windows.Forms.LinkLabel enlaceDeVolver;
    }
}