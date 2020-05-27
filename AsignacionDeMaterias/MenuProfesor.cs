using System;
using System.Collections.Generic;
using System.Text;

namespace AsignacionDeMaterias
{
    class MenuProfesor
    {
      

        enum OpcionMenuProfesor
        {
            ADD = 1,
            EDIT,
            DELETE,
            READ,
            BACK
        }

        public void ImprimirMenu()
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            ServicioProfesor servicioProfesor = new ServicioProfesor();

            try
            {
                Console.Clear();
                Console.WriteLine("1-Agregar \n 2-Editar \n 3- Borrar \n 4- Listar \n 5-Volver atras");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case (int)OpcionMenuProfesor.ADD:
                        servicioProfesor.Add();
                        break;
                    case (int)OpcionMenuProfesor.EDIT:
                        servicioProfesor.Edit();
                        break;
                    case (int)OpcionMenuProfesor.DELETE:
                        servicioProfesor.Delete();
                        break;
                    case (int)OpcionMenuProfesor.READ:
                        servicioProfesor.Read(true);
                        break;
                    case (int)OpcionMenuProfesor.BACK:
                        menuPrincipal.ImprimirMenu();
                        break;
                    default:
                        Console.WriteLine("Debe introducir una opcion valida");
                        Console.ReadKey();
                        ImprimirMenu();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Debe introducir una opcion valida");
                Console.ReadKey();
                ImprimirMenu();
            }
        }

    }
}
