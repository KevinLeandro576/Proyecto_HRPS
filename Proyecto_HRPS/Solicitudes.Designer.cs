namespace Proyecto_HRPS
{
    partial class Solicitudes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Solicitudes));
            this.botonDeVolver = new System.Windows.Forms.Button();
            this.panelDeFlujoDeSolicitudesDeHorasExtra = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridViewDeSolicitudesDeHorasExtra = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumnIdentificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnCantidadDeHoras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botonDeAceptar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.botonDeNegar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.solicitudDeHorasExtraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelDeCedula = new System.Windows.Forms.Label();
            this.textBoxDeCedula = new System.Windows.Forms.TextBox();
            this.labelDeFecha = new System.Windows.Forms.Label();
            this.dateTimePickerDeFecha = new System.Windows.Forms.DateTimePicker();
            this.labelHorasExtra = new System.Windows.Forms.Label();
            this.solicitudDeVacacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelDeFlujoDeSolicitudesDeHorasExtra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeSolicitudesDeHorasExtra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudDeHorasExtraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudDeVacacionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // botonDeVolver
            // 
            this.botonDeVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeVolver.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeVolver.ForeColor = System.Drawing.Color.White;
            this.botonDeVolver.Location = new System.Drawing.Point(56, 480);
            this.botonDeVolver.Margin = new System.Windows.Forms.Padding(4);
            this.botonDeVolver.Name = "botonDeVolver";
            this.botonDeVolver.Size = new System.Drawing.Size(694, 41);
            this.botonDeVolver.TabIndex = 4;
            this.botonDeVolver.Text = "VOLVER";
            this.botonDeVolver.UseVisualStyleBackColor = false;
            this.botonDeVolver.Click += new System.EventHandler(this.botonDeVolver_Click);
            // 
            // panelDeFlujoDeSolicitudesDeHorasExtra
            // 
            this.panelDeFlujoDeSolicitudesDeHorasExtra.Controls.Add(this.dataGridViewDeSolicitudesDeHorasExtra);
            this.panelDeFlujoDeSolicitudesDeHorasExtra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDeFlujoDeSolicitudesDeHorasExtra.Location = new System.Drawing.Point(56, 197);
            this.panelDeFlujoDeSolicitudesDeHorasExtra.Margin = new System.Windows.Forms.Padding(4);
            this.panelDeFlujoDeSolicitudesDeHorasExtra.Name = "panelDeFlujoDeSolicitudesDeHorasExtra";
            this.panelDeFlujoDeSolicitudesDeHorasExtra.Size = new System.Drawing.Size(694, 228);
            this.panelDeFlujoDeSolicitudesDeHorasExtra.TabIndex = 7;
            // 
            // dataGridViewDeSolicitudesDeHorasExtra
            // 
            this.dataGridViewDeSolicitudesDeHorasExtra.AllowUserToAddRows = false;
            this.dataGridViewDeSolicitudesDeHorasExtra.AllowUserToDeleteRows = false;
            this.dataGridViewDeSolicitudesDeHorasExtra.AllowUserToResizeColumns = false;
            this.dataGridViewDeSolicitudesDeHorasExtra.AllowUserToResizeRows = false;
            this.dataGridViewDeSolicitudesDeHorasExtra.AutoGenerateColumns = false;
            this.dataGridViewDeSolicitudesDeHorasExtra.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDeSolicitudesDeHorasExtra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeSolicitudesDeHorasExtra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumnIdentificador,
            this.dataGridViewTextBoxColumnDia,
            this.dataGridViewTextBoxColumnCantidadDeHoras,
            this.dataGridViewTextBoxColumnCedula,
            this.botonDeAceptar,
            this.botonDeNegar});
            this.dataGridViewDeSolicitudesDeHorasExtra.DataSource = this.solicitudDeHorasExtraBindingSource;
            this.dataGridViewDeSolicitudesDeHorasExtra.GridColor = System.Drawing.Color.White;
            this.dataGridViewDeSolicitudesDeHorasExtra.Location = new System.Drawing.Point(8, 9);
            this.dataGridViewDeSolicitudesDeHorasExtra.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.dataGridViewDeSolicitudesDeHorasExtra.Name = "dataGridViewDeSolicitudesDeHorasExtra";
            this.dataGridViewDeSolicitudesDeHorasExtra.ReadOnly = true;
            this.dataGridViewDeSolicitudesDeHorasExtra.RowHeadersVisible = false;
            this.dataGridViewDeSolicitudesDeHorasExtra.Size = new System.Drawing.Size(683, 211);
            this.dataGridViewDeSolicitudesDeHorasExtra.TabIndex = 8;
            this.dataGridViewDeSolicitudesDeHorasExtra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDeEmpleados_CellClick);
            // 
            // dataGridViewTextBoxColumnIdentificador
            // 
            this.dataGridViewTextBoxColumnIdentificador.DataPropertyName = "Identificador";
            this.dataGridViewTextBoxColumnIdentificador.HeaderText = "Identificador";
            this.dataGridViewTextBoxColumnIdentificador.Name = "dataGridViewTextBoxColumnIdentificador";
            this.dataGridViewTextBoxColumnIdentificador.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnDia
            // 
            this.dataGridViewTextBoxColumnDia.DataPropertyName = "Dia";
            this.dataGridViewTextBoxColumnDia.HeaderText = "Dia";
            this.dataGridViewTextBoxColumnDia.Name = "dataGridViewTextBoxColumnDia";
            this.dataGridViewTextBoxColumnDia.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnCantidadDeHoras
            // 
            this.dataGridViewTextBoxColumnCantidadDeHoras.DataPropertyName = "CantidadDeHoras";
            this.dataGridViewTextBoxColumnCantidadDeHoras.HeaderText = "Cantidad De Horas";
            this.dataGridViewTextBoxColumnCantidadDeHoras.Name = "dataGridViewTextBoxColumnCantidadDeHoras";
            this.dataGridViewTextBoxColumnCantidadDeHoras.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnCedula
            // 
            this.dataGridViewTextBoxColumnCedula.DataPropertyName = "CedulaDeEmpleado";
            this.dataGridViewTextBoxColumnCedula.HeaderText = "Cedula De Empleado";
            this.dataGridViewTextBoxColumnCedula.Name = "dataGridViewTextBoxColumnCedula";
            this.dataGridViewTextBoxColumnCedula.ReadOnly = true;
            this.dataGridViewTextBoxColumnCedula.Width = 180;
            // 
            // botonDeAceptar
            // 
            this.botonDeAceptar.DataPropertyName = "botonDeAceptar";
            this.botonDeAceptar.HeaderText = "";
            this.botonDeAceptar.Name = "botonDeAceptar";
            this.botonDeAceptar.ReadOnly = true;
            this.botonDeAceptar.Text = "Aceptar";
            this.botonDeAceptar.UseColumnTextForButtonValue = true;
            // 
            // botonDeNegar
            // 
            this.botonDeNegar.DataPropertyName = "botonDeNegar";
            this.botonDeNegar.HeaderText = "";
            this.botonDeNegar.Name = "botonDeNegar";
            this.botonDeNegar.ReadOnly = true;
            this.botonDeNegar.Text = "Negar";
            this.botonDeNegar.UseColumnTextForButtonValue = true;
            // 
            // solicitudDeHorasExtraBindingSource
            // 
            this.solicitudDeHorasExtraBindingSource.DataSource = typeof(Proyecto_HRPS.SolicitudDeHorasExtra);
            // 
            // labelDeCedula
            // 
            this.labelDeCedula.AutoSize = true;
            this.labelDeCedula.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeCedula.Location = new System.Drawing.Point(53, 105);
            this.labelDeCedula.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelDeCedula.Name = "labelDeCedula";
            this.labelDeCedula.Size = new System.Drawing.Size(112, 18);
            this.labelDeCedula.TabIndex = 10;
            this.labelDeCedula.Text = "Escribe cédula";
            // 
            // textBoxDeCedula
            // 
            this.textBoxDeCedula.Location = new System.Drawing.Point(358, 102);
            this.textBoxDeCedula.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.textBoxDeCedula.Name = "textBoxDeCedula";
            this.textBoxDeCedula.Size = new System.Drawing.Size(381, 26);
            this.textBoxDeCedula.TabIndex = 11;
            this.textBoxDeCedula.TextChanged += new System.EventHandler(this.textBoxDeCedula_TextChanged);
            // 
            // labelDeFecha
            // 
            this.labelDeFecha.AutoSize = true;
            this.labelDeFecha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeFecha.Location = new System.Drawing.Point(53, 58);
            this.labelDeFecha.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelDeFecha.Name = "labelDeFecha";
            this.labelDeFecha.Size = new System.Drawing.Size(128, 18);
            this.labelDeFecha.TabIndex = 13;
            this.labelDeFecha.Text = "Selecciona fecha";
            // 
            // dateTimePickerDeFecha
            // 
            this.dateTimePickerDeFecha.Location = new System.Drawing.Point(358, 52);
            this.dateTimePickerDeFecha.Name = "dateTimePickerDeFecha";
            this.dateTimePickerDeFecha.Size = new System.Drawing.Size(381, 26);
            this.dateTimePickerDeFecha.TabIndex = 14;
            this.dateTimePickerDeFecha.ValueChanged += new System.EventHandler(this.dateTimePickerDeFecha_ValueChanged);
            // 
            // labelHorasExtra
            // 
            this.labelHorasExtra.AutoSize = true;
            this.labelHorasExtra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHorasExtra.Location = new System.Drawing.Point(295, 175);
            this.labelHorasExtra.Name = "labelHorasExtra";
            this.labelHorasExtra.Size = new System.Drawing.Size(193, 18);
            this.labelHorasExtra.TabIndex = 15;
            this.labelHorasExtra.Text = "Solicitudes de Horas Extra";
            // 
            // solicitudDeVacacionesBindingSource
            // 
            this.solicitudDeVacacionesBindingSource.DataSource = typeof(Proyecto_HRPS.SolicitudDeVacaciones);
            // 
            // Solicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 543);
            this.Controls.Add(this.labelHorasExtra);
            this.Controls.Add(this.dateTimePickerDeFecha);
            this.Controls.Add(this.labelDeFecha);
            this.Controls.Add(this.textBoxDeCedula);
            this.Controls.Add(this.labelDeCedula);
            this.Controls.Add(this.panelDeFlujoDeSolicitudesDeHorasExtra);
            this.Controls.Add(this.botonDeVolver);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Solicitudes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitudes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Solicitudes_FormClosing);
            this.Load += new System.EventHandler(this.Solicitudes_Load);
            this.panelDeFlujoDeSolicitudesDeHorasExtra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeSolicitudesDeHorasExtra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudDeHorasExtraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudDeVacacionesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonDeVolver;
        private System.Windows.Forms.FlowLayoutPanel panelDeFlujoDeSolicitudesDeHorasExtra;
        private System.Windows.Forms.Label labelDeCedula;
        private System.Windows.Forms.TextBox textBoxDeCedula;
        private System.Windows.Forms.BindingSource solicitudDeHorasExtraBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewDeSolicitudesDeHorasExtra;
        private System.Windows.Forms.Label labelDeFecha;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnIdentificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnCantidadDeHoras;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnCedula;
        private System.Windows.Forms.DataGridViewButtonColumn botonDeAceptar;
        private System.Windows.Forms.DataGridViewButtonColumn botonDeNegar;
        private System.Windows.Forms.BindingSource solicitudDeVacacionesBindingSource;
        private System.Windows.Forms.Label labelHorasExtra;
    }
}