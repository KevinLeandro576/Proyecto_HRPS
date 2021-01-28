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
            this.hR_PAYROLL_SYSTEMDataSet = new Proyecto_HRPS.HR_PAYROLL_SYSTEMDataSet();
            this.uSUARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSUARIOSTableAdapter = new Proyecto_HRPS.HR_PAYROLL_SYSTEMDataSetTableAdapters.USUARIOSTableAdapter();
            this.textBoxDeCedula = new System.Windows.Forms.TextBox();
            this.labelDeCedula = new System.Windows.Forms.Label();
            this.panelDeBorde = new System.Windows.Forms.Panel();
            this.empleadoEnObjetoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoEnObjetoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hR_PAYROLL_SYSTEMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).BeginInit();
            this.panelDeBorde.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoEnObjetoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoEnObjetoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // botonDeVolver
            // 
            this.botonDeVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeVolver.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeVolver.ForeColor = System.Drawing.Color.White;
            this.botonDeVolver.Location = new System.Drawing.Point(15, 532);
            this.botonDeVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.cedulaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.horarioDataGridViewTextBoxColumn,
            this.Modificar});
            this.dataGridViewDeEmpleados.DataSource = this.empleadoEnObjetoBindingSource;
            this.dataGridViewDeEmpleados.GridColor = System.Drawing.Color.White;
            this.dataGridViewDeEmpleados.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDeEmpleados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewDeEmpleados.Name = "dataGridViewDeEmpleados";
            this.dataGridViewDeEmpleados.ReadOnly = true;
            this.dataGridViewDeEmpleados.RowHeadersVisible = false;
            this.dataGridViewDeEmpleados.Size = new System.Drawing.Size(525, 338);
            this.dataGridViewDeEmpleados.TabIndex = 5;
            this.dataGridViewDeEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDeEmpleados_CellClick);
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
            this.textBoxDeCedula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDeCedula.Name = "textBoxDeCedula";
            this.textBoxDeCedula.Size = new System.Drawing.Size(318, 26);
            this.textBoxDeCedula.TabIndex = 6;
            this.textBoxDeCedula.TextChanged += new System.EventHandler(this.textBoxDeCedula_TextChanged);
            // 
            // labelDeCedula
            // 
            this.labelDeCedula.AutoSize = true;
            this.labelDeCedula.Location = new System.Drawing.Point(45, 86);
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
            this.panelDeBorde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelDeBorde.Name = "panelDeBorde";
            this.panelDeBorde.Size = new System.Drawing.Size(525, 338);
            this.panelDeBorde.TabIndex = 8;
            // 
            // empleadoEnObjetoBindingSource
            // 
            this.empleadoEnObjetoBindingSource.DataSource = typeof(Proyecto_HRPS.EmpleadoEnObjeto);
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataSource = typeof(Proyecto_HRPS.Empleado);
            // 
            // empleadoEnObjetoBindingSource1
            // 
            this.empleadoEnObjetoBindingSource1.DataSource = typeof(Proyecto_HRPS.EmpleadoEnObjeto);
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            this.cedulaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.HeaderText = "Cédula";
            this.cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            this.cedulaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horarioDataGridViewTextBoxColumn
            // 
            this.horarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.horarioDataGridViewTextBoxColumn.DataPropertyName = "Horario";
            this.horarioDataGridViewTextBoxColumn.HeaderText = "Horario";
            this.horarioDataGridViewTextBoxColumn.Name = "horarioDataGridViewTextBoxColumn";
            this.horarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Modificar
            // 
            this.Modificar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Modificar.DataPropertyName = "botonDeModificar";
            this.Modificar.HeaderText = "";
            this.Modificar.Name = "Modificar";
            this.Modificar.ReadOnly = true;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseColumnTextForButtonValue = true;
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ModificarHorario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar horario";
            this.Load += new System.EventHandler(this.ModificarHorario_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hR_PAYROLL_SYSTEMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).EndInit();
            this.panelDeBorde.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.empleadoEnObjetoBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
    }
}