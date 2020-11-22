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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
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
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.linkLabel1.Location = new System.Drawing.Point(350, 31);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(85, 14);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "VER HORARIOS";
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.Controls.Add(this.enlaceDeVolver);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.enlaceDeCrearPerfilDeUsuario);
            this.Font = new System.Drawing.Font("Volta Modern Display 55 Rom", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ControlDeEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de empleados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel enlaceDeCrearPerfilDeUsuario;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel enlaceDeVolver;
    }
}