namespace Proyecto_HRPS
{
    partial class EmpleadoInicioDeSesion
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
            this.textBoxDeCedula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDeContrasena = new System.Windows.Forms.TextBox();
            this.botonDeVolver = new System.Windows.Forms.Button();
            this.botonDeIniciarSesion = new System.Windows.Forms.Button();
            this.linkLabelDeRecuperarPW = new System.Windows.Forms.LinkLabel();
            this.labelDeRecuperarContrasenna = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDeCedula
            // 
            this.labelDeCedula.AutoSize = true;
            this.labelDeCedula.Font = new System.Drawing.Font("Arial", 12F);
            this.labelDeCedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.labelDeCedula.Location = new System.Drawing.Point(64, 54);
            this.labelDeCedula.Name = "labelDeCedula";
            this.labelDeCedula.Size = new System.Drawing.Size(77, 18);
            this.labelDeCedula.TabIndex = 19;
            this.labelDeCedula.Text = "CÉDULA ";
            this.labelDeCedula.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxDeCedula
            // 
            this.textBoxDeCedula.Font = new System.Drawing.Font("Arial", 12F);
            this.textBoxDeCedula.Location = new System.Drawing.Point(264, 51);
            this.textBoxDeCedula.Name = "textBoxDeCedula";
            this.textBoxDeCedula.Size = new System.Drawing.Size(255, 26);
            this.textBoxDeCedula.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(64, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "CONTRASEÑA";
            // 
            // textBoxDeContrasena
            // 
            this.textBoxDeContrasena.Font = new System.Drawing.Font("Arial", 12F);
            this.textBoxDeContrasena.Location = new System.Drawing.Point(264, 97);
            this.textBoxDeContrasena.Name = "textBoxDeContrasena";
            this.textBoxDeContrasena.PasswordChar = '*';
            this.textBoxDeContrasena.Size = new System.Drawing.Size(255, 26);
            this.textBoxDeContrasena.TabIndex = 22;
            // 
            // botonDeVolver
            // 
            this.botonDeVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeVolver.Font = new System.Drawing.Font("Arial", 12F);
            this.botonDeVolver.ForeColor = System.Drawing.Color.White;
            this.botonDeVolver.Location = new System.Drawing.Point(67, 209);
            this.botonDeVolver.Name = "botonDeVolver";
            this.botonDeVolver.Size = new System.Drawing.Size(176, 41);
            this.botonDeVolver.TabIndex = 23;
            this.botonDeVolver.Text = "VOLVER";
            this.botonDeVolver.UseVisualStyleBackColor = false;
            this.botonDeVolver.Click += new System.EventHandler(this.botonDeVolver_Click);
            // 
            // botonDeIniciarSesion
            // 
            this.botonDeIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeIniciarSesion.Font = new System.Drawing.Font("Arial", 12F);
            this.botonDeIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.botonDeIniciarSesion.Location = new System.Drawing.Point(343, 209);
            this.botonDeIniciarSesion.Name = "botonDeIniciarSesion";
            this.botonDeIniciarSesion.Size = new System.Drawing.Size(176, 41);
            this.botonDeIniciarSesion.TabIndex = 24;
            this.botonDeIniciarSesion.Text = "INICIAR SESIÓN";
            this.botonDeIniciarSesion.UseVisualStyleBackColor = false;
            this.botonDeIniciarSesion.Click += new System.EventHandler(this.botonDeIniciarSesion_Click);
            // 
            // linkLabelDeRecuperarPW
            // 
            this.linkLabelDeRecuperarPW.AutoSize = true;
            this.linkLabelDeRecuperarPW.Font = new System.Drawing.Font("Arial", 8F);
            this.linkLabelDeRecuperarPW.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.linkLabelDeRecuperarPW.Location = new System.Drawing.Point(487, 149);
            this.linkLabelDeRecuperarPW.Name = "linkLabelDeRecuperarPW";
            this.linkLabelDeRecuperarPW.Size = new System.Drawing.Size(32, 14);
            this.linkLabelDeRecuperarPW.TabIndex = 25;
            this.linkLabelDeRecuperarPW.TabStop = true;
            this.linkLabelDeRecuperarPW.Text = "AQUÍ";
            this.linkLabelDeRecuperarPW.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDeRecuperarPW_LinkClicked);
            // 
            // labelDeRecuperarContrasenna
            // 
            this.labelDeRecuperarContrasenna.AutoSize = true;
            this.labelDeRecuperarContrasenna.Font = new System.Drawing.Font("Arial", 8F);
            this.labelDeRecuperarContrasenna.Location = new System.Drawing.Point(261, 149);
            this.labelDeRecuperarContrasenna.Name = "labelDeRecuperarContrasenna";
            this.labelDeRecuperarContrasenna.Size = new System.Drawing.Size(220, 14);
            this.labelDeRecuperarContrasenna.TabIndex = 26;
            this.labelDeRecuperarContrasenna.Text = "*SI OLVIDÓ SU CONTRASEÑA, HAGA CLICK";
            // 
            // EmpleadoInicioDeSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(602, 281);
            this.Controls.Add(this.labelDeRecuperarContrasenna);
            this.Controls.Add(this.linkLabelDeRecuperarPW);
            this.Controls.Add(this.botonDeIniciarSesion);
            this.Controls.Add(this.botonDeVolver);
            this.Controls.Add(this.textBoxDeContrasena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDeCedula);
            this.Controls.Add(this.labelDeCedula);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EmpleadoInicioDeSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleado inicio de sesión";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmpleadoInicioDeSesion_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDeCedula;
        private System.Windows.Forms.TextBox textBoxDeCedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDeContrasena;
        private System.Windows.Forms.Button botonDeVolver;
        private System.Windows.Forms.Button botonDeIniciarSesion;
        private System.Windows.Forms.LinkLabel linkLabelDeRecuperarPW;
        private System.Windows.Forms.Label labelDeRecuperarContrasenna;
    }
}