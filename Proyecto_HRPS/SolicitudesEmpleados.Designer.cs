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
            this.enlace_Vacaciones = new System.Windows.Forms.LinkLabel();
            this.enlace_RegistroDeHoras = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // enlace_Vacaciones
            // 
            this.enlace_Vacaciones.AutoSize = true;
            this.enlace_Vacaciones.Font = new System.Drawing.Font("Arial", 8.25F);
            this.enlace_Vacaciones.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.enlace_Vacaciones.Location = new System.Drawing.Point(56, 37);
            this.enlace_Vacaciones.Name = "enlace_Vacaciones";
            this.enlace_Vacaciones.Size = new System.Drawing.Size(129, 14);
            this.enlace_Vacaciones.TabIndex = 6;
            this.enlace_Vacaciones.TabStop = true;
            this.enlace_Vacaciones.Text = "SOLICITAR VACACIONES";
            // 
            // enlace_RegistroDeHoras
            // 
            this.enlace_RegistroDeHoras.AutoSize = true;
            this.enlace_RegistroDeHoras.Font = new System.Drawing.Font("Arial", 8.25F);
            this.enlace_RegistroDeHoras.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.enlace_RegistroDeHoras.Location = new System.Drawing.Point(259, 37);
            this.enlace_RegistroDeHoras.Name = "enlace_RegistroDeHoras";
            this.enlace_RegistroDeHoras.Size = new System.Drawing.Size(149, 14);
            this.enlace_RegistroDeHoras.TabIndex = 7;
            this.enlace_RegistroDeHoras.TabStop = true;
            this.enlace_RegistroDeHoras.Text = "REGISTRAR HORAS EXTRAS";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 8.25F);
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.linkLabel1.Location = new System.Drawing.Point(530, 37);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(49, 14);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "VOLVER";
            // 
            // SolicitudesEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(692, 330);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.enlace_RegistroDeHoras);
            this.Controls.Add(this.enlace_Vacaciones);
            this.Name = "SolicitudesEmpleados";
            this.Text = "Menú de solicitudes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel enlace_Vacaciones;
        private System.Windows.Forms.LinkLabel enlace_RegistroDeHoras;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}