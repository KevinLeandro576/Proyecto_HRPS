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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolicitudesEmpleados));
            this.botonDeVolver = new System.Windows.Forms.Button();
            this.botonDeRegistrarHorasExtra = new System.Windows.Forms.Button();
            this.botonDeSolicitarVacaciones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonDeVolver
            // 
            this.botonDeVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeVolver.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeVolver.ForeColor = System.Drawing.Color.White;
            this.botonDeVolver.Location = new System.Drawing.Point(104, 212);
            this.botonDeVolver.Margin = new System.Windows.Forms.Padding(4);
            this.botonDeVolver.Name = "botonDeVolver";
            this.botonDeVolver.Size = new System.Drawing.Size(325, 57);
            this.botonDeVolver.TabIndex = 21;
            this.botonDeVolver.Text = "VOLVER";
            this.botonDeVolver.UseVisualStyleBackColor = false;
            this.botonDeVolver.Click += new System.EventHandler(this.botonDeVolver_Click);
            // 
            // botonDeRegistrarHorasExtra
            // 
            this.botonDeRegistrarHorasExtra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeRegistrarHorasExtra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeRegistrarHorasExtra.ForeColor = System.Drawing.Color.White;
            this.botonDeRegistrarHorasExtra.Location = new System.Drawing.Point(104, 42);
            this.botonDeRegistrarHorasExtra.Margin = new System.Windows.Forms.Padding(4);
            this.botonDeRegistrarHorasExtra.Name = "botonDeRegistrarHorasExtra";
            this.botonDeRegistrarHorasExtra.Size = new System.Drawing.Size(325, 57);
            this.botonDeRegistrarHorasExtra.TabIndex = 22;
            this.botonDeRegistrarHorasExtra.Text = "REGISTRAR SOLICITUD DE HORAS EXTRA";
            this.botonDeRegistrarHorasExtra.UseVisualStyleBackColor = false;
            this.botonDeRegistrarHorasExtra.Click += new System.EventHandler(this.botonDeRegistrarHorasExtra_Click);
            // 
            // botonDeSolicitarVacaciones
            // 
            this.botonDeSolicitarVacaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeSolicitarVacaciones.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeSolicitarVacaciones.ForeColor = System.Drawing.Color.White;
            this.botonDeSolicitarVacaciones.Location = new System.Drawing.Point(104, 123);
            this.botonDeSolicitarVacaciones.Margin = new System.Windows.Forms.Padding(4);
            this.botonDeSolicitarVacaciones.Name = "botonDeSolicitarVacaciones";
            this.botonDeSolicitarVacaciones.Size = new System.Drawing.Size(325, 57);
            this.botonDeSolicitarVacaciones.TabIndex = 23;
            this.botonDeSolicitarVacaciones.Text = "REGISTRAR SOLICITUD DE VACACIONES";
            this.botonDeSolicitarVacaciones.UseVisualStyleBackColor = false;
            this.botonDeSolicitarVacaciones.Click += new System.EventHandler(this.botonDeSolicitarVacaciones_Click);
            // 
            // SolicitudesEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(545, 324);
            this.Controls.Add(this.botonDeSolicitarVacaciones);
            this.Controls.Add(this.botonDeRegistrarHorasExtra);
            this.Controls.Add(this.botonDeVolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SolicitudesEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú de solicitudes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SolicitudesEmpleados_FormClosing);
            this.Load += new System.EventHandler(this.SolicitudesEmpleados_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button botonDeVolver;
        private System.Windows.Forms.Button botonDeRegistrarHorasExtra;
        private System.Windows.Forms.Button botonDeSolicitarVacaciones;
    }
}