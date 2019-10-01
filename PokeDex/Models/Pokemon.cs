using System.ComponentModel.DataAnnotations;

namespace PokeDex.Models
{
    public class Pokemon
    {
        public int  Id { get; set; }

        [Required]
        public string Nombre {get; set;}
        [Required]
        public string Foto {get; set;}
    }
}