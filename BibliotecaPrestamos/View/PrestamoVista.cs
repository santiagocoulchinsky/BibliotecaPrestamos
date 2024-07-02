using BibliotecaPrestamos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPrestamos.View
{
    public class PrestamoVista
    {
        public void Asignar()
        {
            Console.Write("Libro nro: ");
            int i = int.Parse(Console.ReadLine());
            Console.Write("Se asigna a: ");
            int j = int.Parse(Console.ReadLine());
            Console.WriteLine();

            using (var context = new AppDbContext())
            {
                var lec = context.Lectores
                    .Where(x => x.Id == j)
                    .Single();

                Prestamo asigna = new Prestamo();
                asigna.LibroId = i;    
                lec.Libros.Add(asigna);

                context.SaveChanges();
            }
        }
    }
}
