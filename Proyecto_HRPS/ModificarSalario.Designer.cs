namespace Proyecto_HRPS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarSalario));
            this.botonDeVolver = new System.Windows.Forms.Button();
            this.empleadoEnObjetoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelDeCedula = new System.Windows.Forms.Label();
            this.textBoxDeCedula = new System.Windows.Forms.TextBox();
            this.botonDeModificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewDeEmpleados = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumnCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnSalario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadoEnObjetoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panelDeEmpleados = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoEnObjetoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoEnObjetoBindingSource1)).BeginInit();
            this.panelDeEmpleados.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonDeVolver
            // 
            this.botonDeVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeVolver.Font = new System.Drawing.Font("Arial", 12F);
            this.botonDeVolver.ForeColor = System.Drawing.Color.White;
            this.botonDeVolver.Location = new System.Drawing.Point(55, 517);
            this.botonDeVolver.Margin = new System.Windows.Forms.Padding(4);
            this.botonDeVolver.Name = "botonDeVolver";
            this.botonDeVolver.Size = new System.Drawing.Size(543, 41);
            this.botonDeVolver.TabIndex = 4;
            this.botonDeVolver.Text = "VOLVER";
            this.botonDeVolver.UseVisualStyleBackColor = false;
            this.botonDeVolver.Click += new System.EventHandler(this.botonDeVolver_Click);
            // 
            // labelDeCedula
            // 
            this.labelDeCedula.AutoSize = true;
            this.labelDeCedula.Location = new System.Drawing.Point(52, 86);
            this.labelDeCedula.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelDeCedula.Name = "labelDeCedula";
            this.labelDeCedula.Size = new System.Drawing.Size(182, 18);
            this.labelDeCedula.TabIndex = 8;
            this.labelDeCedula.Text = "Escribe cédula o nombre";
            // 
            // textBoxDeCedula
            // 
            this.textBoxDeCedula.Location = new System.Drawing.Point(282, 83);
            this.textBoxDeCedula.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxDeCedula.Name = "textBoxDeCedula";
            this.textBoxDeCedula.Size = new System.Drawing.Size(318, 26);
            this.textBoxDeCedula.TabIndex = 9;
            this.textBoxDeCedula.TextChanged += new System.EventHandler(this.textBoxDeCedula_TextChanged);
            // 
            // botonDeModificar
            // 
            this.botonDeModificar.DataPropertyName = "botonDeModificar";
            this.botonDeModificar.HeaderText = "";
            this.botonDeModificar.Name = "botonDeModificar";
            this.botonDeModificar.ReadOnly = true;
            this.botonDeModificar.Text = "MODIFICAR";
            this.botonDeModificar.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewDeEmpleados
            // 
            this.dataGridViewDeEmpleados.AllowUserToAddRows = false;
            this.dataGridViewDeEmpleados.AllowUserToDeleteRows = false;
            this.dataGridViewDeEmpleados.AllowUserToResizeColumns = false;
            this.dataGridViewDeEmpleados.AllowUserToResizeRows = false;
            this.dataGridViewDeEmpleados.AutoGenerateColumns = false;
            this.dataGridViewDeEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDeEmpleados.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDeEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumnCedula,
            this.dataGridViewTextBoxColumnNombre,
            this.dataGridViewTextBoxColumnSalario,
            this.botonDeModificar});
            this.dataGridViewDeEmpleados.DataSource = this.empleadoEnObjetoBindingSource1;
            this.dataGridViewDeEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDeEmpleados.GridColor = System.Drawing.Color.White;
            this.dataGridViewDeEmpleados.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDeEmpleados.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dataGridViewDeEmpleados.Name = "dataGridViewDeEmpleados";
            this.dataGridViewDeEmpleados.ReadOnly = true;
            this.dataGridViewDeEmpleados.RowHeadersVisible = false;
            this.dataGridViewDeEmpleados.Size = new System.Drawing.Size(539, 354);
            this.dataGridViewDeEmpleados.TabIndex = 6;
            this.dataGridViewDeEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDeEmpleados_CellClick);
            // 
            // dataGridViewTextBoxColumnCedula
            // 
            this.dataGridViewTextBoxColumnCedula.DataPropertyName = "Cedula";
            this.dataGridViewTextBoxColumnCedula.HeaderText = "CÉDULA";
            this.dataGridViewTextBoxColumnCedula.Name = "dataGridViewTextBoxColumnCedula";
            this.dataGridViewTextBoxColumnCedula.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnNombre
            // 
            this.dataGridViewTextBoxColumnNombre.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumnNombre.HeaderText = "NOMBRE";
            this.dataGridViewTextBoxColumnNombre.Name = "dataGridViewTextBoxColumnNombre";
            this.dataGridViewTextBoxColumnNombre.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnSalario
            // 
            this.dataGridViewTextBoxColumnSalario.DataPropertyName = "Salario";
            this.dataGridViewTextBoxColumnSalario.HeaderText = "SALARIO";
            this.dataGridViewTextBoxColumnSalario.Name = "dataGridViewTextBoxColumnSalario";
            this.dataGridViewTextBoxColumnSalario.ReadOnly = true;
            // 
            // empleadoEnObjetoBindingSource1
            // 
            this.empleadoEnObjetoBindingSource1.DataSource = typeof(Proyecto_HRPS.EmpleadoEnObjeto);
            // 
            // panelDeEmpleados
            // 
            this.panelDeEmpleados.Controls.Add(this.panel1);
            this.panelDeEmpleados.Location = new System.Drawing.Point(55, 131);
            this.panelDeEmpleados.Name = "panelDeEmpleados";
            this.panelDeEmpleados.Size = new System.Drawing.Size(545, 360);
            this.panelDeEmpleados.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewDeEmpleados);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 354);
            this.panel1.TabIndex = 11;
            // 
            // ModificarSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(655, 578);
            this.Controls.Add(this.panelDeEmpleados);
            this.Controls.Add(this.textBoxDeCedula);
            this.Controls.Add(this.labelDeCedula);
            this.Controls.Add(this.botonDeVolver);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ModificarSalario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar salario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModificarSalario_FormClosing);
            this.Load += new System.EventHandler(this.ModificarSalario_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.empleadoEnObjetoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoEnObjetoBindingSource1)).EndInit();
            this.panelDeEmpleados.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonDeVolver;
        private System.Windows.Forms.BindingSource empleadoEnObjetoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.Label labelDeCedula;
        private System.Windows.Forms.TextBox textBoxDeCedula;
        private System.Windows.Forms.BindingSource empleadoEnObjetoBindingSource1;
        private System.Windows.Forms.DataGridView dataGridViewDeEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnSalario;
        private System.Windows.Forms.DataGridViewButtonColumn botonDeModificar;
        private System.Windows.Forms.Panel panelDeEmpleados;
        private System.Windows.Forms.Panel panel1;
    }
}