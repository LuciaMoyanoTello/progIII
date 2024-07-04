using Api.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Dtos
{
    public class LibroDto
    {
        public string Titulo { get; set; }
        public int IdAutor { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public int IdGenero { get; set; }
    }
}
