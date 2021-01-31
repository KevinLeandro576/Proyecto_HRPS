namespace Proyecto_HRPS
{
    partial class AdministradorRecuperarContrasenna
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
            this.botonDeEnviar = new System.Windows.Forms.Button();
            this.botonDeVolver = new System.Windows.Forms.Button();
            this.textBoxDeCedula = new System.Windows.Forms.TextBox();
            this.labelDeCedula = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botonDeEnviar
            // 
            this.botonDeEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeEnviar.Font = new System.Drawing.Font("Arial", 12F);
            this.botonDeEnviar.ForeColor = System.Drawing.Color.White;
            this.botonDeEnviar.Location = new System.Drawing.Point(315, 182);
            this.botonDeEnviar.Name = "botonDeEnviar";
            this.botonDeEnviar.Size = new System.Drawing.Size(176, 41);
            this.botonDeEnviar.TabIndex = 29;
            this.botonDeEnviar.Text = "ENVIAR";
            this.botonDeEnviar.UseVisualStyleBackColor = false;
            this.botonDeEnviar.Click += new System.EventHandler(this.botonDeEnviar_Click);
            // 
            // botonDeVolver
            // 
            this.botonDeVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeVolver.Font = new System.Drawing.Font("Arial", 12F);
            this.botonDeVolver.ForeColor = System.Drawing.Color.White;
            this.botonDeVolver.Location = new System.Drawing.Point(86, 182);
            this.botonDeVolver.Name = "botonDeVolver";
            this.botonDeVolver.Size = new System.Drawing.Size(176, 41);
            this.botonDeVolver.TabIndex = 28;
            this.botonDeVolver.Text = "VOLVER";
            this.botonDeVolver.UseVisualStyleBackColor = false;
            this.botonDeVolver.Click += new System.EventHandler(this.botonDeVolver_Click);
            // 
            // textBoxDeCedula
            // 
            this.textBoxDeCedula.Font = new System.Drawing.Font("Arial", 12F);
            this.textBoxDeCedula.Location = new System.Drawing.Point(270, 86);
            this.textBoxDeCedula.Name = "textBoxDeCedula";
            this.textBoxDeCedula.Size = new System.Drawing.Size(176, 26);
            this.textBoxDeCedula.TabIndex = 27;
            // 
            // labelDeCedula
            // 
            this.labelDeCedula.AutoSize = true;
            this.labelDeCedula.Font = new System.Drawing.Font("Arial", 12F);
            this.labelDeCedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.labelDeCedula.Location = new System.Drawing.Point(131, 89);
            this.labelDeCedula.Name = "labelDeCedula";
            this.labelDeCedula.Size = new System.Drawing.Size(77, 18);
            this.labelDeCedula.TabIndex = 26;
            this.labelDeCedula.Text = "CÉDULA ";
            // 
            // AdministradorRecuperarContrasenna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(612, 285);
            this.Controls.Add(this.botonDeEnviar);
            this.Controls.Add(this.botonDeVolver);
            this.Controls.Add(this.textBoxDeCedula);
            this.Controls.Add(this.labelDeCedula);
            this.Name = "AdministradorRecuperarContrasenna";
            this.Text = "Recuperar contraseña";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdministradorRecuperarContrasenna_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonDeEnviar;
        private System.Windows.Forms.Button botonDeVolver;
        private System.Windows.Forms.TextBox textBoxDeCedula;
        private System.Windows.Forms.Label labelDeCedula;
    }
}