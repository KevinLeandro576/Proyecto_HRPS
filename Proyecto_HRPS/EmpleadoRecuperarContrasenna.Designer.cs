namespace Proyecto_HRPS
{
    partial class EmpleadoRecuperarContrasenna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpleadoRecuperarContrasenna));
            this.textBoxDeCedula = new System.Windows.Forms.TextBox();
            this.labelDeCedula = new System.Windows.Forms.Label();
            this.botonDeVolver = new System.Windows.Forms.Button();
            this.botonDeEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDeCedula
            // 
            this.textBoxDeCedula.Font = new System.Drawing.Font("Arial", 12F);
            this.textBoxDeCedula.Location = new System.Drawing.Point(231, 58);
            this.textBoxDeCedula.Name = "textBoxDeCedula";
            this.textBoxDeCedula.Size = new System.Drawing.Size(245, 26);
            this.textBoxDeCedula.TabIndex = 22;
            // 
            // labelDeCedula
            // 
            this.labelDeCedula.AutoSize = true;
            this.labelDeCedula.Font = new System.Drawing.Font("Arial", 12F);
            this.labelDeCedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.labelDeCedula.Location = new System.Drawing.Point(68, 61);
            this.labelDeCedula.Name = "labelDeCedula";
            this.labelDeCedula.Size = new System.Drawing.Size(77, 18);
            this.labelDeCedula.TabIndex = 21;
            this.labelDeCedula.Text = "CÉDULA ";
            // 
            // botonDeVolver
            // 
            this.botonDeVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeVolver.Font = new System.Drawing.Font("Arial", 12F);
            this.botonDeVolver.ForeColor = System.Drawing.Color.White;
            this.botonDeVolver.Location = new System.Drawing.Point(62, 155);
            this.botonDeVolver.Name = "botonDeVolver";
            this.botonDeVolver.Size = new System.Drawing.Size(176, 41);
            this.botonDeVolver.TabIndex = 24;
            this.botonDeVolver.Text = "VOLVER";
            this.botonDeVolver.UseVisualStyleBackColor = false;
            this.botonDeVolver.Click += new System.EventHandler(this.botonDeVolver_Click);
            // 
            // botonDeEnviar
            // 
            this.botonDeEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeEnviar.Font = new System.Drawing.Font("Arial", 12F);
            this.botonDeEnviar.ForeColor = System.Drawing.Color.White;
            this.botonDeEnviar.Location = new System.Drawing.Point(300, 155);
            this.botonDeEnviar.Name = "botonDeEnviar";
            this.botonDeEnviar.Size = new System.Drawing.Size(176, 41);
            this.botonDeEnviar.TabIndex = 25;
            this.botonDeEnviar.Text = "ENVIAR";
            this.botonDeEnviar.UseVisualStyleBackColor = false;
            this.botonDeEnviar.Click += new System.EventHandler(this.botonDeEnviar_Click);
            // 
            // EmpleadoRecuperarContrasenna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(556, 240);
            this.Controls.Add(this.botonDeEnviar);
            this.Controls.Add(this.botonDeVolver);
            this.Controls.Add(this.textBoxDeCedula);
            this.Controls.Add(this.labelDeCedula);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmpleadoRecuperarContrasenna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperar contraseña";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RecuperarContrasenna_FormClosing);
            this.Load += new System.EventHandler(this.RecuperarContrasenna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDeCedula;
        private System.Windows.Forms.Label labelDeCedula;
        private System.Windows.Forms.Button botonDeVolver;
        private System.Windows.Forms.Button botonDeEnviar;
    }
}