
namespace Proyecto_HRPS
{
    partial class MenuInicial02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuInicial02));
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
            this.botonDeAdministrador.TabIndex = 1;
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
            this.botonDeEmpleado.TabIndex = 2;
            this.botonDeEmpleado.Text = "EMPLEADO";
            this.botonDeEmpleado.UseVisualStyleBackColor = false;
            this.botonDeEmpleado.Click += new System.EventHandler(this.button2_Click);
            // 
            // MenuInicial02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(498, 170);
            this.Controls.Add(this.botonDeEmpleado);
            this.Controls.Add(this.botonDeAdministrador);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuInicial02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú inicial";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuInicial02_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonDeAdministrador;
        private System.Windows.Forms.Button botonDeEmpleado;
    }
}