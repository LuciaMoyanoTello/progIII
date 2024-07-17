using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Libreria_api.Entidades
{
    public class Libro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ISBN { get; set; }
        public string Nombre { get; set; }
        public int IdAutor { get; set; }
        [ForeignKey("IdAutor")]
        public virtual Autor Autor { get; set; }
        public int IdGenero { get; set; }
        [ForeignKey("IdGenero")]
        public virtual Genero Genero { get; set; }
    }
}
