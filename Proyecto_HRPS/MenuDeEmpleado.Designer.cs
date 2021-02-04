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
            this.botonDeVolver = new System.Windows.Forms.Button();
            this.botonDePerfil = new System.Windows.Forms.Button();
            this.botonDeVerHorasExtra = new System.Windows.Forms.Button();
            this.botonDeSolicitudes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonDeVolver
            // 
            this.botonDeVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeVolver.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeVolver.ForeColor = System.Drawing.Color.White;
            this.botonDeVolver.Location = new System.Drawing.Point(66, 187);
            this.botonDeVolver.Margin = new System.Windows.Forms.Padding(4);
            this.botonDeVolver.Name = "botonDeVolver";
            this.botonDeVolver.Size = new System.Drawing.Size(325, 41);
            this.botonDeVolver.TabIndex = 18;
            this.botonDeVolver.Text = "VOLVER";
            this.botonDeVolver.UseVisualStyleBackColor = false;
            this.botonDeVolver.Click += new System.EventHandler(this.botonDeVolver_Click);
            // 
            // botonDePerfil
            // 
            this.botonDePerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDePerfil.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDePerfil.ForeColor = System.Drawing.Color.White;
            this.botonDePerfil.Location = new System.Drawing.Point(66, 40);
            this.botonDePerfil.Margin = new System.Windows.Forms.Padding(4);
            this.botonDePerfil.Name = "botonDePerfil";
            this.botonDePerfil.Size = new System.Drawing.Size(325, 41);
            this.botonDePerfil.TabIndex = 19;
            this.botonDePerfil.Text = "PERFIL";
            this.botonDePerfil.UseVisualStyleBackColor = false;
            this.botonDePerfil.Click += new System.EventHandler(this.botonDePerfil_Click);
            // 
            // botonDeVerHorasExtra
            // 
            this.botonDeVerHorasExtra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeVerHorasExtra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeVerHorasExtra.ForeColor = System.Drawing.Color.White;
            this.botonDeVerHorasExtra.Location = new System.Drawing.Point(66, 89);
            this.botonDeVerHorasExtra.Margin = new System.Windows.Forms.Padding(4);
            this.botonDeVerHorasExtra.Name = "botonDeVerHorasExtra";
            this.botonDeVerHorasExtra.Size = new System.Drawing.Size(325, 41);
            this.botonDeVerHorasExtra.TabIndex = 20;
            this.botonDeVerHorasExtra.Text = "VER HORAS EXTRA";
            this.botonDeVerHorasExtra.UseVisualStyleBackColor = false;
            this.botonDeVerHorasExtra.Click += new System.EventHandler(this.botonDeVerHorasExtra_Click);
            // 
            // botonDeSolicitudes
            // 
            this.botonDeSolicitudes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeSolicitudes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeSolicitudes.ForeColor = System.Drawing.Color.White;
            this.botonDeSolicitudes.Location = new System.Drawing.Point(66, 138);
            this.botonDeSolicitudes.Margin = new System.Windows.Forms.Padding(4);
            this.botonDeSolicitudes.Name = "botonDeSolicitudes";
            this.botonDeSolicitudes.Size = new System.Drawing.Size(325, 41);
            this.botonDeSolicitudes.TabIndex = 21;
            this.botonDeSolicitudes.Text = "SOLICITUDES";
            this.botonDeSolicitudes.UseVisualStyleBackColor = false;
            this.botonDeSolicitudes.Click += new System.EventHandler(this.botonDeSolicitudes_Click);
            // 
            // MenuDeEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(480, 271);
            this.Controls.Add(this.botonDeSolicitudes);
            this.Controls.Add(this.botonDeVerHorasExtra);
            this.Controls.Add(this.botonDePerfil);
            this.Controls.Add(this.botonDeVolver);
            this.Name = "MenuDeEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú de empleado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuDeEmpleado_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button botonDeVolver;
        private System.Windows.Forms.Button botonDePerfil;
        private System.Windows.Forms.Button botonDeVerHorasExtra;
        private System.Windows.Forms.Button botonDeSolicitudes;
    }
}