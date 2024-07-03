using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPrestamos.View
{
    public class Menu
    {
        LibroVista libroVista = new LibroVista();
        LectorVista lectorVista = new LectorVista();
        PrestamoVista prestamoVista = new PrestamoVista();

        public void MostrarMenu()
        {
            int opcion;
            Console.WriteLine("1- Nuevo Libro. ");
            Console.WriteLine("2- Nuevo Lector. ");
            Console.WriteLine("3- Nuevo Préstamo. ");
            Console.WriteLine("4- Registro de préstamos. ");
            Console.WriteLine("5- Salir. ");
            Console.Write("\nOpción: ");
            opcion = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------");

            switch (opcion)
            {
                case 1:

                    libroVista.CrearLibro();

                    break;

                case 2:

                    lectorVista.CrearLector();

                    break;

                case 3:

                    prestamoVista.Asignar();

                    break;

                case 4:

                    prestamoVista.VerPrestamos();

                    break;

                case 5:
                    Environment.Exit(0);
                    break;

                default:
                    Console.Clear();
                    MostrarMenu();
                    break;
            }
            MostrarMenu();
        }
    }
}
