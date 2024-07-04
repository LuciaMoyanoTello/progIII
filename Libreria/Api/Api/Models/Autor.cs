using System.ComponentModel.DataAnnotations;

namespace Api.Models
{
    public class Autor
    {
        //Id, Nombre, Fecha de Nacimiento.
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
