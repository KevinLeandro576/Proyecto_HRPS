namespace Proyecto_HRPS
{
    partial class VerReporteHorasExtra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerReporteHorasExtra));
            this.labelDeFechaDeInicio = new System.Windows.Forms.Label();
            this.labelDeFechaDeFin = new System.Windows.Forms.Label();
            this.dateTimePickerDeFechaDeInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDeFechaDeFinalizacion = new System.Windows.Forms.DateTimePicker();
            this.botonDeVolver = new System.Windows.Forms.Button();
            this.botonDeGenerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDeFechaDeInicio
            // 
            this.labelDeFechaDeInicio.AutoSize = true;
            this.labelDeFechaDeInicio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeFechaDeInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.labelDeFechaDeInicio.Location = new System.Drawing.Point(51, 60);
            this.labelDeFechaDeInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDeFechaDeInicio.Name = "labelDeFechaDeInicio";
            this.labelDeFechaDeInicio.Size = new System.Drawing.Size(137, 18);
            this.labelDeFechaDeInicio.TabIndex = 3;
            this.labelDeFechaDeInicio.Text = "FECHA DE INICIO";
            // 
            // labelDeFechaDeFin
            // 
            this.labelDeFechaDeFin.AutoSize = true;
            this.labelDeFechaDeFin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeFechaDeFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.labelDeFechaDeFin.Location = new System.Drawing.Point(477, 60);
            this.labelDeFechaDeFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDeFechaDeFin.Name = "labelDeFechaDeFin";
            this.labelDeFechaDeFin.Size = new System.Drawing.Size(198, 18);
            this.labelDeFechaDeFin.TabIndex = 4;
            this.labelDeFechaDeFin.Text = "FECHA DE FINALIZACIÓN";
            // 
            // dateTimePickerDeFechaDeInicio
            // 
            this.dateTimePickerDeFechaDeInicio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDeFechaDeInicio.Location = new System.Drawing.Point(54, 108);
            this.dateTimePickerDeFechaDeInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerDeFechaDeInicio.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerDeFechaDeInicio.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDeFechaDeInicio.Name = "dateTimePickerDeFechaDeInicio";
            this.dateTimePickerDeFechaDeInicio.Size = new System.Drawing.Size(321, 26);
            this.dateTimePickerDeFechaDeInicio.TabIndex = 5;
            // 
            // dateTimePickerDeFechaDeFinalizacion
            // 
            this.dateTimePickerDeFechaDeFinalizacion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDeFechaDeFinalizacion.Location = new System.Drawing.Point(480, 108);
            this.dateTimePickerDeFechaDeFinalizacion.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerDeFechaDeFinalizacion.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerDeFechaDeFinalizacion.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDeFechaDeFinalizacion.Name = "dateTimePickerDeFechaDeFinalizacion";
            this.dateTimePickerDeFechaDeFinalizacion.Size = new System.Drawing.Size(321, 26);
            this.dateTimePickerDeFechaDeFinalizacion.TabIndex = 6;
            // 
            // botonDeVolver
            // 
            this.botonDeVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeVolver.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeVolver.ForeColor = System.Drawing.Color.White;
            this.botonDeVolver.Location = new System.Drawing.Point(54, 175);
            this.botonDeVolver.Margin = new System.Windows.Forms.Padding(4);
            this.botonDeVolver.Name = "botonDeVolver";
            this.botonDeVolver.Size = new System.Drawing.Size(321, 41);
            this.botonDeVolver.TabIndex = 16;
            this.botonDeVolver.Text = "VOLVER";
            this.botonDeVolver.UseVisualStyleBackColor = false;
            this.botonDeVolver.Click += new System.EventHandler(this.botonDeVolver_Click);
            // 
            // botonDeGenerar
            // 
            this.botonDeGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeGenerar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeGenerar.ForeColor = System.Drawing.Color.White;
            this.botonDeGenerar.Location = new System.Drawing.Point(480, 175);
            this.botonDeGenerar.Margin = new System.Windows.Forms.Padding(4);
            this.botonDeGenerar.Name = "botonDeGenerar";
            this.botonDeGenerar.Size = new System.Drawing.Size(319, 41);
            this.botonDeGenerar.TabIndex = 17;
            this.botonDeGenerar.Text = "GENERAR";
            this.botonDeGenerar.UseVisualStyleBackColor = false;
            this.botonDeGenerar.Click += new System.EventHandler(this.botonDeGenerar_Click);
            // 
            // VerReporteHorasExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(852, 257);
            this.Controls.Add(this.botonDeGenerar);
            this.Controls.Add(this.botonDeVolver);
            this.Controls.Add(this.dateTimePickerDeFechaDeFinalizacion);
            this.Controls.Add(this.dateTimePickerDeFechaDeInicio);
            this.Controls.Add(this.labelDeFechaDeFin);
            this.Controls.Add(this.labelDeFechaDeInicio);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VerReporteHorasExtra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de horas extra";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VerReporteHorasExtra_FormClosing);
            this.Load += new System.EventHandler(this.VerReporteHorasExtra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDeFechaDeInicio;
        private System.Windows.Forms.Label labelDeFechaDeFin;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeFechaDeInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeFechaDeFinalizacion;
        private System.Windows.Forms.Button botonDeVolver;
        private System.Windows.Forms.Button botonDeGenerar;
    }
}