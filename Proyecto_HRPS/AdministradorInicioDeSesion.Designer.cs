namespace Proyecto_HRPS
{
    partial class AdministradorInicioDeSesion
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
            this.labelDeCedula = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDeCedula = new System.Windows.Forms.TextBox();
            this.textBoxDeContrasena = new System.Windows.Forms.TextBox();
            this.botonDeVolver = new System.Windows.Forms.Button();
            this.botonDeIniciarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDeCedula
            // 
            this.labelDeCedula.AutoSize = true;
            this.labelDeCedula.Font = new System.Drawing.Font("Arial", 8.25F);
            this.labelDeCedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.labelDeCedula.Location = new System.Drawing.Point(68, 49);
            this.labelDeCedula.Name = "labelDeCedula";
            this.labelDeCedula.Size = new System.Drawing.Size(50, 14);
            this.labelDeCedula.TabIndex = 20;
            this.labelDeCedula.Text = "CÉDULA ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(68, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 14);
            this.label1.TabIndex = 22;
            this.label1.Text = "CONTRASEÑA";
            // 
            // textBoxDeCedula
            // 
            this.textBoxDeCedula.Font = new System.Drawing.Font("Arial", 8.25F);
            this.textBoxDeCedula.Location = new System.Drawing.Point(183, 43);
            this.textBoxDeCedula.Name = "textBoxDeCedula";
            this.textBoxDeCedula.Size = new System.Drawing.Size(176, 20);
            this.textBoxDeCedula.TabIndex = 23;
            // 
            // textBoxDeContrasena
            // 
            this.textBoxDeContrasena.Font = new System.Drawing.Font("Arial", 8.25F);
            this.textBoxDeContrasena.Location = new System.Drawing.Point(183, 89);
            this.textBoxDeContrasena.Name = "textBoxDeContrasena";
            this.textBoxDeContrasena.Size = new System.Drawing.Size(176, 20);
            this.textBoxDeContrasena.TabIndex = 24;
            // 
            // botonDeVolver
            // 
            this.botonDeVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeVolver.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeVolver.ForeColor = System.Drawing.Color.White;
            this.botonDeVolver.Location = new System.Drawing.Point(71, 172);
            this.botonDeVolver.Name = "botonDeVolver";
            this.botonDeVolver.Size = new System.Drawing.Size(176, 41);
            this.botonDeVolver.TabIndex = 25;
            this.botonDeVolver.Text = "VOLVER";
            this.botonDeVolver.UseVisualStyleBackColor = false;
            this.botonDeVolver.Click += new System.EventHandler(this.botonDeVolver_Click);
            // 
            // botonDeIniciarSesion
            // 
            this.botonDeIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeIniciarSesion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.botonDeIniciarSesion.Location = new System.Drawing.Point(343, 172);
            this.botonDeIniciarSesion.Name = "botonDeIniciarSesion";
            this.botonDeIniciarSesion.Size = new System.Drawing.Size(176, 41);
            this.botonDeIniciarSesion.TabIndex = 26;
            this.botonDeIniciarSesion.Text = "INICIAR SESIÓN";
            this.botonDeIniciarSesion.UseVisualStyleBackColor = false;
            this.botonDeIniciarSesion.Click += new System.EventHandler(this.botonDeIniciarSesion_Click);
            // 
            // AdministradorInicioDeSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(602, 281);
            this.Controls.Add(this.botonDeIniciarSesion);
            this.Controls.Add(this.botonDeVolver);
            this.Controls.Add(this.textBoxDeContrasena);
            this.Controls.Add(this.textBoxDeCedula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDeCedula);
            this.Font = new System.Drawing.Font("Volta Modern Display 55 Rom", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdministradorInicioDeSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador inicio de sesión";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdministradorInicioDeSesion_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDeCedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDeCedula;
        private System.Windows.Forms.TextBox textBoxDeContrasena;
        private System.Windows.Forms.Button botonDeVolver;
        private System.Windows.Forms.Button botonDeIniciarSesion;
    }
}