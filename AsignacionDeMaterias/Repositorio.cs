using System;
using System.Collections.Generic;
using System.Text;

namespace AsignacionDeMaterias
{
    public sealed class Repositorio
    {
        public List<Profesor> profesores { get; set; } = new List<Profesor>();

        public List<Materia> materias { get; set; } = new List<Materia>();

        public static Repositorio Instancia { get; } = new Repositorio();

        private Repositorio()
        {
        }

    }
}
