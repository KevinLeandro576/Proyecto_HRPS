namespace Proyecto_HRPS
{
    partial class SolicitudesVacaciones
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
            this.botonDeVolver = new System.Windows.Forms.Button();
            this.botonDeEnviar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDeNombre = new System.Windows.Forms.TextBox();
            this.dateTimePickerDeFechaDeInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerDeFechaDeFinalizacion = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // botonDeVolver
            // 
            this.botonDeVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeVolver.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeVolver.ForeColor = System.Drawing.Color.White;
            this.botonDeVolver.Location = new System.Drawing.Point(53, 205);
            this.botonDeVolver.Name = "botonDeVolver";
            this.botonDeVolver.Size = new System.Drawing.Size(176, 48);
            this.botonDeVolver.TabIndex = 6;
            this.botonDeVolver.Text = "VOLVER";
            this.botonDeVolver.UseVisualStyleBackColor = false;
            // 
            // botonDeEnviar
            // 
            this.botonDeEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeEnviar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeEnviar.ForeColor = System.Drawing.Color.White;
            this.botonDeEnviar.Location = new System.Drawing.Point(309, 205);
            this.botonDeEnviar.Name = "botonDeEnviar";
            this.botonDeEnviar.Size = new System.Drawing.Size(176, 48);
            this.botonDeEnviar.TabIndex = 7;
            this.botonDeEnviar.Text = "ENVIAR";
            this.botonDeEnviar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(50, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "NOMBRE";
            // 
            // textBoxDeNombre
            // 
            this.textBoxDeNombre.Font = new System.Drawing.Font("Arial", 8.25F);
            this.textBoxDeNombre.Location = new System.Drawing.Point(196, 54);
            this.textBoxDeNombre.Name = "textBoxDeNombre";
            this.textBoxDeNombre.Size = new System.Drawing.Size(176, 20);
            this.textBoxDeNombre.TabIndex = 9;
            // 
            // dateTimePickerDeFechaDeInicio
            // 
            this.dateTimePickerDeFechaDeInicio.Font = new System.Drawing.Font("Arial", 8.25F);
            this.dateTimePickerDeFechaDeInicio.Location = new System.Drawing.Point(196, 88);
            this.dateTimePickerDeFechaDeInicio.Name = "dateTimePickerDeFechaDeInicio";
            this.dateTimePickerDeFechaDeInicio.Size = new System.Drawing.Size(176, 20);
            this.dateTimePickerDeFechaDeInicio.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(50, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 14);
            this.label2.TabIndex = 11;
            this.label2.Text = "FECHA DE FINALIZACIÓN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(50, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 14);
            this.label3.TabIndex = 12;
            this.label3.Text = "FECHA DE INICIO";
            // 
            // dateTimePickerDeFechaDeFinalizacion
            // 
            this.dateTimePickerDeFechaDeFinalizacion.Font = new System.Drawing.Font("Arial", 8.25F);
            this.dateTimePickerDeFechaDeFinalizacion.Location = new System.Drawing.Point(196, 125);
            this.dateTimePickerDeFechaDeFinalizacion.Name = "dateTimePickerDeFechaDeFinalizacion";
            this.dateTimePickerDeFechaDeFinalizacion.Size = new System.Drawing.Size(176, 20);
            this.dateTimePickerDeFechaDeFinalizacion.TabIndex = 13;
            // 
            // SolicitudesVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(562, 290);
            this.Controls.Add(this.dateTimePickerDeFechaDeFinalizacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerDeFechaDeInicio);
            this.Controls.Add(this.textBoxDeNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonDeEnviar);
            this.Controls.Add(this.botonDeVolver);
            this.Name = "SolicitudesVacaciones";
            this.Text = "Solicitar vacaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonDeVolver;
        private System.Windows.Forms.Button botonDeEnviar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDeNombre;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeFechaDeInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeFechaDeFinalizacion;
    }
}