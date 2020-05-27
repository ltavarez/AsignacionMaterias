using System;
using System.Collections.Generic;
using System.Text;

namespace AsignacionDeMaterias
{
    public class ServicioAsignacion
    {
        private ServicioProfesor servicioProfesor;
        private ServicioMateria servicioMateria;
        private MenuPrincipal menuPrincipal;

        public ServicioAsignacion()
        {
            servicioProfesor = new ServicioProfesor();
            servicioMateria = new ServicioMateria();
            menuPrincipal = new MenuPrincipal();
        }

        public void Asignar()
        {
            servicioProfesor.Read();
            Console.WriteLine("Seleccione el profesor al cual desea asignarle materias");
            int IndexProfesorAsignar = Convert.ToInt32(Console.ReadLine());

            AsignarMateria(IndexProfesorAsignar);
        }

        private void AsignarMateria(int IndexProfesorAsignar)
        {
            Console.WriteLine("Listados de materias");
            servicioMateria.Read();

            Console.WriteLine("Seleccione la materia que desea asignar");
            int IndexMateriaAsignar = Convert.ToInt32(Console.ReadLine());

            bool isValid = this.IsValid(IndexProfesorAsignar - 1, IndexMateriaAsignar - 1);

            if (isValid)
            {
                Materia materiaAsignada = servicioMateria.GetByIndex(IndexMateriaAsignar - 1);
                servicioProfesor.AsignarMateria(IndexProfesorAsignar - 1, materiaAsignada);
                Console.WriteLine("La materia ha sido agregada con exito");

                Console.WriteLine("Desea asignar otra materia s/n");
                string opcion = Console.ReadLine();

                if (opcion == "s")
                {
                    Console.Clear();
                    AsignarMateria(IndexProfesorAsignar);
                }
                else
                {
                    menuPrincipal.ImprimirMenu();
                }

            }
            else
            {
                Console.WriteLine("Ya el profesor tiene esa materia asignada");
                Console.ReadKey();
                

                Console.WriteLine("Desea asignar otra materia s/n");
                string opcion = Console.ReadLine();

                if (opcion == "s")
                {
                    Console.Clear();
                    AsignarMateria(IndexProfesorAsignar);
                }
                else
                {
                    menuPrincipal.ImprimirMenu();
                }
            }
        }

        private bool IsValid(int indexProfesor, int indexMateria)
        {
            Profesor profesorAsignar = servicioProfesor.GetByIndex(indexProfesor);

            Materia materiaAsignar = servicioMateria.GetByIndex(indexMateria);

            foreach (Materia item in profesorAsignar.Materias)
            {
                if (item.Nombre == materiaAsignar.Nombre)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
