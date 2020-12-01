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
            this.enlace_Perfiles = new System.Windows.Forms.LinkLabel();
            this.enlace_HorasExtras = new System.Windows.Forms.LinkLabel();
            this.enlace_Solicitudes = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // enlace_Perfiles
            // 
            this.enlace_Perfiles.AutoSize = true;
            this.enlace_Perfiles.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.enlace_Perfiles.Location = new System.Drawing.Point(103, 52);
            this.enlace_Perfiles.Name = "enlace_Perfiles";
            this.enlace_Perfiles.Size = new System.Drawing.Size(44, 13);
            this.enlace_Perfiles.TabIndex = 0;
            this.enlace_Perfiles.TabStop = true;
            this.enlace_Perfiles.Text = "PERFIL";
            // 
            // enlace_HorasExtras
            // 
            this.enlace_HorasExtras.AutoSize = true;
            this.enlace_HorasExtras.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.enlace_HorasExtras.Location = new System.Drawing.Point(310, 52);
            this.enlace_HorasExtras.Name = "enlace_HorasExtras";
            this.enlace_HorasExtras.Size = new System.Drawing.Size(116, 13);
            this.enlace_HorasExtras.TabIndex = 1;
            this.enlace_HorasExtras.TabStop = true;
            this.enlace_HorasExtras.Text = "VER HORAS EXTRAS";
            // 
            // enlace_Solicitudes
            // 
            this.enlace_Solicitudes.AutoSize = true;
            this.enlace_Solicitudes.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.enlace_Solicitudes.Location = new System.Drawing.Point(558, 52);
            this.enlace_Solicitudes.Name = "enlace_Solicitudes";
            this.enlace_Solicitudes.Size = new System.Drawing.Size(78, 13);
            this.enlace_Solicitudes.TabIndex = 2;
            this.enlace_Solicitudes.TabStop = true;
            this.enlace_Solicitudes.Text = "SOLICITUDES";
            // 
            // MenuDeEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.enlace_Solicitudes);
            this.Controls.Add(this.enlace_HorasExtras);
            this.Controls.Add(this.enlace_Perfiles);
            this.Name = "MenuDeEmpleado";
            this.Text = "MenuDeEmpleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel enlace_Perfiles;
        private System.Windows.Forms.LinkLabel enlace_HorasExtras;
        private System.Windows.Forms.LinkLabel enlace_Solicitudes;
    }
}