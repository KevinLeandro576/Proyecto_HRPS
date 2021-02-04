namespace Proyecto_HRPS
{
    partial class MenuInicial
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.botonDeAdministrador = new System.Windows.Forms.Button();
            this.botonDeEmpleado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonDeAdministrador
            // 
            this.botonDeAdministrador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeAdministrador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeAdministrador.ForeColor = System.Drawing.Color.White;
            this.botonDeAdministrador.Location = new System.Drawing.Point(52, 46);
            this.botonDeAdministrador.Name = "botonDeAdministrador";
            this.botonDeAdministrador.Size = new System.Drawing.Size(400, 41);
            this.botonDeAdministrador.TabIndex = 0;
            this.botonDeAdministrador.Text = "ADMINISTRADOR";
            this.botonDeAdministrador.UseVisualStyleBackColor = false;
            this.botonDeAdministrador.Click += new System.EventHandler(this.botonDeAdministrador_Click);
            // 
            // botonDeEmpleado
            // 
            this.botonDeEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeEmpleado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeEmpleado.ForeColor = System.Drawing.Color.White;
            this.botonDeEmpleado.Location = new System.Drawing.Point(52, 93);
            this.botonDeEmpleado.Name = "botonDeEmpleado";
            this.botonDeEmpleado.Size = new System.Drawing.Size(400, 41);
            this.botonDeEmpleado.TabIndex = 1;
            this.botonDeEmpleado.Text = "EMPLEADO";
            this.botonDeEmpleado.UseVisualStyleBackColor = false;
            this.botonDeEmpleado.Click += new System.EventHandler(this.button2_Click);
            // 
            // MenuInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(498, 170);
            this.Controls.Add(this.botonDeEmpleado);
            this.Controls.Add(this.botonDeAdministrador);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MenuInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú inicial";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuInicial_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonDeAdministrador;
        private System.Windows.Forms.Button botonDeEmpleado;
    }
}

