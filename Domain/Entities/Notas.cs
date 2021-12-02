using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Notas
    {
        public Asignaturas Asignaturas { get; set; }
        public Estudiante Estudiante { get; set; }
        public int Sistematicos { get; set; }
        public int IParcial {get; set;}
        public int IIParcial { get; set; }
        public int TareaCurso { get; set; }
        public int NotaFinal { get; set; }

    }
}
