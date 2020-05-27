using System;
using System.Collections.Generic;
using System.Text;

namespace AsignacionDeMaterias
{
    public class ServicioProfesor
    {
        private MenuProfesor menu;

        public ServicioProfesor()
        {
            menu = new MenuProfesor();
        }

        public void Add()
        {
            Console.WriteLine("Ingrese el nombre del profesor: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el apellido del profesor: ");
            string apellido = Console.ReadLine();

            Profesor nuevoProfesor = new Profesor(nombre, apellido);

            Repositorio.Instancia.profesores.Add(nuevoProfesor);
            Console.WriteLine("Se ha agregado con exito");
            Console.ReadKey();

            menu.ImprimirMenu();
        }

        public void Edit()
        {
            try
            {
                Console.Clear();
                Read();

                Console.WriteLine("Seleccione el profesor que desea editar");
                int opcion = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el nombre del profesor: ");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el apellido del profesor: ");
                string apellido = Console.ReadLine();

                Profesor profesorEditado = new Profesor(nombre, apellido);

                Repositorio.Instancia.profesores[opcion - 1] = profesorEditado;

                menu.ImprimirMenu();
            }
            catch (Exception e)
            {
                Console.WriteLine("Debe selecciona una opcion valida");
                Console.ReadKey();
                Edit();
            }
        }
        public void Delete()
        {
            try
            {
                Read();

                Console.WriteLine("Seleccione el profesor que desea eliminar");
                int opcion = Convert.ToInt32(Console.ReadLine());

                Repositorio.Instancia.profesores.RemoveAt(opcion - 1);

                menu.ImprimirMenu();

            }
            catch (Exception e)
            {
                Console.WriteLine("Debe selecciona una opcion valida");
                Console.ReadKey();
                Delete();
            }
            
        }
        public void Read(bool isWait = false)
        {
            int interactor = 1;

            foreach (Profesor item in Repositorio.Instancia.profesores)
            {
                Console.WriteLine(interactor + "- " + item.Nombre + " " + item.Apellido );
                interactor++;

                //Para imprimir las materias del profesor an caso de que tenga y asignada
                if (item.Materias.Count > 0)
                {
                    int interatorMateria = 1;
                    Console.WriteLine("Materias asignadas");

                    foreach (Materia itemMateria in item.Materias)
                    {
                        Console.WriteLine(interatorMateria + "- " + itemMateria.Nombre );
                        interatorMateria++;

                    }
                }

               
            }

            if (isWait)
            {
                Console.ReadKey();
                menu.ImprimirMenu();
            }
        }

        public Profesor GetByIndex(int index)
        {
            return Repositorio.Instancia.profesores[index];
        }

        public void AsignarMateria(int IndexProfesor,Materia materia)
        {
            Repositorio.Instancia.profesores[IndexProfesor].Materias.Add(materia);
        }

    }
}
