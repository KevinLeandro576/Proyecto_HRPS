
namespace Proyecto_HRPS
{
    partial class EmpleadoCambiarContrasena
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
            this.labelDeContrasena = new System.Windows.Forms.Label();
            this.textBoxDeContrasena = new System.Windows.Forms.TextBox();
            this.botonDeGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxDeContrasena = new System.Windows.Forms.CheckBox();
            this.botonDeVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDeContrasena
            // 
            this.labelDeContrasena.AutoSize = true;
            this.labelDeContrasena.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.labelDeContrasena.Location = new System.Drawing.Point(59, 66);
            this.labelDeContrasena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDeContrasena.Name = "labelDeContrasena";
            this.labelDeContrasena.Size = new System.Drawing.Size(175, 18);
            this.labelDeContrasena.TabIndex = 18;
            this.labelDeContrasena.Text = "CONTRASEÑA NUEVA";
            // 
            // textBoxDeContrasena
            // 
            this.textBoxDeContrasena.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDeContrasena.Location = new System.Drawing.Point(281, 63);
            this.textBoxDeContrasena.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDeContrasena.Name = "textBoxDeContrasena";
            this.textBoxDeContrasena.PasswordChar = '*';
            this.textBoxDeContrasena.Size = new System.Drawing.Size(261, 26);
            this.textBoxDeContrasena.TabIndex = 24;
            // 
            // botonDeGuardar
            // 
            this.botonDeGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeGuardar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeGuardar.ForeColor = System.Drawing.Color.White;
            this.botonDeGuardar.Location = new System.Drawing.Point(328, 240);
            this.botonDeGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.botonDeGuardar.Name = "botonDeGuardar";
            this.botonDeGuardar.Size = new System.Drawing.Size(214, 41);
            this.botonDeGuardar.TabIndex = 25;
            this.botonDeGuardar.Text = "GUARDAR";
            this.botonDeGuardar.UseVisualStyleBackColor = false;
            this.botonDeGuardar.Click += new System.EventHandler(this.botonDeGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "*Contraseña deberá tener mínimo una mayúscula y una minúscula,";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "números y de 8 a 16 caracteres.";
            // 
            // checkBoxDeContrasena
            // 
            this.checkBoxDeContrasena.AutoSize = true;
            this.checkBoxDeContrasena.Location = new System.Drawing.Point(410, 96);
            this.checkBoxDeContrasena.Name = "checkBoxDeContrasena";
            this.checkBoxDeContrasena.Size = new System.Drawing.Size(132, 22);
            this.checkBoxDeContrasena.TabIndex = 28;
            this.checkBoxDeContrasena.Text = "Ver contraseña";
            this.checkBoxDeContrasena.UseVisualStyleBackColor = true;
            this.checkBoxDeContrasena.CheckedChanged += new System.EventHandler(this.checkBoxDeContrasena_CheckedChanged);
            // 
            // botonDeVolver
            // 
            this.botonDeVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeVolver.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeVolver.ForeColor = System.Drawing.Color.White;
            this.botonDeVolver.Location = new System.Drawing.Point(62, 240);
            this.botonDeVolver.Margin = new System.Windows.Forms.Padding(4);
            this.botonDeVolver.Name = "botonDeVolver";
            this.botonDeVolver.Size = new System.Drawing.Size(214, 41);
            this.botonDeVolver.TabIndex = 29;
            this.botonDeVolver.Text = "VOLVER";
            this.botonDeVolver.UseVisualStyleBackColor = false;
            this.botonDeVolver.Click += new System.EventHandler(this.botonDeVolver_Click);
            // 
            // EmpleadoCambiarContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(623, 323);
            this.Controls.Add(this.botonDeVolver);
            this.Controls.Add(this.checkBoxDeContrasena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonDeGuardar);
            this.Controls.Add(this.textBoxDeContrasena);
            this.Controls.Add(this.labelDeContrasena);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmpleadoCambiarContrasena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar contraseña";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmpleadoCambiarContrasena_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDeContrasena;
        private System.Windows.Forms.TextBox textBoxDeContrasena;
        private System.Windows.Forms.Button botonDeGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxDeContrasena;
        private System.Windows.Forms.Button botonDeVolver;
    }
}