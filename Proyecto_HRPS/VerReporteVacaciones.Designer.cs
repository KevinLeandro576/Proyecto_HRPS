namespace Proyecto_HRPS
{
    partial class VerReporteVacaciones
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
            this.botonDeGenerar = new System.Windows.Forms.Button();
            this.botonDeVolver = new System.Windows.Forms.Button();
            this.dateTimePickerDeFechaDeFinalizacion = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDeFechaDeInicio = new System.Windows.Forms.DateTimePicker();
            this.labelDeFechaDeFin = new System.Windows.Forms.Label();
            this.labelDeFechaDeInicio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botonDeGenerar
            // 
            this.botonDeGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeGenerar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeGenerar.ForeColor = System.Drawing.Color.White;
            this.botonDeGenerar.Location = new System.Drawing.Point(378, 173);
            this.botonDeGenerar.Name = "botonDeGenerar";
            this.botonDeGenerar.Size = new System.Drawing.Size(176, 48);
            this.botonDeGenerar.TabIndex = 23;
            this.botonDeGenerar.Text = "GENERAR";
            this.botonDeGenerar.UseVisualStyleBackColor = false;
            this.botonDeGenerar.Click += new System.EventHandler(this.botonDeGenerar_Click);
            // 
            // botonDeVolver
            // 
            this.botonDeVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeVolver.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeVolver.ForeColor = System.Drawing.Color.White;
            this.botonDeVolver.Location = new System.Drawing.Point(100, 173);
            this.botonDeVolver.Name = "botonDeVolver";
            this.botonDeVolver.Size = new System.Drawing.Size(176, 48);
            this.botonDeVolver.TabIndex = 22;
            this.botonDeVolver.Text = "VOLVER";
            this.botonDeVolver.UseVisualStyleBackColor = false;
            this.botonDeVolver.Click += new System.EventHandler(this.botonDeVolver_Click);
            // 
            // dateTimePickerDeFechaDeFinalizacion
            // 
            this.dateTimePickerDeFechaDeFinalizacion.Font = new System.Drawing.Font("Arial", 8.25F);
            this.dateTimePickerDeFechaDeFinalizacion.Location = new System.Drawing.Point(378, 108);
            this.dateTimePickerDeFechaDeFinalizacion.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerDeFechaDeFinalizacion.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDeFechaDeFinalizacion.Name = "dateTimePickerDeFechaDeFinalizacion";
            this.dateTimePickerDeFechaDeFinalizacion.Size = new System.Drawing.Size(176, 20);
            this.dateTimePickerDeFechaDeFinalizacion.TabIndex = 21;
            // 
            // dateTimePickerDeFechaDeInicio
            // 
            this.dateTimePickerDeFechaDeInicio.Font = new System.Drawing.Font("Arial", 8.25F);
            this.dateTimePickerDeFechaDeInicio.Location = new System.Drawing.Point(100, 108);
            this.dateTimePickerDeFechaDeInicio.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerDeFechaDeInicio.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDeFechaDeInicio.Name = "dateTimePickerDeFechaDeInicio";
            this.dateTimePickerDeFechaDeInicio.Size = new System.Drawing.Size(176, 20);
            this.dateTimePickerDeFechaDeInicio.TabIndex = 20;
            // 
            // labelDeFechaDeFin
            // 
            this.labelDeFechaDeFin.AutoSize = true;
            this.labelDeFechaDeFin.Font = new System.Drawing.Font("Arial", 8.25F);
            this.labelDeFechaDeFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.labelDeFechaDeFin.Location = new System.Drawing.Point(375, 65);
            this.labelDeFechaDeFin.Name = "labelDeFechaDeFin";
            this.labelDeFechaDeFin.Size = new System.Drawing.Size(129, 14);
            this.labelDeFechaDeFin.TabIndex = 19;
            this.labelDeFechaDeFin.Text = "FECHA DE FINALIZACIÓN";
            // 
            // labelDeFechaDeInicio
            // 
            this.labelDeFechaDeInicio.AutoSize = true;
            this.labelDeFechaDeInicio.Font = new System.Drawing.Font("Arial", 8.25F);
            this.labelDeFechaDeInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.labelDeFechaDeInicio.Location = new System.Drawing.Point(97, 65);
            this.labelDeFechaDeInicio.Name = "labelDeFechaDeInicio";
            this.labelDeFechaDeInicio.Size = new System.Drawing.Size(87, 14);
            this.labelDeFechaDeInicio.TabIndex = 18;
            this.labelDeFechaDeInicio.Text = "FECHA DE INICIO";
            // 
            // VerReporteVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(651, 287);
            this.Controls.Add(this.botonDeGenerar);
            this.Controls.Add(this.botonDeVolver);
            this.Controls.Add(this.dateTimePickerDeFechaDeFinalizacion);
            this.Controls.Add(this.dateTimePickerDeFechaDeInicio);
            this.Controls.Add(this.labelDeFechaDeFin);
            this.Controls.Add(this.labelDeFechaDeInicio);
            this.Name = "VerReporteVacaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerReporteVacaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonDeGenerar;
        private System.Windows.Forms.Button botonDeVolver;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeFechaDeFinalizacion;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeFechaDeInicio;
        private System.Windows.Forms.Label labelDeFechaDeFin;
        private System.Windows.Forms.Label labelDeFechaDeInicio;
    }
}