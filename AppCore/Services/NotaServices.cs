using Domain.Entities;
using Domain.Enums;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Services
{
    public class NotaServices : BaseServices<Notas>, NotaRepositoryService
    {
        // Aqui van todos los metodos de EstudianteRepositoryServices.
        private INotasRepository Repository;
        public NotaServices(INotasRepository repository) : base(repository)
        {
            this.Repository = repository;
        }

        public int CalcularNotas(int primer, int segundo)
        {
            return Repository.CalcularNotas(primer, segundo);
        }

        public int CalcularPromedio()
        {
            return Repository.CalcularPromedio();
        }

        public Estudiante EstudianteById(int Id)
        {
            return Repository.EstudianteById(Id);
        }

        public ICollection<Asignaturas> GetAsignaturas()
        {
            return Repository.GetAsignaturas();
        }

        public ICollection<Notas> MejoresEstudiantes()
        {
            return Repository.MejoresEstudiantes();
        }
    }
}
