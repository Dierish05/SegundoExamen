using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface INotasRepository : IModel<Notas>
    {
        // Aqui poner los metodos que se ocuparan para la clase Estudiante.
        int CalcularPromedio();
        ICollection<Notas> MejoresEstudiantes();
        ICollection<Asignaturas> GetAsignaturas();
        Estudiante EstudianteById(int Id);
        int CalcularNotas(int primer, int segundo);
    }
}
