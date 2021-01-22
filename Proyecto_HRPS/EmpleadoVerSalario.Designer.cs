namespace Proyecto_HRPS
{
    partial class EmpleadoVerSalario
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.botonDeBuscar = new System.Windows.Forms.Button();
            this.textBoxDeCedula = new System.Windows.Forms.TextBox();
            this.textBoxDeSalarioBruto = new System.Windows.Forms.TextBox();
            this.textBoxDeSalarioNeto = new System.Windows.Forms.TextBox();
            this.textBoxDeDeducciones = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // botonDeVolver
            // 
            this.botonDeVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeVolver.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeVolver.ForeColor = System.Drawing.Color.White;
            this.botonDeVolver.Location = new System.Drawing.Point(55, 229);
            this.botonDeVolver.Name = "botonDeVolver";
            this.botonDeVolver.Size = new System.Drawing.Size(176, 52);
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
            this.label1.Location = new System.Drawing.Point(52, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 14);
            this.label1.TabIndex = 17;
            this.label1.Text = "SALARIO BRUTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(52, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 14);
            this.label2.TabIndex = 18;
            this.label2.Text = "DEDUCCIONES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(52, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 14);
            this.label3.TabIndex = 19;
            this.label3.Text = "SALARIO NETO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(52, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 14);
            this.label4.TabIndex = 20;
            this.label4.Text = "CÉDULA";
            // 
            // botonDeBuscar
            // 
            this.botonDeBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeBuscar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeBuscar.ForeColor = System.Drawing.Color.White;
            this.botonDeBuscar.Location = new System.Drawing.Point(294, 229);
            this.botonDeBuscar.Name = "botonDeBuscar";
            this.botonDeBuscar.Size = new System.Drawing.Size(176, 52);
            this.botonDeBuscar.TabIndex = 21;
            this.botonDeBuscar.Text = "BUSCAR";
            this.botonDeBuscar.UseVisualStyleBackColor = false;
            this.botonDeBuscar.Click += new System.EventHandler(this.botonDeBuscar_Click);
            // 
            // textBoxDeCedula
            // 
            this.textBoxDeCedula.Font = new System.Drawing.Font("Arial", 8.25F);
            this.textBoxDeCedula.Location = new System.Drawing.Point(184, 57);
            this.textBoxDeCedula.Name = "textBoxDeCedula";
            this.textBoxDeCedula.Size = new System.Drawing.Size(176, 20);
            this.textBoxDeCedula.TabIndex = 22;
            // 
            // textBoxDeSalarioBruto
            // 
            this.textBoxDeSalarioBruto.Font = new System.Drawing.Font("Arial", 8.25F);
            this.textBoxDeSalarioBruto.Location = new System.Drawing.Point(184, 97);
            this.textBoxDeSalarioBruto.Name = "textBoxDeSalarioBruto";
            this.textBoxDeSalarioBruto.Size = new System.Drawing.Size(176, 20);
            this.textBoxDeSalarioBruto.TabIndex = 23;
            // 
            // textBoxDeSalarioNeto
            // 
            this.textBoxDeSalarioNeto.Font = new System.Drawing.Font("Arial", 8.25F);
            this.textBoxDeSalarioNeto.Location = new System.Drawing.Point(184, 167);
            this.textBoxDeSalarioNeto.Name = "textBoxDeSalarioNeto";
            this.textBoxDeSalarioNeto.Size = new System.Drawing.Size(176, 20);
            this.textBoxDeSalarioNeto.TabIndex = 24;
            // 
            // textBoxDeDeducciones
            // 
            this.textBoxDeDeducciones.Font = new System.Drawing.Font("Arial", 8.25F);
            this.textBoxDeDeducciones.Location = new System.Drawing.Point(184, 135);
            this.textBoxDeDeducciones.Name = "textBoxDeDeducciones";
            this.textBoxDeDeducciones.Size = new System.Drawing.Size(176, 20);
            this.textBoxDeDeducciones.TabIndex = 25;
            // 
            // EmpleadoVerSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(528, 341);
            this.Controls.Add(this.textBoxDeDeducciones);
            this.Controls.Add(this.textBoxDeSalarioNeto);
            this.Controls.Add(this.textBoxDeSalarioBruto);
            this.Controls.Add(this.textBoxDeCedula);
            this.Controls.Add(this.botonDeBuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonDeVolver);
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.Name = "EmpleadoVerSalario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Salario";
            this.Load += new System.EventHandler(this.EmpleadoVerSalario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonDeVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button botonDeBuscar;
        private System.Windows.Forms.TextBox textBoxDeCedula;
        private System.Windows.Forms.TextBox textBoxDeSalarioBruto;
        private System.Windows.Forms.TextBox textBoxDeSalarioNeto;
        private System.Windows.Forms.TextBox textBoxDeDeducciones;
    }
}