﻿namespace Proyecto_HRPS
{
    partial class ModificarSalario
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
            this.panelDeFlujoDeSalarios = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // botonDeVolver
            // 
            this.botonDeVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeVolver.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeVolver.ForeColor = System.Drawing.Color.White;
            this.botonDeVolver.Location = new System.Drawing.Point(36, 239);
            this.botonDeVolver.Name = "botonDeVolver";
            this.botonDeVolver.Size = new System.Drawing.Size(176, 44);
            this.botonDeVolver.TabIndex = 4;
            this.botonDeVolver.Text = "VOLVER";
            this.botonDeVolver.UseVisualStyleBackColor = false;
            this.botonDeVolver.Click += new System.EventHandler(this.botonDeVolver_Click);
            // 
            // panelDeFlujoDeSalarios
            // 
            this.panelDeFlujoDeSalarios.Location = new System.Drawing.Point(12, 12);
            this.panelDeFlujoDeSalarios.Name = "panelDeFlujoDeSalarios";
            this.panelDeFlujoDeSalarios.Size = new System.Drawing.Size(684, 212);
            this.panelDeFlujoDeSalarios.TabIndex = 5;
            // 
            // ModificarSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(708, 317);
            this.Controls.Add(this.panelDeFlujoDeSalarios);
            this.Controls.Add(this.botonDeVolver);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModificarSalario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar salario";
            this.Load += new System.EventHandler(this.ModificarSalario_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonDeVolver;
        private System.Windows.Forms.FlowLayoutPanel panelDeFlujoDeSalarios;
    }
}