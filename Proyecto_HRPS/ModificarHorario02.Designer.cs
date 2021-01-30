namespace Proyecto_HRPS
{
    partial class ModificarHorario02
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
            this.labelDeHorarioActual = new System.Windows.Forms.Label();
            this.labelDeHorarioNuevo = new System.Windows.Forms.Label();
            this.textBoxDeHorarioNuevo = new System.Windows.Forms.TextBox();
            this.botonDeVolver = new System.Windows.Forms.Button();
            this.botonDeGuardarCambios = new System.Windows.Forms.Button();
            this.labelDeNombre = new System.Windows.Forms.Label();
            this.textBoxDeHorarioActual = new System.Windows.Forms.TextBox();
            this.textBoxDeNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelDeHorarioActual
            // 
            this.labelDeHorarioActual.AutoSize = true;
            this.labelDeHorarioActual.Font = new System.Drawing.Font("Arial", 12F);
            this.labelDeHorarioActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.labelDeHorarioActual.Location = new System.Drawing.Point(49, 118);
            this.labelDeHorarioActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDeHorarioActual.Name = "labelDeHorarioActual";
            this.labelDeHorarioActual.Size = new System.Drawing.Size(145, 18);
            this.labelDeHorarioActual.TabIndex = 6;
            this.labelDeHorarioActual.Text = "HORARIO ACTUAL";
            // 
            // labelDeHorarioNuevo
            // 
            this.labelDeHorarioNuevo.AutoSize = true;
            this.labelDeHorarioNuevo.Font = new System.Drawing.Font("Arial", 12F);
            this.labelDeHorarioNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.labelDeHorarioNuevo.Location = new System.Drawing.Point(49, 170);
            this.labelDeHorarioNuevo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDeHorarioNuevo.Name = "labelDeHorarioNuevo";
            this.labelDeHorarioNuevo.Size = new System.Drawing.Size(139, 18);
            this.labelDeHorarioNuevo.TabIndex = 8;
            this.labelDeHorarioNuevo.Text = "HORARIO NUEVO";
            this.labelDeHorarioNuevo.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxDeHorarioNuevo
            // 
            this.textBoxDeHorarioNuevo.Font = new System.Drawing.Font("Arial", 12F);
            this.textBoxDeHorarioNuevo.Location = new System.Drawing.Point(329, 167);
            this.textBoxDeHorarioNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDeHorarioNuevo.Name = "textBoxDeHorarioNuevo";
            this.textBoxDeHorarioNuevo.Size = new System.Drawing.Size(225, 26);
            this.textBoxDeHorarioNuevo.TabIndex = 9;
            // 
            // botonDeVolver
            // 
            this.botonDeVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeVolver.Font = new System.Drawing.Font("Arial", 12F);
            this.botonDeVolver.ForeColor = System.Drawing.Color.White;
            this.botonDeVolver.Location = new System.Drawing.Point(52, 270);
            this.botonDeVolver.Margin = new System.Windows.Forms.Padding(4);
            this.botonDeVolver.Name = "botonDeVolver";
            this.botonDeVolver.Size = new System.Drawing.Size(226, 66);
            this.botonDeVolver.TabIndex = 10;
            this.botonDeVolver.Text = "VOLVER";
            this.botonDeVolver.UseVisualStyleBackColor = false;
            this.botonDeVolver.Click += new System.EventHandler(this.botonDeVolver_Click);
            // 
            // botonDeGuardarCambios
            // 
            this.botonDeGuardarCambios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeGuardarCambios.Font = new System.Drawing.Font("Arial", 12F);
            this.botonDeGuardarCambios.ForeColor = System.Drawing.Color.White;
            this.botonDeGuardarCambios.Location = new System.Drawing.Point(328, 270);
            this.botonDeGuardarCambios.Margin = new System.Windows.Forms.Padding(4);
            this.botonDeGuardarCambios.Name = "botonDeGuardarCambios";
            this.botonDeGuardarCambios.Size = new System.Drawing.Size(226, 66);
            this.botonDeGuardarCambios.TabIndex = 11;
            this.botonDeGuardarCambios.Text = "GUARDAR CAMBIOS";
            this.botonDeGuardarCambios.UseVisualStyleBackColor = false;
            this.botonDeGuardarCambios.Click += new System.EventHandler(this.botonDeGuardarCambios_Click);
            // 
            // labelDeNombre
            // 
            this.labelDeNombre.AutoSize = true;
            this.labelDeNombre.Font = new System.Drawing.Font("Arial", 12F);
            this.labelDeNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.labelDeNombre.Location = new System.Drawing.Point(49, 69);
            this.labelDeNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDeNombre.Name = "labelDeNombre";
            this.labelDeNombre.Size = new System.Drawing.Size(198, 18);
            this.labelDeNombre.TabIndex = 12;
            this.labelDeNombre.Text = "NOMBRE DE EMPLEADO";
            // 
            // textBoxDeHorarioActual
            // 
            this.textBoxDeHorarioActual.Enabled = false;
            this.textBoxDeHorarioActual.Font = new System.Drawing.Font("Arial", 12F);
            this.textBoxDeHorarioActual.Location = new System.Drawing.Point(329, 115);
            this.textBoxDeHorarioActual.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDeHorarioActual.Name = "textBoxDeHorarioActual";
            this.textBoxDeHorarioActual.Size = new System.Drawing.Size(225, 26);
            this.textBoxDeHorarioActual.TabIndex = 13;
            // 
            // textBoxDeNombre
            // 
            this.textBoxDeNombre.Enabled = false;
            this.textBoxDeNombre.Font = new System.Drawing.Font("Arial", 12F);
            this.textBoxDeNombre.Location = new System.Drawing.Point(329, 66);
            this.textBoxDeNombre.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDeNombre.Name = "textBoxDeNombre";
            this.textBoxDeNombre.Size = new System.Drawing.Size(225, 26);
            this.textBoxDeNombre.TabIndex = 14;
            // 
            // ModificarHorario02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(624, 411);
            this.Controls.Add(this.textBoxDeNombre);
            this.Controls.Add(this.textBoxDeHorarioActual);
            this.Controls.Add(this.labelDeNombre);
            this.Controls.Add(this.botonDeGuardarCambios);
            this.Controls.Add(this.botonDeVolver);
            this.Controls.Add(this.textBoxDeHorarioNuevo);
            this.Controls.Add(this.labelDeHorarioNuevo);
            this.Controls.Add(this.labelDeHorarioActual);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ModificarHorario02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar horario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModificarHorario02_FormClosing);
            this.Load += new System.EventHandler(this.ModificarHorario02_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDeHorarioActual;
        private System.Windows.Forms.Label labelDeHorarioNuevo;
        private System.Windows.Forms.TextBox textBoxDeHorarioNuevo;
        private System.Windows.Forms.Button botonDeVolver;
        private System.Windows.Forms.Button botonDeGuardarCambios;
        private System.Windows.Forms.Label labelDeNombre;
        private System.Windows.Forms.TextBox textBoxDeHorarioActual;
        private System.Windows.Forms.TextBox textBoxDeNombre;
    }
}