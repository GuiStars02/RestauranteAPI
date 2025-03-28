namespace RestauranteAPI.Data.Models
{
    public class CategoriaPrato
    {
        public int IdCategoriaPrato { get; set; }
        public string DescricaoCategoria { get; set; }
        public ICollection<Pratos> Pratos { get; set; } = new List<Pratos>();
    }
}
