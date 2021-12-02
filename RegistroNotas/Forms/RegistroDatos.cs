using AppCore.Services;
using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroNotas.Forms
{
    public partial class RegistroDatos : Form
    {
        public NotaRepositoryService Services;
        List<Asignatura> asignaturas;
        Estudiante estudiante;
        int Seleccionado = 0;
        int Siguiente = 0;
        public RegistroDatos(NotaRepositoryService services)
        {
            estudiante = new Estudiante();
            asignaturas = new List<Asignatura>();
            this.Services = services;
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            estudiante = new Estudiante()
            {
                Id = Services.GetLastId() + 1,
                Nombres = txtNombre.Text,
                Apellidos = txtApellidos.Text,
                Carnet = txtCarnet.Text,
                Departamento = txtDepartamento.Text,
                Municipio = txtMunicipio.Text
            };
            AgregarAsignaturas();
            Notas Notas = new Notas()
            {
                Estudiante = estudiante,
                Asignatura = asignaturas,

            };
            Services.Create(Notas);
            LlenarDgv();
            Vaciar();
            groupBoxNotas.Visible = true;
            cmbAsignatutas.Visible = true;
            txtPrimerParcial.Visible = true;
            txtSegundoParcial.Visible = true;
            txtSistematicos.Visible = true;
            txtTareaCurso.Visible = true;
            btnAgregarNotas.Visible = true;
        }

        private void Vaciar()
        {
            txtApellidos.Text = "Apellido";
            txtCarnet.Text = "Carnet";
            txtDepartamento.Text = "Departamento";
            txtMunicipio.Text = "Municipio";
            txtNombre.Text = "Nombre";

        }
        private void LlenarDgv()
        {
            dataGridView1.Rows.Clear();
            List<Notas> Estudiantes = (List<Notas>)Services.Read();
            for (int i = 0; i < Estudiantes.Count; i++)
            {
                dataGridView1.Rows.Add(Estudiantes[i].Estudiante.Id, Estudiantes[i].Estudiante.Nombres, Estudiantes[i].Estudiante.Apellidos, Estudiantes[i].Estudiante.Carnet,  Estudiantes[i].Estudiante.Departamento, Estudiantes[i].Estudiante.Municipio);
            }

        }
        private void AgregarAsignaturas()
        {
            Asignatura Contabilidad = new Asignatura()
            {
                Id = Services.GetLastId() + 1,
                Credito = 2,
                Nombre = "Contabilidad"
            };
            asignaturas.Add(Contabilidad);
            Asignatura AlgebraLineal = new Asignatura()
            {
                Id = Services.GetLastId() + 1,
                Credito = 2,
                Nombre = "AlgebraLineal"
            };
            asignaturas.Add(AlgebraLineal);
            Asignatura Matematicas2 = new Asignatura()
            {
                Id = Services.GetLastId() + 1,
                Credito = 2,
                Nombre = "Matematicas2"
            };
            asignaturas.Add(Matematicas2);
            Asignatura Ingles2 = new Asignatura()
            {
                Id = Services.GetLastId() + 1,
                Credito = 2,
                Nombre = "Ingles2"
            };
            asignaturas.Add(Ingles2);

            Asignatura Sociologia = new Asignatura()
            {
                Id = Services.GetLastId() + 1,
                Credito = 2,
                Nombre = "Sociologia"
            };
            asignaturas.Add(Sociologia);
            Asignatura Programacion1 = new Asignatura()
            {
                Id = Services.GetLastId() + 1,
                Credito = 2,
                Nombre = "Programacion1"
            };
            asignaturas.Add(Programacion1);
        }

        private void BtnAgregarNotas_Click(object sender, EventArgs e)
        {
            Siguiente++;
            if (Siguiente == 6)
            {
                return;
                MessageBox.Show("Notas registradas");
            }
            Notas notas = new Notas()
            {
                Estudiante = estudiante,
                Asignatura = asignaturas,
                IParcial = Convert.ToInt16(txtPrimerParcial.Text),
                IIParcial = Convert.ToInt16(txtSegundoParcial.Text),
                Sistematicos = Convert.ToInt16(txtSistematicos.Text),
                TareaCurso = Convert.ToInt16(txtTareaCurso.Text)
            };
            Services.Create(notas);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Seleccionado = e.RowIndex;
                int id = Convert.ToInt32(dataGridView1.Rows[Seleccionado].Cells["ID"].Value);
                FrmVerNotas frmNotas = new FrmVerNotas(id);
                frmNotas.Services = Services;
                frmNotas.ShowDialog();
            }
        }
    }
}
