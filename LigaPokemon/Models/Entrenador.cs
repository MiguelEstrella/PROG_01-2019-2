using System.ComponentModel.DataAnnotations;

namespace LigaPokemon.Models
{
    public class Entrenador
    {
        [Required]
        public string nombre{get; set;}

        [Required]
        public string pueblo{get; set;}
        
        [Required]
        public string medallas{get; set;}

    }
}