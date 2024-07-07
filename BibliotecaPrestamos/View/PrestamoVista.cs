using BibliotecaPrestamos.Controller;
using BibliotecaPrestamos.Enumeraciones;
using BibliotecaPrestamos.Model;
using BibliotecaPrestamos.Repositorio;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BibliotecaPrestamos.View
{
    public class PrestamoVista
    {
        PrestamoController prestamoController = new PrestamoController();
        public void Asignar()
        {
            var repo = new RepoGenerico<Libro>();
            //Lector lector = new Lector();

            Prestamo presta = new Prestamo();

            Console.Write("Libro nro: ");
            presta.LibroId = int.Parse(Console.ReadLine());
            Console.Write("Se asigna a: ");
            presta.LectorId = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            var p = repo.Obtener(presta.LibroId);
            var lector = prestamoController.ObtenerUno(presta.LibroId);

            if (p.Estado == EstadoLibro.Disponible)
            {
                prestamoController.CargarPrestamo(presta);
            }
            else
            {
                Console.WriteLine($"Este libro se encuentra prestado a: {lector.Lector.Nombre}");
                Console.WriteLine();
                Console.WriteLine();
            }

            p.Prestado();
            repo.Actualizar(p);

        }

        public void Devolucion()
        {
            var repo = new RepoGenerico<Libro>();

            Console.Write("Libro nro: ");
            int id = int.Parse(Console.ReadLine());

            var libro = repo.Obtener(id);

            libro.Disponible();

            repo.Actualizar(libro);

            Console.WriteLine();
        }

        public void VerPrestamos()
        {

            var lista = prestamoController.ListarPrestamos();

            foreach (var item in lista)
            {
                //if (item.Libro.Estado == EstadoLibro.Disponible)
                //{
                //    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"El libro: {item.Libro.Titulo}, lo tiene: {item.Lector.Nombre}.");
                //}
                //else
                //{
                //    Console.ForegroundColor = ConsoleColor.Red;
                //    Console.WriteLine($"El libro: {item.Libro.Titulo}, lo tiene: {item.Lector.Nombre}.");
                //}
                
            }
            //Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("-----------------");

        }
    }
}
