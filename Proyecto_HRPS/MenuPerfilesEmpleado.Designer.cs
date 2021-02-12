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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPerfilesEmpleado));
            this.botonDeVolver = new System.Windows.Forms.Button();
            this.botonDeVerHorario = new System.Windows.Forms.Button();
            this.botonDeVerPerfil = new System.Windows.Forms.Button();
            this.botonDeVerSalario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonDeVolver
            // 
            this.botonDeVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeVolver.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeVolver.ForeColor = System.Drawing.Color.White;
            this.botonDeVolver.Location = new System.Drawing.Point(60, 181);
            this.botonDeVolver.Margin = new System.Windows.Forms.Padding(4);
            this.botonDeVolver.Name = "botonDeVolver";
            this.botonDeVolver.Size = new System.Drawing.Size(325, 41);
            this.botonDeVolver.TabIndex = 19;
            this.botonDeVolver.Text = "VOLVER";
            this.botonDeVolver.UseVisualStyleBackColor = false;
            this.botonDeVolver.Click += new System.EventHandler(this.botonDeVolver_Click);
            // 
            // botonDeVerHorario
            // 
            this.botonDeVerHorario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeVerHorario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeVerHorario.ForeColor = System.Drawing.Color.White;
            this.botonDeVerHorario.Location = new System.Drawing.Point(60, 34);
            this.botonDeVerHorario.Margin = new System.Windows.Forms.Padding(4);
            this.botonDeVerHorario.Name = "botonDeVerHorario";
            this.botonDeVerHorario.Size = new System.Drawing.Size(325, 41);
            this.botonDeVerHorario.TabIndex = 20;
            this.botonDeVerHorario.Text = "VER HORARIO";
            this.botonDeVerHorario.UseVisualStyleBackColor = false;
            this.botonDeVerHorario.Click += new System.EventHandler(this.botonDeVerHorario_Click);
            // 
            // botonDeVerPerfil
            // 
            this.botonDeVerPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeVerPerfil.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeVerPerfil.ForeColor = System.Drawing.Color.White;
            this.botonDeVerPerfil.Location = new System.Drawing.Point(60, 83);
            this.botonDeVerPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.botonDeVerPerfil.Name = "botonDeVerPerfil";
            this.botonDeVerPerfil.Size = new System.Drawing.Size(325, 41);
            this.botonDeVerPerfil.TabIndex = 21;
            this.botonDeVerPerfil.Text = "VER PERFIL";
            this.botonDeVerPerfil.UseVisualStyleBackColor = false;
            this.botonDeVerPerfil.Click += new System.EventHandler(this.botonDeVerPerfil_Click);
            // 
            // botonDeVerSalario
            // 
            this.botonDeVerSalario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeVerSalario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeVerSalario.ForeColor = System.Drawing.Color.White;
            this.botonDeVerSalario.Location = new System.Drawing.Point(60, 132);
            this.botonDeVerSalario.Margin = new System.Windows.Forms.Padding(4);
            this.botonDeVerSalario.Name = "botonDeVerSalario";
            this.botonDeVerSalario.Size = new System.Drawing.Size(325, 41);
            this.botonDeVerSalario.TabIndex = 22;
            this.botonDeVerSalario.Text = "VER SALARIO";
            this.botonDeVerSalario.UseVisualStyleBackColor = false;
            this.botonDeVerSalario.Click += new System.EventHandler(this.botonDeVerSalario_Click);
            // 
            // MenuPerfilesEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(454, 252);
            this.Controls.Add(this.botonDeVerSalario);
            this.Controls.Add(this.botonDeVerPerfil);
            this.Controls.Add(this.botonDeVerHorario);
            this.Controls.Add(this.botonDeVolver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPerfilesEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú de perfil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPerfilesEmpleado_FormClosing);
            this.Load += new System.EventHandler(this.MenuPerfilesEmpleado_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button botonDeVolver;
        private System.Windows.Forms.Button botonDeVerHorario;
        private System.Windows.Forms.Button botonDeVerPerfil;
        private System.Windows.Forms.Button botonDeVerSalario;
    }
}