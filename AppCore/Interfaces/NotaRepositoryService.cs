using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Services
{
    public interface NotaRepositoryService : IServices<Notas>
    {
        Estudiante EstudianteById(int Id);
        int CalcularPromedio();
        ICollection<Notas> MejoresEstudiantes();
        ICollection<Asignaturas> GetAsignaturas();
        int CalcularNotas(int primer, int segundo);
    }
}
