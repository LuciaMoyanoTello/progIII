using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models
{
    public class Libro
    {
        //ISBN, Título, Autor, Fecha de Publicación, Género.
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ISBN { get; set; }
        public string Titulo { get; set; }
        public int IdAutor { get; set; }
        [ForeignKey("IdAutor")]
        public Autor Autor { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public int IdGenero { get; set; }
        [ForeignKey("IdGenero")]
        public Genero Genero { get; set; }
    }
}
