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
            this.enlaceDeCrearPerfilDeUsuario = new System.Windows.Forms.LinkLabel();
            this.enlaceDeVerHorarios = new System.Windows.Forms.LinkLabel();
            this.enlaceDeVolver = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // enlaceDeCrearPerfilDeUsuario
            // 
            this.enlaceDeCrearPerfilDeUsuario.AutoSize = true;
            this.enlaceDeCrearPerfilDeUsuario.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enlaceDeCrearPerfilDeUsuario.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.enlaceDeCrearPerfilDeUsuario.Location = new System.Drawing.Point(53, 31);
            this.enlaceDeCrearPerfilDeUsuario.Name = "enlaceDeCrearPerfilDeUsuario";
            this.enlaceDeCrearPerfilDeUsuario.Size = new System.Drawing.Size(105, 14);
            this.enlaceDeCrearPerfilDeUsuario.TabIndex = 2;
            this.enlaceDeCrearPerfilDeUsuario.TabStop = true;
            this.enlaceDeCrearPerfilDeUsuario.Text = "VER HORAS EXTRA";
            // 
            // enlaceDeVerHorarios
            // 
            this.enlaceDeVerHorarios.AutoSize = true;
            this.enlaceDeVerHorarios.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enlaceDeVerHorarios.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.enlaceDeVerHorarios.Location = new System.Drawing.Point(350, 31);
            this.enlaceDeVerHorarios.Name = "enlaceDeVerHorarios";
            this.enlaceDeVerHorarios.Size = new System.Drawing.Size(85, 14);
            this.enlaceDeVerHorarios.TabIndex = 3;
            this.enlaceDeVerHorarios.TabStop = true;
            this.enlaceDeVerHorarios.Text = "VER HORARIOS";
            // 
            // enlaceDeVolver
            // 
            this.enlaceDeVolver.AutoSize = true;
            this.enlaceDeVolver.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enlaceDeVolver.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.enlaceDeVolver.Location = new System.Drawing.Point(689, 31);
            this.enlaceDeVolver.Name = "enlaceDeVolver";
            this.enlaceDeVolver.Size = new System.Drawing.Size(49, 14);
            this.enlaceDeVolver.TabIndex = 8;
            this.enlaceDeVolver.TabStop = true;
            this.enlaceDeVolver.Text = "VOLVER";
            // 
            // ControlDeEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(788, 330);
            this.Controls.Add(this.enlaceDeVolver);
            this.Controls.Add(this.enlaceDeVerHorarios);
            this.Controls.Add(this.enlaceDeCrearPerfilDeUsuario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ControlDeEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de empleados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel enlaceDeCrearPerfilDeUsuario;
        private System.Windows.Forms.LinkLabel enlaceDeVerHorarios;
        private System.Windows.Forms.LinkLabel enlaceDeVolver;
    }
}