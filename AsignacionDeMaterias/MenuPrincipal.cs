using System;
using System.Collections.Generic;
using System.Text;

namespace AsignacionDeMaterias
{
    class MenuPrincipal
    {

        enum OpcionMenuPrincipal
        {
            MANT_PROF = 1,
            MANT_MAT,
            ASSIGN,
            EXIT
        }

        public void ImprimirMenu()
        {
            MenuProfesor menuProfesor = new MenuProfesor();
            MenuMateria menuMateria = new MenuMateria();
            ServicioAsignacion servicioAsignacion = new ServicioAsignacion();
            
            try
            {
                Console.Clear();
                Console.WriteLine("1-Mantenimiento profesores \n 2-Mantenimiento materias \n 3- Asignar \n 4- Salir");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case (int)OpcionMenuPrincipal.MANT_PROF:
                        menuProfesor.ImprimirMenu();
                        break;
                    case (int)OpcionMenuPrincipal.MANT_MAT:
                        menuMateria.ImprimirMenu();
                        break;
                    case (int)OpcionMenuPrincipal.ASSIGN:
                        servicioAsignacion.Asignar();
                        break;
                    case (int)OpcionMenuPrincipal.EXIT:
                        Console.WriteLine("Gracias por utilizar el sistema");
                        Console.ReadKey();
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
