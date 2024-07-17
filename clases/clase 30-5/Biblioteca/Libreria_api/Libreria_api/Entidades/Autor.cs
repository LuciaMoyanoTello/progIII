using System.ComponentModel.DataAnnotations;

namespace Libreria_api.Entidades
{
    public class Autor
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateOnly FechaNacimiento { get; set; }
    }
}
