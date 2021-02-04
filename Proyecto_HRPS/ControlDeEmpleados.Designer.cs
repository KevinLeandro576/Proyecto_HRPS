namespace Proyecto_HRPS
{
    partial class ControlDeEmpleados
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
            this.botonDeVerHorasExtra = new System.Windows.Forms.Button();
            this.botonDeVerHorarios = new System.Windows.Forms.Button();
            this.botonDeVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonDeVerHorasExtra
            // 
            this.botonDeVerHorasExtra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeVerHorasExtra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeVerHorasExtra.ForeColor = System.Drawing.Color.White;
            this.botonDeVerHorasExtra.Location = new System.Drawing.Point(91, 50);
            this.botonDeVerHorasExtra.Margin = new System.Windows.Forms.Padding(4);
            this.botonDeVerHorasExtra.Name = "botonDeVerHorasExtra";
            this.botonDeVerHorasExtra.Size = new System.Drawing.Size(324, 41);
            this.botonDeVerHorasExtra.TabIndex = 9;
            this.botonDeVerHorasExtra.Text = "HORAS EXTRA";
            this.botonDeVerHorasExtra.UseVisualStyleBackColor = false;
            this.botonDeVerHorasExtra.Click += new System.EventHandler(this.botonDeVerHorasExtra_Click);
            // 
            // botonDeVerHorarios
            // 
            this.botonDeVerHorarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeVerHorarios.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeVerHorarios.ForeColor = System.Drawing.Color.White;
            this.botonDeVerHorarios.Location = new System.Drawing.Point(91, 122);
            this.botonDeVerHorarios.Margin = new System.Windows.Forms.Padding(4);
            this.botonDeVerHorarios.Name = "botonDeVerHorarios";
            this.botonDeVerHorarios.Size = new System.Drawing.Size(324, 41);
            this.botonDeVerHorarios.TabIndex = 10;
            this.botonDeVerHorarios.Text = "VER HORARIOS";
            this.botonDeVerHorarios.UseVisualStyleBackColor = false;
            this.botonDeVerHorarios.Click += new System.EventHandler(this.botonDeVerHorarios_Click);
            // 
            // botonDeVolver
            // 
            this.botonDeVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeVolver.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeVolver.ForeColor = System.Drawing.Color.White;
            this.botonDeVolver.Location = new System.Drawing.Point(91, 198);
            this.botonDeVolver.Margin = new System.Windows.Forms.Padding(4);
            this.botonDeVolver.Name = "botonDeVolver";
            this.botonDeVolver.Size = new System.Drawing.Size(324, 41);
            this.botonDeVolver.TabIndex = 11;
            this.botonDeVolver.Text = "VOLVER";
            this.botonDeVolver.UseVisualStyleBackColor = false;
            this.botonDeVolver.Click += new System.EventHandler(this.botonDeVolver_Click);
            // 
            // ControlDeEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(519, 289);
            this.Controls.Add(this.botonDeVolver);
            this.Controls.Add(this.botonDeVerHorarios);
            this.Controls.Add(this.botonDeVerHorasExtra);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ControlDeEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de empleados";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button botonDeVerHorasExtra;
        private System.Windows.Forms.Button botonDeVerHorarios;
        private System.Windows.Forms.Button botonDeVolver;
    }
}