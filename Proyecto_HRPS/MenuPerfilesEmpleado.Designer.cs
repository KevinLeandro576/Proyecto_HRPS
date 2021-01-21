namespace Proyecto_HRPS
{
    partial class MenuPerfilesEmpleado
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
            this.enlaceDeVolver = new System.Windows.Forms.LinkLabel();
            this.enlaceDeVerSalario = new System.Windows.Forms.LinkLabel();
            this.enlaceDeVerPerfil = new System.Windows.Forms.LinkLabel();
            this.enlaceDeVerHorario = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // enlaceDeVolver
            // 
            this.enlaceDeVolver.AutoSize = true;
            this.enlaceDeVolver.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enlaceDeVolver.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.enlaceDeVolver.Location = new System.Drawing.Point(657, 42);
            this.enlaceDeVolver.Name = "enlaceDeVolver";
            this.enlaceDeVolver.Size = new System.Drawing.Size(49, 14);
            this.enlaceDeVolver.TabIndex = 10;
            this.enlaceDeVolver.TabStop = true;
            this.enlaceDeVolver.Text = "VOLVER";
            this.enlaceDeVolver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.enlaceDeVolver_LinkClicked);
            // 
            // enlaceDeVerSalario
            // 
            this.enlaceDeVerSalario.AutoSize = true;
            this.enlaceDeVerSalario.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enlaceDeVerSalario.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.enlaceDeVerSalario.Location = new System.Drawing.Point(464, 42);
            this.enlaceDeVerSalario.Name = "enlaceDeVerSalario";
            this.enlaceDeVerSalario.Size = new System.Drawing.Size(77, 14);
            this.enlaceDeVerSalario.TabIndex = 11;
            this.enlaceDeVerSalario.TabStop = true;
            this.enlaceDeVerSalario.Text = "VER SALARIO";
            this.enlaceDeVerSalario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.enlaceDeVerSalario_LinkClicked);
            // 
            // enlaceDeVerPerfil
            // 
            this.enlaceDeVerPerfil.AutoSize = true;
            this.enlaceDeVerPerfil.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enlaceDeVerPerfil.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.enlaceDeVerPerfil.Location = new System.Drawing.Point(256, 42);
            this.enlaceDeVerPerfil.Name = "enlaceDeVerPerfil";
            this.enlaceDeVerPerfil.Size = new System.Drawing.Size(64, 14);
            this.enlaceDeVerPerfil.TabIndex = 12;
            this.enlaceDeVerPerfil.TabStop = true;
            this.enlaceDeVerPerfil.Text = "VER PERFIL";
            this.enlaceDeVerPerfil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.enlaceDeVerPerfil_LinkClicked);
            // 
            // enlaceDeVerHorario
            // 
            this.enlaceDeVerHorario.AutoSize = true;
            this.enlaceDeVerHorario.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enlaceDeVerHorario.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.enlaceDeVerHorario.Location = new System.Drawing.Point(73, 42);
            this.enlaceDeVerHorario.Name = "enlaceDeVerHorario";
            this.enlaceDeVerHorario.Size = new System.Drawing.Size(78, 14);
            this.enlaceDeVerHorario.TabIndex = 13;
            this.enlaceDeVerHorario.TabStop = true;
            this.enlaceDeVerHorario.Text = "VER HORARIO";
            this.enlaceDeVerHorario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.enlaceDeVerHorario_LinkClicked);
            // 
            // MenuPerfilesEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 374);
            this.Controls.Add(this.enlaceDeVerHorario);
            this.Controls.Add(this.enlaceDeVerPerfil);
            this.Controls.Add(this.enlaceDeVerSalario);
            this.Controls.Add(this.enlaceDeVolver);
            this.Name = "MenuPerfilesEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú de perfil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel enlaceDeVolver;
        private System.Windows.Forms.LinkLabel enlaceDeVerSalario;
        private System.Windows.Forms.LinkLabel enlaceDeVerPerfil;
        private System.Windows.Forms.LinkLabel enlaceDeVerHorario;
    }
}