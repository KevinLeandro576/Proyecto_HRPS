namespace Proyecto_HRPS
{
    partial class MenuDeEmpleado
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
            this.enlaceDePerfiles = new System.Windows.Forms.LinkLabel();
            this.enlaceDeVerHorasExtras = new System.Windows.Forms.LinkLabel();
            this.enlaceDeSolicitudes = new System.Windows.Forms.LinkLabel();
            this.enlaceDeVolver = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // enlaceDePerfiles
            // 
            this.enlaceDePerfiles.AutoSize = true;
            this.enlaceDePerfiles.Font = new System.Drawing.Font("Arial", 8.25F);
            this.enlaceDePerfiles.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.enlaceDePerfiles.Location = new System.Drawing.Point(70, 37);
            this.enlaceDePerfiles.Name = "enlaceDePerfiles";
            this.enlaceDePerfiles.Size = new System.Drawing.Size(40, 14);
            this.enlaceDePerfiles.TabIndex = 0;
            this.enlaceDePerfiles.TabStop = true;
            this.enlaceDePerfiles.Text = "PERFIL";
            // 
            // enlaceDeVerHorasExtras
            // 
            this.enlaceDeVerHorasExtras.AutoSize = true;
            this.enlaceDeVerHorasExtras.Font = new System.Drawing.Font("Arial", 8.25F);
            this.enlaceDeVerHorasExtras.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.enlaceDeVerHorasExtras.Location = new System.Drawing.Point(218, 37);
            this.enlaceDeVerHorasExtras.Name = "enlaceDeVerHorasExtras";
            this.enlaceDeVerHorasExtras.Size = new System.Drawing.Size(112, 14);
            this.enlaceDeVerHorasExtras.TabIndex = 1;
            this.enlaceDeVerHorasExtras.TabStop = true;
            this.enlaceDeVerHorasExtras.Text = "VER HORAS EXTRAS";
            // 
            // enlaceDeSolicitudes
            // 
            this.enlaceDeSolicitudes.AutoSize = true;
            this.enlaceDeSolicitudes.Font = new System.Drawing.Font("Arial", 8.25F);
            this.enlaceDeSolicitudes.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.enlaceDeSolicitudes.Location = new System.Drawing.Point(445, 37);
            this.enlaceDeSolicitudes.Name = "enlaceDeSolicitudes";
            this.enlaceDeSolicitudes.Size = new System.Drawing.Size(72, 14);
            this.enlaceDeSolicitudes.TabIndex = 2;
            this.enlaceDeSolicitudes.TabStop = true;
            this.enlaceDeSolicitudes.Text = "SOLICITUDES";
            // 
            // enlaceDeVolver
            // 
            this.enlaceDeVolver.AutoSize = true;
            this.enlaceDeVolver.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enlaceDeVolver.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.enlaceDeVolver.Location = new System.Drawing.Point(652, 37);
            this.enlaceDeVolver.Name = "enlaceDeVolver";
            this.enlaceDeVolver.Size = new System.Drawing.Size(49, 14);
            this.enlaceDeVolver.TabIndex = 9;
            this.enlaceDeVolver.TabStop = true;
            this.enlaceDeVolver.Text = "VOLVER";
            // 
            // MenuDeEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 317);
            this.Controls.Add(this.enlaceDeVolver);
            this.Controls.Add(this.enlaceDeSolicitudes);
            this.Controls.Add(this.enlaceDeVerHorasExtras);
            this.Controls.Add(this.enlaceDePerfiles);
            this.Name = "MenuDeEmpleado";
            this.Text = "Menú de empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel enlaceDePerfiles;
        private System.Windows.Forms.LinkLabel enlaceDeVerHorasExtras;
        private System.Windows.Forms.LinkLabel enlaceDeSolicitudes;
        private System.Windows.Forms.LinkLabel enlaceDeVolver;
    }
}