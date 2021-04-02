
namespace Proyecto_HRPS
{
    partial class PerfilDeAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerfilDeAdministrador));
            this.botonDeVerPerfil = new System.Windows.Forms.Button();
            this.botonDeSolicitarVacaciones = new System.Windows.Forms.Button();
            this.botonDeVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonDeVerPerfil
            // 
            this.botonDeVerPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeVerPerfil.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeVerPerfil.ForeColor = System.Drawing.Color.White;
            this.botonDeVerPerfil.Location = new System.Drawing.Point(55, 33);
            this.botonDeVerPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.botonDeVerPerfil.Name = "botonDeVerPerfil";
            this.botonDeVerPerfil.Size = new System.Drawing.Size(325, 57);
            this.botonDeVerPerfil.TabIndex = 19;
            this.botonDeVerPerfil.Text = "VER PERFIL";
            this.botonDeVerPerfil.UseVisualStyleBackColor = false;
            this.botonDeVerPerfil.Click += new System.EventHandler(this.botonDeVerPerfil_Click);
            // 
            // botonDeSolicitarVacaciones
            // 
            this.botonDeSolicitarVacaciones.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.botonDeSolicitarVacaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeSolicitarVacaciones.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeSolicitarVacaciones.ForeColor = System.Drawing.Color.White;
            this.botonDeSolicitarVacaciones.Location = new System.Drawing.Point(55, 98);
            this.botonDeSolicitarVacaciones.Margin = new System.Windows.Forms.Padding(4);
            this.botonDeSolicitarVacaciones.Name = "botonDeSolicitarVacaciones";
            this.botonDeSolicitarVacaciones.Size = new System.Drawing.Size(325, 57);
            this.botonDeSolicitarVacaciones.TabIndex = 20;
            this.botonDeSolicitarVacaciones.Text = "REGISTRAR SOLICITUD DE VACACIONES";
            this.botonDeSolicitarVacaciones.UseVisualStyleBackColor = false;
            this.botonDeSolicitarVacaciones.Click += new System.EventHandler(this.botonDeSolicitarVacaciones_Click);
            // 
            // botonDeVolver
            // 
            this.botonDeVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeVolver.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeVolver.ForeColor = System.Drawing.Color.White;
            this.botonDeVolver.Location = new System.Drawing.Point(55, 163);
            this.botonDeVolver.Margin = new System.Windows.Forms.Padding(4);
            this.botonDeVolver.Name = "botonDeVolver";
            this.botonDeVolver.Size = new System.Drawing.Size(325, 57);
            this.botonDeVolver.TabIndex = 21;
            this.botonDeVolver.Text = "VOLVER";
            this.botonDeVolver.UseVisualStyleBackColor = false;
            this.botonDeVolver.Click += new System.EventHandler(this.botonDeVolver_Click);
            // 
            // PerfilDeAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(432, 250);
            this.Controls.Add(this.botonDeVolver);
            this.Controls.Add(this.botonDeSolicitarVacaciones);
            this.Controls.Add(this.botonDeVerPerfil);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PerfilDeAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfil de Administrador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonDeVerPerfil;
        private System.Windows.Forms.Button botonDeSolicitarVacaciones;
        private System.Windows.Forms.Button botonDeVolver;
    }
}