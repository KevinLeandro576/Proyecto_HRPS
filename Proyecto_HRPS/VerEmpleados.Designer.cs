namespace Proyecto_HRPS
{
    partial class VerEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerEmpleados));
            this.botonDeVolver = new System.Windows.Forms.Button();
            this.botonDeVerEmpleadosInactivos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonDeVolver
            // 
            this.botonDeVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeVolver.Font = new System.Drawing.Font("Arial", 12F);
            this.botonDeVolver.ForeColor = System.Drawing.Color.White;
            this.botonDeVolver.Location = new System.Drawing.Point(32, 90);
            this.botonDeVolver.Name = "botonDeVolver";
            this.botonDeVolver.Size = new System.Drawing.Size(348, 41);
            this.botonDeVolver.TabIndex = 3;
            this.botonDeVolver.Text = "VOLVER";
            this.botonDeVolver.UseVisualStyleBackColor = false;
            this.botonDeVolver.Click += new System.EventHandler(this.botonDeVolver_Click);
            // 
            // botonDeVerEmpleadosInactivos
            // 
            this.botonDeVerEmpleadosInactivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeVerEmpleadosInactivos.Font = new System.Drawing.Font("Arial", 12F);
            this.botonDeVerEmpleadosInactivos.ForeColor = System.Drawing.Color.White;
            this.botonDeVerEmpleadosInactivos.Location = new System.Drawing.Point(32, 43);
            this.botonDeVerEmpleadosInactivos.Name = "botonDeVerEmpleadosInactivos";
            this.botonDeVerEmpleadosInactivos.Size = new System.Drawing.Size(348, 41);
            this.botonDeVerEmpleadosInactivos.TabIndex = 4;
            this.botonDeVerEmpleadosInactivos.Text = "VER EMPLEADOS INACTIVOS";
            this.botonDeVerEmpleadosInactivos.UseVisualStyleBackColor = false;
            this.botonDeVerEmpleadosInactivos.Click += new System.EventHandler(this.botonDeVerEmpleadosInactivos_Click);
            // 
            // VerEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(404, 157);
            this.Controls.Add(this.botonDeVerEmpleadosInactivos);
            this.Controls.Add(this.botonDeVolver);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VerEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver empleados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VerEmpleados_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonDeVolver;
        private System.Windows.Forms.Button botonDeVerEmpleadosInactivos;
    }
}