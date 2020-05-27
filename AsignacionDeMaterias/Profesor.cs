using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AsignacionDeMaterias
{
    public class Profesor
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public List<Materia> Materias { get; set; } = new List<Materia>();

        public Profesor(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }


    }
}
