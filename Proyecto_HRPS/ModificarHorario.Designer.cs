namespace Proyecto_HRPS
{
    partial class ModificarHorario
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
            this.botonDeVolver = new System.Windows.Forms.Button();
            this.dataGridViewDeEmpleados = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumnCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.empleadoEnObjetoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoEnObjetoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hR_PAYROLL_SYSTEMDataSet = new Proyecto_HRPS.HR_PAYROLL_SYSTEMDataSet();
            this.uSUARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSUARIOSTableAdapter = new Proyecto_HRPS.HR_PAYROLL_SYSTEMDataSetTableAdapters.USUARIOSTableAdapter();
            this.textBoxDeCedula = new System.Windows.Forms.TextBox();
            this.labelDeCedula = new System.Windows.Forms.Label();
            this.panelDeBorde = new System.Windows.Forms.Panel();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoEnObjetoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoEnObjetoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoEnObjetoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hR_PAYROLL_SYSTEMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).BeginInit();
            this.panelDeBorde.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoEnObjetoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // botonDeVolver
            // 
            this.botonDeVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeVolver.Font = new System.Drawing.Font("Arial", 12F);
            this.botonDeVolver.ForeColor = System.Drawing.Color.White;
            this.botonDeVolver.Location = new System.Drawing.Point(13, 541);
            this.botonDeVolver.Margin = new System.Windows.Forms.Padding(4);
            this.botonDeVolver.Name = "botonDeVolver";
            this.botonDeVolver.Size = new System.Drawing.Size(226, 68);
            this.botonDeVolver.TabIndex = 3;
            this.botonDeVolver.Text = "VOLVER";
            this.botonDeVolver.UseVisualStyleBackColor = false;
            this.botonDeVolver.Click += new System.EventHandler(this.botonDeVolver_Click);
            // 
            // dataGridViewDeEmpleados
            // 
            this.dataGridViewDeEmpleados.AllowUserToAddRows = false;
            this.dataGridViewDeEmpleados.AllowUserToDeleteRows = false;
            this.dataGridViewDeEmpleados.AllowUserToResizeColumns = false;
            this.dataGridViewDeEmpleados.AllowUserToResizeRows = false;
            this.dataGridViewDeEmpleados.AutoGenerateColumns = false;
            this.dataGridViewDeEmpleados.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDeEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumnCedula,
            this.dataGridViewTextBoxColumnNombre,
            this.dataGridViewTextBoxColumnHorario,
            this.Modificar});
            this.dataGridViewDeEmpleados.DataSource = this.empleadoEnObjetoBindingSource2;
            this.dataGridViewDeEmpleados.GridColor = System.Drawing.Color.White;
            this.dataGridViewDeEmpleados.Location = new System.Drawing.Point(4, 0);
            this.dataGridViewDeEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewDeEmpleados.Name = "dataGridViewDeEmpleados";
            this.dataGridViewDeEmpleados.ReadOnly = true;
            this.dataGridViewDeEmpleados.RowHeadersVisible = false;
            this.dataGridViewDeEmpleados.Size = new System.Drawing.Size(521, 338);
            this.dataGridViewDeEmpleados.TabIndex = 5;
            this.dataGridViewDeEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDeEmpleados_CellClick);
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
            this.dataGridViewTextBoxColumnNombre.Width = 200;
            // 
            // dataGridViewTextBoxColumnHorario
            // 
            this.dataGridViewTextBoxColumnHorario.DataPropertyName = "Horario";
            this.dataGridViewTextBoxColumnHorario.HeaderText = "HORARIO";
            this.dataGridViewTextBoxColumnHorario.Name = "dataGridViewTextBoxColumnHorario";
            this.dataGridViewTextBoxColumnHorario.ReadOnly = true;
            // 
            // Modificar
            // 
            this.Modificar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Modificar.DataPropertyName = "botonDeModificar";
            this.Modificar.HeaderText = "";
            this.Modificar.Name = "Modificar";
            this.Modificar.ReadOnly = true;
            this.Modificar.Text = "MODIFICAR";
            this.Modificar.UseColumnTextForButtonValue = true;
            // 
            // empleadoEnObjetoBindingSource2
            // 
            this.empleadoEnObjetoBindingSource2.DataSource = typeof(Proyecto_HRPS.EmpleadoEnObjeto);
            // 
            // hR_PAYROLL_SYSTEMDataSet
            // 
            this.hR_PAYROLL_SYSTEMDataSet.DataSetName = "HR_PAYROLL_SYSTEMDataSet";
            this.hR_PAYROLL_SYSTEMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSUARIOSBindingSource
            // 
            this.uSUARIOSBindingSource.DataMember = "USUARIOS";
            this.uSUARIOSBindingSource.DataSource = this.hR_PAYROLL_SYSTEMDataSet;
            // 
            // uSUARIOSTableAdapter
            // 
            this.uSUARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxDeCedula
            // 
            this.textBoxDeCedula.Location = new System.Drawing.Point(255, 80);
            this.textBoxDeCedula.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDeCedula.Name = "textBoxDeCedula";
            this.textBoxDeCedula.Size = new System.Drawing.Size(318, 26);
            this.textBoxDeCedula.TabIndex = 6;
            this.textBoxDeCedula.TextChanged += new System.EventHandler(this.textBoxDeCedula_TextChanged);
            // 
            // labelDeCedula
            // 
            this.labelDeCedula.AutoSize = true;
            this.labelDeCedula.Location = new System.Drawing.Point(51, 83);
            this.labelDeCedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDeCedula.Name = "labelDeCedula";
            this.labelDeCedula.Size = new System.Drawing.Size(182, 18);
            this.labelDeCedula.TabIndex = 7;
            this.labelDeCedula.Text = "Escribe cédula o nombre";
            // 
            // panelDeBorde
            // 
            this.panelDeBorde.Controls.Add(this.dataGridViewDeEmpleados);
            this.panelDeBorde.Location = new System.Drawing.Point(50, 141);
            this.panelDeBorde.Margin = new System.Windows.Forms.Padding(4);
            this.panelDeBorde.Name = "panelDeBorde";
            this.panelDeBorde.Size = new System.Drawing.Size(525, 338);
            this.panelDeBorde.TabIndex = 8;
            // 
            // ModificarHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(693, 622);
            this.Controls.Add(this.panelDeBorde);
            this.Controls.Add(this.labelDeCedula);
            this.Controls.Add(this.textBoxDeCedula);
            this.Controls.Add(this.botonDeVolver);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ModificarHorario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar horario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModificarHorario_FormClosing);
            this.Load += new System.EventHandler(this.ModificarHorario_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoEnObjetoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoEnObjetoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hR_PAYROLL_SYSTEMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).EndInit();
            this.panelDeBorde.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoEnObjetoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonDeVolver;
        private System.Windows.Forms.DataGridView dataGridViewDeEmpleados;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private HR_PAYROLL_SYSTEMDataSet hR_PAYROLL_SYSTEMDataSet;
        private System.Windows.Forms.BindingSource uSUARIOSBindingSource;
        private HR_PAYROLL_SYSTEMDataSetTableAdapters.USUARIOSTableAdapter uSUARIOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDeDiasUsadosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDeHorasExtraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDeInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource empleadoEnObjetoBindingSource;
        private System.Windows.Forms.BindingSource empleadoEnObjetoBindingSource1;
        private System.Windows.Forms.TextBox textBoxDeCedula;
        private System.Windows.Forms.Label labelDeCedula;
        private System.Windows.Forms.Panel panelDeBorde;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource empleadoEnObjetoBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnHorario;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
    }
}