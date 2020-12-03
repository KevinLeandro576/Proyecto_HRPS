namespace Proyecto_HRPS
{
    partial class Reportes
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
            this.sal_emp = new System.Windows.Forms.LinkLabel();
            this.reportes_diarios = new System.Windows.Forms.LinkLabel();
            this.vacaciones = new System.Windows.Forms.LinkLabel();
            this.link_Volver = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // sal_emp
            // 
            this.sal_emp.AutoSize = true;
            this.sal_emp.Font = new System.Drawing.Font("Arial", 8.25F);
            this.sal_emp.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.sal_emp.Location = new System.Drawing.Point(41, 38);
            this.sal_emp.Name = "sal_emp";
            this.sal_emp.Size = new System.Drawing.Size(165, 14);
            this.sal_emp.TabIndex = 0;
            this.sal_emp.TabStop = true;
            this.sal_emp.Text = "VER SALARIOS DE EMPLEADOS";
            // 
            // reportes_diarios
            // 
            this.reportes_diarios.AutoSize = true;
            this.reportes_diarios.Font = new System.Drawing.Font("Arial", 8.25F);
            this.reportes_diarios.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.reportes_diarios.Location = new System.Drawing.Point(244, 38);
            this.reportes_diarios.Name = "reportes_diarios";
            this.reportes_diarios.Size = new System.Drawing.Size(128, 14);
            this.reportes_diarios.TabIndex = 1;
            this.reportes_diarios.TabStop = true;
            this.reportes_diarios.Text = "VER REPORTES DIARIOS";
            // 
            // vacaciones
            // 
            this.vacaciones.AutoSize = true;
            this.vacaciones.Font = new System.Drawing.Font("Arial", 8.25F);
            this.vacaciones.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.vacaciones.Location = new System.Drawing.Point(418, 38);
            this.vacaciones.Name = "vacaciones";
            this.vacaciones.Size = new System.Drawing.Size(203, 14);
            this.vacaciones.TabIndex = 2;
            this.vacaciones.TabStop = true;
            this.vacaciones.Text = "VER VACACIONES DE LOS EMPLEADOS";
            // 
            // link_Volver
            // 
            this.link_Volver.AutoSize = true;
            this.link_Volver.Font = new System.Drawing.Font("Arial", 8.25F);
            this.link_Volver.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.link_Volver.Location = new System.Drawing.Point(662, 38);
            this.link_Volver.Name = "link_Volver";
            this.link_Volver.Size = new System.Drawing.Size(49, 14);
            this.link_Volver.TabIndex = 3;
            this.link_Volver.TabStop = true;
            this.link_Volver.Text = "VOLVER";
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 281);
            this.Controls.Add(this.link_Volver);
            this.Controls.Add(this.vacaciones);
            this.Controls.Add(this.reportes_diarios);
            this.Controls.Add(this.sal_emp);
            this.Name = "Reportes";
            this.Text = "Menú de reportes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel sal_emp;
        private System.Windows.Forms.LinkLabel reportes_diarios;
        private System.Windows.Forms.LinkLabel vacaciones;
        private System.Windows.Forms.LinkLabel link_Volver;
    }
}