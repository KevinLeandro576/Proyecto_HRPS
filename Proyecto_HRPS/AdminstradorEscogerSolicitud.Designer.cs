
namespace Proyecto_HRPS
{
    partial class AdminstradorEscogerSolicitud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminstradorEscogerSolicitud));
            this.botonDeVolver = new System.Windows.Forms.Button();
            this.botonDeHorasExtra = new System.Windows.Forms.Button();
            this.botonDeVacaciones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonDeVolver
            // 
            this.botonDeVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeVolver.Font = new System.Drawing.Font("Arial", 12F);
            this.botonDeVolver.ForeColor = System.Drawing.Color.White;
            this.botonDeVolver.Location = new System.Drawing.Point(65, 203);
            this.botonDeVolver.Margin = new System.Windows.Forms.Padding(4);
            this.botonDeVolver.Name = "botonDeVolver";
            this.botonDeVolver.Size = new System.Drawing.Size(324, 41);
            this.botonDeVolver.TabIndex = 5;
            this.botonDeVolver.Text = "VOLVER";
            this.botonDeVolver.UseVisualStyleBackColor = false;
            this.botonDeVolver.Click += new System.EventHandler(this.botonDeVolver_Click);
            // 
            // botonDeHorasExtra
            // 
            this.botonDeHorasExtra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeHorasExtra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeHorasExtra.ForeColor = System.Drawing.Color.White;
            this.botonDeHorasExtra.Location = new System.Drawing.Point(65, 52);
            this.botonDeHorasExtra.Margin = new System.Windows.Forms.Padding(4);
            this.botonDeHorasExtra.Name = "botonDeHorasExtra";
            this.botonDeHorasExtra.Size = new System.Drawing.Size(324, 41);
            this.botonDeHorasExtra.TabIndex = 6;
            this.botonDeHorasExtra.Text = "HORAS EXTRA";
            this.botonDeHorasExtra.UseVisualStyleBackColor = false;
            this.botonDeHorasExtra.Click += new System.EventHandler(this.botonDeHorasExtra_Click);
            // 
            // botonDeVacaciones
            // 
            this.botonDeVacaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeVacaciones.Font = new System.Drawing.Font("Arial", 12F);
            this.botonDeVacaciones.ForeColor = System.Drawing.Color.White;
            this.botonDeVacaciones.Location = new System.Drawing.Point(65, 127);
            this.botonDeVacaciones.Margin = new System.Windows.Forms.Padding(4);
            this.botonDeVacaciones.Name = "botonDeVacaciones";
            this.botonDeVacaciones.Size = new System.Drawing.Size(324, 41);
            this.botonDeVacaciones.TabIndex = 7;
            this.botonDeVacaciones.Text = "VACACIONES";
            this.botonDeVacaciones.UseVisualStyleBackColor = false;
            this.botonDeVacaciones.Click += new System.EventHandler(this.botonDeVacaciones_Click);
            // 
            // AdminstradorEscogerSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(463, 297);
            this.Controls.Add(this.botonDeVacaciones);
            this.Controls.Add(this.botonDeHorasExtra);
            this.Controls.Add(this.botonDeVolver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminstradorEscogerSolicitud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escoger solicitud";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonDeVolver;
        private System.Windows.Forms.Button botonDeHorasExtra;
        private System.Windows.Forms.Button botonDeVacaciones;
    }
}