using System.ComponentModel.DataAnnotations;

namespace Api.Models
{
    public class Genero
    {
        //Id, Nombre.
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
