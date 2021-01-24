namespace Proyecto_HRPS
{
    partial class ModificarSalario02
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
            this.labelDeSalarioNuevo = new System.Windows.Forms.Label();
            this.textBoxDeSalarioNuevo = new System.Windows.Forms.TextBox();
            this.botonDeVolver = new System.Windows.Forms.Button();
            this.botonDeGuardarCambios = new System.Windows.Forms.Button();
            this.labelDeSalarioActual = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDeSalarioNuevo
            // 
            this.labelDeSalarioNuevo.AutoSize = true;
            this.labelDeSalarioNuevo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeSalarioNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.labelDeSalarioNuevo.Location = new System.Drawing.Point(108, 114);
            this.labelDeSalarioNuevo.Name = "labelDeSalarioNuevo";
            this.labelDeSalarioNuevo.Size = new System.Drawing.Size(92, 14);
            this.labelDeSalarioNuevo.TabIndex = 8;
            this.labelDeSalarioNuevo.Text = "SALARIO NUEVO";
            // 
            // textBoxDeSalarioNuevo
            // 
            this.textBoxDeSalarioNuevo.Location = new System.Drawing.Point(248, 107);
            this.textBoxDeSalarioNuevo.Name = "textBoxDeSalarioNuevo";
            this.textBoxDeSalarioNuevo.Size = new System.Drawing.Size(176, 20);
            this.textBoxDeSalarioNuevo.TabIndex = 10;
            // 
            // botonDeVolver
            // 
            this.botonDeVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeVolver.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeVolver.ForeColor = System.Drawing.Color.White;
            this.botonDeVolver.Location = new System.Drawing.Point(41, 191);
            this.botonDeVolver.Name = "botonDeVolver";
            this.botonDeVolver.Size = new System.Drawing.Size(176, 48);
            this.botonDeVolver.TabIndex = 11;
            this.botonDeVolver.Text = "VOLVER";
            this.botonDeVolver.UseVisualStyleBackColor = false;
            this.botonDeVolver.Click += new System.EventHandler(this.botonDeVolver_Click);
            // 
            // botonDeGuardarCambios
            // 
            this.botonDeGuardarCambios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeGuardarCambios.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeGuardarCambios.ForeColor = System.Drawing.Color.White;
            this.botonDeGuardarCambios.Location = new System.Drawing.Point(319, 191);
            this.botonDeGuardarCambios.Name = "botonDeGuardarCambios";
            this.botonDeGuardarCambios.Size = new System.Drawing.Size(176, 48);
            this.botonDeGuardarCambios.TabIndex = 12;
            this.botonDeGuardarCambios.Text = "GUARDAR CAMBIOS";
            this.botonDeGuardarCambios.UseVisualStyleBackColor = false;
            this.botonDeGuardarCambios.Click += new System.EventHandler(this.botonDeGuardarCambios_Click);
            // 
            // labelDeSalarioActual
            // 
            this.labelDeSalarioActual.AutoSize = true;
            this.labelDeSalarioActual.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeSalarioActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.labelDeSalarioActual.Location = new System.Drawing.Point(108, 65);
            this.labelDeSalarioActual.Name = "labelDeSalarioActual";
            this.labelDeSalarioActual.Size = new System.Drawing.Size(97, 14);
            this.labelDeSalarioActual.TabIndex = 7;
            this.labelDeSalarioActual.Text = "SALARIO ACTUAL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 13;
            // 
            // ModificarSalario02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(551, 275);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonDeGuardarCambios);
            this.Controls.Add(this.botonDeVolver);
            this.Controls.Add(this.textBoxDeSalarioNuevo);
            this.Controls.Add(this.labelDeSalarioNuevo);
            this.Controls.Add(this.labelDeSalarioActual);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModificarSalario02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar salario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDeSalarioNuevo;
        private System.Windows.Forms.TextBox textBoxDeSalarioNuevo;
        private System.Windows.Forms.Button botonDeVolver;
        private System.Windows.Forms.Button botonDeGuardarCambios;
        private System.Windows.Forms.Label labelDeSalarioActual;
        private System.Windows.Forms.Label label1;
    }
}