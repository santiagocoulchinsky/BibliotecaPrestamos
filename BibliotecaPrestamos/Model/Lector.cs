using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPrestamos.Model
{
    public class Lector : BaseEntidad
    {
        public Lector()
        {
            Libros = new List<Prestamo>();
        }
        public string Nombre { get; set; }  
        public List<Prestamo> Libros { get; set; }
    }
}
