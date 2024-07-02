using BibliotecaPrestamos.Model;
using BibliotecaPrestamos.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPrestamos.View
{
    public class LibroVista
    {
        public void CrearLibro()
        {
            var repo = new RepoGenerico<Libro>();

            Console.Write("Titulo: ");
            string titulo = Console.ReadLine();
            Console.WriteLine();

            var libro = new Libro() { Titulo = titulo };

            repo.Crear(libro);
        }

    }
}
