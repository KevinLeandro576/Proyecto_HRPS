﻿
namespace Proyecto_HRPS
{
    partial class AdministradorSolicitudesDeVacaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministradorSolicitudesDeVacaciones));
            this.botonDeVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFin = new System.Windows.Forms.DateTimePicker();
            this.solicitudDeVacacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelVacaciones = new System.Windows.Forms.Label();
            this.labelDeCedula = new System.Windows.Forms.Label();
            this.textBoxDeCedula = new System.Windows.Forms.TextBox();
            this.dataGridViewDeSolicitudesDeVacaciones = new System.Windows.Forms.DataGridView();
            this.identificadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaDeInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDeDiasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaDeEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botonAceptar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.botonNegar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudDeVacacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeSolicitudesDeVacaciones)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonDeVolver
            // 
            this.botonDeVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeVolver.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeVolver.ForeColor = System.Drawing.Color.White;
            this.botonDeVolver.Location = new System.Drawing.Point(20, 598);
            this.botonDeVolver.Margin = new System.Windows.Forms.Padding(6);
            this.botonDeVolver.Name = "botonDeVolver";
            this.botonDeVolver.Size = new System.Drawing.Size(226, 41);
            this.botonDeVolver.TabIndex = 5;
            this.botonDeVolver.Text = "VOLVER";
            this.botonDeVolver.UseVisualStyleBackColor = false;
            this.botonDeVolver.Click += new System.EventHandler(this.botonDeVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Selecciona fecha de inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Selecciona fecha de fin";
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.Location = new System.Drawing.Point(353, 85);
            this.dateTimePickerInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerInicio.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(354, 26);
            this.dateTimePickerInicio.TabIndex = 21;
            this.dateTimePickerInicio.ValueChanged += new System.EventHandler(this.dateTimePickerInicio_ValueChanged);
            // 
            // dateTimePickerFin
            // 
            this.dateTimePickerFin.Location = new System.Drawing.Point(353, 125);
            this.dateTimePickerFin.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerFin.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFin.Name = "dateTimePickerFin";
            this.dateTimePickerFin.Size = new System.Drawing.Size(354, 26);
            this.dateTimePickerFin.TabIndex = 22;
            this.dateTimePickerFin.ValueChanged += new System.EventHandler(this.dateTimePickerFin_ValueChanged);
            // 
            // solicitudDeVacacionesBindingSource
            // 
            this.solicitudDeVacacionesBindingSource.DataSource = typeof(Proyecto_HRPS.SolicitudDeVacaciones);
            // 
            // labelVacaciones
            // 
            this.labelVacaciones.AutoSize = true;
            this.labelVacaciones.Location = new System.Drawing.Point(265, 189);
            this.labelVacaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVacaciones.Name = "labelVacaciones";
            this.labelVacaciones.Size = new System.Drawing.Size(193, 18);
            this.labelVacaciones.TabIndex = 24;
            this.labelVacaciones.Text = "Solicitudes de Vacaciones";
            // 
            // labelDeCedula
            // 
            this.labelDeCedula.AutoSize = true;
            this.labelDeCedula.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeCedula.Location = new System.Drawing.Point(26, 51);
            this.labelDeCedula.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.labelDeCedula.Name = "labelDeCedula";
            this.labelDeCedula.Size = new System.Drawing.Size(112, 18);
            this.labelDeCedula.TabIndex = 25;
            this.labelDeCedula.Text = "Escribe cédula";
            // 
            // textBoxDeCedula
            // 
            this.textBoxDeCedula.Location = new System.Drawing.Point(353, 43);
            this.textBoxDeCedula.Margin = new System.Windows.Forms.Padding(12);
            this.textBoxDeCedula.Name = "textBoxDeCedula";
            this.textBoxDeCedula.Size = new System.Drawing.Size(354, 26);
            this.textBoxDeCedula.TabIndex = 26;
            this.textBoxDeCedula.TextChanged += new System.EventHandler(this.textBoxDeCedula_TextChanged);
            // 
            // dataGridViewDeSolicitudesDeVacaciones
            // 
            this.dataGridViewDeSolicitudesDeVacaciones.AllowUserToAddRows = false;
            this.dataGridViewDeSolicitudesDeVacaciones.AllowUserToDeleteRows = false;
            this.dataGridViewDeSolicitudesDeVacaciones.AllowUserToResizeColumns = false;
            this.dataGridViewDeSolicitudesDeVacaciones.AllowUserToResizeRows = false;
            this.dataGridViewDeSolicitudesDeVacaciones.AutoGenerateColumns = false;
            this.dataGridViewDeSolicitudesDeVacaciones.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDeSolicitudesDeVacaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeSolicitudesDeVacaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identificadorDataGridViewTextBoxColumn,
            this.diaDeInicioDataGridViewTextBoxColumn,
            this.cantidadDeDiasDataGridViewTextBoxColumn,
            this.cedulaDeEmpleadoDataGridViewTextBoxColumn,
            this.botonAceptar,
            this.botonNegar});
            this.dataGridViewDeSolicitudesDeVacaciones.DataSource = this.solicitudDeVacacionesBindingSource;
            this.dataGridViewDeSolicitudesDeVacaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDeSolicitudesDeVacaciones.GridColor = System.Drawing.Color.White;
            this.dataGridViewDeSolicitudesDeVacaciones.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDeSolicitudesDeVacaciones.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewDeSolicitudesDeVacaciones.Name = "dataGridViewDeSolicitudesDeVacaciones";
            this.dataGridViewDeSolicitudesDeVacaciones.RowHeadersVisible = false;
            this.dataGridViewDeSolicitudesDeVacaciones.Size = new System.Drawing.Size(672, 348);
            this.dataGridViewDeSolicitudesDeVacaciones.TabIndex = 0;
            this.dataGridViewDeSolicitudesDeVacaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDeSolicitudesDeVacaciones_CellClick);
            // 
            // identificadorDataGridViewTextBoxColumn
            // 
            this.identificadorDataGridViewTextBoxColumn.DataPropertyName = "Identificador";
            this.identificadorDataGridViewTextBoxColumn.HeaderText = "Identificador";
            this.identificadorDataGridViewTextBoxColumn.Name = "identificadorDataGridViewTextBoxColumn";
            // 
            // diaDeInicioDataGridViewTextBoxColumn
            // 
            this.diaDeInicioDataGridViewTextBoxColumn.DataPropertyName = "DiaDeInicio";
            this.diaDeInicioDataGridViewTextBoxColumn.HeaderText = "Día De Inicio";
            this.diaDeInicioDataGridViewTextBoxColumn.Name = "diaDeInicioDataGridViewTextBoxColumn";
            // 
            // cantidadDeDiasDataGridViewTextBoxColumn
            // 
            this.cantidadDeDiasDataGridViewTextBoxColumn.DataPropertyName = "CantidadDeDias";
            this.cantidadDeDiasDataGridViewTextBoxColumn.HeaderText = "Cantidad De Días";
            this.cantidadDeDiasDataGridViewTextBoxColumn.Name = "cantidadDeDiasDataGridViewTextBoxColumn";
            // 
            // cedulaDeEmpleadoDataGridViewTextBoxColumn
            // 
            this.cedulaDeEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "CedulaDeEmpleado";
            this.cedulaDeEmpleadoDataGridViewTextBoxColumn.HeaderText = "Cédula De Empleado";
            this.cedulaDeEmpleadoDataGridViewTextBoxColumn.Name = "cedulaDeEmpleadoDataGridViewTextBoxColumn";
            this.cedulaDeEmpleadoDataGridViewTextBoxColumn.Width = 180;
            // 
            // botonAceptar
            // 
            this.botonAceptar.DataPropertyName = "botonAceptar";
            this.botonAceptar.HeaderText = "";
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseColumnTextForButtonValue = true;
            // 
            // botonNegar
            // 
            this.botonNegar.DataPropertyName = "botonNegar";
            this.botonNegar.HeaderText = "";
            this.botonNegar.Name = "botonNegar";
            this.botonNegar.Text = "Negar";
            this.botonNegar.UseColumnTextForButtonValue = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(29, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 354);
            this.panel1.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewDeSolicitudesDeVacaciones);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(672, 348);
            this.panel2.TabIndex = 29;
            // 
            // AdministradorSolicitudesDeVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 656);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxDeCedula);
            this.Controls.Add(this.labelDeCedula);
            this.Controls.Add(this.labelVacaciones);
            this.Controls.Add(this.dateTimePickerFin);
            this.Controls.Add(this.dateTimePickerInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonDeVolver);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdministradorSolicitudesDeVacaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitudes de vacaciones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdministradorSolicitudesDeVacaciones_FormClosing);
            this.Load += new System.EventHandler(this.AdministradorSolicitudesDeVacaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.solicitudDeVacacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeSolicitudesDeVacaciones)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonDeVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerFin;
        private System.Windows.Forms.BindingSource solicitudDeVacacionesBindingSource;
        private System.Windows.Forms.Label labelVacaciones;
        private System.Windows.Forms.Label labelDeCedula;
        private System.Windows.Forms.TextBox textBoxDeCedula;
        private System.Windows.Forms.DataGridView dataGridViewDeSolicitudesDeVacaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaDeInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDeDiasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDeEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn botonAceptar;
        private System.Windows.Forms.DataGridViewButtonColumn botonNegar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}