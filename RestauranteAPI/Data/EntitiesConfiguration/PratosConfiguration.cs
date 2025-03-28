using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestauranteAPI.Data.Models;

namespace RestauranteAPI.Data.EntitiesConfiguration
{
    public class PratosConfiguration : IEntityTypeConfiguration<Pratos>
    {
        public void Configure(EntityTypeBuilder<Pratos> builder)
        {
            builder.HasKey(x => x.IdPrato);
            builder.HasOne(x => x.CategoriaPrato)
                .WithMany(x => x.Pratos)
                .HasForeignKey(x => x.IdCategoriaPrato);
            builder.Property(x => x.DescricaoPrato).HasMaxLength(255);
            builder.Property(x => x.NomePrato).HasMaxLength(100);
            builder.Property(x => x.ValorPrato).HasPrecision(12, 2);
        }
    }
}
