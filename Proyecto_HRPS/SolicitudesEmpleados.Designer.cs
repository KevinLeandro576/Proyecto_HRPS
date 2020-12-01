namespace Proyecto_HRPS
{
    partial class SolicitudesEmpleados
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
            this.enlace_Vacaciones = new System.Windows.Forms.LinkLabel();
            this.enlace_RegistroDeHoras = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // botonDeVolver
            // 
            this.botonDeVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeVolver.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeVolver.ForeColor = System.Drawing.Color.White;
            this.botonDeVolver.Location = new System.Drawing.Point(125, 301);
            this.botonDeVolver.Name = "botonDeVolver";
            this.botonDeVolver.Size = new System.Drawing.Size(176, 48);
            this.botonDeVolver.TabIndex = 5;
            this.botonDeVolver.Text = "VOLVER";
            this.botonDeVolver.UseVisualStyleBackColor = false;
            // 
            // enlace_Vacaciones
            // 
            this.enlace_Vacaciones.AutoSize = true;
            this.enlace_Vacaciones.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.enlace_Vacaciones.Location = new System.Drawing.Point(135, 87);
            this.enlace_Vacaciones.Name = "enlace_Vacaciones";
            this.enlace_Vacaciones.Size = new System.Drawing.Size(134, 13);
            this.enlace_Vacaciones.TabIndex = 6;
            this.enlace_Vacaciones.TabStop = true;
            this.enlace_Vacaciones.Text = "SOLICITAR VACACIONES";
            // 
            // enlace_RegistroDeHoras
            // 
            this.enlace_RegistroDeHoras.AutoSize = true;
            this.enlace_RegistroDeHoras.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.enlace_RegistroDeHoras.Location = new System.Drawing.Point(489, 87);
            this.enlace_RegistroDeHoras.Name = "enlace_RegistroDeHoras";
            this.enlace_RegistroDeHoras.Size = new System.Drawing.Size(157, 13);
            this.enlace_RegistroDeHoras.TabIndex = 7;
            this.enlace_RegistroDeHoras.TabStop = true;
            this.enlace_RegistroDeHoras.Text = "REGISTRAR HORAS EXTRAS";
            // 
            // SolicitudesEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.enlace_RegistroDeHoras);
            this.Controls.Add(this.enlace_Vacaciones);
            this.Controls.Add(this.botonDeVolver);
            this.Name = "SolicitudesEmpleados";
            this.Text = "SolicitudesEmpleados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonDeVolver;
        private System.Windows.Forms.LinkLabel enlace_Vacaciones;
        private System.Windows.Forms.LinkLabel enlace_RegistroDeHoras;
    }
}