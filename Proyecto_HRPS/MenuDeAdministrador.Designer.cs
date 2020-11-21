namespace Proyecto_HRPS
{
    partial class MenuDeAdministrador
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
            this.enlaceDePerfilesDeUsuario = new System.Windows.Forms.LinkLabel();
            this.enlaceDeControlDeEmpleados = new System.Windows.Forms.LinkLabel();
            this.enlaceDeSolicitudes = new System.Windows.Forms.LinkLabel();
            this.enlaceDeReportes = new System.Windows.Forms.LinkLabel();
            this.enlaceDeVolver = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // enlaceDePerfilesDeUsuario
            // 
            this.enlaceDePerfilesDeUsuario.AutoSize = true;
            this.enlaceDePerfilesDeUsuario.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enlaceDePerfilesDeUsuario.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.enlaceDePerfilesDeUsuario.Location = new System.Drawing.Point(38, 18);
            this.enlaceDePerfilesDeUsuario.Name = "enlaceDePerfilesDeUsuario";
            this.enlaceDePerfilesDeUsuario.Size = new System.Drawing.Size(118, 14);
            this.enlaceDePerfilesDeUsuario.TabIndex = 0;
            this.enlaceDePerfilesDeUsuario.TabStop = true;
            this.enlaceDePerfilesDeUsuario.Text = "PERFILES DE USUARIO";
            this.enlaceDePerfilesDeUsuario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.enlaceDePerfilesDeUsuario_LinkClicked);
            // 
            // enlaceDeControlDeEmpleados
            // 
            this.enlaceDeControlDeEmpleados.AutoSize = true;
            this.enlaceDeControlDeEmpleados.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enlaceDeControlDeEmpleados.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.enlaceDeControlDeEmpleados.Location = new System.Drawing.Point(202, 18);
            this.enlaceDeControlDeEmpleados.Name = "enlaceDeControlDeEmpleados";
            this.enlaceDeControlDeEmpleados.Size = new System.Drawing.Size(137, 14);
            this.enlaceDeControlDeEmpleados.TabIndex = 1;
            this.enlaceDeControlDeEmpleados.TabStop = true;
            this.enlaceDeControlDeEmpleados.Text = "CONTROL DE EMPLEADOS";
            // 
            // enlaceDeSolicitudes
            // 
            this.enlaceDeSolicitudes.AutoSize = true;
            this.enlaceDeSolicitudes.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enlaceDeSolicitudes.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.enlaceDeSolicitudes.Location = new System.Drawing.Point(412, 18);
            this.enlaceDeSolicitudes.Name = "enlaceDeSolicitudes";
            this.enlaceDeSolicitudes.Size = new System.Drawing.Size(72, 14);
            this.enlaceDeSolicitudes.TabIndex = 2;
            this.enlaceDeSolicitudes.TabStop = true;
            this.enlaceDeSolicitudes.Text = "SOLICITUDES";
            // 
            // enlaceDeReportes
            // 
            this.enlaceDeReportes.AutoSize = true;
            this.enlaceDeReportes.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enlaceDeReportes.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.enlaceDeReportes.Location = new System.Drawing.Point(557, 18);
            this.enlaceDeReportes.Name = "enlaceDeReportes";
            this.enlaceDeReportes.Size = new System.Drawing.Size(60, 14);
            this.enlaceDeReportes.TabIndex = 3;
            this.enlaceDeReportes.TabStop = true;
            this.enlaceDeReportes.Text = "REPORTES";
            // 
            // enlaceDeVolver
            // 
            this.enlaceDeVolver.AutoSize = true;
            this.enlaceDeVolver.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enlaceDeVolver.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.enlaceDeVolver.Location = new System.Drawing.Point(697, 18);
            this.enlaceDeVolver.Name = "enlaceDeVolver";
            this.enlaceDeVolver.Size = new System.Drawing.Size(49, 14);
            this.enlaceDeVolver.TabIndex = 4;
            this.enlaceDeVolver.TabStop = true;
            this.enlaceDeVolver.Text = "VOLVER";
            // 
            // MenuDeAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.Controls.Add(this.enlaceDeVolver);
            this.Controls.Add(this.enlaceDeReportes);
            this.Controls.Add(this.enlaceDeSolicitudes);
            this.Controls.Add(this.enlaceDeControlDeEmpleados);
            this.Controls.Add(this.enlaceDePerfilesDeUsuario);
            this.Font = new System.Drawing.Font("Volta Modern Display 55 Rom", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MenuDeAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu de administrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel enlaceDePerfilesDeUsuario;
        private System.Windows.Forms.LinkLabel enlaceDeControlDeEmpleados;
        private System.Windows.Forms.LinkLabel enlaceDeSolicitudes;
        private System.Windows.Forms.LinkLabel enlaceDeReportes;
        private System.Windows.Forms.LinkLabel enlaceDeVolver;
    }
}