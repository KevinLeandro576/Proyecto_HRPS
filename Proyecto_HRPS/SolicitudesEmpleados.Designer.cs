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
            this.enlaceDeSolicitarVacaciones = new System.Windows.Forms.LinkLabel();
            this.enlaceDeRegistrarHorasExtras = new System.Windows.Forms.LinkLabel();
            this.enlaceDeVolver = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // enlaceDeSolicitarVacaciones
            // 
            this.enlaceDeSolicitarVacaciones.AutoSize = true;
            this.enlaceDeSolicitarVacaciones.Font = new System.Drawing.Font("Arial", 8.25F);
            this.enlaceDeSolicitarVacaciones.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.enlaceDeSolicitarVacaciones.Location = new System.Drawing.Point(56, 37);
            this.enlaceDeSolicitarVacaciones.Name = "enlaceDeSolicitarVacaciones";
            this.enlaceDeSolicitarVacaciones.Size = new System.Drawing.Size(129, 14);
            this.enlaceDeSolicitarVacaciones.TabIndex = 6;
            this.enlaceDeSolicitarVacaciones.TabStop = true;
            this.enlaceDeSolicitarVacaciones.Text = "SOLICITAR VACACIONES";
            this.enlaceDeSolicitarVacaciones.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.enlaceDeSolicitarVacaciones_LinkClicked);
            // 
            // enlaceDeRegistrarHorasExtras
            // 
            this.enlaceDeRegistrarHorasExtras.AutoSize = true;
            this.enlaceDeRegistrarHorasExtras.Font = new System.Drawing.Font("Arial", 8.25F);
            this.enlaceDeRegistrarHorasExtras.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.enlaceDeRegistrarHorasExtras.Location = new System.Drawing.Point(259, 37);
            this.enlaceDeRegistrarHorasExtras.Name = "enlaceDeRegistrarHorasExtras";
            this.enlaceDeRegistrarHorasExtras.Size = new System.Drawing.Size(149, 14);
            this.enlaceDeRegistrarHorasExtras.TabIndex = 7;
            this.enlaceDeRegistrarHorasExtras.TabStop = true;
            this.enlaceDeRegistrarHorasExtras.Text = "REGISTRAR HORAS EXTRAS";
            this.enlaceDeRegistrarHorasExtras.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.enlaceDeRegistrarHorasExtras_LinkClicked);
            // 
            // enlaceDeVolver
            // 
            this.enlaceDeVolver.AutoSize = true;
            this.enlaceDeVolver.Font = new System.Drawing.Font("Arial", 8.25F);
            this.enlaceDeVolver.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.enlaceDeVolver.Location = new System.Drawing.Point(530, 37);
            this.enlaceDeVolver.Name = "enlaceDeVolver";
            this.enlaceDeVolver.Size = new System.Drawing.Size(49, 14);
            this.enlaceDeVolver.TabIndex = 8;
            this.enlaceDeVolver.TabStop = true;
            this.enlaceDeVolver.Text = "VOLVER";
            this.enlaceDeVolver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.enlaceDeVolver_LinkClicked);
            // 
            // SolicitudesEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(692, 330);
            this.Controls.Add(this.enlaceDeVolver);
            this.Controls.Add(this.enlaceDeRegistrarHorasExtras);
            this.Controls.Add(this.enlaceDeSolicitarVacaciones);
            this.Name = "SolicitudesEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú de solicitudes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel enlaceDeSolicitarVacaciones;
        private System.Windows.Forms.LinkLabel enlaceDeRegistrarHorasExtras;
        private System.Windows.Forms.LinkLabel enlaceDeVolver;
    }
}