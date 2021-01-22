namespace Proyecto_HRPS
{
    partial class SolicitudesHorasExtra
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
            this.botonDeEnviar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDeNombre = new System.Windows.Forms.TextBox();
            this.dateTimePickerDeDiaTrabajado = new System.Windows.Forms.DateTimePicker();
            this.numericDeCantidadDeHorasExtra = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericDeCantidadDeHorasExtra)).BeginInit();
            this.SuspendLayout();
            // 
            // botonDeVolver
            // 
            this.botonDeVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeVolver.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeVolver.ForeColor = System.Drawing.Color.White;
            this.botonDeVolver.Location = new System.Drawing.Point(55, 205);
            this.botonDeVolver.Name = "botonDeVolver";
            this.botonDeVolver.Size = new System.Drawing.Size(176, 48);
            this.botonDeVolver.TabIndex = 7;
            this.botonDeVolver.Text = "VOLVER";
            this.botonDeVolver.UseVisualStyleBackColor = false;
            this.botonDeVolver.Click += new System.EventHandler(this.botonDeVolver_Click);
            // 
            // botonDeEnviar
            // 
            this.botonDeEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeEnviar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeEnviar.ForeColor = System.Drawing.Color.White;
            this.botonDeEnviar.Location = new System.Drawing.Point(331, 205);
            this.botonDeEnviar.Name = "botonDeEnviar";
            this.botonDeEnviar.Size = new System.Drawing.Size(176, 48);
            this.botonDeEnviar.TabIndex = 8;
            this.botonDeEnviar.Text = "ENVIAR";
            this.botonDeEnviar.UseVisualStyleBackColor = false;
            this.botonDeEnviar.Click += new System.EventHandler(this.botonDeEnviar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(52, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 14);
            this.label1.TabIndex = 9;
            this.label1.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(52, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "DÍA TRABAJADO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(52, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 14);
            this.label3.TabIndex = 11;
            this.label3.Text = "CANTIDAD DE HORAS EXTRA";
            // 
            // textBoxDeNombre
            // 
            this.textBoxDeNombre.Font = new System.Drawing.Font("Arial", 8.25F);
            this.textBoxDeNombre.Location = new System.Drawing.Point(214, 56);
            this.textBoxDeNombre.Name = "textBoxDeNombre";
            this.textBoxDeNombre.Size = new System.Drawing.Size(176, 20);
            this.textBoxDeNombre.TabIndex = 12;
            // 
            // dateTimePickerDeDiaTrabajado
            // 
            this.dateTimePickerDeDiaTrabajado.Font = new System.Drawing.Font("Arial", 8.25F);
            this.dateTimePickerDeDiaTrabajado.Location = new System.Drawing.Point(214, 96);
            this.dateTimePickerDeDiaTrabajado.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerDeDiaTrabajado.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDeDiaTrabajado.Name = "dateTimePickerDeDiaTrabajado";
            this.dateTimePickerDeDiaTrabajado.Size = new System.Drawing.Size(176, 20);
            this.dateTimePickerDeDiaTrabajado.TabIndex = 14;
            // 
            // numericDeCantidadDeHorasExtra
            // 
            this.numericDeCantidadDeHorasExtra.Font = new System.Drawing.Font("Arial", 8.25F);
            this.numericDeCantidadDeHorasExtra.Location = new System.Drawing.Point(214, 136);
            this.numericDeCantidadDeHorasExtra.Name = "numericDeCantidadDeHorasExtra";
            this.numericDeCantidadDeHorasExtra.Size = new System.Drawing.Size(176, 20);
            this.numericDeCantidadDeHorasExtra.TabIndex = 15;
            // 
            // SolicitudesHorasExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(606, 296);
            this.Controls.Add(this.numericDeCantidadDeHorasExtra);
            this.Controls.Add(this.dateTimePickerDeDiaTrabajado);
            this.Controls.Add(this.textBoxDeNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonDeEnviar);
            this.Controls.Add(this.botonDeVolver);
            this.Name = "SolicitudesHorasExtra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de horas extra";
            ((System.ComponentModel.ISupportInitialize)(this.numericDeCantidadDeHorasExtra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonDeVolver;
        private System.Windows.Forms.Button botonDeEnviar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDeNombre;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeDiaTrabajado;
        private System.Windows.Forms.NumericUpDown numericDeCantidadDeHorasExtra;
    }
}