using BibliotecaPrestamos.Enumeraciones;


namespace BibliotecaPrestamos.Model
{
    
    public class Libro : BaseEntidad
    {
        public Libro()
        {
            Estado = EstadoLibro.Disponible;
        }
        public void Prestado()
        {
            Estado = EstadoLibro.Prestado;
        }

        public void Disponible()
        {
            Estado = EstadoLibro.Disponible;
        }

        public string Titulo { get; set; }

        public EstadoLibro Estado { get; set; }

        public List<Prestamo> Lectores { get; set; }
    }
}
