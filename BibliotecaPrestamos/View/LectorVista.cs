using BibliotecaPrestamos.Model;
using BibliotecaPrestamos.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPrestamos.View
{
    public class LectorVista
    {
        public void CrearLector()
        {
            var repo1 = new RepoGenerico<Lector>();

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine();

            var lector = new Lector() { Nombre = nombre };  

            repo1.Crear(lector);
        }

    }
}
