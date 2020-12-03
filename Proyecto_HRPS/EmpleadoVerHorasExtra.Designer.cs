namespace Proyecto_HRPS
{
    partial class EmpleadoVerHorasExtra
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
            this.tb_Cedula = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonDeVolver
            // 
            this.botonDeVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeVolver.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeVolver.ForeColor = System.Drawing.Color.White;
            this.botonDeVolver.Location = new System.Drawing.Point(57, 184);
            this.botonDeVolver.Name = "botonDeVolver";
            this.botonDeVolver.Size = new System.Drawing.Size(176, 48);
            this.botonDeVolver.TabIndex = 17;
            this.botonDeVolver.Text = "VOLVER";
            this.botonDeVolver.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(145, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 14);
            this.label1.TabIndex = 18;
            this.label1.Text = "CÉDULA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(145, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 14);
            this.label2.TabIndex = 19;
            this.label2.Text = "HORAS EXTRAS";
            // 
            // tb_Cedula
            // 
            this.tb_Cedula.Font = new System.Drawing.Font("Arial", 8.25F);
            this.tb_Cedula.Location = new System.Drawing.Point(335, 52);
            this.tb_Cedula.Name = "tb_Cedula";
            this.tb_Cedula.Size = new System.Drawing.Size(112, 20);
            this.tb_Cedula.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(335, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 48);
            this.button1.TabIndex = 21;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // EmpleadoVerHorasExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(564, 293);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_Cedula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonDeVolver);
            this.Name = "EmpleadoVerHorasExtra";
            this.Text = "Ver horas extra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonDeVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Cedula;
        private System.Windows.Forms.Button button1;
    }
}