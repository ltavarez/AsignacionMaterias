using System;
using System.Collections.Generic;
using System.Text;

namespace AsignacionDeMaterias
{
    public class ServicioMateria
    {
        private MenuMateria menu;

        public ServicioMateria()
        {
            menu = new MenuMateria();
        }

        public void Add()
        {
            Console.WriteLine("Ingrese el nombre de la materia: ");
            string materia = Console.ReadLine();

            Materia nuevaMateria = new Materia(materia);

            Repositorio.Instancia.materias.Add(nuevaMateria);
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

                Console.WriteLine("Seleccione la materia que desea editar");
                int opcion = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el nombre de la materia: ");
                string materia = Console.ReadLine();

                Materia materiaEditada = new Materia(materia);

                Repositorio.Instancia.materias[opcion - 1] = materiaEditada;

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

                Console.WriteLine("Seleccione la materia que desea eliminar");
                int opcion = Convert.ToInt32(Console.ReadLine());

                Repositorio.Instancia.materias.RemoveAt(opcion - 1);

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

            foreach (Materia item in Repositorio.Instancia.materias)
            {
                Console.WriteLine(interactor + "- " + item.Nombre );
                interactor++;
            }

            if (isWait)
            {
                Console.ReadKey();
                menu.ImprimirMenu();
            }
        }
        public Materia GetByIndex(int index)
        {
            return Repositorio.Instancia.materias[index];
        }

    }
}
