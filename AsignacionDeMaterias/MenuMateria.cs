using System;
using System.Collections.Generic;
using System.Text;

namespace AsignacionDeMaterias
{
    class MenuMateria
    {

        enum OpcionMenuMateria
        {
            ADD = 1,
            EDIT,
            DELETE,
            READ,
            BACK
        }

        public void ImprimirMenu()
        {
            ServicioMateria servicio = new ServicioMateria();
            MenuPrincipal menu = new MenuPrincipal();

            try
            {
                Console.Clear();
                Console.WriteLine("1-Agregar \n 2-Editar \n 3- Borrar \n 4- Listar \n 5-Volver atras");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case (int)OpcionMenuMateria.ADD:
                        servicio.Add();
                        break;
                    case (int)OpcionMenuMateria.EDIT:
                        servicio.Edit();
                        break;
                    case (int)OpcionMenuMateria.DELETE:
                        servicio.Delete();
                        break;
                    case (int)OpcionMenuMateria.READ:
                        servicio.Read(true);
                        break;
                    case (int)OpcionMenuMateria.BACK:
                        menu.ImprimirMenu();
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
