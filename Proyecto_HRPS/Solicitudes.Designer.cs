﻿namespace Proyecto_HRPS
{
    partial class Solicitudes
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
            this.panelDeFlujoDeSolicitudesDeHorasExtra = new System.Windows.Forms.FlowLayoutPanel();
            this.panelDeFlujoDeSolicitudesDeVacaciones = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botonDeVolver
            // 
            this.botonDeVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeVolver.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeVolver.ForeColor = System.Drawing.Color.White;
            this.botonDeVolver.Location = new System.Drawing.Point(12, 533);
            this.botonDeVolver.Name = "botonDeVolver";
            this.botonDeVolver.Size = new System.Drawing.Size(176, 48);
            this.botonDeVolver.TabIndex = 4;
            this.botonDeVolver.Text = "VOLVER";
            this.botonDeVolver.UseVisualStyleBackColor = false;
            this.botonDeVolver.Click += new System.EventHandler(this.botonDeVolver_Click);
            // 
            // panelDeFlujoDeSolicitudesDeHorasExtra
            // 
            this.panelDeFlujoDeSolicitudesDeHorasExtra.Location = new System.Drawing.Point(12, 40);
            this.panelDeFlujoDeSolicitudesDeHorasExtra.Name = "panelDeFlujoDeSolicitudesDeHorasExtra";
            this.panelDeFlujoDeSolicitudesDeHorasExtra.Size = new System.Drawing.Size(903, 209);
            this.panelDeFlujoDeSolicitudesDeHorasExtra.TabIndex = 7;
            // 
            // panelDeFlujoDeSolicitudesDeVacaciones
            // 
            this.panelDeFlujoDeSolicitudesDeVacaciones.Location = new System.Drawing.Point(12, 318);
            this.panelDeFlujoDeSolicitudesDeVacaciones.Name = "panelDeFlujoDeSolicitudesDeVacaciones";
            this.panelDeFlujoDeSolicitudesDeVacaciones.Size = new System.Drawing.Size(903, 209);
            this.panelDeFlujoDeSolicitudesDeVacaciones.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "SOLICITUDES DE HORAS EXTRA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "SOLICITUDES DE VACACIONES";
            // 
            // Solicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 593);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelDeFlujoDeSolicitudesDeVacaciones);
            this.Controls.Add(this.panelDeFlujoDeSolicitudesDeHorasExtra);
            this.Controls.Add(this.botonDeVolver);
            this.Font = new System.Drawing.Font("Volta Modern Display 55 Rom", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Solicitudes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitudes";
            this.Load += new System.EventHandler(this.Solicitudes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonDeVolver;
        private System.Windows.Forms.FlowLayoutPanel panelDeFlujoDeSolicitudesDeHorasExtra;
        private System.Windows.Forms.FlowLayoutPanel panelDeFlujoDeSolicitudesDeVacaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}