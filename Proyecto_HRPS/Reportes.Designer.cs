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
            this.SuspendLayout();
            // 
            // sal_emp
            // 
            this.sal_emp.AutoSize = true;
            this.sal_emp.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.sal_emp.Location = new System.Drawing.Point(41, 38);
            this.sal_emp.Name = "sal_emp";
            this.sal_emp.Size = new System.Drawing.Size(172, 13);
            this.sal_emp.TabIndex = 0;
            this.sal_emp.TabStop = true;
            this.sal_emp.Text = "VER SALARIOS DE EMPLEADOS";
            // 
            // reportes_diarios
            // 
            this.reportes_diarios.AutoSize = true;
            this.reportes_diarios.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.reportes_diarios.Location = new System.Drawing.Point(314, 38);
            this.reportes_diarios.Name = "reportes_diarios";
            this.reportes_diarios.Size = new System.Drawing.Size(138, 13);
            this.reportes_diarios.TabIndex = 1;
            this.reportes_diarios.TabStop = true;
            this.reportes_diarios.Text = "VER REPORTES DIARIOS";
            // 
            // vacaciones
            // 
            this.vacaciones.AutoSize = true;
            this.vacaciones.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.vacaciones.Location = new System.Drawing.Point(538, 38);
            this.vacaciones.Name = "vacaciones";
            this.vacaciones.Size = new System.Drawing.Size(211, 13);
            this.vacaciones.TabIndex = 2;
            this.vacaciones.TabStop = true;
            this.vacaciones.Text = "VER VACACIONES DE LOS EMPLEADOS";
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vacaciones);
            this.Controls.Add(this.reportes_diarios);
            this.Controls.Add(this.sal_emp);
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel sal_emp;
        private System.Windows.Forms.LinkLabel reportes_diarios;
        private System.Windows.Forms.LinkLabel vacaciones;
    }
}