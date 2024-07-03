using BibliotecaPrestamos.Model;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaPrestamos.Controller
{
    public class PrestamoController
    {
        public void CargarPrestamo(Prestamo p)
        {
            using (var context = new AppDbContext())
            {
                context.Database.EnsureCreated();
                context.Set<Prestamo>().Add(p);
                context.SaveChanges();
            }
        }

        public List<Prestamo> ListarPrestamos()
        {
            using (var context = new AppDbContext())
            {
                List<Prestamo> lista = context.Prestamos
                    .Include(x => x.Libro)
                    .Include(x => x.Lector)
                    .ToList();

                return lista;
            }
          
        }
    }
}
