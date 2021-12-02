using AppCore.Services;
using Domain.Entities;
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
    public partial class FrmVerNotas : Form
    {
        int cambio = 0;
        public NotaRepositoryService Services { get; set; }
        int Id = 0;

        public FrmVerNotas(int id)
        {
            this.Id = id;
            InitializeComponent();
        }

        private void FrmVerNotas_Load(object sender, EventArgs e)
        {
            Estudiante estudiante = Services.EstudianteById(Id);
            lblNombre.Text = estudiante.Nombres + " " + estudiante.Apellidos;
        }
    }
}
