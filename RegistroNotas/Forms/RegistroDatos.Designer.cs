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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxEstudiante = new System.Windows.Forms.GroupBox();
            this.groupBoxNotas = new System.Windows.Forms.GroupBox();
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
            // 
            // txtTareaCurso
            // 
            this.txtTareaCurso.Location = new System.Drawing.Point(54, 178);
            this.txtTareaCurso.Name = "txtTareaCurso";
            this.txtTareaCurso.Size = new System.Drawing.Size(132, 20);
            this.txtTareaCurso.TabIndex = 9;
            // 
            // txtSegundoParcial
            // 
            this.txtSegundoParcial.Location = new System.Drawing.Point(54, 140);
            this.txtSegundoParcial.Name = "txtSegundoParcial";
            this.txtSegundoParcial.Size = new System.Drawing.Size(132, 20);
            this.txtSegundoParcial.TabIndex = 8;
            // 
            // txtPrimerParcial
            // 
            this.txtPrimerParcial.Location = new System.Drawing.Point(54, 103);
            this.txtPrimerParcial.Name = "txtPrimerParcial";
            this.txtPrimerParcial.Size = new System.Drawing.Size(132, 20);
            this.txtPrimerParcial.TabIndex = 7;
            // 
            // txtSistematicos
            // 
            this.txtSistematicos.Location = new System.Drawing.Point(54, 70);
            this.txtSistematicos.Name = "txtSistematicos";
            this.txtSistematicos.Size = new System.Drawing.Size(132, 20);
            this.txtSistematicos.TabIndex = 6;
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(533, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(926, 244);
            this.dataGridView1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(69, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 48);
            this.button1.TabIndex = 15;
            this.button1.Text = "Agregar Notas";
            this.button1.UseVisualStyleBackColor = true;
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
            this.groupBoxNotas.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBoxEstudiante;
        private System.Windows.Forms.GroupBox groupBoxNotas;
    }
}