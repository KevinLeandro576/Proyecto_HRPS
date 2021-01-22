namespace Proyecto_HRPS
{
    partial class EmpleadoVerHorario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDeCedula = new System.Windows.Forms.TextBox();
            this.botonDeBuscar = new System.Windows.Forms.Button();
            this.textBoxDeHorario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // botonDeVolver
            // 
            this.botonDeVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeVolver.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeVolver.ForeColor = System.Drawing.Color.White;
            this.botonDeVolver.Location = new System.Drawing.Point(61, 187);
            this.botonDeVolver.Name = "botonDeVolver";
            this.botonDeVolver.Size = new System.Drawing.Size(176, 48);
            this.botonDeVolver.TabIndex = 16;
            this.botonDeVolver.Text = "VOLVER";
            this.botonDeVolver.UseVisualStyleBackColor = false;
            this.botonDeVolver.Click += new System.EventHandler(this.botonDeVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(58, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 14);
            this.label1.TabIndex = 17;
            this.label1.Text = "HORARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(58, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 14);
            this.label2.TabIndex = 18;
            this.label2.Text = "CÉDULA";
            // 
            // textBoxDeCedula
            // 
            this.textBoxDeCedula.Font = new System.Drawing.Font("Arial", 8.25F);
            this.textBoxDeCedula.Location = new System.Drawing.Point(165, 62);
            this.textBoxDeCedula.Name = "textBoxDeCedula";
            this.textBoxDeCedula.Size = new System.Drawing.Size(176, 20);
            this.textBoxDeCedula.TabIndex = 19;
            // 
            // botonDeBuscar
            // 
            this.botonDeBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeBuscar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeBuscar.ForeColor = System.Drawing.Color.White;
            this.botonDeBuscar.Location = new System.Drawing.Point(311, 187);
            this.botonDeBuscar.Name = "botonDeBuscar";
            this.botonDeBuscar.Size = new System.Drawing.Size(176, 48);
            this.botonDeBuscar.TabIndex = 20;
            this.botonDeBuscar.Text = "BUSCAR";
            this.botonDeBuscar.UseVisualStyleBackColor = false;
            this.botonDeBuscar.Click += new System.EventHandler(this.botonDeBuscar_Click);
            // 
            // textBoxDeHorario
            // 
            this.textBoxDeHorario.Location = new System.Drawing.Point(165, 105);
            this.textBoxDeHorario.Name = "textBoxDeHorario";
            this.textBoxDeHorario.Size = new System.Drawing.Size(176, 20);
            this.textBoxDeHorario.TabIndex = 21;
            // 
            // EmpleadoVerHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(556, 281);
            this.Controls.Add(this.textBoxDeHorario);
            this.Controls.Add(this.botonDeBuscar);
            this.Controls.Add(this.textBoxDeCedula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonDeVolver);
            this.Name = "EmpleadoVerHorario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Horario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonDeVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDeCedula;
        private System.Windows.Forms.Button botonDeBuscar;
        private System.Windows.Forms.TextBox textBoxDeHorario;
    }
}