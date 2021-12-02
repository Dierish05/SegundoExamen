namespace RegistroNotas.Forms
{
    partial class RegistroDatos
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTareaCurso = new System.Windows.Forms.TextBox();
            this.txtSegundoParcial = new System.Windows.Forms.TextBox();
            this.txtPrimerParcial = new System.Windows.Forms.TextBox();
            this.txtSistematicos = new System.Windows.Forms.TextBox();
            this.cmbAsignatutas = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAgregarNotas = new System.Windows.Forms.Button();
            this.groupBoxEstudiante = new System.Windows.Forms.GroupBox();
            this.groupBoxNotas = new System.Windows.Forms.GroupBox();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCarnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMunicipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxEstudiante.SuspendLayout();
            this.groupBoxNotas.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(40, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(40, 70);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(132, 20);
            this.txtApellidos.TabIndex = 1;
            // 
            // txtCarnet
            // 
            this.txtCarnet.Location = new System.Drawing.Point(40, 107);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(132, 20);
            this.txtCarnet.TabIndex = 2;
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Location = new System.Drawing.Point(40, 175);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(132, 20);
            this.txtMunicipio.TabIndex = 3;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(40, 137);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(132, 20);
            this.txtDepartamento.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Green;
            this.btnAgregar.Location = new System.Drawing.Point(58, 212);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(90, 35);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // txtTareaCurso
            // 
            this.txtTareaCurso.Location = new System.Drawing.Point(54, 178);
            this.txtTareaCurso.Name = "txtTareaCurso";
            this.txtTareaCurso.Size = new System.Drawing.Size(132, 20);
            this.txtTareaCurso.TabIndex = 9;
            this.txtTareaCurso.Visible = false;
            // 
            // txtSegundoParcial
            // 
            this.txtSegundoParcial.Location = new System.Drawing.Point(54, 140);
            this.txtSegundoParcial.Name = "txtSegundoParcial";
            this.txtSegundoParcial.Size = new System.Drawing.Size(132, 20);
            this.txtSegundoParcial.TabIndex = 8;
            this.txtSegundoParcial.Visible = false;
            // 
            // txtPrimerParcial
            // 
            this.txtPrimerParcial.Location = new System.Drawing.Point(54, 103);
            this.txtPrimerParcial.Name = "txtPrimerParcial";
            this.txtPrimerParcial.Size = new System.Drawing.Size(132, 20);
            this.txtPrimerParcial.TabIndex = 7;
            this.txtPrimerParcial.Visible = false;
            // 
            // txtSistematicos
            // 
            this.txtSistematicos.Location = new System.Drawing.Point(54, 70);
            this.txtSistematicos.Name = "txtSistematicos";
            this.txtSistematicos.Size = new System.Drawing.Size(132, 20);
            this.txtSistematicos.TabIndex = 6;
            this.txtSistematicos.Visible = false;
            // 
            // cmbAsignatutas
            // 
            this.cmbAsignatutas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAsignatutas.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAsignatutas.FormattingEnabled = true;
            this.cmbAsignatutas.Items.AddRange(new object[] {
            "Álgebra Lineal",
            "Contabilidad de Costos",
            "Inglés II",
            "Matemáticas II",
            "Programación I",
            "Sociología"});
            this.cmbAsignatutas.Location = new System.Drawing.Point(54, 34);
            this.cmbAsignatutas.Name = "cmbAsignatutas";
            this.cmbAsignatutas.Size = new System.Drawing.Size(132, 21);
            this.cmbAsignatutas.TabIndex = 12;
            this.cmbAsignatutas.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnNombres,
            this.ColumnApellidos,
            this.ColumnCarnet,
            this.ColumnDepartamento,
            this.ColumnMunicipio});
            this.dataGridView1.Location = new System.Drawing.Point(533, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(926, 244);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // btnAgregarNotas
            // 
            this.btnAgregarNotas.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarNotas.ForeColor = System.Drawing.Color.Blue;
            this.btnAgregarNotas.Location = new System.Drawing.Point(69, 212);
            this.btnAgregarNotas.Name = "btnAgregarNotas";
            this.btnAgregarNotas.Size = new System.Drawing.Size(96, 48);
            this.btnAgregarNotas.TabIndex = 15;
            this.btnAgregarNotas.Text = "Agregar Notas";
            this.btnAgregarNotas.UseVisualStyleBackColor = true;
            this.btnAgregarNotas.Visible = false;
            this.btnAgregarNotas.Click += new System.EventHandler(this.BtnAgregarNotas_Click);
            // 
            // groupBoxEstudiante
            // 
            this.groupBoxEstudiante.Controls.Add(this.btnAgregar);
            this.groupBoxEstudiante.Controls.Add(this.txtNombre);
            this.groupBoxEstudiante.Controls.Add(this.txtApellidos);
            this.groupBoxEstudiante.Controls.Add(this.txtCarnet);
            this.groupBoxEstudiante.Controls.Add(this.txtMunicipio);
            this.groupBoxEstudiante.Controls.Add(this.txtDepartamento);
            this.groupBoxEstudiante.Location = new System.Drawing.Point(31, 49);
            this.groupBoxEstudiante.Name = "groupBoxEstudiante";
            this.groupBoxEstudiante.Size = new System.Drawing.Size(210, 274);
            this.groupBoxEstudiante.TabIndex = 16;
            this.groupBoxEstudiante.TabStop = false;
            this.groupBoxEstudiante.Text = "Datos del Estudiante";
            // 
            // groupBoxNotas
            // 
            this.groupBoxNotas.Controls.Add(this.btnAgregarNotas);
            this.groupBoxNotas.Controls.Add(this.txtSistematicos);
            this.groupBoxNotas.Controls.Add(this.txtPrimerParcial);
            this.groupBoxNotas.Controls.Add(this.txtSegundoParcial);
            this.groupBoxNotas.Controls.Add(this.cmbAsignatutas);
            this.groupBoxNotas.Controls.Add(this.txtTareaCurso);
            this.groupBoxNotas.Location = new System.Drawing.Point(260, 49);
            this.groupBoxNotas.Name = "groupBoxNotas";
            this.groupBoxNotas.Size = new System.Drawing.Size(235, 274);
            this.groupBoxNotas.TabIndex = 17;
            this.groupBoxNotas.TabStop = false;
            this.groupBoxNotas.Text = "Registro de Notas";
            this.groupBoxNotas.Visible = false;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            // 
            // ColumnNombres
            // 
            this.ColumnNombres.HeaderText = "Nombres";
            this.ColumnNombres.Name = "ColumnNombres";
            // 
            // ColumnApellidos
            // 
            this.ColumnApellidos.HeaderText = "Apellidos";
            this.ColumnApellidos.Name = "ColumnApellidos";
            // 
            // ColumnCarnet
            // 
            this.ColumnCarnet.HeaderText = "Carnet";
            this.ColumnCarnet.Name = "ColumnCarnet";
            // 
            // ColumnDepartamento
            // 
            this.ColumnDepartamento.HeaderText = "Departamento";
            this.ColumnDepartamento.Name = "ColumnDepartamento";
            // 
            // ColumnMunicipio
            // 
            this.ColumnMunicipio.HeaderText = "Municipio";
            this.ColumnMunicipio.Name = "ColumnMunicipio";
            // 
            // RegistroDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 669);
            this.Controls.Add(this.groupBoxNotas);
            this.Controls.Add(this.groupBoxEstudiante);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RegistroDatos";
            this.Text = "RegistroDatos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxEstudiante.ResumeLayout(false);
            this.groupBoxEstudiante.PerformLayout();
            this.groupBoxNotas.ResumeLayout(false);
            this.groupBoxNotas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTareaCurso;
        private System.Windows.Forms.TextBox txtSegundoParcial;
        private System.Windows.Forms.TextBox txtPrimerParcial;
        private System.Windows.Forms.TextBox txtSistematicos;
        private System.Windows.Forms.ComboBox cmbAsignatutas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAgregarNotas;
        private System.Windows.Forms.GroupBox groupBoxEstudiante;
        private System.Windows.Forms.GroupBox groupBoxNotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCarnet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMunicipio;
    }
}