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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportes));
            this.botonDeVolver = new System.Windows.Forms.Button();
            this.botonDeVerSalariosDeEmpleados = new System.Windows.Forms.Button();
            this.botonDeVerReportesDiarios = new System.Windows.Forms.Button();
            this.botonDeVerVacacionesDeEmpleados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonDeVolver
            // 
            this.botonDeVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeVolver.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeVolver.ForeColor = System.Drawing.Color.White;
            this.botonDeVolver.Location = new System.Drawing.Point(96, 179);
            this.botonDeVolver.Margin = new System.Windows.Forms.Padding(4);
            this.botonDeVolver.Name = "botonDeVolver";
            this.botonDeVolver.Size = new System.Drawing.Size(325, 41);
            this.botonDeVolver.TabIndex = 20;
            this.botonDeVolver.Text = "VOLVER";
            this.botonDeVolver.UseVisualStyleBackColor = false;
            this.botonDeVolver.Click += new System.EventHandler(this.botonDeVolver_Click);
            // 
            // botonDeVerSalariosDeEmpleados
            // 
            this.botonDeVerSalariosDeEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeVerSalariosDeEmpleados.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeVerSalariosDeEmpleados.ForeColor = System.Drawing.Color.White;
            this.botonDeVerSalariosDeEmpleados.Location = new System.Drawing.Point(96, 32);
            this.botonDeVerSalariosDeEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.botonDeVerSalariosDeEmpleados.Name = "botonDeVerSalariosDeEmpleados";
            this.botonDeVerSalariosDeEmpleados.Size = new System.Drawing.Size(325, 41);
            this.botonDeVerSalariosDeEmpleados.TabIndex = 21;
            this.botonDeVerSalariosDeEmpleados.Text = "VER SALARIOS DE EMPLEADOS";
            this.botonDeVerSalariosDeEmpleados.UseVisualStyleBackColor = false;
            this.botonDeVerSalariosDeEmpleados.Click += new System.EventHandler(this.botonDeVerSalariosDeEmpleados_Click);
            // 
            // botonDeVerReportesDiarios
            // 
            this.botonDeVerReportesDiarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeVerReportesDiarios.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeVerReportesDiarios.ForeColor = System.Drawing.Color.White;
            this.botonDeVerReportesDiarios.Location = new System.Drawing.Point(96, 81);
            this.botonDeVerReportesDiarios.Margin = new System.Windows.Forms.Padding(4);
            this.botonDeVerReportesDiarios.Name = "botonDeVerReportesDiarios";
            this.botonDeVerReportesDiarios.Size = new System.Drawing.Size(325, 41);
            this.botonDeVerReportesDiarios.TabIndex = 22;
            this.botonDeVerReportesDiarios.Text = "VER REPORTES DIARIOS";
            this.botonDeVerReportesDiarios.UseVisualStyleBackColor = false;
            this.botonDeVerReportesDiarios.Click += new System.EventHandler(this.botonDeVevReportesDiarios_Click);
            // 
            // botonDeVerVacacionesDeEmpleados
            // 
            this.botonDeVerVacacionesDeEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeVerVacacionesDeEmpleados.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeVerVacacionesDeEmpleados.ForeColor = System.Drawing.Color.White;
            this.botonDeVerVacacionesDeEmpleados.Location = new System.Drawing.Point(96, 130);
            this.botonDeVerVacacionesDeEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.botonDeVerVacacionesDeEmpleados.Name = "botonDeVerVacacionesDeEmpleados";
            this.botonDeVerVacacionesDeEmpleados.Size = new System.Drawing.Size(325, 41);
            this.botonDeVerVacacionesDeEmpleados.TabIndex = 23;
            this.botonDeVerVacacionesDeEmpleados.Text = "VER VACACIONES DE EMPLEADOS";
            this.botonDeVerVacacionesDeEmpleados.UseVisualStyleBackColor = false;
            this.botonDeVerVacacionesDeEmpleados.Click += new System.EventHandler(this.botonDeVerVacacionesDeEmpleados_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(514, 258);
            this.Controls.Add(this.botonDeVerVacacionesDeEmpleados);
            this.Controls.Add(this.botonDeVerReportesDiarios);
            this.Controls.Add(this.botonDeVerSalariosDeEmpleados);
            this.Controls.Add(this.botonDeVolver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú de reportes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Reportes_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button botonDeVolver;
        private System.Windows.Forms.Button botonDeVerSalariosDeEmpleados;
        private System.Windows.Forms.Button botonDeVerReportesDiarios;
        private System.Windows.Forms.Button botonDeVerVacacionesDeEmpleados;
    }
}