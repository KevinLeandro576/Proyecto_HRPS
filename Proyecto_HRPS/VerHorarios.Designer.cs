
namespace Proyecto_HRPS
{
    partial class VerHorarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerHorarios));
            this.botonDeVolver = new System.Windows.Forms.Button();
            this.dataGridViewDeEmpleados = new System.Windows.Forms.DataGridView();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadoEnObjetoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoEnObjetoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // botonDeVolver
            // 
            this.botonDeVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(75)))), ((int)(((byte)(128)))));
            this.botonDeVolver.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeVolver.ForeColor = System.Drawing.Color.White;
            this.botonDeVolver.Location = new System.Drawing.Point(34, 323);
            this.botonDeVolver.Margin = new System.Windows.Forms.Padding(4);
            this.botonDeVolver.Name = "botonDeVolver";
            this.botonDeVolver.Size = new System.Drawing.Size(450, 41);
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
            this.horarioDataGridViewTextBoxColumn});
            this.dataGridViewDeEmpleados.DataSource = this.empleadoEnObjetoBindingSource;
            this.dataGridViewDeEmpleados.GridColor = System.Drawing.Color.White;
            this.dataGridViewDeEmpleados.Location = new System.Drawing.Point(34, 31);
            this.dataGridViewDeEmpleados.Name = "dataGridViewDeEmpleados";
            this.dataGridViewDeEmpleados.ReadOnly = true;
            this.dataGridViewDeEmpleados.RowHeadersVisible = false;
            this.dataGridViewDeEmpleados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewDeEmpleados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewDeEmpleados.Size = new System.Drawing.Size(450, 285);
            this.dataGridViewDeEmpleados.TabIndex = 4;
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            this.cedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.HeaderText = "CÉDULA";
            this.cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            this.cedulaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cedulaDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 150;
            // 
            // horarioDataGridViewTextBoxColumn
            // 
            this.horarioDataGridViewTextBoxColumn.DataPropertyName = "Horario";
            this.horarioDataGridViewTextBoxColumn.HeaderText = "HORARIO";
            this.horarioDataGridViewTextBoxColumn.Name = "horarioDataGridViewTextBoxColumn";
            this.horarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.horarioDataGridViewTextBoxColumn.Width = 150;
            // 
            // empleadoEnObjetoBindingSource
            // 
            this.empleadoEnObjetoBindingSource.DataSource = typeof(Proyecto_HRPS.EmpleadoEnObjeto);
            // 
            // VerHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(518, 377);
            this.Controls.Add(this.dataGridViewDeEmpleados);
            this.Controls.Add(this.botonDeVolver);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VerHorarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver horarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VerHorarios_FormClosing);
            this.Load += new System.EventHandler(this.VerHorarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoEnObjetoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonDeVolver;
        private System.Windows.Forms.DataGridView dataGridViewDeEmpleados;
        private System.Windows.Forms.BindingSource empleadoEnObjetoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioDataGridViewTextBoxColumn;
    }
}