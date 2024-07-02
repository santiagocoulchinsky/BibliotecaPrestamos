using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPrestamos.Model
{
    class Libro : BaseEntidad
    {
        public string Titulo { get; set; }

        public List<Prestamo> Lectores { get; set; }
    }
}
