using System.ComponentModel.DataAnnotations;

namespace Libreria_api.Entidades
{
    public class Genero
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
