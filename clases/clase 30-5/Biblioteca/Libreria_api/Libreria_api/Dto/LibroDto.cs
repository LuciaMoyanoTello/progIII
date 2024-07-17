using Libreria_api.Entidades;
using System.ComponentModel.DataAnnotations.Schema;

namespace Libreria_api.Dto
{
    public class LibroDto
    {
        public string Nombre { get; set; }
        public int IdAutor { get; set; }
        public int IdGenero { get; set; }
    }
}
