using Domain.Entities;
using Domain.Enums;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infraestructura.Interfaces
{
    public class NotaListRepository : BaseRepository<Notas>, INotasRepository
    {
        public int CalcularNotas(int primer, int segundo)
        {
            throw new NotImplementedException();
        }

        public int CalcularPromedio()
        {
            decimal promedio = datos.Sum(x => x.NotaFinal);
            return Convert.ToInt32(promedio / 6);
        }

        public Estudiante EstudianteById(int Id)
        {
            for (int i = 0; i < datos.Count; i++)
            {
                if (Id == datos[i].Estudiante.Id)
                {
                    return datos[i].Estudiante;
                }
            }
            return null;
        }

        public ICollection<Asignaturas> GetAsignaturas()
        {

            List<Asignaturas> asignaturas = new List<Asignaturas>();
            asignaturas = (List<Asignaturas>)datos.Select(x => x.Asignaturas);
            return asignaturas;

        }

        public ICollection<Notas> MejoresEstudiantes()
        {
            List<Notas> MejoresNotas = new List<Notas>();
            datos.OrderBy(x => x.NotaFinal);
            for (int i = 0; i < 2; i++)
            {
                MejoresNotas.Add(datos[i]);
            }
            return MejoresNotas;
        }

    }
}
