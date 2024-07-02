using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPrestamos.Model
{
    class Prestamo 
    {
        public int LectorId { get; set; }
        public Lector Lector { get; set; }
        public int LibroId { get; set; }
        public Libro Libro { get; set; }
        
    }
}
