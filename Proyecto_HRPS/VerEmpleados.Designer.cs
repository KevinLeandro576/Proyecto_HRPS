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
            this.botonDeVolver = new System.Windows.Forms.Button();
            this.botonDeVerEmpleadosInactivos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonDeVolver
            // 
            this.botonDeVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeVolver.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeVolver.ForeColor = System.Drawing.Color.White;
            this.botonDeVolver.Location = new System.Drawing.Point(44, 56);
            this.botonDeVolver.Name = "botonDeVolver";
            this.botonDeVolver.Size = new System.Drawing.Size(122, 50);
            this.botonDeVolver.TabIndex = 3;
            this.botonDeVolver.Text = "VOLVER";
            this.botonDeVolver.UseVisualStyleBackColor = false;
            // 
            // botonDeVerEmpleadosInactivos
            // 
            this.botonDeVerEmpleadosInactivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeVerEmpleadosInactivos.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeVerEmpleadosInactivos.ForeColor = System.Drawing.Color.White;
            this.botonDeVerEmpleadosInactivos.Location = new System.Drawing.Point(200, 56);
            this.botonDeVerEmpleadosInactivos.Name = "botonDeVerEmpleadosInactivos";
            this.botonDeVerEmpleadosInactivos.Size = new System.Drawing.Size(122, 50);
            this.botonDeVerEmpleadosInactivos.TabIndex = 4;
            this.botonDeVerEmpleadosInactivos.Text = "VER EMPLEADOS INACTIVOS";
            this.botonDeVerEmpleadosInactivos.UseVisualStyleBackColor = false;
            this.botonDeVerEmpleadosInactivos.Click += new System.EventHandler(this.botonDeVerEmpleadosInactivos_Click);
            // 
            // VerEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(370, 169);
            this.Controls.Add(this.botonDeVerEmpleadosInactivos);
            this.Controls.Add(this.botonDeVolver);
            this.Font = new System.Drawing.Font("Volta Modern Display 55 Rom", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VerEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver empleados";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonDeVolver;
        private System.Windows.Forms.Button botonDeVerEmpleadosInactivos;
    }
}