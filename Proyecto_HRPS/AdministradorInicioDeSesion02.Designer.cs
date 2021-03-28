
namespace Proyecto_HRPS
{
    partial class AdministradorInicioDeSesion02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministradorInicioDeSesion02));
            this.labelDeCedula = new System.Windows.Forms.Label();
            this.labelDeContrasena = new System.Windows.Forms.Label();
            this.textBoxDeCedula = new System.Windows.Forms.TextBox();
            this.textBoxDeContrasena = new System.Windows.Forms.TextBox();
            this.checkBoxDeContrasena = new System.Windows.Forms.CheckBox();
            this.labelDeRecuperarContrasenna = new System.Windows.Forms.Label();
            this.linkLabelDeRecuperarPW = new System.Windows.Forms.LinkLabel();
            this.botonDeIniciarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDeCedula
            // 
            this.labelDeCedula.AutoSize = true;
            this.labelDeCedula.Font = new System.Drawing.Font("Arial", 12F);
            this.labelDeCedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.labelDeCedula.Location = new System.Drawing.Point(65, 44);
            this.labelDeCedula.Name = "labelDeCedula";
            this.labelDeCedula.Size = new System.Drawing.Size(77, 18);
            this.labelDeCedula.TabIndex = 21;
            this.labelDeCedula.Text = "CÉDULA ";
            // 
            // labelDeContrasena
            // 
            this.labelDeContrasena.AutoSize = true;
            this.labelDeContrasena.Font = new System.Drawing.Font("Arial", 12F);
            this.labelDeContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.labelDeContrasena.Location = new System.Drawing.Point(65, 94);
            this.labelDeContrasena.Name = "labelDeContrasena";
            this.labelDeContrasena.Size = new System.Drawing.Size(118, 18);
            this.labelDeContrasena.TabIndex = 23;
            this.labelDeContrasena.Text = "CONTRASEÑA";
            // 
            // textBoxDeCedula
            // 
            this.textBoxDeCedula.Font = new System.Drawing.Font("Arial", 12F);
            this.textBoxDeCedula.Location = new System.Drawing.Point(261, 41);
            this.textBoxDeCedula.Name = "textBoxDeCedula";
            this.textBoxDeCedula.Size = new System.Drawing.Size(255, 26);
            this.textBoxDeCedula.TabIndex = 24;
            // 
            // textBoxDeContrasena
            // 
            this.textBoxDeContrasena.Font = new System.Drawing.Font("Arial", 12F);
            this.textBoxDeContrasena.Location = new System.Drawing.Point(261, 91);
            this.textBoxDeContrasena.Name = "textBoxDeContrasena";
            this.textBoxDeContrasena.PasswordChar = '*';
            this.textBoxDeContrasena.Size = new System.Drawing.Size(255, 26);
            this.textBoxDeContrasena.TabIndex = 25;
            this.textBoxDeContrasena.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxDeContrasena_KeyDown);
            // 
            // checkBoxDeContrasena
            // 
            this.checkBoxDeContrasena.AutoSize = true;
            this.checkBoxDeContrasena.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDeContrasena.Location = new System.Drawing.Point(384, 123);
            this.checkBoxDeContrasena.Name = "checkBoxDeContrasena";
            this.checkBoxDeContrasena.Size = new System.Drawing.Size(132, 22);
            this.checkBoxDeContrasena.TabIndex = 31;
            this.checkBoxDeContrasena.Text = "Ver contraseña";
            this.checkBoxDeContrasena.UseVisualStyleBackColor = true;
            this.checkBoxDeContrasena.CheckedChanged += new System.EventHandler(this.checkBoxDeContrasena_CheckedChanged);
            // 
            // labelDeRecuperarContrasenna
            // 
            this.labelDeRecuperarContrasenna.AutoSize = true;
            this.labelDeRecuperarContrasenna.Font = new System.Drawing.Font("Arial", 8F);
            this.labelDeRecuperarContrasenna.Location = new System.Drawing.Point(258, 157);
            this.labelDeRecuperarContrasenna.Name = "labelDeRecuperarContrasenna";
            this.labelDeRecuperarContrasenna.Size = new System.Drawing.Size(220, 14);
            this.labelDeRecuperarContrasenna.TabIndex = 32;
            this.labelDeRecuperarContrasenna.Text = "*SI OLVIDÓ SU CONTRASEÑA, HAGA CLICK";
            // 
            // linkLabelDeRecuperarPW
            // 
            this.linkLabelDeRecuperarPW.AutoSize = true;
            this.linkLabelDeRecuperarPW.Font = new System.Drawing.Font("Arial", 8F);
            this.linkLabelDeRecuperarPW.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.linkLabelDeRecuperarPW.Location = new System.Drawing.Point(484, 157);
            this.linkLabelDeRecuperarPW.Name = "linkLabelDeRecuperarPW";
            this.linkLabelDeRecuperarPW.Size = new System.Drawing.Size(32, 14);
            this.linkLabelDeRecuperarPW.TabIndex = 33;
            this.linkLabelDeRecuperarPW.TabStop = true;
            this.linkLabelDeRecuperarPW.Text = "AQUÍ";
            this.linkLabelDeRecuperarPW.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDeRecuperarPW_LinkClicked);
            // 
            // botonDeIniciarSesion
            // 
            this.botonDeIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeIniciarSesion.Font = new System.Drawing.Font("Arial", 12F);
            this.botonDeIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.botonDeIniciarSesion.Location = new System.Drawing.Point(68, 199);
            this.botonDeIniciarSesion.Name = "botonDeIniciarSesion";
            this.botonDeIniciarSesion.Size = new System.Drawing.Size(448, 41);
            this.botonDeIniciarSesion.TabIndex = 34;
            this.botonDeIniciarSesion.Text = "INICIAR SESIÓN";
            this.botonDeIniciarSesion.UseVisualStyleBackColor = false;
            this.botonDeIniciarSesion.Click += new System.EventHandler(this.botonDeIniciarSesion_Click);
            // 
            // AdministradorInicioDeSesion02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(602, 281);
            this.Controls.Add(this.botonDeIniciarSesion);
            this.Controls.Add(this.linkLabelDeRecuperarPW);
            this.Controls.Add(this.labelDeRecuperarContrasenna);
            this.Controls.Add(this.checkBoxDeContrasena);
            this.Controls.Add(this.textBoxDeContrasena);
            this.Controls.Add(this.textBoxDeCedula);
            this.Controls.Add(this.labelDeContrasena);
            this.Controls.Add(this.labelDeCedula);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdministradorInicioDeSesion02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesión";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdministradorInicioDeSesion02_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDeCedula;
        private System.Windows.Forms.Label labelDeContrasena;
        private System.Windows.Forms.TextBox textBoxDeCedula;
        private System.Windows.Forms.TextBox textBoxDeContrasena;
        private System.Windows.Forms.CheckBox checkBoxDeContrasena;
        private System.Windows.Forms.Label labelDeRecuperarContrasenna;
        private System.Windows.Forms.LinkLabel linkLabelDeRecuperarPW;
        private System.Windows.Forms.Button botonDeIniciarSesion;
    }
}