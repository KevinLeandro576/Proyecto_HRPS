namespace Proyecto_HRPS
{
    partial class VerSalarioEmpleados
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
            this.dateTimePickerDeFechaDeInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDeFechaDeFinalizacion = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.botonDeVolver = new System.Windows.Forms.Button();
            this.botonDeGenerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePickerDeFechaDeInicio
            // 
            this.dateTimePickerDeFechaDeInicio.Font = new System.Drawing.Font("Arial", 8.25F);
            this.dateTimePickerDeFechaDeInicio.Location = new System.Drawing.Point(61, 79);
            this.dateTimePickerDeFechaDeInicio.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerDeFechaDeInicio.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDeFechaDeInicio.Name = "dateTimePickerDeFechaDeInicio";
            this.dateTimePickerDeFechaDeInicio.Size = new System.Drawing.Size(176, 20);
            this.dateTimePickerDeFechaDeInicio.TabIndex = 0;
            // 
            // dateTimePickerDeFechaDeFinalizacion
            // 
            this.dateTimePickerDeFechaDeFinalizacion.Font = new System.Drawing.Font("Arial", 8.25F);
            this.dateTimePickerDeFechaDeFinalizacion.Location = new System.Drawing.Point(365, 79);
            this.dateTimePickerDeFechaDeFinalizacion.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerDeFechaDeFinalizacion.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDeFechaDeFinalizacion.Name = "dateTimePickerDeFechaDeFinalizacion";
            this.dateTimePickerDeFechaDeFinalizacion.Size = new System.Drawing.Size(176, 20);
            this.dateTimePickerDeFechaDeFinalizacion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(58, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "FECHA DE INICIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(362, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "FECHA DE FINALIZACIÓN";
            // 
            // botonDeVolver
            // 
            this.botonDeVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeVolver.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeVolver.ForeColor = System.Drawing.Color.White;
            this.botonDeVolver.Location = new System.Drawing.Point(84, 174);
            this.botonDeVolver.Name = "botonDeVolver";
            this.botonDeVolver.Size = new System.Drawing.Size(176, 48);
            this.botonDeVolver.TabIndex = 15;
            this.botonDeVolver.Text = "VOLVER";
            this.botonDeVolver.UseVisualStyleBackColor = false;
            // 
            // botonDeGenerar
            // 
            this.botonDeGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeGenerar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeGenerar.ForeColor = System.Drawing.Color.White;
            this.botonDeGenerar.Location = new System.Drawing.Point(336, 174);
            this.botonDeGenerar.Name = "botonDeGenerar";
            this.botonDeGenerar.Size = new System.Drawing.Size(176, 48);
            this.botonDeGenerar.TabIndex = 16;
            this.botonDeGenerar.Text = "GENERAR";
            this.botonDeGenerar.UseVisualStyleBackColor = false;
            // 
            // VerSalarioEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(651, 287);
            this.Controls.Add(this.botonDeGenerar);
            this.Controls.Add(this.botonDeVolver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerDeFechaDeFinalizacion);
            this.Controls.Add(this.dateTimePickerDeFechaDeInicio);
            this.Name = "VerSalarioEmpleados";
            this.Text = "Ver salarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerDeFechaDeInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeFechaDeFinalizacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonDeVolver;
        private System.Windows.Forms.Button botonDeGenerar;
    }
}