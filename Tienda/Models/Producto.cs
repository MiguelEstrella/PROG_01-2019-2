namespace Tienda.Models
{
    public class Producto
    {
        public int id {get; set;}

        public string Nombre {get; set;}

        public decimal precio {get; set;}

        public Categoria Categoria {get; set;}

        public int? CategoriaId {get; set;}
    }
}