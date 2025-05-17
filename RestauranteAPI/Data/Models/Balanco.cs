namespace RestauranteAPI.Data.Models
{
    public class Balanco
    {
        public int IdBalanco { get; set; }
        public decimal Valor { get; set; }
        public int TipoBalanco { get; set; }
        public int IdPrato { get; set; }
        public virtual Prato? Prato { get; set; }
    }

    public enum TiposBalanco 
    { 
        Entrada = 1,
        Saida = 2
    }
}
