using BibliotecaPrestamos.Controller;
using BibliotecaPrestamos.Model;

namespace BibliotecaPrestamos.View
{
    public class PrestamoVista
    {

        PrestamoController prestamoController = new PrestamoController();
        public void Asignar()
        {
            Prestamo presta = new Prestamo();

            Console.Write("Libro nro: ");
            presta.LibroId = int.Parse(Console.ReadLine());
            Console.Write("Se asigna a: ");
            presta.LectorId = int.Parse(Console.ReadLine());
            Console.WriteLine();

            prestamoController.CargarPrestamo(presta);
        }

        public void VerPrestamos()
        {

            var lista = prestamoController.ListarPrestamos();

            foreach (var item in lista)
            {
                Console.WriteLine($"El libro: {item.Libro.Titulo}, lo tiene: {item.Lector.Nombre}.");
            }
            Console.WriteLine("-----------------");

        }
    }
}
//lp