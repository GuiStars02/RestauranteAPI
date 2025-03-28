namespace RestauranteAPI.Data.Models
{
    public class Pratos
    {
        public int IdPrato { get; set; }
        public string NomePrato { get; set; }
        public string DescricaoPrato { get; set; }
        public int IdCategoriaPrato { get; set; }
        public decimal ValorPrato { get; set; }
        public virtual CategoriaPrato? CategoriaPrato { get; set; }
    }
}
